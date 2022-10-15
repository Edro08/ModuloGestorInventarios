using ModuloGestorInventarios._Repositories;
using ModuloGestorInventarios.Salidas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloGestorInventarios.Salidas._Repository
{
    class SalidasRepository: Connection, ISalidas
    {
        public SalidasRepository(string Cadena)
        {
            this.ConnnectionString = Cadena;
        }
    }
}
