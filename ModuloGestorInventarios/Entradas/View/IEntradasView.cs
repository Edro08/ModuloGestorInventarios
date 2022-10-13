using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ModuloGestorInventarios.Entradas.View
{
    interface IEntradasView
    {
        //Metodos
        void setInventarioBindingSource(BindingSource inventarioList);
        void MostrarMsj(string message, string caption, MessageBoxButtons buttons);
    }
}
