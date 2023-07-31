namespace P1_JerryHurtado.Server.Views.Interfaces
{
    /// <summary>
    /// Define las propiedades, eventos y métodos que serán utilizados en la vista.
    /// </summary>
    public interface IDishCategoryView
    {
        #region Properties

        string DishCategoryDescription { get; set; }
        bool DishCategoryStatus { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion Properties

        #region Events

        event EventHandler AddNewEvent;

        event EventHandler SaveEvent;

        event EventHandler CancelEvent;

        #endregion Events

        #region Methods

        void SetDishCategoryListBindingSource(BindingSource dishCategoryList);

        void Show();

        #endregion Methods
    }
}