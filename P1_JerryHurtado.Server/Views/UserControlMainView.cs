namespace P1_JerryHurtado.Server.Views
{
    public partial class UserControlMainView : UserControl
    {
        public UserControlMainView()
        {
            InitializeComponent();
        }

        #region Methods

        /// <summary>
        /// Crea una instancia de la vista
        /// </summary>
        /// <param name="parentContainer">Contenedor padre</param>
        /// <returns></returns>
        public static UserControlMainView GetInstance(Panel parentContainer)
        {
            var instance = new UserControlMainView();
            instance.Dock = DockStyle.Fill;
            parentContainer.Controls.Clear();
            parentContainer.Controls.Add(instance);
            return instance;
        }

        #endregion Methods
    }
}