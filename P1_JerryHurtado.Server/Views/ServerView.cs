using P1_JerryHurtado.Server.Views.Interfaces;
using P1_JerryHurtado.Server.Views.Utilities;

namespace P1_JerryHurtado.Server.Views
{
    public partial class ServerView : Form, IServerView
    {
        private string _message;
        private bool _isSuccessful;
        private bool _isServerStarted;

        public ServerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            btnStopServer.Enabled = false;
        }

        #region Properties

        public TextBox TextBoxLogbook { get => textBoxLogbook; }
        public ListBox ListBoxClients { get => listBoxConnectedCustomers; }
        public string Status { get => labelStatus.Text; set => labelStatus.Text = value; }
        public bool IsSuccessful { get => _isSuccessful; set => _isSuccessful = value; }
        public bool IsServerStarted { get => _isServerStarted; set => _isServerStarted = value; }
        public string Message { get => _message; set => _message = value; }

        #endregion Properties

        #region Events

        public event EventHandler StartServerEvent;

        public event EventHandler StopServerEvent;

        #endregion Events

        #region Methods

        private void AssociateAndRaiseViewEvents()
        {
            btnStartServer.Click += delegate
            {
                StartServerEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    ShowMessage();
                    textBoxLogbook.Text = Message;
                    textBoxLogbook.AppendText(Environment.NewLine);
                    btnStartServer.Enabled = false;
                    btnStopServer.Enabled = true;
                }
                else
                    Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
            };

            btnStopServer.Click += delegate
            {
                StopServerEvent?.Invoke(this, EventArgs.Empty);
                textBoxLogbook.Text = Message;
                textBoxLogbook.AppendText(Environment.NewLine);
                btnStartServer.Enabled = true;
                btnStopServer.Enabled = false;
            };
        }

        private void ShowMessage()
            => MessageBox.Show("El servidor se ha encendido correctamente.\n\nTener en cuenta: \n- Si cambia de vista, después de haber iniciado el servidor, este se apagará.", "Servidor disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static ServerView GetInstance(Panel parentContainer)
        {
            var instance = new ServerView();
            instance.TopLevel = false;
            instance.FormBorderStyle = FormBorderStyle.None;
            instance.Dock = DockStyle.Fill;
            parentContainer.Controls.Clear();
            parentContainer.Controls.Add(instance);
            return instance;
        }

        #endregion Methods
    }
}