using P1_JerryHurtado.Server._Repository;
using P1_JerryHurtado.Server._Repository.ContextDB;
using P1_JerryHurtado.Server._Repository.Interfaces;
using P1_JerryHurtado.Server._Utilities;
using P1_JerryHurtado.Server.Models.Enum;
using P1_JerryHurtado.Server.Models.ModelsDB;
using P1_JerryHurtado.Server.Models.ViewModels;
using P1_JerryHurtado.Server.Presenters.Utilities;
using P1_JerryHurtado.Server.Views.Interfaces;
using System.Collections;
using System.Collections.Immutable;

namespace P1_JerryHurtado.Server.Presenters
{
    public class ExtraPresenter
    {
        private IExtraView _view;
        private IRepository<Models.ModelsDB.Extra> _extrasRepository;
        private IRepository<CategoriaPlato> _dishCategoryRepository;
        private BindingSource _extrasBindingSource;

        public ExtraPresenter(IExtraView view, RestUnedContext dbContext)
        {
            _view = view;
            _extrasRepository = new ExtraRepository(dbContext);
            _dishCategoryRepository = new DishCategoryRepository(dbContext);
            _extrasBindingSource = new BindingSource();

            _view.AddNewEvent += AddNewEvent;
            _view.SaveEvent += SaveEvent;
            _view.CancelEvent += CancelEvent;

            _view.SetExtrasListBindingSource(_extrasBindingSource);
            _view.SetDishCategorySelectList(LoadAllDishesCategories());
            LoadAllExtras();
            _view.Show();
        }

        #region Event handler methods

        private void AddNewEvent(object sender, EventArgs e)
        {
            _view.IsSuccessful = true;
            _view.Message = string.Empty;
            if (_dishCategoryRepository.IsEmpty())
            {
                _view.IsSuccessful = false;
                _view.Message = "- Para agregar Extras, la lista de 'Categoría de platos' debe contener al menos un elemento registrado y activo.";
            }
        }

        private void SaveEvent(object sender, EventArgs e)
        {
            try
            {
                var model = new Models.Entities.Extra();
                model.Id = _extrasRepository.GetNewIdValue();
                model.CategoryId = _view.ExtraCategoryId;
                model.Description = _view?.ExtraDescription?.Trim();
                model.Status = _view.ExtrasStatus;
                model.Price = Convert.ToInt32(_view.ExtraPrice);

                #region Validations

                ModelDataValidation.Validate(model);
                var exist = _extrasRepository.GetById(model.Id);
                if (exist != null)
                    throw new Exception(message: Messages.DuplicateData.GetDisplayName());

                bool isSuccessful = _extrasRepository.Add(model.ConvertToDB());
                if (!isSuccessful)
                    throw new Exception(message: Messages.BadRequest.GetDisplayName());

                #endregion Validations

                _view.Message = Messages.Success.GetDisplayName();
                _view.IsSuccessful = true;
                LoadAllExtras();
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

        /// <summary>
        /// Retorna el listado de categorías de platos activos
        /// </summary>
        /// <returns>ArrayList: Listado de categoría de platos (activos).</returns>
        private ArrayList LoadAllDishesCategories()
        {
            ArrayList categories = new ArrayList();
            if (!_dishCategoryRepository.IsEmpty())
            {
                var dishCategoryList = _dishCategoryRepository.GetAll();
                foreach (var item in dishCategoryList.Where(x => x.Estado))
                {
                    categories.Add(new
                    {
                        Id = item.IdCategoria.ToString(),
                        Description = item.Descripcion.Trim()
                    }); ;
                }
            }
            else
                categories.Add(new { Id = string.Empty, Description = Messages.DataEmpty.GetDisplayName() });
            return categories;
        }

        private void LoadAllExtras()
        {
            var extrasViewModel_List = new List<ExtraViewModel>();
            var extras = _extrasRepository.GetAll();
            extras.ToImmutableList().ForEach(x => extrasViewModel_List.Add(ExtraViewModel.ConvertToViewModel(x)));
            _extrasBindingSource.DataSource = extrasViewModel_List;
        }

        private void CleanViewFields()
        {
            _view.ExtraDescription = string.Empty;
            _view.ExtraPrice = string.Empty;
        }

        #endregion Methods
    }
}