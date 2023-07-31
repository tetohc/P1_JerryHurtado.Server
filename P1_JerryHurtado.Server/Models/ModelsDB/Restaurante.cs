namespace P1_JerryHurtado.Server.Models.ModelsDB
{
    public class Restaurante
    {
        public int IdRestaurante { get; set; }

        public string Nombre { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public bool Estado { get; set; }

        public string Telefono { get; set; } = null!;

        public virtual ICollection<PlatoRestaurante> PlatoRestaurante { get; set; } = new List<PlatoRestaurante>();
    }
}