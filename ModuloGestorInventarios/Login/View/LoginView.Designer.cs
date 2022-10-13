
namespace ModuloGestorInventarios.Views
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.btn_CerrarLogin = new System.Windows.Forms.Button();
            this.lblInicarSesion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.panelClave = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.panelBorderButtom2 = new System.Windows.Forms.Panel();
            this.panelBorderButtom1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDatos.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CerrarLogin
            // 
            this.btn_CerrarLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_CerrarLogin.BackgroundImage = global::ModuloGestorInventarios.Properties.Resources.cross_small_free_icon_font;
            this.btn_CerrarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_CerrarLogin.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_CerrarLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_CerrarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_CerrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarLogin.Location = new System.Drawing.Point(354, 0);
            this.btn_CerrarLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CerrarLogin.Name = "btn_CerrarLogin";
            this.btn_CerrarLogin.Size = new System.Drawing.Size(46, 43);
            this.btn_CerrarLogin.TabIndex = 0;
            this.btn_CerrarLogin.UseVisualStyleBackColor = false;
            this.btn_CerrarLogin.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lblInicarSesion
            // 
            this.lblInicarSesion.AutoSize = true;
            this.lblInicarSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblInicarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblInicarSesion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblInicarSesion.Location = new System.Drawing.Point(91, 11);
            this.lblInicarSesion.Name = "lblInicarSesion";
            this.lblInicarSesion.Size = new System.Drawing.Size(191, 31);
            this.lblInicarSesion.TabIndex = 0;
            this.lblInicarSesion.Text = "Iniciar Sesión";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUsuario.Location = new System.Drawing.Point(29, 69);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblClave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblClave.Location = new System.Drawing.Point(29, 146);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(107, 20);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(70, 97);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsuario.MaxLength = 32;
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(302, 27);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtClave.Location = new System.Drawing.Point(70, 174);
            this.txtClave.MaxLength = 32;
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(302, 27);
            this.txtClave.TabIndex = 4;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(29, 231);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(343, 46);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.White;
            this.panelUsuario.BackgroundImage = global::ModuloGestorInventarios.Properties.Resources.Usuaio;
            this.panelUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelUsuario.Location = new System.Drawing.Point(29, 94);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(38, 32);
            this.panelUsuario.TabIndex = 6;
            // 
            // panelClave
            // 
            this.panelClave.BackColor = System.Drawing.Color.White;
            this.panelClave.BackgroundImage = global::ModuloGestorInventarios.Properties.Resources.Clave;
            this.panelClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelClave.Location = new System.Drawing.Point(29, 171);
            this.panelClave.Name = "panelClave";
            this.panelClave.Size = new System.Drawing.Size(38, 32);
            this.panelClave.TabIndex = 7;
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.lblEtiqueta);
            this.panelDatos.Controls.Add(this.panelBorderButtom2);
            this.panelDatos.Controls.Add(this.panelBorderButtom1);
            this.panelDatos.Controls.Add(this.btnLimpiar);
            this.panelDatos.Controls.Add(this.panelClave);
            this.panelDatos.Controls.Add(this.panelUsuario);
            this.panelDatos.Controls.Add(this.btnIniciarSesion);
            this.panelDatos.Controls.Add(this.txtClave);
            this.panelDatos.Controls.Add(this.txtUsuario);
            this.panelDatos.Controls.Add(this.lblClave);
            this.panelDatos.Controls.Add(this.lblUsuario);
            this.panelDatos.Controls.Add(this.lblInicarSesion);
            this.panelDatos.Location = new System.Drawing.Point(29, 256);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(400, 352);
            this.panelDatos.TabIndex = 2;
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblEtiqueta.ForeColor = System.Drawing.Color.Red;
            this.lblEtiqueta.Location = new System.Drawing.Point(29, 208);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(0, 16);
            this.lblEtiqueta.TabIndex = 10;
            // 
            // panelBorderButtom2
            // 
            this.panelBorderButtom2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderButtom2.Location = new System.Drawing.Point(32, 204);
            this.panelBorderButtom2.Name = "panelBorderButtom2";
            this.panelBorderButtom2.Size = new System.Drawing.Size(343, 1);
            this.panelBorderButtom2.TabIndex = 9;
            // 
            // panelBorderButtom1
            // 
            this.panelBorderButtom1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderButtom1.Location = new System.Drawing.Point(29, 127);
            this.panelBorderButtom1.Name = "panelBorderButtom1";
            this.panelBorderButtom1.Size = new System.Drawing.Size(343, 1);
            this.panelBorderButtom1.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLimpiar.Location = new System.Drawing.Point(29, 288);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(343, 46);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Controls.Add(this.btn_CerrarLogin);
            this.panelLogo.Location = new System.Drawing.Point(29, 21);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(400, 228);
            this.panelLogo.TabIndex = 3;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 640);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CerrarLogin;
        private System.Windows.Forms.Label lblInicarSesion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panelClave;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panelBorderButtom2;
        private System.Windows.Forms.Panel panelBorderButtom1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblEtiqueta;
    }
}