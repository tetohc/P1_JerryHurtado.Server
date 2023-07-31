using P1_JerryHurtado.Server._Utilities;
using P1_JerryHurtado.Server.Models.Enum;
using P1_JerryHurtado.Server.Views.Interfaces;
using P1_JerryHurtado.Server.Views.Utilities;

namespace P1_JerryHurtado.Server.Views
{
    public partial class CustomerView : Form, ICustomerView
    {
        private string _message;
        private bool _isSuccessful;

        public CustomerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            LoadCustomersGender();
            tabControlCustomer.TabPages.Remove(tabPageCustomerAddNew);
        }

        #region Properties

        public string CustomerId { get => textBoxClientId.Text; set => textBoxClientId.Text = value; }
        public string CustomerName { get => textBoxName.Text; set => textBoxName.Text = value; }
        public string CustomerFirstSurname { get => textBoxFirstSurname.Text; set => textBoxFirstSurname.Text = value; }
        public string CustomerLastSurname { get => textBoxLastSurname.Text; set => textBoxLastSurname.Text = value; }
        public DateTime CustomerBirthDate { get => dateTimePickerBirthDate.Value; set => dateTimePickerBirthDate.Value = DateTime.UtcNow; }
        public char CustomerGender { get => (int)comboBoxGender.SelectedValue == (int)Gender.Male ? 'M' : 'F'; set => CustomerGender = value; }
        public bool IsSuccessful { get => _isSuccessful; set => _isSuccessful = value; }
        public string Message { get => _message; set => _message = value; }

        #endregion Properties

        #region Events

        public event EventHandler AddNewEvent;

        public event EventHandler SaveEvent;

        public event EventHandler CancelEvent;

        #endregion Events

        #region Methods

        /// <summary>
        /// Asociación e invocación de eventos
        /// </summary>
        private void AssociateAndRaiseViewEvents()
        {
            btnAddNewCustomer.Click += delegate
            {
                tabControlCustomer.TabPages.Remove(tabPageCustomerList);
                tabControlCustomer.TabPages.Add(tabPageCustomerAddNew);
                comboBoxGender.SelectedIndex = 0;
            };

            btnSaveCustomer.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControlCustomer.TabPages.Remove(tabPageCustomerAddNew);
                    tabControlCustomer.TabPages.Add(tabPageCustomerList);
                }
                Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
            };

            btnCancelCustomer.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlCustomer.TabPages.Remove(tabPageCustomerAddNew);
                tabControlCustomer.TabPages.Add(tabPageCustomerList);
                comboBoxGender.SelectedIndex = 0;
            };
        }

        public void LoadCustomersGender()
        {
            comboBoxGender.DataSource = typeof(Gender).GetSelectList();
            comboBoxGender.ValueMember = "EnumValue";
            comboBoxGender.DisplayMember = "EnumDescription";
        }

        public void SetCustomerListBindingSource(BindingSource customerList) => dataGridViewCustomers.DataSource = customerList;

        /// <summary>
        /// Crea una instancia de la vista
        /// </summary>
        /// <param name="parentContainer">Contenedor padre</param>
        /// <returns></returns>
        public static CustomerView GetInstance(Panel parentContainer)
        {
            var instance = new CustomerView();
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