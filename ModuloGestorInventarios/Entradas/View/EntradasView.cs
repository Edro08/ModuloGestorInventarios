using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloGestorInventarios.Entradas.View
{
    public partial class EntradasView : Form, IEntradasView
    {
        public EntradasView()
        {
            InitializeComponent();
        }

        public void MostrarMsj(string message, string caption, MessageBoxButtons buttons)
        {
            throw new NotImplementedException();
        }

        public void setEntradasBindingSource(BindingSource entradasList)
        {
            throw new NotImplementedException();
        }
    }
}
