using ModuloGestorInventarios.Login._Repositories;
using ModuloGestorInventarios.Login.Presenters;
using ModuloGestorInventarios.Views;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ModuloGestorInventarios
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string ConnnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            LoginView iloginView = new LoginView();
            LoginRepository ilogin = new LoginRepository(ConnnectionString);
            LoginPresenter loginPresenter = new LoginPresenter(iloginView, ilogin, ConnnectionString);
            Application.Run((Form)iloginView);
        }
    }
}
