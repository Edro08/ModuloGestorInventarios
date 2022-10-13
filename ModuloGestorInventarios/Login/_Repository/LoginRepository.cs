using ModuloGestorInventarios.Login.Models;
using ModuloGestorInventarios._Repositories;
using System.Configuration;

namespace ModuloGestorInventarios.Login._Repositories
{
    class LoginRepository : Connection, ILogin
    {
        public LoginRepository(string Cadena)
        {
            this.ConnnectionString = Cadena; 
        }

        public bool Login(string user, string clave)
        {
            bool estado = true;

            return estado;
        }
    }
}
