namespace P1_JerryHurtado.Server.Models.ModelsDB
{
    public class Cliente
    {
        public string IdCliente { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string PrimerApellido { get; set; } = null!;

        public string SegundoApellido { get; set; } = null!;

        public DateTime FechaNacimiento { get; set; }

        public string Genero { get; set; } = null!;

        public virtual ICollection<Pedido> Pedido { get; set; } = new List<Pedido>();
    }
}