using Microsoft.EntityFrameworkCore;
using P1_JerryHurtado.Server._Repository.ContextDB;
using P1_JerryHurtado.Server._Repository.Interfaces;
using P1_JerryHurtado.Server.Models.ModelsDB;
using P1_JerryHurtado.Server.Models.ViewModels;
using System.Collections.Immutable;

namespace P1_JerryHurtado.Server._Repository
{
    public class DishRestaurantRepository : IDishRestaurantRepository<PlatoRestaurante>
    {
        private readonly RestUnedContext _dbContext;

        public DishRestaurantRepository(RestUnedContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(PlatoRestaurante model)
        {
            using var transaccion = _dbContext.Database.BeginTransaction();
            try
            {
                _dbContext.PlatoRestaurante.Add(model);
                _dbContext.SaveChanges();
                transaccion.Commit();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                transaccion.Rollback();
                return false;
            }
        }

        public IEnumerable<PlatoRestaurante> GetAll() => _dbContext.PlatoRestaurante
                                                            .Include(x => x.IdPlatoNavigation)
                                                            .Include(x => x.IdRestauranteNavigation).ToList();

        public PlatoRestaurante GetById(int id) => _dbContext.PlatoRestaurante.FirstOrDefault(x => x.IdAsignacion == id);

        public int GetNewIdValue()
        {
            int newId = 1;
            var list = _dbContext.PlatoRestaurante.ToList();
            if (list.Count() > 0)
            {
                list = list.OrderByDescending(x => x.IdAsignacion).ToList();
                newId = list.FirstOrDefault().IdAsignacion + 1;
            }
            return newId;
        }

        public bool IsEmpty()
        {
            var list = GetAll();
            return list.Count() == 0 ? true : false;
        }

        #region Client

        public IEnumerable<SelectListViewModel> GetRestaurantSelectList()
        {
            var list = _dbContext.PlatoRestaurante.Include(x => x.IdRestauranteNavigation).Where(x => x.IdRestauranteNavigation.Estado).Distinct().ToList();
            var restaurantSelectList = new List<SelectListViewModel>();
            foreach (var item in list)
            {
                if (!restaurantSelectList.Any(x => x.Id == item.IdRestaurante))
                    restaurantSelectList.Add(new SelectListViewModel() { Id = item.IdRestaurante, Name = item?.IdRestauranteNavigation?.Nombre?.Trim() });
            }
            return restaurantSelectList.OrderBy(x => x?.Name);
        }

        public IEnumerable<SelectListViewModel> GetCategoriesSelectList(int restaurantId)
        {
            var categories = _dbContext.PlatoRestaurante
                .Include(x => x.IdPlatoNavigation)
                .ThenInclude(x => x.IdCategoriaNavigation)
                .Where(x => x.IdRestaurante == restaurantId && x.IdRestauranteNavigation.Estado).ToList();

            var categorySelectList = new List<SelectListViewModel>();
            foreach (var item in categories)
            {
                if (!categorySelectList.Any(x => x.Id == item.IdPlatoNavigation.IdCategoriaNavigation.IdCategoria))
                    categorySelectList.Add(new SelectListViewModel()
                    {
                        Id = item.IdPlatoNavigation.IdCategoriaNavigation.IdCategoria,
                        Name = item.IdPlatoNavigation.IdCategoriaNavigation.Descripcion.Trim()
                    });
            }

            if (categorySelectList.Count() > 0)
                categorySelectList.Add(new SelectListViewModel() { Id = -1, Name = "Todas las categorías" });
            return categorySelectList.OrderBy(x => x?.Id);
        }

        public IEnumerable<ExtraViewModel> GetExtrasByCategory(int categoryId)
        {
            var extras = _dbContext.Extra.Where(x => x.IdCategoria == categoryId && x.Estado).ToList();
            return extras.ConvertAll(x => ExtraViewModel.ConvertToViewModel(x));
        }

        public DishRestaurantDetailViewModel GetDishRestaurantDetail(int restaurantId)
        {
            var dishesAndCategories = _dbContext.PlatoRestaurante
                .Include(x => x.IdPlatoNavigation)
                .ThenInclude(x => x.IdCategoriaNavigation).ThenInclude(x => x.Extra)
                .Where(x => x.IdRestaurante == restaurantId && x.IdRestauranteNavigation.Estado).ToList();

            #region join dishes

            var model = new DishRestaurantDetailViewModel();
            model.RestaurantId = restaurantId;
            foreach (var item in dishesAndCategories)
            {
                int categoryId = item.IdPlatoNavigation.IdCategoria;
                if (!model.Dish.Any(x => x.Id == item.IdAsignacion))
                    model.Dish.Add(DishViewModel.ConvertToViewModel(item.IdPlatoNavigation));
            }

            #endregion join dishes

            #region join categories

            model.Category = GetCategoriesSelectList(restaurantId);

            #endregion join categories

            #region join extras by category

            foreach (var item in model.Category.ToList())
            {
                var extrasByCategory = _dbContext.Extra.Where(x => x.IdCategoria == item.Id && x.Estado);
                foreach (var extra in extrasByCategory.ToList())
                {
                    if (!model.Extra.Any(x => x.Id == extra.IdExtra))
                        extrasByCategory.ToImmutableList().ForEach(x => model.Extra.Add(ExtraViewModel.ConvertToViewModel(x)));
                }
            }

            #endregion join extras by category

            return model;
        }

        #endregion Client
    }
}