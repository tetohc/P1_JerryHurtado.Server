using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Server.Models.Entities
{
    public class ExtraOrder
    {
        [DisplayName("Orden Id")]
        [Required(ErrorMessage = "El id de pedido es requerido.")]
        public int OrderId { get; set; }

        [DisplayName("Plato Id")]
        [Required(ErrorMessage = "El id de plato es requerido.")]
        public int DishId { get; set; }

        [DisplayName("Extra Id")]
        [Required(ErrorMessage = "El id de extra es requerido.")]
        public int ExtraId { get; set; }

        public ExtraPedido ConvertToDB() => new()
        {
            IdPedido = OrderId,
            IdPlato = DishId,
            IdExtra = ExtraId
        };
    }
}