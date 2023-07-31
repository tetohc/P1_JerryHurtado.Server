using P1_JerryHurtado.Server._Repository;
using P1_JerryHurtado.Server._Repository.ContextDB;
using P1_JerryHurtado.Server._Repository.Interfaces;
using P1_JerryHurtado.Server._Utilities;
using P1_JerryHurtado.Server.Models.Entities;
using P1_JerryHurtado.Server.Models.Enum;
using P1_JerryHurtado.Server.Models.ModelsDB;
using P1_JerryHurtado.Server.Models.ViewModels;
using P1_JerryHurtado.Server.Presenters.Utilities;
using P1_JerryHurtado.Server.Views.Interfaces;
using System.Collections;
using System.Collections.Immutable;

namespace P1_JerryHurtado.Server.Presenters
{
    /// <summary>
    /// Esta clase es el puente que comunica la vista y el acceso a datos del modelo Dish
    /// </summary>
    public class DishPresenter
    {
        private IDishView _view;
        private IRepository<Plato> _dishRepository;
        private IRepository<CategoriaPlato> _dishCategoryRepository;
        private BindingSource _dishesBindingSource;

        public DishPresenter(IDishView view, RestUnedContext dbContext)
        {
            _view = view;
            _dishRepository = new DishRepository(dbContext);
            _dishCategoryRepository = new DishCategoryRepository(dbContext);
            _dishesBindingSource = new BindingSource();

            _view.AddNewEvent += AddNewEvent;
            _view.SaveEvent += SaveDishCategory;
            _view.CancelEvent += CancelAction;

            _view.SetDishListBindingSource(_dishesBindingSource);
            _view.SetDishCategorySelectList(LoadAllDishesCategories());
            LoadAllDishes();
            _view.Show();
        }

        #region Event handler methods

        private void AddNewEvent(object sender, EventArgs e)
        {
            _view.IsSuccessful = true;
            if (_dishCategoryRepository.IsEmpty())
            {
                _view.IsSuccessful = false;
                _view.Message = "- Para agregar Platos, la lista de 'Categoría de platos' debe contener al menos un elemento registrado y activo.";
            }
        }

        private void SaveDishCategory(object sender, EventArgs e)
        {
            try
            {
                var model = new Dish();
                model.Id = _dishRepository.GetNewIdValue();
                model.CategoryId = _view.CategoryId;
                model.Name = _view.DishName.Trim();
                model.Price = Convert.ToInt32(_view.DishPrice);

                #region Validations

                ModelDataValidation.Validate(model);
                var exist = _dishRepository.GetById(model.Id);
                if (exist != null)
                    throw new Exception(message: Messages.DuplicateData.GetDisplayName());

                bool isSuccessful = _dishRepository.Add(model.ConvertToDB());
                if (!isSuccessful)
                    throw new Exception(message: Messages.BadRequest.GetDisplayName());

                #endregion Validations

                _view.Message = Messages.Success.GetDisplayName();
                _view.IsSuccessful = true;
                LoadAllDishes();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void CancelAction(object sender, EventArgs e) => CleanViewFields();

        #endregion Event handler methods

        #region Methods

        /// <summary>
        /// Obtiene el listado de categorías de platos activos y los agrega a un ArrayList
        /// </summary>
        /// <returns>ArrayList: Listado de categoría de platos (activos).</returns>
        private ArrayList LoadAllDishesCategories()
        {
            ArrayList categories = new ArrayList();
            if (!_dishCategoryRepository.IsEmpty())
            {
                var dishCategoryList = _dishCategoryRepository.GetAll();
                foreach (var item in dishCategoryList.Where(x => x.Estado))
                    categories.Add(new { Id = item.IdCategoria.ToString(), Description = item.Descripcion.Trim() }); ;
            }
            else
                categories.Add(new { Id = string.Empty, Description = Messages.DataEmpty.GetDisplayName() });
            return categories;
        }

        private void LoadAllDishes()
        {
            var dishes = new List<DishViewModel>();
            var dishList = _dishRepository.GetAll();
            dishList.ToImmutableList().ForEach(dish => dishes.Add(DishViewModel.ConvertToViewModel(dish)));
            _dishesBindingSource.DataSource = dishes;
        }

        private void CleanViewFields()
        {
            _view.DishName = string.Empty;
            _view.DishPrice = string.Empty;
        }

        #endregion Methods
    }
}