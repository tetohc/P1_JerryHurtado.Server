using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Server.Models.Entities
{
    public class DishRestaurant
    {
        [DisplayName("Id Asignación")]
        [Required(ErrorMessage = "El id de asignación es requerido.")]
        public int Id { get; set; }

        [DisplayName("Id Restaurante")]
        [Required(ErrorMessage = "El id de restaurante es requerido.")]
        public int RestaurantId { get; set; }

        [DisplayName("Id Plato")]
        [Required(ErrorMessage = "El id del plato es requerido.")]
        public int DishId { get; set; }

        [DisplayName("Fecha de registro")]
        [Required(ErrorMessage = "La fecha de registro es requerida.")]
        public DateTime RegistrationDate { get; set; }

        [DisplayName("Plato")]
        [Required(ErrorMessage = "El plato es requerido.")]
        public virtual Dish Dish { get; set; } = null!;

        [DisplayName("Restaurante")]
        public virtual Restaurant Restaurant { get; set; } = null!;

        public PlatoRestaurante ConvertToDB() => new()
        {
            IdAsignacion = Id,
            IdRestaurante = RestaurantId,
            IdPlato = DishId,
            FechaAsignacion = RegistrationDate
        };
    }
}