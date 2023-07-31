using Newtonsoft.Json;
using P1_JerryHurtado.Server._Repository;
using P1_JerryHurtado.Server._Repository.ContextDB;
using P1_JerryHurtado.Server._Repository.Interfaces;
using P1_JerryHurtado.Server._Utilities;
using P1_JerryHurtado.Server.Models._Socket;
using P1_JerryHurtado.Server.Models.Enum;
using P1_JerryHurtado.Server.Models.ModelsDB;
using P1_JerryHurtado.Server.Models.ViewModels;
using P1_JerryHurtado.Server.Views.Interfaces;
using System.Collections.Immutable;
using System.Net;
using System.Net.Sockets;

namespace P1_JerryHurtado.Server.Presenters
{
    public class ServerPresenter
    {
        private IServerView _view;
        private ICustomerRepository<Cliente> _customerRepository;
        private IDishRestaurantRepository<PlatoRestaurante> _dishRestaurantRepository;
        private IOrderRepository<Pedido> _orderRepository;
        private IExtraOrderRepository<ExtraPedido> _extraOrderRepository;
        private TcpListener tcpListener;
        private Thread threadListeningCustomers;
        private UpdateLogbookDelegate _updateLogbookDelegate;
        private UpdateConnectedClientsDelegate _updateConnectedClientsDelegate;

        public ServerPresenter(IServerView view, RestUnedContext dbContext)
        {
            _view = view;
            _customerRepository = new CustomerRepository(dbContext);
            _dishRestaurantRepository = new DishRestaurantRepository(dbContext);
            _orderRepository = new OrderRepository(dbContext);
            _extraOrderRepository = new ExtraOrderRepository();

            _updateLogbookDelegate = new UpdateLogbookDelegate(UpdateLogbook);
            _updateConnectedClientsDelegate = new UpdateConnectedClientsDelegate(UpdateConnectedClients);

            _view.StartServerEvent += StartServerEvent;
            _view.StopServerEvent += StopServerEvent;
            _view.Show();
        }

        #region Delegates and delegates handler methods

        /// <summary>
        /// Delegado para actualizar bitácora desde un subproceso.
        /// </summary>
        /// <param name="text">string: Datos de bitácora.</param>
        private delegate void UpdateLogbookDelegate(string text);

        /// <summary>
        /// Delegado para actualizar clientes conectados.
        /// </summary>
        /// <param name="text">string: Datos de cliente</param>
        /// <param name="addClient">bool: Agregar o remover del listado.</param>
        private delegate void UpdateConnectedClientsDelegate(string text, bool addClient);

        private void UpdateLogbook(string text)
        {
            _view.TextBoxLogbook.AppendText($"{DateTime.Now} - {text}");
            _view.TextBoxLogbook.AppendText(Environment.NewLine);
        }

        private void UpdateConnectedClients(string text, bool addClient)
        {
            if (addClient)
                _view.ListBoxClients.Items.Add(text);
            else
                _view.ListBoxClients.Items.Remove(text);
        }

        #endregion Delegates and delegates handler methods

        #region Event handler methods

        private void StartServerEvent(object sender, EventArgs e)
        {
            IPAddress local = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(local, 14100);
            _view.IsServerStarted = true;

            threadListeningCustomers = new Thread(new ThreadStart(ListenCustomers));
            threadListeningCustomers.Start();
            threadListeningCustomers.IsBackground = true;
            _view.Status = "Escuchando clientes en (127.0.0.1, 14100)...";
            _view.IsSuccessful = true;
            _view.Message = "Servidor iniciado en (127.0.0.1, 14100)...";
        }

        private void StopServerEvent(object sender, EventArgs e)
        {
            _view.IsServerStarted = false;
            tcpListener.Stop();
            _view.Status = "Apagado";
            _view.Message = "Servidor en (127.0.0.1, 14100) Apagado...";
            _view.ListBoxClients.Items.Clear();
        }

        #endregion Event handler methods

        #region Methods

        private void ListenCustomers()
        {
            try
            {
                tcpListener.Start();
                while (_view.IsServerStarted)
                {
                    TcpClient client = tcpListener.AcceptTcpClient();
                    Thread clientThread = new Thread(new ParameterizedThreadStart(CustomerCommunication));
                    clientThread.Start(client);
                }
            }
            catch (SocketException ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
                return;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
                return;
            }
        }

