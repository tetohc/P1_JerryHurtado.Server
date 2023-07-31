using P1_JerryHurtado.Server.Views.Interfaces;

namespace P1_JerryHurtado.Server.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        #region Properties

        public Panel MainPanel { get => mainPanel; set => mainPanel = value; }

        #endregion Properties

        #region Events

        public event EventHandler ShowRestaurantView;

        public event EventHandler ShowDishCategoryView;

        public event EventHandler ShowDishView;

        public event EventHandler ShowCustomerView;

        public event EventHandler ShowDishRestaurantView;

        public event EventHandler ShowExtraView;

        public event EventHandler ShowMainView;

        public event EventHandler ShowServerView;

        #endregion Events

        #region Methods

        /// <summary>
        /// Se realiza la asociación e invocación de eventos
        /// </summary>
        private void AssociateAndRaiseViewEvents()
        {
            btnHome.Click += delegate { ShowMainView?.Invoke(this, EventArgs.Empty); };
            btnRestaurant.Click += delegate { ShowRestaurantView?.Invoke(this, EventArgs.Empty); };
            btnDishCategory.Click += delegate { ShowDishCategoryView?.Invoke(this, EventArgs.Empty); };
            btnDish.Click += delegate { ShowDishView?.Invoke(this, EventArgs.Empty); };
            btnCustomer.Click += delegate { ShowCustomerView?.Invoke(this, EventArgs.Empty); };
            btnDishesRestaurant.Click += delegate { ShowDishRestaurantView?.Invoke(this, EventArgs.Empty); };
            btnExtras.Click += delegate { ShowExtraView?.Invoke(this, EventArgs.Empty); };
            btnServer.Click += delegate { ShowServerView?.Invoke(this, EventArgs.Empty); };
        }

        #endregion Methods
    }
}