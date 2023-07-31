using System.Collections;

namespace P1_JerryHurtado.Server.Views.Interfaces
{
    /// <summary>
    /// Define las propiedades, eventos y métodos que se utilizan en la vista Dish.
    /// </summary>
    public interface IDishView
    {
        #region Properties

        string DishName { get; set; }
        string DishPrice { get; set; }
        int CategoryId { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion Properties

        #region Events

        event EventHandler AddNewEvent;

        event EventHandler SaveEvent;

        event EventHandler CancelEvent;

        #endregion Events

        #region Methods

        void SetDishListBindingSource(BindingSource dishList);

        void SetDishCategorySelectList(ArrayList dishesCategories);

        void Show();

        #endregion Methods
    }
}