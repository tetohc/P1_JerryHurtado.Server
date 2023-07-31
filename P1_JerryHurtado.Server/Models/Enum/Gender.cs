using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Server.Models.Enum
{
    public enum Gender
    {
        [Display(Name = "Hombre")]
        Male,

        [Display(Name = "Mujer")]
        Female,
    }
}