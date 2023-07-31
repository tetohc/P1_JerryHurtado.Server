using P1_JerryHurtado.Server.Models.ModelsDB;

namespace P1_JerryHurtado.Server._Repository.Interfaces
{
    public interface IOrderRepository<Pedido>
    {
        /// <summary>
        /// Agrega un nuevo registro a la base de datos.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Add(Pedido model);

        /// <summary>
        /// Retorna un pedido por su Id.
        /// </summary>
        /// <param name="id">Id de pedido.</param>
        /// <returns></returns>
        Pedido GetById(int id);

        /// <summary>
        /// Retorna una lista de todos los pedidos registrados en base de datos.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Pedido> GetAll();

        /// <summary>
        /// Retorna un listado de pedidos realizados por un cliente.
        /// </summary>
        /// <param name="customerId">Id de cliente.</param>
        /// <returns></returns>
        IEnumerable<Pedido> GetAllByCustomer(string customerId);

        /// <summary>
        /// Retorna el listado de extras asociados a un pedido.
        /// </summary>
        /// <param name="orderId">Id de pedido.</param>
        /// <returns></returns>
        IEnumerable<Pedido> GetExtasByOrder(int orderId);

        /// <summary>
        /// Generar un nuevo valor Id.
        /// </summary>
        /// <returns>int: nuevo Id.</returns>
        int GetNewIdValue();
    }
}