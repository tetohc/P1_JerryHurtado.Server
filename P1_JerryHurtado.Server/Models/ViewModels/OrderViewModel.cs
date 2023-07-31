using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;

namespace P1_JerryHurtado.Server.Models.ViewModels
{
    public class OrderViewModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Cliente Id")]
        public string CustomerId { get; set; }

        [DisplayName("Plato Id")]
        public int DishId { get; set; }

        [DisplayName("Fecha de pedido")]
        public DateTime? DateOrder { get; set; }

        [DisplayName("Cliente")]
        public string CustomerName { get; set; }

        [DisplayName("Plato")]
        public string DishName { get; set; }

        [DisplayName("Precio")]
        public int Price { get; set; }

        public static OrderViewModel ConvertToViewModel(Pedido model) => new()
        {
            Id = model.IdPedido,
            CustomerId = model.IdCliente,
            DishId = model.IdPlato,
            DateOrder = model?.FechaPedido,
            CustomerName = $"{model?.IdClienteNavigation?.Nombre?.Trim()} {model?.IdClienteNavigation?.PrimerApellido?.Trim()} {model?.IdClienteNavigation?.SegundoApellido?.Trim()}",
            DishName = model?.IdPlatoNavigation?.Nombre?.Trim(),
            Price = model.IdPlatoNavigation.Precio
        };
    }
}