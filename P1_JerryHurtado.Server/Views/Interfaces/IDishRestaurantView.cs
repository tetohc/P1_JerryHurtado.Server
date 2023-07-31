using P1_JerryHurtado.Server.Models.ViewModels;
using System.Collections;

namespace P1_JerryHurtado.Server.Views.Interfaces
{
    /// <summary>
    /// Define las propiedades, eventos y métodos que serán utilizados en la vista DishRestaurant.
    /// </summary>
    public interface IDishRestaurantView
    {
        #region Properties

        int RestaurantId { get; set; }
        string TitleForDetailPage { get; set; }
        DateTime DishRestaurantRegistrationDate { get; set; }
        List<DishViewModel> SelectedDishesList { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion Properties

        #region Events

        event EventHandler AddNewEvent;

        event EventHandler SaveEvent;

        event EventHandler CancelEvent;

        #endregion Events

        #region Methods

        void SetDishRestaurantListBindingSource(BindingSource dishRestaurantList);

        void SetRestaurantListBindingSource(BindingSource restaurantList);

        void SetDishListBindingSource(BindingSource dishList);

        void SetRestaurantSelectList(ArrayList restaurants);

        void Show();

        #endregion Methods
    }
}