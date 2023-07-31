using P1_JerryHurtado.Server._Utilities;
using P1_JerryHurtado.Server.Models.Enum;
using P1_JerryHurtado.Server.Views.Interfaces;
using P1_JerryHurtado.Server.Views.Utilities;

namespace P1_JerryHurtado.Server.Views
{
    public partial class DishCategoryView : Form, IDishCategoryView
    {
        private string _message;
        private bool _isSuccessful;

        public DishCategoryView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            LoadStatusDishCategory();
            tabControlDishCategory.TabPages.Remove(tabPageDishCategoryAddNew);
        }

        #region Properties

        public string DishCategoryDescription { get => textBoxDescription.Text; set => textBoxDescription.Text = value; }
        public bool DishCategoryStatus { get => (int)comboBoxStatus.SelectedValue == (int)Status.Active ? true : false; set => DishCategoryStatus = value; }
        public bool IsSuccessful { get => _isSuccessful; set => _isSuccessful = value; }
        public string Message { get => _message; set => _message = value; }

        #endregion Properties

        #region Events

        public event EventHandler AddNewEvent;

        public event EventHandler SaveEvent;

        public event EventHandler CancelEvent;

        #endregion Events

        #region Methods

        public void SetDishCategoryListBindingSource(BindingSource dishCategoryList) => dataGridViewDishCategory.DataSource = dishCategoryList;

        private void AssociateAndRaiseViewEvents()
        {
            btnAddNewDishCategory.Click += delegate
            {
                tabControlDishCategory.TabPages.Remove(tabPageDishCategoryList);
                tabControlDishCategory.TabPages.Add(tabPageDishCategoryAddNew);
                comboBoxStatus.SelectedIndex = 0;
            };

            btnSaveDishCategory.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControlDishCategory.TabPages.Remove(tabPageDishCategoryAddNew);
                    tabControlDishCategory.TabPages.Add(tabPageDishCategoryList);
                }
                Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
            };

            btnCancelDishCategory.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlDishCategory.TabPages.Remove(tabPageDishCategoryAddNew);
                tabControlDishCategory.TabPages.Add(tabPageDishCategoryList);
                comboBoxStatus.SelectedIndex = 0;
            };
        }

        private void LoadStatusDishCategory()
        {
            comboBoxStatus.DataSource = typeof(Status).GetSelectList();
            comboBoxStatus.ValueMember = "EnumValue";
            comboBoxStatus.DisplayMember = "EnumDescription";
        }

        public static DishCategoryView GetInstance(Panel parentContainer)
        {
            var instance = new DishCategoryView();
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