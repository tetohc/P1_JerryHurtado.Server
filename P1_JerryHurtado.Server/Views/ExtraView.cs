using P1_JerryHurtado.Server._Utilities;
using P1_JerryHurtado.Server.Models.Enum;
using P1_JerryHurtado.Server.Views.Interfaces;
using P1_JerryHurtado.Server.Views.Utilities;
using System.Collections;

namespace P1_JerryHurtado.Server.Views
{
    public partial class ExtraView : Form, IExtraView
    {
        private string _message;
        private bool _isSuccessful;

        public ExtraView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            LoadStatusExtras();
            tabControlExtras.TabPages.Remove(tabPageAddNewExtras);
        }

        #region Properties

        public string ExtraDescription { get => textBoxDescription.Text; set => textBoxDescription.Text = value; }
        public string ExtraPrice { get => maskedTextBoxPrice.Text == "" ? "-1" : maskedTextBoxPrice.Text; set => maskedTextBoxPrice.Text = value; }
        public int ExtraCategoryId { get => Convert.ToInt32(comboBoxCategory?.SelectedValue); set => ExtraCategoryId = value; }
        public bool ExtrasStatus { get => (int)comboBoxStatus.SelectedValue == (int)Status.Active ? true : false; set => ExtrasStatus = value; }
        public bool IsSuccessful { get => _isSuccessful; set => _isSuccessful = value; }
        public string Message { get => _message; set => _message = value; }

        #endregion Properties

        #region Events

        public event EventHandler AddNewEvent;

        public event EventHandler SaveEvent;

        public event EventHandler CancelEvent;

        #endregion Events

        #region Methods

        public void SetDishCategorySelectList(ArrayList dishesCategories)
        {
            comboBoxCategory.DataSource = dishesCategories;
            comboBoxCategory.ValueMember = "Id";
            comboBoxCategory.DisplayMember = "Description";
        }

        public void SetExtrasListBindingSource(BindingSource extrasList) => dataGridViewExtras.DataSource = extrasList;

        private void AssociateAndRaiseViewEvents()
        {
            btnAddNewExtras.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                    Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
                else
                {
                    tabControlExtras.TabPages.Remove(tabPageExtasList);
                    tabControlExtras.TabPages.Add(tabPageAddNewExtras);
                    comboBoxCategory.SelectedIndex = 0;
                    comboBoxStatus.SelectedIndex = 0;
                }
            };

            btnSaveExtras.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControlExtras.TabPages.Remove(tabPageAddNewExtras);
                    tabControlExtras.TabPages.Add(tabPageExtasList);
                }
                Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
            };

            btnCancelExtras.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlExtras.TabPages.Remove(tabPageAddNewExtras);
                tabControlExtras.TabPages.Add(tabPageExtasList);
                comboBoxCategory.SelectedIndex = 0;
                comboBoxStatus.SelectedIndex = 0;
            };
        }

        private void LoadStatusExtras()
        {
            comboBoxStatus.DataSource = typeof(Status).GetSelectList();
            comboBoxStatus.ValueMember = "EnumValue";
            comboBoxStatus.DisplayMember = "EnumDescription";
        }

        public static ExtraView GetInstance(Panel parentContainer)
        {
            var instance = new ExtraView();
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