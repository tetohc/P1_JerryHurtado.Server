using P1_JerryHurtado.Server._Utilities;
using P1_JerryHurtado.Server.Models.Enum;
using P1_JerryHurtado.Server.Views.Interfaces;
using P1_JerryHurtado.Server.Views.Utilities;

namespace P1_JerryHurtado.Server.Views
{
    public partial class RestaurantView : Form, IRestaurantView
    {
        private string _message;
        private bool _isSuccessful;

        public RestaurantView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            LoadStatusRestaurant();
            tabControlRestaurant.TabPages.Remove(tabPageRestaurantAddNew);
        }

        #region Properties

        public string RestaurantName { get => textBoxName.Text; set => textBoxName.Text = value; }
        public string RestaurantAddress { get => textBoxAddress.Text; set => textBoxAddress.Text = value; }
        public bool RestaurantStatus { get => (int)comboBoxStatus.SelectedValue == (int)Status.Active ? true : false; set => RestaurantStatus = value; }
        public string RestaurantTelephone { get => maskedTextBoxPhone.Text == "    -  -" ? string.Empty : maskedTextBoxPhone.Text; set => maskedTextBoxPhone.Text = value; }
        public bool IsSuccessful { get => _isSuccessful; set => _isSuccessful = value; }
        public string Message { get => _message; set => _message = value; }

        #endregion Properties

        #region Events

        public event EventHandler AddNewEvent;

        public event EventHandler SaveEvent;

        public event EventHandler CancelEvent;

        #endregion Events

        #region Methods

        public void SetRestaurantListBindingSource(BindingSource restaurantList) => dataGridViewRestaurant.DataSource = restaurantList;

        private void AssociateAndRaiseViewEvents()
        {
            btnAddNewRestaurant.Click += delegate
            {
                tabControlRestaurant.TabPages.Remove(tabPageRestaurantList);
                tabControlRestaurant.TabPages.Add(tabPageRestaurantAddNew);
                comboBoxStatus.SelectedIndex = 0;
            };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControlRestaurant.TabPages.Remove(tabPageRestaurantAddNew);
                    tabControlRestaurant.TabPages.Add(tabPageRestaurantList);
                }
                Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlRestaurant.TabPages.Remove(tabPageRestaurantAddNew);
                tabControlRestaurant.TabPages.Add(tabPageRestaurantList);
                comboBoxStatus.SelectedIndex = 0;
            };
        }

        private void LoadStatusRestaurant()
        {
            comboBoxStatus.DataSource = typeof(Status).GetSelectList();
            comboBoxStatus.ValueMember = "EnumValue";
            comboBoxStatus.DisplayMember = "EnumDescription";
        }

        public static RestaurantView GetInstance(Panel parentContainer)
        {
            var instance = new RestaurantView();
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