        private void CustomerCommunication(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            StreamReader reader = new StreamReader(tcpClient.GetStream());
            StreamWriter serverStreamWriter = new StreamWriter(tcpClient.GetStream());

            while (_view.IsServerStarted)
            {
                try
                {
                    var message = reader.ReadLine();
                    ClientRequest<object> request = JsonConvert.DeserializeObject<ClientRequest<object>>(message);
                    RequestHandler(request.TypeRequest, message, ref serverStreamWriter);
                }
                catch (Exception ex)
                {
                    _view.IsSuccessful = false;
                    _view.Message = ex.Message;
                    return;
                }
            }
        }

        #region Request handler

        /// <summary>
        /// Maneja la solicitud o consulta realizada por el cliente.
        /// </summary>
        /// <param name="typeRequest"></param>
        /// <param name="message"></param>
        /// <param name="serverStreamWriter"></param>
        public void RequestHandler(int typeRequest, string message, ref StreamWriter serverStreamWriter)
        {
            switch (typeRequest)
            {
                case (int)Request.ConnectToServer:
                    ClientRequest<string> customerCredentials = JsonConvert.DeserializeObject<ClientRequest<string>>(message);
                    ConnectToServer(customerId: customerCredentials.UserId, serverStreamWriter: ref serverStreamWriter);
                    break;

                case (int)Request.DisconnectFromServer:
                    ClientRequest<string> requestDisconnect = JsonConvert.DeserializeObject<ClientRequest<string>>(message);
                    DisconnectFromServer(customerId: requestDisconnect.UserId);
                    break;

                case (int)Request.GetRestaurantSelectList:
                    ClientRequest<string> requestRestaurant = JsonConvert.DeserializeObject<ClientRequest<string>>(message);
                    GetRestaurantSelectList(customerId: requestRestaurant.UserId, serverStreamWriter: ref serverStreamWriter);
                    break;

                case (int)Request.GetCategoriesSelectList:
                    ClientRequest<int> requestCategories = JsonConvert.DeserializeObject<ClientRequest<int>>(message);
                    GetCategoriesSelectList(restaurantId: requestCategories.Data, customerId: requestCategories.UserId, serverStreamWriter: ref serverStreamWriter);
                    break;

                case (int)Request.GetRestaurantData:
                    ClientRequest<int> requestRestaurantData = JsonConvert.DeserializeObject<ClientRequest<int>>(message);
                    GetRestaurantData(restaurantId: requestRestaurantData.Data, customerId: requestRestaurantData.UserId, serverStreamWriter: ref serverStreamWriter);
                    break;

                case (int)Request.AddDishOrder:
                    ClientRequest<CreateOrderViewModel> order = JsonConvert.DeserializeObject<ClientRequest<CreateOrderViewModel>>(message);
                    AddDishOrder(model: order.Data, customerId: order.UserId, serverStreamWriter: ref serverStreamWriter);
                    break;

                case (int)Request.ListOrdersByClient:
                    ClientRequest<string> customer = JsonConvert.DeserializeObject<ClientRequest<string>>(message);
                    GetListOrdersByClient(customerId: customer.UserId, serverStreamWriter: ref serverStreamWriter);
                    break;

                default:
                    break;
            }
        }

        #endregion Request handler

        #region Connect to server and disconnect from the server

        private void ConnectToServer(string customerId, ref StreamWriter serverStreamWriter)
        {
            var customer = _customerRepository.GetById(customerId);
            bool isSuccessful = false;
            string message = string.Empty;
            if (customer != null)
            {
                message = $"Id: {customer.IdCliente} | {customer.Nombre.Trim()} {customer.PrimerApellido.Trim()} {customer.SegundoApellido.Trim()}";
                isSuccessful = true;
                _view.TextBoxLogbook?.Invoke(_updateLogbookDelegate, new object[] { $"Cliente con Id: {customerId} se ha conectado..." });
                _view.ListBoxClients?.Invoke(_updateConnectedClientsDelegate, new object[] { message, true });
            }
            else
                message = Messages.Forbidden.GetDisplayName();

            serverStreamWriter.WriteLine(JsonConvert.SerializeObject(new { IsSuccessful = isSuccessful, Messages = message }));
            serverStreamWriter.Flush();
        }

        private void DisconnectFromServer(string customerId)
        {
            var customer = _customerRepository.GetById(customerId);
            if (customer != null)
            {
                string message = $"Id: {customer.IdCliente} | {customer.Nombre.Trim()} {customer.PrimerApellido.Trim()} {customer.SegundoApellido.Trim()}";
                _view.TextBoxLogbook?.Invoke(_updateLogbookDelegate, new object[] { $"Cliente con Id: {customerId} se ha desconectado..." });
                _view.ListBoxClients?.Invoke(_updateConnectedClientsDelegate, new object[] { message, false });
            }
        }

