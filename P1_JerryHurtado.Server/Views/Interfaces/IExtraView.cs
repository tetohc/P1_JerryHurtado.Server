using System.Collections;

namespace P1_JerryHurtado.Server.Views.Interfaces
{
    /// <summary>
    /// Define las propiedades, eventos y métodos que serán utilizados en la vista.
    /// </summary>
    public interface IExtraView
    {
        #region Properties

        string ExtraDescription { get; set; }
        string ExtraPrice { get; set; }
        int ExtraCategoryId { get; set; }
        bool ExtrasStatus { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion Properties

        #region Events

        event EventHandler AddNewEvent;

        event EventHandler SaveEvent;

        event EventHandler CancelEvent;

        #endregion Events

        #region Methods

        void SetExtrasListBindingSource(BindingSource extrasList);

        void SetDishCategorySelectList(ArrayList dishesCategories);

        void Show();

        #endregion Methods
    }
}