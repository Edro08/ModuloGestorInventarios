using ModuloGestorInventarios.Inventarios.View;
using System;
using System.Windows.Forms;

namespace ModuloGestorInventarios.MainContainer.View
{
    interface IMainContainerView
    {
        //Metodos
        void MostrarMsj(string message, string caption, MessageBoxButtons buttons);

        //Eventos
        event EventHandler AbrirDashBoard;
        event EventHandler AbrirInventario;
        event EventHandler AbrirEntradas;
        event EventHandler AbrirSalidas;
        event EventHandler AbrirProveedores;
        event EventHandler AbrirReportes;
        event EventHandler AbrirMantenimientos;

        //Metodos
        void MostrarInventario(Form inventario);
        void MostrarEntradas(Form entradas);
        void MostrarSalidas(Form salidas);
        void MostrarProveedores(Form proveedores);
        void MostrarReportes(Form reportes);
        void MostrarMantenimientos();
        void MostrarDashBoard();
    }
}
