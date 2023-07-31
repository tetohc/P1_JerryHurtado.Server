namespace P1_JerryHurtado.Server.Views.Interfaces
{
    /// <summary>
    /// Define las propiedades, eventos y métodos que serán utilizados en la vista.
    /// </summary>
    public interface IMainView
    {
        #region Properties

        Panel MainPanel { get; set; }

        #endregion Properties

        #region Events

        event EventHandler ShowRestaurantView;

        event EventHandler ShowDishCategoryView;

        event EventHandler ShowDishView;

        event EventHandler ShowCustomerView;

        event EventHandler ShowDishRestaurantView;

        event EventHandler ShowExtraView;

        event EventHandler ShowMainView;

        event EventHandler ShowServerView;

        #endregion Events
    }
}