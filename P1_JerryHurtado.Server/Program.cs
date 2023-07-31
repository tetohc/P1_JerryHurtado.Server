using P1_JerryHurtado.Server._Repository.ContextDB;
using P1_JerryHurtado.Server.Presenters;
using P1_JerryHurtado.Server.Views;
using P1_JerryHurtado.Server.Views.Interfaces;

namespace P1_JerryHurtado.Server
{
    /*
     * Jerry Alonso Hurtado Castillo
     * Proyecto 1 - 00830 Programación Avanzada
     */

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            RestUnedContext dbContext = new RestUnedContext();
            IMainView view = new MainView();
            new MainPresenter(view, dbContext);
            Application.Run((Form)view);
        }
    }
}