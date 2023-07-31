using P1_JerryHurtado.Server.Models.ViewModels;

namespace P1_JerryHurtado.Server._Repository.Interfaces
{
    public interface IDishRestaurantRepository<T>
    {
        /// <summary>
        /// Agrega un nuevo registro a la base de datos.
        /// </summary>
        /// <param name="model"></param>
        /// <returns>bool: true si es registro exitoso, de lo contrario false.</returns>
        bool Add(T model);

        T GetById(int id);

        IEnumerable<T> GetAll();

        /// <summary>
        /// Retorna los restaurantes que tienen platos asignados y que estan activos.
        /// </summary>
        /// <returns></returns>
        IEnumerable<SelectListViewModel> GetRestaurantSelectList();

        /// <summary>
        /// Retorna las categorias asociadas a los platos asignados de un restaurante.
        /// </summary>
        /// <param name="restaurantId"></param>
        /// <returns></returns>
        IEnumerable<SelectListViewModel> GetCategoriesSelectList(int restaurantId);

        IEnumerable<ExtraViewModel> GetExtrasByCategory(int categoryId);

        /// <summary>
        /// Retorna platos, categorías y extras, asociados a un restaurante.
        /// </summary>
        /// <param name="restaurantId"></param>
        /// <returns></returns>
        DishRestaurantDetailViewModel GetDishRestaurantDetail(int restaurantId);

        bool IsEmpty();

        /// <summary>
        /// Generar un nuevo valor Id.
        /// </summary>
        /// <returns>int: nuevo Id.</returns>
        int GetNewIdValue();
    }
}