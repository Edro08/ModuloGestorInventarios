using ModuloGestorInventarios.Salidas.Model;
using ModuloGestorInventarios.Salidas.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloGestorInventarios.Salidas.Presenter
{
    class SalidasPresenter
    {
        private ISalidasView iSalidasView;
        private ISalidas iSalidas;
        private readonly string ConnnectionString;
        public SalidasPresenter(ISalidasView iSalidasView, ISalidas iSalidas, string ConnnectionString)
        {
            this.iSalidasView = iSalidasView;
            this.ConnnectionString = ConnnectionString;
            this.iSalidas = iSalidas;
        }
    }
}
