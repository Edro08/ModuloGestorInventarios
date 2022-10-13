using ModuloGestorInventarios.MainContainer.View;
using System;
using System.Windows.Forms;

namespace ModuloGestorInventarios.Login.Views
{
    interface ILoginView
    {
        //Propiedades
        string User{ get; set; }
        string Clave { get; set; }
        string Etiqueta { get; set; }

        //Eventos
        event EventHandler ValidarDatosLogin;

        //Metodos
        void DatosIncorrectos();
        void DatosCorrectos(Form main);
    }
}
