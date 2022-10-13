using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ModuloGestorInventarios.Entradas.View
{
    interface IEntradasView
    {
        //Metodos
        void setEntradasBindingSource(BindingSource entradasList);
        void MostrarMsj(string message, string caption, MessageBoxButtons buttons);
    }
}
