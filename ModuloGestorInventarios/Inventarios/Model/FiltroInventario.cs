using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloGestorInventarios.Inventarios.Model
{
    public class FiltroInventario
    {
        private int idFiltro;

        private string filtroNombre;

        public int IdFiltro { get => idFiltro; set => idFiltro = value; }
        public string FiltroNombre { get => filtroNombre; set => filtroNombre = value; }
    }
}
