using Supermarker_MVP._Repositories;
using Supermarker_MVP.Models;
using Supermarker_MVP.Views;
using Supermarker_MVP.Properties;
using Supermarker_MVP.Presenters;

namespace Supermarker_MVP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            IPayModeView view= new PayModeView();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter (view, repository);
            Application.Run((Form)view);
        }
    }
}