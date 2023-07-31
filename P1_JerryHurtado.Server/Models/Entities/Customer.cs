using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Server.Models.Entities
{
    public class Customer
    {
        [DisplayName("Id")]
        [Required(ErrorMessage = "El Id de Cliente es requerido.")]
        public string Id { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido.")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "El nombre debe tener entre 1 y 10 caracteres.")]
        public string Name { get; set; } = null!;

        [DisplayName("Primer apellido")]
        [Required(ErrorMessage = "El primer apellido es requerido.")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "El primer apellido debe tener entre 1 y 255 caracteres.")]
        public string FirstSurname { get; set; } = null!;

        [DisplayName("Segundo apellido")]
        [Required(ErrorMessage = "El segundo apellido es requerido.")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "El segundo apellido debe tener entre 1 y 255 caracteres.")]
        public string LastSurname { get; set; } = null!;

        [DisplayName("Fecha de nacimiento")]
        [Required(ErrorMessage = "La fecha de nacimiento es requirida.")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Género")]
        [Required(ErrorMessage = "El género es requerido.")]
        [RegularExpression(@"^[FM]$", ErrorMessage = "El valor de género debe ser 'F' o 'M'.")]
        public char Gender { get; set; }

        public virtual ICollection<Order> Order { get; set; } = new List<Order>();

        public Cliente ConvetToDB() => new()
        {
            IdCliente = Id,
            Nombre = Name,
            PrimerApellido = FirstSurname,
            SegundoApellido = LastSurname,
            FechaNacimiento = BirthDate,
            Genero = Gender.ToString()
        };
    }
}