using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;

namespace P1_JerryHurtado.Server.Models.ViewModels
{
    public class ExtraViewModel
    {
        [DisplayName("Id de Extra")]
        public int Id { get; set; }

        [DisplayName("Id de Categoría")]
        public int CategoryId { get; set; }

        [DisplayName("Categoría")]
        public string Category { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }

        [DisplayName("Estado")]
        public string Status { get; set; }

        [DisplayName("Precio")]
        public int Price { get; set; }

        public static ExtraViewModel ConvertToViewModel(Extra model) => new()
        {
            Id = model.IdExtra,
            CategoryId = model.IdCategoria,
            Category = model?.IdCategoriaNavigation?.Descripcion?.Trim(),
            Description = model?.Descripcion.Trim(),
            Status = model.Estado ? "Activo" : "Inactivo",
            Price = model.Precio
        };
    }
}