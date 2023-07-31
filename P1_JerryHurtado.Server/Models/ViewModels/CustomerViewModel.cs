using P1_JerryHurtado.Server.Models.Entities;
using P1_JerryHurtado.Server.Models.ModelsDB;
using System.ComponentModel;

namespace P1_JerryHurtado.Server.Models.ViewModels
{
    public class CustomerViewModel
    {
        [DisplayName("Id")]
        public string Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Primer apellido")]
        public string FirstSurname { get; set; }

        [DisplayName("Segundo apellido")]
        public string LastSurname { get; set; }

        [DisplayName("Fecha de nacimiento")]
        public string BirthDate { get; set; }

        [DisplayName("Género")]
        public string Gender { get; set; }

        public static CustomerViewModel ConvertToViewModel(Cliente model) => new()
        {
            Id = model.IdCliente.Trim(),
            Name = model.Nombre.Trim(),
            FirstSurname = model.PrimerApellido.Trim(),
            LastSurname = model.SegundoApellido.Trim(),
            BirthDate = model.FechaNacimiento.ToShortDateString(),
            Gender = model.Genero == "M" ? "Masculino" : "Femenino"
        };
    }
}