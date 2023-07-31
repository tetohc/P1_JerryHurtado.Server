namespace P1_JerryHurtado.Server.Views.Interfaces
{
    /// <summary>
    /// Define las propiedades, eventos y métodos que serán utilizados en la vista.
    /// </summary>
    public interface IServerView
    {
        #region Properties

        TextBox TextBoxLogbook { get; }
        ListBox ListBoxClients { get; }
        string Status { get; set; }
        bool IsSuccessful { get; set; }
        bool IsServerStarted { get; set; }
        string Message { get; set; }

        #endregion Properties

        #region Events

        event EventHandler StartServerEvent;

        event EventHandler StopServerEvent;

        #endregion Events

        #region Methods

        void Show();

        #endregion Methods
    }
}