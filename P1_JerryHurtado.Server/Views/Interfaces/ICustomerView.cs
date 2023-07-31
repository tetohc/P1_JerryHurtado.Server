namespace P1_JerryHurtado.Server.Views.Interfaces
{
    /// <summary>
    /// Define las propiedades, eventos y métodos que serán utilizados en la vista Customer.
    /// </summary>
    public interface ICustomerView
    {
        #region Properties

        string CustomerId { get; set; }
        string CustomerName { get; set; }
        string CustomerFirstSurname { get; set; }
        string CustomerLastSurname { get; set; }
        DateTime CustomerBirthDate { get; set; }
        char CustomerGender { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion Properties

        #region Events

        event EventHandler AddNewEvent;

        event EventHandler SaveEvent;

        event EventHandler CancelEvent;

        #endregion Events

        #region Methods

        void SetCustomerListBindingSource(BindingSource customerList);

        void LoadCustomersGender();

        void Show();

        #endregion Methods
    }
}