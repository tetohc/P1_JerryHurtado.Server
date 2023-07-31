using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Server.Models.Entities
{
    public class Extra
    {
        [DisplayName("Id")]
        [Required(ErrorMessage = "El id es requerido.")]
        public int Id { get; set; }

        [DisplayName("Categoría")]
        [Required(ErrorMessage = "La categoría es requerida.")]
        public int CategoryId { get; set; }

        [DisplayName("Descripción")]
        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "La descripción debe tener entre 1 y 50 caracteres.")]
        public string Description { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "El estado es requerido.")]
        public bool Status { get; set; }

        [DisplayName("Precio")]
        [Range(0, int.MaxValue, ErrorMessage = "El valor de 'Precio' debe ser un número mayor o igual a 0.")]
        [Required(ErrorMessage = "El precio es requerido.")]
        public int Price { get; set; }

        [DisplayName("Categoría")]
        public virtual DishCategory Category { get; set; }

        [DisplayName("Pedido")]
        public virtual ICollection<Order> Order { get; set; } = new List<Order>();

        public ModelsDB.Extra ConvertToDB() => new()
        {
            IdExtra = Id,
            Descripcion = Description,
            IdCategoria = CategoryId,
            Estado = Status,
            Precio = Price
        };
    }
}