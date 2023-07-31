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
using System.Collections.Immutable;

namespace P1_JerryHurtado.Server.Presenters
{
    public class RestaurantPresenter
    {
        private IRestaurantView _view;
        private IRepository<Restaurante> _repository;
        private BindingSource _restaurantsBindingSource;

        public RestaurantPresenter(IRestaurantView view, RestUnedContext dbContext)
        {
            _view = view;
            _repository = new RestaurantRepository(dbContext);
            _restaurantsBindingSource = new BindingSource();

            _view.SaveEvent += SaveRestaurant;
            _view.CancelEvent += CancelAction;
            _view.SetRestaurantListBindingSource(_restaurantsBindingSource);
            LoadAllRestaurantList();
            _view.Show();
        }

        #region Event handler methods

        private void SaveRestaurant(object sender, EventArgs e)
        {
            try
            {
                var model = new Restaurant();
                model.Id = _repository.GetNewIdValue();
                model.Name = _view.RestaurantName?.Trim();
                model.Address = _view.RestaurantAddress?.Trim();
                model.Status = _view.RestaurantStatus;
                model.Telephone = _view.RestaurantTelephone?.Trim();

                #region Validations

                ModelDataValidation.Validate(model);
                var exist = _repository.GetById(model.Id);
                if (exist != null)
                    throw new Exception(message: Messages.DuplicateData.GetDisplayName());

                bool isSuccessful = _repository.Add(model.ConvertToDB());
                if (!isSuccessful)
                    throw new Exception(message: Messages.BadRequest.GetDisplayName());

                #endregion Validations

                _view.Message = Messages.Success.GetDisplayName();
                _view.IsSuccessful = true;
                LoadAllRestaurantList();
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

        private void LoadAllRestaurantList()
        {
            var restaurantViewModelList = new List<RestaurantViewModel>();
            var list = _repository.GetAll();
            list.ToImmutableList().ForEach(restaurant => restaurantViewModelList.Add(RestaurantViewModel.ConvertToViewModel(restaurant)));
            _restaurantsBindingSource.DataSource = restaurantViewModelList;
        }

        private void CleanViewFields()
        {
            _view.RestaurantName = string.Empty;
            _view.RestaurantAddress = string.Empty;
            _view.RestaurantTelephone = string.Empty;
        }

        #endregion Methods
    }
}