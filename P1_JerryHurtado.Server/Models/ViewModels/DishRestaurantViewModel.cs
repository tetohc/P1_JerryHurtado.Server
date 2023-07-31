using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;

namespace P1_JerryHurtado.Server.Models.ViewModels
{
    public class DishRestaurantViewModel
    {
        [DisplayName("Id Asignación")]
        public int Id { get; set; }

        [DisplayName("Id Restaurante")]
        public int RestaurantId { get; set; }

        [DisplayName("Restaurante")]
        public string RestaurantName { get; set; }

        [DisplayName("Id Plato")]
        public int DishId { get; set; }

        [DisplayName("Plato")]
        public string DishName { get; set; }

        [DisplayName("Fecha de registro")]
        public string RegistrationDate { get; set; }

        public static DishRestaurantViewModel ConvertToViewModel(PlatoRestaurante model) => new()
        {
            Id = model.IdAsignacion,
            RestaurantId = model.IdRestaurante,
            RestaurantName = model?.IdRestauranteNavigation?.Nombre?.Trim(),
            DishId = model.IdPlato,
            DishName = model?.IdPlatoNavigation?.Nombre?.Trim(),
            RegistrationDate = model.FechaAsignacion.ToString(),
        };
    }
}