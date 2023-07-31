using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Server.Models.Entities
{
    public class DishCategory
    {
        [DisplayName("Id")]
        [Required(ErrorMessage = "El id es requerido.")]
        public int Id { get; set; }

        [DisplayName("Descripción")]
        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "La descripción debe tener entre 1 y 50 caracteres.")]
        public string Description { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "El estado es requerido.")]
        public bool Status { get; set; }

        [DisplayName("Extra")]
        public virtual ICollection<Extra> Extra { get; set; } = new List<Extra>();

        [DisplayName("Platos")]
        public virtual ICollection<Dish> Dish { get; set; } = new List<Dish>();

        public CategoriaPlato ConvertToDB() => new()
        {
            IdCategoria = Id,
            Descripcion = Description,
            Estado = Status
        };
    }
}