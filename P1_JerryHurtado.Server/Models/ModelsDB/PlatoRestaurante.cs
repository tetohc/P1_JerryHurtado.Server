namespace P1_JerryHurtado.Server.Models.ModelsDB
{
    public class PlatoRestaurante
    {
        public int IdAsignacion { get; set; }

        public int IdRestaurante { get; set; }

        public int IdPlato { get; set; }

        public DateTime FechaAsignacion { get; set; }

        public virtual Plato IdPlatoNavigation { get; set; } = null!;

        public virtual Restaurante IdRestauranteNavigation { get; set; } = null!;
    }
}