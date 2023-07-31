namespace P1_JerryHurtado.Server.Models.ModelsDB
{
    public class Plato
    {
        public int IdPlato { get; set; }

        public string Nombre { get; set; } = null!;

        public int IdCategoria { get; set; }

        public int Precio { get; set; }

        public virtual CategoriaPlato IdCategoriaNavigation { get; set; } = null!;

        public virtual ICollection<Pedido> Pedido { get; set; } = new List<Pedido>();

        public virtual ICollection<PlatoRestaurante> PlatoRestaurante { get; set; } = new List<PlatoRestaurante>();
    }
}