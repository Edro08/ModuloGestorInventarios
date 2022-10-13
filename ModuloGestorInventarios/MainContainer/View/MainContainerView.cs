﻿using ModuloGestorInventarios.Inventarios.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ModuloGestorInventarios.MainContainer.View
{
    public partial class MainContainerView : Form, IMainContainerView
    {
        //Posicion y Tamaño para btnMax
        private int LocationX = 0, LocationY = 0;
        private int SizeW = 0, SizeH = 0;
        private bool statusMax = false;

        public event EventHandler AbrirInventario;
        public MainContainerView()
        {
            InitializeComponent();
        }

        //Ocultar texto de menu lateral
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 220)
                panelMenu.Width = 50;
            else
                panelMenu.Width = 220;
        }

        //Ni idea como funciona pero ayuda a redimensionar el formulario principal.
        protected override void WndProc(ref Message m)
        {
            const UInt32 WM_NCHITTEST = 0x0084;
            const UInt32 WM_MOUSEMOVE = 0x0200;

            const UInt32 HTLEFT = 10;
            const UInt32 HTRIGHT = 11;
            const UInt32 HTBOTTOMRIGHT = 17;
            const UInt32 HTBOTTOM = 15;
            const UInt32 HTBOTTOMLEFT = 16;
            const UInt32 HTTOP = 12;
            const UInt32 HTTOPLEFT = 13;
            const UInt32 HTTOPRIGHT = 14;

            const int RESIZE_HANDLE_SIZE = 10;
            bool handled = false;
            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {
                Size formSize = this.Size;
                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = this.PointToClient(screenPoint);

                Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {
                    {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                    {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                    {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                    {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
                    {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                    {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                    {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                    {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) 
                }
            };

                foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes)
                {
                    if (this.WindowState != FormWindowState.Maximized
                        && hitBox.Value.Contains(clientPoint))
                    {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }

            if (!handled)
                base.WndProc(ref m);
        }

        ////Evento que permite mover el formulario desde la barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string message = "¿Desea cerrar el gestor de inventarios?";
            string caption = "Cerrar programa";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Muestra el mensaje
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Cerrar programa
                Dispose(true);
                Application.Exit();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (!statusMax)
            {
                //Almacenar datos de posicion y tamaño
                LocationX = this.Location.X;
                LocationY = this.Location.Y;
                SizeH = this.Size.Height;
                SizeW = this.Size.Width;

                //Maximizar a area de trabajo maximo
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                statusMax = true;

            }
            else
            {
                //Volver al tamaño y posicion antigua
                this.Size = new Size(SizeW, SizeH);
                this.Location = new Point(LocationX, LocationY);
                statusMax = false;
            }
        }

        private void ConfiguracionesForm(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulario);
            panelContenedor.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirInventario?.Invoke(this, e);
        }

        public void MostrarMsj(string message, string caption, MessageBoxButtons buttons)
        {
            MessageBox.Show(message, caption, buttons);
        }

        public void MostrarInventario(Form inventario)
        {
            InventarioView formulario;
            //Busca en la colecion el formulario si el formulario/instancia no existe
            formulario = panelContenedor.Controls.OfType<InventarioView>().FirstOrDefault();

            if (formulario == null)
            {
                ConfiguracionesForm(inventario);
            }
            //si el formulario/instancia existe
            else
            {
                inventario.BringToFront();
            }
        }
    }
}
