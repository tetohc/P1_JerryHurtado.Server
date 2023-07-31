namespace P1_JerryHurtado.Server.Models.ModelsDB
{
    public class Pedido
    {
        public int IdPedido { get; set; }

        public string? IdCliente { get; set; }

        public int IdPlato { get; set; }

        public DateTime? FechaPedido { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }

        public virtual Plato IdPlatoNavigation { get; set; } = null!;

        public virtual ICollection<Extra> IdExtra { get; set; } = new List<Extra>();
    }
}