using P1_JerryHurtado.Server._Repository.ContextDB;
using P1_JerryHurtado.Server.Views;
using P1_JerryHurtado.Server.Views.Interfaces;

namespace P1_JerryHurtado.Server.Presenters
{
    /// <summary>
    /// Presentador de vista principal. Controla los accesos y llamadas a la demás vistas.
    /// </summary>
    public class MainPresenter
    {
        private IMainView _mainView;
        private readonly RestUnedContext _dbContext;

        public MainPresenter(IMainView mainView, RestUnedContext dbContext)
        {
            _mainView = mainView;
            _dbContext = dbContext;

            #region event subscription

            _mainView.ShowRestaurantView += ShowRestaurantView;
            _mainView.ShowDishCategoryView += ShowDishCategoryView;
            _mainView.ShowDishView += ShowDishView;
            _mainView.ShowCustomerView += ShowCustomerView;
            _mainView.ShowDishRestaurantView += ShowDishRestaurantView;
            _mainView.ShowExtraView += ShowExtraView;
            _mainView.ShowServerView += ShowServerView;
            _mainView.ShowMainView += ShowMainView;

            #endregion event subscription

            SetViewInMainPanel();
        }

        #region Event handler methods

        private void ShowRestaurantView(object sender, EventArgs e)
        {
            IRestaurantView view = RestaurantView.GetInstance(parentContainer: (Panel)_mainView.MainPanel);
            new RestaurantPresenter(view, _dbContext);
        }

        private void ShowDishCategoryView(object sender, EventArgs e)
        {
            IDishCategoryView view = DishCategoryView.GetInstance(parentContainer: (Panel)_mainView.MainPanel);
            new DishCategoryPresenter(view, _dbContext);
        }

        private void ShowDishView(object sender, EventArgs e)
        {
            IDishView view = DishView.GetInstance(parentContainer: (Panel)_mainView.MainPanel);
            new DishPresenter(view, _dbContext);
        }

        private void ShowCustomerView(object sender, EventArgs e)
        {
            ICustomerView view = CustomerView.GetInstance(parentContainer: (Panel)_mainView.MainPanel);
            new CustomerPresenter(view, _dbContext);
        }

        private void ShowDishRestaurantView(object sender, EventArgs e)
        {
            IDishRestaurantView view = DishRestaurantView.GetInstance(parentContainer: (Panel)_mainView.MainPanel);
            new DishRestaurantPresenter(view, _dbContext);
        }

        private void ShowExtraView(object sender, EventArgs e)
        {
            IExtraView view = ExtraView.GetInstance(parentContainer: (Panel)_mainView.MainPanel);
            new ExtraPresenter(view, _dbContext);
        }

        private void ShowServerView(object sender, EventArgs e)
        {
            IServerView view = ServerView.GetInstance(parentContainer: (Panel)_mainView.MainPanel);
            new ServerPresenter(view, _dbContext);
        }

        private void ShowMainView(object sender, EventArgs e) => SetViewInMainPanel();

        #endregion Event handler methods

        #region Methods

        private void SetViewInMainPanel() => UserControlMainView.GetInstance(parentContainer: (Panel)_mainView.MainPanel);

        #endregion Methods
    }
}