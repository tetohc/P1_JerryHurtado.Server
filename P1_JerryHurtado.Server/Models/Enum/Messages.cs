using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Server.Models.Enum
{
    public enum Messages
    {
        [Display(Name = "El Id proporcionado ya se encuentra registrado.")]
        DuplicateData,

        [Display(Name = "No hay datos disponibles")]
        DataEmpty,

        [Display(Name = "Los datos se han guardado correctamente.")]
        Success,

        [Display(Name = "Hubo un error, los datos no se han guardado correctamente.")]
        BadRequest,

        [Display(Name = "No se pudo establecer la conexión con el servidor. Usuario no registrado.")]
        Forbidden,
    }
}