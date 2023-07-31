namespace P1_JerryHurtado.Server.Models.ModelsDB
{
    public class Extra
    {
        public int IdExtra { get; set; }

        public string Descripcion { get; set; } = null!;

        public int IdCategoria { get; set; }

        public bool Estado { get; set; }

        public int Precio { get; set; }

        public virtual CategoriaPlato IdCategoriaNavigation { get; set; } = null!;

        public virtual ICollection<Pedido> IdP { get; set; } = new List<Pedido>();
    }
}