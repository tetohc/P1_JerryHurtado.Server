namespace P1_JerryHurtado.Server.Views.Interfaces
{
    public interface IRestaurantView
    {
        #region Properties

        string RestaurantName { get; set; }
        string RestaurantAddress { get; set; }
        bool RestaurantStatus { get; set; }
        string RestaurantTelephone { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion Properties

        #region Events

        event EventHandler AddNewEvent;

        event EventHandler SaveEvent;

        event EventHandler CancelEvent;

        #endregion Events

        #region Methods

        void SetRestaurantListBindingSource(BindingSource restaurantLis);

        void Show();

        #endregion Methods
    }
}