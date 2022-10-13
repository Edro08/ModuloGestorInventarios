using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloGestorInventarios.Login.Models
{
    class Login
    {
        private int idUser;
        private string user;
        private string clave;

        public int IdUser { get => idUser; set => idUser = value; }
        public string User { get => user; set => user = value; }
        public string Clave { get => clave; set => clave = value; }
    }
}
