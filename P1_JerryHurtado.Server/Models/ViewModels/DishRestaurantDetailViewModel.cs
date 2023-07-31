namespace P1_JerryHurtado.Server.Models.ViewModels
{
    public class DishRestaurantDetailViewModel
    {
        public int RestaurantId { get; set; }
        public virtual IEnumerable<SelectListViewModel> Category { get; set; } = new List<SelectListViewModel>();
        public virtual List<DishViewModel> Dish { get; set; } = new List<DishViewModel>();
        public virtual List<ExtraViewModel> Extra { get; set; } = new List<ExtraViewModel>();
    }
}