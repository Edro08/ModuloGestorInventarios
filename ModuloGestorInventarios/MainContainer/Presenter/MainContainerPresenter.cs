using ModuloGestorInventarios.Inventarios._Repository;
using ModuloGestorInventarios.Inventarios.Model;
using ModuloGestorInventarios.Inventarios.Presenter;
using ModuloGestorInventarios.Inventarios.View;
using ModuloGestorInventarios.Login.Views;
using ModuloGestorInventarios.MainContainer.View;
using System;
using System.Windows.Forms;

namespace ModuloGestorInventarios.MainContainer.Presenter
{
    class MainContainerPresenter
    {
        private IMainContainerView iMainContainerView;
        private ILoginView iloginView;
        private readonly string ConnnectionString;

        public MainContainerPresenter(IMainContainerView iMainContainerView, string ConnnectionString, ILoginView iloginView)
        {
            this.iMainContainerView = iMainContainerView;
            this.iloginView = iloginView;
            this.ConnnectionString = ConnnectionString;
            iMainContainerView.AbrirInventario += AbrirInventario;
        }

        private void AbrirInventario(object sender, EventArgs e)
        {
            IInventarioView iInventarioView = new InventarioView();
            IInventario inventario = new InventarioRepository(ConnnectionString);
            InventarioPresenter inventarioPresenter = new InventarioPresenter(iInventarioView, inventario, ConnnectionString);
            iMainContainerView.MostrarInventario((Form) iInventarioView);
        }
    }
}
