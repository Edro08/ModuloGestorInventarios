using ModuloGestorInventarios.Entradas.Model;
using ModuloGestorInventarios.Entradas.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModuloGestorInventarios.Entradas.Presenter
{
    class EntradasPresenter
    {
        private IEntradasView iEntradasView;
        private IEntradas iEntradas;
        private readonly string ConnnectionString;

        public EntradasPresenter(IEntradasView iEntradasView, IEntradas iEntradas, string ConnnectionString)
        {
            this.iEntradasView = iEntradasView;
            this.ConnnectionString = ConnnectionString;
            this.iEntradas = iEntradas;
        }
    }
}
