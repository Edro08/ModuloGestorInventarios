using ModuloGestorInventarios.Entradas._Repository;
using ModuloGestorInventarios.Entradas.Model;
using ModuloGestorInventarios.Entradas.View;
using ModuloGestorInventarios.Entradas.Presenter;
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
            iMainContainerView.AbrirEntradas += AbrirEntradas;
            iMainContainerView.AbrirSalidas += AbrirSalidas;
            iMainContainerView.AbrirProveedores += AbrirProveedores;
            iMainContainerView.AbrirReportes += AbrirReportes;
            iMainContainerView.AbrirMantenimientos += AbrirMantenimientos;
            iMainContainerView.AbrirDashBoard += AbrirDashBoard;
        }

        private void AbrirInventario(object sender, EventArgs e)
        {
            IInventarioView iInventarioView = new InventarioView();
            IInventario inventario = new InventarioRepository(ConnnectionString);
            InventarioPresenter inventarioPresenter = new InventarioPresenter(iInventarioView, inventario, ConnnectionString);
            iMainContainerView.MostrarInventario((Form) iInventarioView);
        }

        private void AbrirEntradas(object sender, EventArgs e)
        {
            IEntradasView iEntradasView = new EntradasView();
            IEntradas Entradas = new EntradasRepository(ConnnectionString);
            EntradasPresenter EntradasPresenter = new EntradasPresenter(iEntradasView, Entradas, ConnnectionString);
            iMainContainerView.MostrarEntradas((Form)iEntradasView);
        }

        private void AbrirSalidas(object sender, EventArgs e)
        {
            IEntradasView iEntradasView = new EntradasView();
            IEntradas Entradas = new EntradasRepository(ConnnectionString);
            EntradasPresenter EntradasPresenter = new EntradasPresenter(iEntradasView, Entradas, ConnnectionString);
            iMainContainerView.MostrarEntradas((Form)iEntradasView);
        }

        private void AbrirProveedores(object sender, EventArgs e)
        {
            IEntradasView iEntradasView = new EntradasView();
            IEntradas Entradas = new EntradasRepository(ConnnectionString);
            EntradasPresenter EntradasPresenter = new EntradasPresenter(iEntradasView, Entradas, ConnnectionString);
            iMainContainerView.MostrarEntradas((Form)iEntradasView);
        }

        private void AbrirReportes(object sender, EventArgs e)
        {
            IEntradasView iEntradasView = new EntradasView();
            IEntradas Entradas = new EntradasRepository(ConnnectionString);
            EntradasPresenter EntradasPresenter = new EntradasPresenter(iEntradasView, Entradas, ConnnectionString);
            iMainContainerView.MostrarEntradas((Form)iEntradasView);
        }

        private void AbrirMantenimientos(object sender, EventArgs e)
        {
            iMainContainerView.MostrarMantenimientos();
        }

        private void AbrirDashBoard(object sender, EventArgs e)
        {
            iMainContainerView.MostrarDashBoard();
        }
    }
}
