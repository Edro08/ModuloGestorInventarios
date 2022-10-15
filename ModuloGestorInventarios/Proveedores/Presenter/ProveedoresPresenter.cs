using ModuloGestorInventarios.Proveedores.Model;
using ModuloGestorInventarios.Proveedores.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloGestorInventarios.Proveedores.Presenter
{
    class ProveedoresPresenter
    {
        private IProveedoresView iProveedoresView;
        private IProveedores iProveedores;
        private readonly string ConnnectionString;


        public ProveedoresPresenter(IProveedoresView iProveedoresView, IProveedores iProveedores, string ConnnectionString)
        {
            this.iProveedoresView = iProveedoresView;
            this.ConnnectionString = ConnnectionString;
            this.iProveedores = iProveedores;
        }
    }
}
