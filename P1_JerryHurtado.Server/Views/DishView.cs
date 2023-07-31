using P1_JerryHurtado.Server.Views.Interfaces;
using P1_JerryHurtado.Server.Views.Utilities;
using System.Collections;

namespace P1_JerryHurtado.Server.Views
{
    public partial class DishView : Form, IDishView
    {
        private string _message;
        private bool _isSuccessful;

        public DishView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlDish.TabPages.Remove(tabPageDishAddNew);
        }

        #region Properties

        public string DishName { get => textBoxName.Text; set => textBoxName.Text = value; }
        public string DishPrice { get => maskedTextBoxPrice.Text == "" ? "-1" : maskedTextBoxPrice.Text; set => maskedTextBoxPrice.Text = value; }
        public int CategoryId { get => Convert.ToInt32(comboBoxCategory?.SelectedValue); set => CategoryId = value; }
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
            btnAddNewDish.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                    Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
                else
                {
                    tabControlDish.TabPages.Remove(tabPageDishList);
                    tabControlDish.TabPages.Add(tabPageDishAddNew);
                    comboBoxCategory.SelectedIndex = 0;
                }
            };

            btnSaveDish.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControlDish.TabPages.Remove(tabPageDishAddNew);
                    tabControlDish.TabPages.Add(tabPageDishList);
                }
                Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
            };

            btnCancelDish.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlDish.TabPages.Remove(tabPageDishAddNew);
                tabControlDish.TabPages.Add(tabPageDishList);
                comboBoxCategory.SelectedIndex = 0;
            };
        }

        public void SetDishListBindingSource(BindingSource dishList) => dataGridViewDish.DataSource = dishList;

        public void SetDishCategorySelectList(ArrayList dishesCategories)
        {
            comboBoxCategory.DataSource = dishesCategories;
            comboBoxCategory.ValueMember = "Id";
            comboBoxCategory.DisplayMember = "Description";
        }

        public static DishView GetInstance(Panel parentContainer)
        {
            var instance = new DishView();
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