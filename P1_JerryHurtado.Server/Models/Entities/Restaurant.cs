using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Server.Models.Entities
{
    public class Restaurant
    {
        [DisplayName("Id")]
        [Required(ErrorMessage = "El Id es requerido.")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "El nombre debe tener entre 1 y 50 caracteres.")]
        public string Name { get; set; }

        [DisplayName("Dirección")]
        [Required(ErrorMessage = "La dirección es requerida.")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "El dirección debe tener entre 1 y 255 caracteres.")]
        public string Address { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "El estado es requerido.")]
        public bool Status { get; set; }

        [DisplayName("Teléfono")]
        [Required(ErrorMessage = "El teléfono es requerido.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "El teléfono debe tener entre 1 y 50 caracteres.")]
        public string Telephone { get; set; }

        public virtual ICollection<DishRestaurant> DishRestaurant { get; set; } = new List<DishRestaurant>();

        public Restaurante ConvertToDB() => new()
        {
            IdRestaurante = Id,
            Nombre = Name,
            Direccion = Address,
            Estado = Status,
            Telefono = Telephone
        };
    }
}