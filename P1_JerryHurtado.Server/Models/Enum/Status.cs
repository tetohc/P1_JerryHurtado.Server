using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Server.Models.Enum
{
    public enum Status
    {
        [Display(Name = "Activo")]
        Active,

        [Display(Name = "Inactivo")]
        Inactive,
    }
}