using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Server.Models.Enum
{
    /// <summary>
    /// Tipos de consultas que puede realizar el Cliente al Servidor.
    /// </summary>
    public enum Request
    {
        [Display(Name = "Conectarse al servidor")]
        ConnectToServer,

        [Display(Name = "Realizar pedido de platos")]
        AddDishOrder,

        [Display(Name = "Listar pedidos")]
        ListOrdersByClient,

        [Display(Name = "Listar restaurantes")]
        GetRestaurantSelectList,

        [Display(Name = "Listar categorias de platos")]
        GetCategoriesSelectList,

        [Display(Name = "Información de restaurante")]
        GetRestaurantData,

        [Display(Name = "Desconectarse del servidor")]
        DisconnectFromServer,
    }
}