        #endregion Connect to server and disconnect from the server

        #region Get restaurant info for order

        private void GetRestaurantSelectList(string customerId, ref StreamWriter serverStreamWriter)
        {
            var selectListViewModel = _dishRestaurantRepository.GetRestaurantSelectList();
            serverStreamWriter.WriteLine(JsonConvert.SerializeObject(selectListViewModel));
            serverStreamWriter.Flush();
            _view.TextBoxLogbook?.Invoke(_updateLogbookDelegate, new object[] { $"Cliente con Id: {customerId} ha consultado Restaurantes activos ..." });
        }

        private void GetCategoriesSelectList(int restaurantId, string customerId, ref StreamWriter serverStreamWriter)
        {
            var selectListViewModel = _dishRestaurantRepository.GetCategoriesSelectList(restaurantId);
            serverStreamWriter.WriteLine(JsonConvert.SerializeObject(selectListViewModel));
            serverStreamWriter.Flush();
            _view.TextBoxLogbook?.Invoke(_updateLogbookDelegate, new object[] { $"Cliente con Id: {customerId} ha consultado Categorías de platos activos ..." });
        }

        private void GetRestaurantData(int restaurantId, string customerId, ref StreamWriter serverStreamWriter)
        {
            DishRestaurantDetailViewModel model = _dishRestaurantRepository.GetDishRestaurantDetail(restaurantId: restaurantId);
            serverStreamWriter.WriteLine(JsonConvert.SerializeObject(model));
            serverStreamWriter.Flush();
            _view.TextBoxLogbook?.Invoke(_updateLogbookDelegate, new object[] { $"Cliente con Id: {customerId} ha consultado información de restaurante con Id: {restaurantId}..." });
        }

        #endregion Get restaurant info for order

        #region Orders

        /// <summary>
        /// Agrega pedidos y extras a la base de datos.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="customerId"></param>
        /// <param name="serverStreamWriter"></param>
        private void AddDishOrder(CreateOrderViewModel model, string customerId, ref StreamWriter serverStreamWriter)
        {
            try
            {
                foreach (var order in model.Order)
                {
                    order.Id = _orderRepository.GetNewIdValue();
                    bool isSuccessful = _orderRepository.Add(order.ConvertToDB());
                    if (!isSuccessful)
                        throw new Exception(message: "Hubo un error y se detuvo el registro de pedidos.");

                    foreach (var extra in model.ExtraOrder)
                    {
                        if (extra.DishId == order.DishId)
                        {
                            extra.OrderId = order.Id;
                            var existExtra = _extraOrderRepository.GetById(extra.OrderId, extra.DishId, extra.ExtraId);
                            if (existExtra == null)
                            {
                                var result = _extraOrderRepository.Add(extra.ConvertToDB());
                                if (!result)
                                    throw new Exception(message: "Hubo un error y se detuvo el registro de extras.");
                            }
                        }
                    }
                }

                _view.TextBoxLogbook?.Invoke(_updateLogbookDelegate, new object[] { $"Cliente con Id: {customerId} ha realizado un pedido ..." });
                serverStreamWriter.WriteLine(JsonConvert.SerializeObject(new { IsSuccessful = true, Messages = "Pedido realizado correctamente." }));
                serverStreamWriter.Flush();
            }
            catch (Exception ex)
            {
                serverStreamWriter.WriteLine(JsonConvert.SerializeObject(new { IsSuccessful = false, Messages = ex.Message }));
                serverStreamWriter.Flush();
            }
        }

        private void GetListOrdersByClient(string customerId, ref StreamWriter serverStreamWriter)
        {
            var ordersViewModel = new List<OrderViewModel>();
            var orderList = _orderRepository.GetAllByCustomer(customerId: customerId);
            orderList.ToImmutableList().ForEach(order => ordersViewModel.Add(OrderViewModel.ConvertToViewModel(order)));

            _view.TextBoxLogbook?.Invoke(_updateLogbookDelegate, new object[] { $"Cliente con Id: {customerId} ha solicitado el listado de sus pedidos ..." });
            serverStreamWriter.WriteLine(JsonConvert.SerializeObject(ordersViewModel));
            serverStreamWriter.Flush();
        }

        #endregion Orders

        #endregion Methods
    }
}