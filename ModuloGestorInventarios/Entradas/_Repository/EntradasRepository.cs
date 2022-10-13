using ModuloGestorInventarios._Repositories;
using ModuloGestorInventarios.Entradas.Model;

namespace ModuloGestorInventarios.Entradas._Repository
{
    class EntradasRepository : Connection, IEntradas
    {
        public EntradasRepository(string Cadena)
        {
            this.ConnnectionString = Cadena;
        }
    }
}
