using ModuloGestorInventarios.Login.Presenters;
using ModuloGestorInventarios.Login.Views;
using ModuloGestorInventarios.MainContainer.View;
using System;
using System.Windows.Forms;

namespace ModuloGestorInventarios.Views
{
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public string User { get => txtUsuario.Text.Trim(); set => txtUsuario.Text = value; }
        public string Clave { get => txtClave.Text.Trim(); set => txtClave.Text = value; }
        public string Etiqueta { get => lblEtiqueta.Text; set => lblEtiqueta.Text = value; }

        public event EventHandler ValidarDatosLogin;

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            User = "";
            Clave = "";
            Etiqueta = "";
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            ValidarDatosLogin?.Invoke(this, e);
        }

        public void DatosCorrectos(Form Main)
        {
            Main.Show();
            Clave = "";
            this.Hide();
        }

        public void DatosIncorrectos()
        {
            Etiqueta = "Datos de Usuario Incorrectos";
            Clave = "";
        }
    }
}
