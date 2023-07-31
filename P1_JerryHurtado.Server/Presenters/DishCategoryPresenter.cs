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
    public class DishCategoryPresenter
    {
        private IDishCategoryView _view;
        private IRepository<CategoriaPlato> _repository;
        private BindingSource _dishCategoriesBindingSource;

        public DishCategoryPresenter(IDishCategoryView view, RestUnedContext dbContext)
        {
            _view = view;
            _repository = new DishCategoryRepository(dbContext);
            _dishCategoriesBindingSource = new BindingSource();

            _view.SaveEvent += SaveDishCategory;
            _view.CancelEvent += CancelAction;
            _view.SetDishCategoryListBindingSource(_dishCategoriesBindingSource);
            LoadAllDishCategories();
            _view.Show();
        }

        #region Event handler methods

        private void SaveDishCategory(object sender, EventArgs e)
        {
            try
            {
                var model = new DishCategory();
                model.Id = _repository.GetNewIdValue();
                model.Description = _view.DishCategoryDescription?.Trim();
                model.Status = _view.DishCategoryStatus;

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
                LoadAllDishCategories();
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

        private void LoadAllDishCategories()
        {
            var dishCategoryViewModel_List = new List<DishCategoryViewModel>();
            var dishCategoryList = _repository.GetAll();
            dishCategoryList.ToImmutableList().ForEach(x => dishCategoryViewModel_List.Add(DishCategoryViewModel.ConvertToViewModel(x)));
            _dishCategoriesBindingSource.DataSource = dishCategoryViewModel_List;
        }

        private void CleanViewFields() => _view.DishCategoryDescription = string.Empty;

        #endregion Methods
    }
}