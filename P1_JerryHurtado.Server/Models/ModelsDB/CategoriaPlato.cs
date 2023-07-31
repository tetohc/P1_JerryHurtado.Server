namespace P1_JerryHurtado.Server.Models.ModelsDB
{
    public class CategoriaPlato
    {
        public int IdCategoria { get; set; }

        public string Descripcion { get; set; } = null!;

        public bool Estado { get; set; }

        public virtual ICollection<Extra> Extra { get; set; } = new List<Extra>();

        public virtual ICollection<Plato> Plato { get; set; } = new List<Plato>();
    }
}