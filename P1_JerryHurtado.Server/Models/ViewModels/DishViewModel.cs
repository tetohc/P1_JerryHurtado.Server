using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;

namespace P1_JerryHurtado.Server.Models.ViewModels
{
    public class DishViewModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Precio")]
        public int Price { get; set; }

        [DisplayName("Categoría Id")]
        public int CategoryId { get; set; }

        [DisplayName("Categoría")]
        public string CategoryName { get; set; }

        public static DishViewModel ConvertToViewModel(Plato model) => new()
        {
            Id = model.IdPlato,
            Name = model?.Nombre?.Trim(),
            Price = model.Precio,
            CategoryId = model.IdCategoria,
            CategoryName = model?.IdCategoriaNavigation?.Descripcion?.Trim()
        };
    }
}