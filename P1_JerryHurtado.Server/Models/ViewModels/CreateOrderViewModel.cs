using P1_JerryHurtado.Server.Models.Entities;

namespace P1_JerryHurtado.Server.Models.ViewModels
{
    public class CreateOrderViewModel
    {
        public List<Order> Order { get; set; } = new List<Order>();
        public List<ExtraOrder> ExtraOrder { get; set; } = new List<ExtraOrder>();
    }
}