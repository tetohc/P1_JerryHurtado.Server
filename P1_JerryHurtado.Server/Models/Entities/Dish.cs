using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Server.Models.Entities
{
    public class Dish
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Categoría")]
        [Required(ErrorMessage = "La categoría es requerida.")]
        public int CategoryId { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre del plato es requerido.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "El nombre debe tener entre 1 y 50 caracteres.")]
        public string Name { get; set; } = null!;

        [DisplayName("Precio")]
        [Range(0, int.MaxValue, ErrorMessage = "El valor de 'Precio' debe ser un número mayor o igual a 0.")]
        [Required(ErrorMessage = "El precio es requerido.")]
        public int Price { get; set; }

        [DisplayName("Categoría")]
        public virtual DishCategory Category { get; set; } = null!;

        [DisplayName("Pedido")]
        public virtual ICollection<Order> Order { get; set; } = new List<Order>();

        [DisplayName("Plato Restaurante")]
        public virtual ICollection<DishRestaurant> DishRestaurant { get; set; } = new List<DishRestaurant>();

        public Plato ConvertToDB() => new()
        {
            IdPlato = Id,
            IdCategoria = CategoryId,
            Nombre = Name,
            Precio = Price
        };
    }
}