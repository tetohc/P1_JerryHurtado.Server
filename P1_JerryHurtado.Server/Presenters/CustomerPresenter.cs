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
    /// <summary>
    /// Esta clase es el puente que comunica la vista y la capa de persistencia del modelo Cliente
    /// </summary>
    public class CustomerPresenter
    {
        private ICustomerView _view;
        private ICustomerRepository<Cliente> _repository;
        private BindingSource _customersBindingSource;

        public CustomerPresenter(ICustomerView view, RestUnedContext dbContext)
        {
            _view = view;
            _repository = new CustomerRepository(dbContext);
            _customersBindingSource = new BindingSource();

            _view.SaveEvent += SaveEvent;
            _view.CancelEvent += CancelEvent;

            _view.SetCustomerListBindingSource(_customersBindingSource);
            LoadAllCustomers();
            _view.Show();
        }

        #region Event handler methods

        private void SaveEvent(object sender, EventArgs e)
        {
            try
            {
                var model = new Customer();
                model.Id = _view.CustomerId?.Trim();
                model.Name = _view.CustomerName?.Trim();
                model.FirstSurname = _view.CustomerFirstSurname?.Trim();
                model.LastSurname = _view.CustomerLastSurname?.Trim();
                model.BirthDate = _view.CustomerBirthDate;
                model.Gender = _view.CustomerGender;

                #region Validations

                ModelDataValidation.Validate(model);
                var exist = _repository.GetById(model.Id);
                if (exist != null)
                    throw new Exception(message: Messages.DuplicateData.GetDisplayName());

                bool isSuccessful = _repository.Add(model.ConvetToDB());
                if (!isSuccessful)
                    throw new Exception(message: Messages.BadRequest.GetDisplayName());

                #endregion Validations

                _view.Message = Messages.Success.GetDisplayName();
                _view.IsSuccessful = true;
                LoadAllCustomers();
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

        private void LoadAllCustomers()
        {
            var customers = new List<CustomerViewModel>();
            var list = _repository.GetAll();
            list.ToImmutableList().ForEach(customer => customers.Add(CustomerViewModel.ConvertToViewModel(customer)));
            _customersBindingSource.DataSource = customers;
        }

        private void CleanViewFields()
        {
            _view.CustomerId = string.Empty;
            _view.CustomerName = string.Empty;
            _view.CustomerFirstSurname = string.Empty;
            _view.CustomerLastSurname = string.Empty;
        }

        #endregion Methods
    }
}