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
        event EventHandler AbrirInventario;

        //Metodos
        void MostrarInventario(Form inventario);
    }
}
