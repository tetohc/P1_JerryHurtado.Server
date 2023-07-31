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
    public class DishRestaurantPresenter
    {
        private IDishRestaurantView _view;
        private IDishRestaurantRepository<PlatoRestaurante> _dishRestaurantRepository;
        private IRepository<Restaurante> _restaurantRepository;
        private IRepository<Plato> _dishRepository;
        private BindingSource _dishRestaurantBindingSource;
        private BindingSource _restaurantBindingSource;
        private BindingSource _dishesBindingSource;

        public DishRestaurantPresenter(IDishRestaurantView view, RestUnedContext dbContext)
        {
            _view = view;
            _dishRestaurantRepository = new DishRestaurantRepository(dbContext);
            _restaurantRepository = new RestaurantRepository(dbContext);
            _dishRepository = new DishRepository(dbContext);
            _dishRestaurantBindingSource = new BindingSource();
            _restaurantBindingSource = new BindingSource();
            _dishesBindingSource = new BindingSource();

            _view.AddNewEvent += AddNewEvent;
            _view.SaveEvent += SaveEvent;
            _view.CancelEvent += CancelEvent;

            _view.SetDishRestaurantListBindingSource(_dishRestaurantBindingSource);
            _view.SetRestaurantListBindingSource(_restaurantBindingSource);
            _view.SetDishListBindingSource(_dishesBindingSource);
            _view.SetRestaurantSelectList(LoadActiveRestaurants());
            LoadAllBindingSource();
            _view.Show();
        }

        #region Event handler methods

        private void AddNewEvent(object sender, EventArgs e)
        {
            _view.IsSuccessful = true;
            _view.Message = string.Empty;
            if (_restaurantRepository.IsEmpty())
            {
                _view.IsSuccessful = false;
                _view.Message += "- La lista de 'Restaurantes' debe contener al menos un elemento registrado y activo.\n";
            }

            if (_dishRepository.IsEmpty())
            {
                _view.IsSuccessful = false;
                _view.Message += "- La lista de 'Platos' debe contener al menos un elemento registrado.\n";
            }
        }

        private void SaveEvent(object sender, EventArgs e)
        {
            try
            {
                var model = new DishRestaurant();
                model.RestaurantId = _view.RestaurantId;
                model.RegistrationDate = DateTime.UtcNow;
                int quantityDish = _view.SelectedDishesList.Count();

                if (quantityDish > 10)
                    throw new Exception(message: $"No se ha podido realizar la asignación. La cantidad de platos seleccionados superan el límite permitido. (Límite: 10, Seleccionados: {quantityDish})");

                var restaurant = _restaurantRepository.GetById(model.RestaurantId);
                var dishRestaurantList = _dishRestaurantRepository.GetAll().Where(x => x.IdRestaurante == model.RestaurantId);
                if (dishRestaurantList.Count() >= 10)
                    throw new Exception(message: $"No se ha podido realizar la asignación. El Restaurante {restaurant?.Nombre?.Trim()} ha alcanzado el límite permitido.");

                foreach (var dish in _view.SelectedDishesList)
                {
                    if (!dishRestaurantList.Any(x => x.IdPlato == dish.Id))
                    {
                        var currentDish = model.ConvertToDB();
                        currentDish.IdAsignacion = _dishRestaurantRepository.GetNewIdValue();
                        currentDish.IdPlato = dish.Id;
                        ModelDataValidation.Validate(currentDish);

                        bool isSuccessful = _dishRestaurantRepository.Add(currentDish);
                        if (!isSuccessful)
                            throw new Exception(message: Messages.BadRequest.GetDisplayName());
                    }
                }

                _view.Message = Messages.Success.GetDisplayName();
                _view.IsSuccessful = true;
                LoadAllBindingSource();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void CancelEvent(object sender, EventArgs e) => CleanViewFields();

        #endregion Event handler methods

        #region Methods

        private ArrayList LoadActiveRestaurants()
        {
            ArrayList activeRestaurantList = new ArrayList();
            if (!_restaurantRepository.IsEmpty())
            {
                var restaurantList = _restaurantRepository.GetAll();
                foreach (var restaurant in restaurantList.Where(x => x.Estado))
                {
                    activeRestaurantList.Add(new
                    {
                        Id = restaurant.IdRestaurante.ToString(),
                        Name = restaurant.Nombre.Trim()
                    });
                }
            }
            else
                activeRestaurantList.Add(new { Id = string.Empty, Description = Messages.DataEmpty.GetDisplayName() });
            return activeRestaurantList;
        }

        private void LoadAllBindingSource()
        {
            #region Load DishRestaurants

            var dishRestaurantViewModel_List = new List<DishRestaurantViewModel>();
            var dishRestaurantList = _dishRestaurantRepository.GetAll();
            dishRestaurantList.ToImmutableList().ForEach(x => dishRestaurantViewModel_List.Add(DishRestaurantViewModel.ConvertToViewModel(x)));
            _dishRestaurantBindingSource.DataSource = dishRestaurantViewModel_List;

            #endregion Load DishRestaurants

            #region Load Restaurants

            var restaurantViewModel_List = new List<RestaurantViewModel>();
            var restaurantList = _restaurantRepository.GetAll().Where(x => x.Estado);
            restaurantList.ToImmutableList().ForEach(x => restaurantViewModel_List.Add(RestaurantViewModel.ConvertToViewModel(x)));
            _restaurantBindingSource.DataSource = restaurantViewModel_List;

            #endregion Load Restaurants

            #region Load Dishes

            var dishViewModel_List = new List<DishViewModel>();
            var dishList = _dishRepository.GetAll();
            dishList.ToImmutableList().ForEach(x => dishViewModel_List.Add(DishViewModel.ConvertToViewModel(x)));
            _dishesBindingSource.DataSource = dishViewModel_List;

            #endregion Load Dishes
        }

        private void CleanViewFields() => _view.SelectedDishesList.Clear();

        #endregion Methods
    }
}