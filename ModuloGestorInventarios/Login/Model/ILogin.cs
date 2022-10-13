using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloGestorInventarios.Login.Models
{
    public interface ILogin
    {
        bool Login(string user, string clave);
    }
}
