using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;

namespace P1_JerryHurtado.Server.Models.ViewModels
{
    public class DishCategoryViewModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }

        [DisplayName("Estado")]
        public string Status { get; set; }

        public static DishCategoryViewModel ConvertToViewModel(CategoriaPlato model) => new()
        {
            Id = model.IdCategoria,
            Description = model.Descripcion.Trim(),
            Status = model.Estado ? "Activo" : "Inactivo"
        };
    }
}