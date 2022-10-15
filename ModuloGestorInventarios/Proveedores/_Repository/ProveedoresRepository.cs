using ModuloGestorInventarios._Repositories;
using ModuloGestorInventarios.Proveedores.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloGestorInventarios.Proveedores._Repository
{
    class ProveedoresRepository: Connection, IProveedores
    {
        public ProveedoresRepository(string Cadena)
        {
            this.ConnnectionString = Cadena;
        }
    }
}
