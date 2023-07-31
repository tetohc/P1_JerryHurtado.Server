using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Server.Models.Entities
{
    public class Order
    {
        [DisplayName("Id")]
        [Required(ErrorMessage = "El id del pedido es requerido.")]
        public int Id { get; set; }

        [DisplayName("Cliente Id")]
        [Required(ErrorMessage = "El id del cliente es requerido.")]
        public string CustomerId { get; set; }

        [DisplayName("Plato Id")]
        [Required(ErrorMessage = "El id del plato es requerido.")]
        public int DishId { get; set; }

        [DisplayName("Fecha de pedido")]
        [Required(ErrorMessage = "La fecha del pedido es requirida.")]
        public DateTime? DateOrder { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Dish Dish { get; set; } = null!;

        public virtual ICollection<Extra> Extra { get; set; } = new List<Extra>();

        public Pedido ConvertToDB() => new()
        {
            IdPedido = Id,
            IdCliente = CustomerId,
            IdPlato = DishId,
            FechaPedido = DateTime.Now
        };
    }
}