using P1_JerryHurtado.Server.Models.ViewModels;
using P1_JerryHurtado.Server.Views.Interfaces;
using P1_JerryHurtado.Server.Views.Utilities;
using System.Collections;

namespace P1_JerryHurtado.Server.Views
{
    public partial class DishRestaurantView : Form, IDishRestaurantView
    {
        private string _message;
        private bool _isSuccessful;
        private string _title;

        public DishRestaurantView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlDishRestaurant.TabPages.Remove(tabPageDishRestaurantAddNew);
        }

        #region Properties

        public int RestaurantId { get => Convert.ToInt32(comboBoxRestaurant.SelectedValue); set => RestaurantId = value; }

        public DateTime DishRestaurantRegistrationDate { get => DateTime.UtcNow; set => DishRestaurantRegistrationDate = value; }
        public string TitleForDetailPage { get => _title; set => _title = value; }
        public List<DishViewModel> SelectedDishesList { get => dataGridViewDishes?.Rows?.Cast<DataGridViewRow>()?.Where(x => x.Selected)?.Select(x => (DishViewModel)x?.DataBoundItem)?.ToList(); set => SelectedDishesList = value; } 
        public bool IsSuccessful { get => _isSuccessful; set => _isSuccessful = value; }
        public string Message { get => _message; set => _message = value; }

        #endregion Properties

        #region Events

        public event EventHandler AddNewEvent;

        public event EventHandler SaveEvent;

        public event EventHandler CancelEvent;

        #endregion Events

        #region Methods

        private void AssociateAndRaiseViewEvents()
        {
            btnAddNewDishRestaurant.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                    Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
                else
                {
                    tabControlDishRestaurant.TabPages.Remove(tabPageDishRestaurantList);
                    tabControlDishRestaurant.TabPages.Add(tabPageDishRestaurantAddNew);
                    comboBoxRestaurant.SelectedIndex = 0;
                }
            };

            btnSaveDishRestaurant.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
                if (IsSuccessful)
                {
                    var result = MessageBox.Show("¿Quiere asignar más platos?", "Asignación de platos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                        SelectedDishesList.Clear();
                    else
                    {
                        tabControlDishRestaurant.TabPages.Remove(tabPageDishRestaurantAddNew);
                        tabControlDishRestaurant.TabPages.Add(tabPageDishRestaurantList);
                    }
                }
            };

            btnCancelDishRestaurant.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlDishRestaurant.TabPages.Remove(tabPageDishRestaurantAddNew);
                tabControlDishRestaurant.TabPages.Add(tabPageDishRestaurantList);
                comboBoxRestaurant.SelectedIndex = 0;
            };
        }

        #region Data load

        /// <summary>
        /// Carga el datagrid de platos.
        /// </summary>
        /// <param name="dishList">Listado de platos.</param>
        public void SetDishListBindingSource(BindingSource dishList) => dataGridViewDishes.DataSource = dishList;

        /// <summary>
        /// Carga el datagrid de platos por restaurantes.
        /// </summary>
        /// <param name="dishRestaurantList">Listado de platos asignados a restaurante.</param>
        public void SetDishRestaurantListBindingSource(BindingSource dishRestaurantList) => dataGridViewDishRestaurant.DataSource = dishRestaurantList;

        /// <summary>
        /// Carga el datagrid de restaurantes.
        /// </summary>
        /// <param name="restaurantList">Listado de restaurantes activos.</param>
        public void SetRestaurantListBindingSource(BindingSource restaurantList) => dataGridViewActiveRestaurants.DataSource = restaurantList;

        /// <summary>
        /// Carga el combobox de restaurantes.
        /// </summary>
        /// <param name="restaurants">Listado de restaurantes activos.</param>
        public void SetRestaurantSelectList(ArrayList restaurants)
        {
            comboBoxRestaurant.DataSource = restaurants;
            comboBoxRestaurant.ValueMember = "Id";
            comboBoxRestaurant.DisplayMember = "Name";
        }

        #endregion Data load

        public static DishRestaurantView GetInstance(Panel parentContainer)
        {
            var instance = new DishRestaurantView();
            instance.TopLevel = false;
            instance.FormBorderStyle = FormBorderStyle.None;
            instance.Dock = DockStyle.Fill;
            parentContainer.Controls.Clear();
            parentContainer.Controls.Add(instance);
            return instance;
        }

        #endregion Methods
    }
}