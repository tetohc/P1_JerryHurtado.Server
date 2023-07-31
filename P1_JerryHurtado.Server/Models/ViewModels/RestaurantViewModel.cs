using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;

namespace P1_JerryHurtado.Server.Models.ViewModels
{
    public class RestaurantViewModel
    {
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Dirección")]
        public string Address { get; set; }

        [DisplayName("Estado")]
        public string Status { get; set; }

        [DisplayName("Teléfono")]
        public string Telephone { get; set; }

        public static RestaurantViewModel ConvertToViewModel(Restaurante model) => new()
        {
            Id = model.IdRestaurante,
            Name = model.Nombre.Trim(),
            Address = model.Direccion.Trim(),
            Status = model.Estado ? "Activo" : "Inactivo",
            Telephone = model.Telefono.Trim(),
        };
    }
}