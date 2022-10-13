using ModuloGestorInventarios.Login.Models;
using ModuloGestorInventarios.Login.Views;
using ModuloGestorInventarios.MainContainer.Presenter;
using ModuloGestorInventarios.MainContainer.View;
using System;
using System.Windows.Forms;

namespace ModuloGestorInventarios.Login.Presenters
{
    class LoginPresenter
    {
        private ILoginView iloginView;
        private ILogin ilogin;
        private readonly string ConnnectionString;
        public LoginPresenter(ILoginView iloginView, ILogin ilogin, string ConnnectionString)
        {
            this.iloginView = iloginView;
            this.ilogin = ilogin;
            this.ConnnectionString = ConnnectionString;
            iloginView.ValidarDatosLogin += ValidarLogin;
        }

        private void ValidarLogin(object sender, EventArgs e)
        {
           
            if (ilogin.Login(iloginView.User, iloginView.Clave))
            {
                IMainContainerView Main = new MainContainerView();
                MainContainerPresenter mainContainerPresenter = new MainContainerPresenter(Main,ConnnectionString,iloginView);
                iloginView.DatosCorrectos((Form)Main);
            }
            else
            {
                iloginView.DatosIncorrectos();
            }
            
        }
    }
}
