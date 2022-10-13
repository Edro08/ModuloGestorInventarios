
namespace ModuloGestorInventarios.Inventarios.View
{
    partial class InventarioView
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTituloInventario = new System.Windows.Forms.Label();
            this.tabControlInventario = new System.Windows.Forms.TabControl();
            this.tpLista = new System.Windows.Forms.TabPage();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.panelControles = new System.Windows.Forms.Panel();
            this.cbFiltroDatos = new System.Windows.Forms.ComboBox();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.tpDetalles = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExistenciasMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExistenciasMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelAccion = new System.Windows.Forms.Panel();
            this.lblAccion = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.tabControlInventario.SuspendLayout();
            this.tpLista.SuspendLayout();
            this.panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.panelControles.SuspendLayout();
            this.tpDetalles.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelTitulo.Controls.Add(this.btnSalir);
            this.panelTitulo.Controls.Add(this.lblTituloInventario);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(686, 35);
            this.panelTitulo.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Blue;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::ModuloGestorInventarios.Properties.Resources.Cerrar_Small_White;
            this.btnSalir.Location = new System.Drawing.Point(636, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 35);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTituloInventario
            // 
            this.lblTituloInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloInventario.AutoSize = true;
            this.lblTituloInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloInventario.ForeColor = System.Drawing.Color.White;
            this.lblTituloInventario.Location = new System.Drawing.Point(13, 9);
            this.lblTituloInventario.Name = "lblTituloInventario";
            this.lblTituloInventario.Size = new System.Drawing.Size(182, 20);
            this.lblTituloInventario.TabIndex = 0;
            this.lblTituloInventario.Text = "Gestión de Inventario";
            this.lblTituloInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlInventario
            // 
            this.tabControlInventario.Controls.Add(this.tpLista);
            this.tabControlInventario.Controls.Add(this.tpDetalles);
            this.tabControlInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControlInventario.Location = new System.Drawing.Point(0, 35);
            this.tabControlInventario.Name = "tabControlInventario";
            this.tabControlInventario.SelectedIndex = 0;
            this.tabControlInventario.Size = new System.Drawing.Size(686, 526);
            this.tabControlInventario.TabIndex = 9;
            // 
            // tpLista
            // 
            this.tpLista.Controls.Add(this.panelDGV);
            this.tpLista.Controls.Add(this.panelControles);
            this.tpLista.Location = new System.Drawing.Point(4, 29);
            this.tpLista.Name = "tpLista";
            this.tpLista.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpLista.Size = new System.Drawing.Size(678, 493);
            this.tpLista.TabIndex = 0;
            this.tpLista.Text = "Ver Lista";
            this.tpLista.UseVisualStyleBackColor = true;
            // 
            // panelDGV
            // 
            this.panelDGV.Controls.Add(this.dgvInventario);
            this.panelDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGV.Location = new System.Drawing.Point(3, 136);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.panelDGV.Size = new System.Drawing.Size(672, 354);
            this.panelDGV.TabIndex = 6;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToOrderColumns = true;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventario.Location = new System.Drawing.Point(9, 9);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.Size = new System.Drawing.Size(654, 336);
            this.dgvInventario.TabIndex = 1;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            // 
            // panelControles
            // 
            this.panelControles.Controls.Add(this.cbFiltroDatos);
            this.panelControles.Controls.Add(this.btnNuevoRegistro);
            this.panelControles.Controls.Add(this.lblFiltro);
            this.panelControles.Controls.Add(this.cbFiltro);
            this.panelControles.Controls.Add(this.btnBuscar);
            this.panelControles.Controls.Add(this.txtBuscador);
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelControles.Location = new System.Drawing.Point(3, 3);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(672, 133);
            this.panelControles.TabIndex = 0;
            // 
            // cbFiltroDatos
            // 
            this.cbFiltroDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltroDatos.FormattingEnabled = true;
            this.cbFiltroDatos.Location = new System.Drawing.Point(391, 55);
            this.cbFiltroDatos.Name = "cbFiltroDatos";
            this.cbFiltroDatos.Size = new System.Drawing.Size(260, 32);
            this.cbFiltroDatos.TabIndex = 7;
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnNuevoRegistro.FlatAppearance.BorderSize = 2;
            this.btnNuevoRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnNuevoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoRegistro.Image = global::ModuloGestorInventarios.Properties.Resources.agregar;
            this.btnNuevoRegistro.Location = new System.Drawing.Point(9, 95);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(200, 35);
            this.btnNuevoRegistro.TabIndex = 6;
            this.btnNuevoRegistro.Text = "Agregar Registro";
            this.btnNuevoRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(49, 58);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(61, 24);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtro: ";
            // 
            // cbFiltro
            // 
            this.cbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(116, 55);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(260, 32);
            this.cbFiltro.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::ModuloGestorInventarios.Properties.Resources.busqueda;
            this.btnBuscar.Location = new System.Drawing.Point(10, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 35);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(116, 11);
            this.txtBuscador.Multiline = true;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(534, 35);
            this.txtBuscador.TabIndex = 0;
            // 
            // tpDetalles
            // 
            this.tpDetalles.Controls.Add(this.panel1);
            this.tpDetalles.Controls.Add(this.panelAccion);
            this.tpDetalles.Location = new System.Drawing.Point(4, 29);
            this.tpDetalles.Name = "tpDetalles";
            this.tpDetalles.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpDetalles.Size = new System.Drawing.Size(678, 493);
            this.tpDetalles.TabIndex = 1;
            this.tpDetalles.Text = "Detalles";
            this.tpDetalles.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtExistenciasMax);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtExistenciasMin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtExistencias);
            this.panel1.Controls.Add(this.txtNombreProducto);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 457);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Detalle de Inventario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Existencias Máx:";
            // 
            // txtExistenciasMax
            // 
            this.txtExistenciasMax.Location = new System.Drawing.Point(261, 249);
            this.txtExistenciasMax.Multiline = true;
            this.txtExistenciasMax.Name = "txtExistenciasMax";
            this.txtExistenciasMax.ReadOnly = true;
            this.txtExistenciasMax.Size = new System.Drawing.Size(300, 30);
            this.txtExistenciasMax.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Existencias Min:";
            // 
            // txtExistenciasMin
            // 
            this.txtExistenciasMin.Location = new System.Drawing.Point(261, 203);
            this.txtExistenciasMin.Multiline = true;
            this.txtExistenciasMin.Name = "txtExistenciasMin";
            this.txtExistenciasMin.ReadOnly = true;
            this.txtExistenciasMin.Size = new System.Drawing.Size(300, 30);
            this.txtExistenciasMin.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Existencias:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre de Producto:";
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(261, 157);
            this.txtExistencias.Multiline = true;
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.ReadOnly = true;
            this.txtExistencias.Size = new System.Drawing.Size(300, 30);
            this.txtExistencias.TabIndex = 12;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(261, 111);
            this.txtNombreProducto.Multiline = true;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(300, 30);
            this.txtNombreProducto.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(93, 66);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(162, 24);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "Código Inventario:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(261, 66);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(300, 30);
            this.txtCodigo.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(446, 309);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 31);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(261, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 31);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelAccion
            // 
            this.panelAccion.BackColor = System.Drawing.Color.Silver;
            this.panelAccion.Controls.Add(this.lblAccion);
            this.panelAccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccion.Location = new System.Drawing.Point(3, 3);
            this.panelAccion.Name = "panelAccion";
            this.panelAccion.Size = new System.Drawing.Size(672, 30);
            this.panelAccion.TabIndex = 0;
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccion.Location = new System.Drawing.Point(6, 6);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(142, 20);
            this.lblAccion.TabIndex = 0;
            this.lblAccion.Text = "Acción a realizar";
            // 
            // InventarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 561);
            this.Controls.Add(this.tabControlInventario);
            this.Controls.Add(this.panelTitulo);
            this.Name = "InventarioView";
            this.Text = "InventarioView";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.tabControlInventario.ResumeLayout(false);
            this.tpLista.ResumeLayout(false);
            this.panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.panelControles.ResumeLayout(false);
            this.panelControles.PerformLayout();
            this.tpDetalles.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAccion.ResumeLayout(false);
            this.panelAccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTituloInventario;
        private System.Windows.Forms.TabControl tabControlInventario;
        private System.Windows.Forms.TabPage tpLista;
        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.TabPage tpDetalles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelAccion;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExistenciasMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExistenciasMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFiltroDatos;
    }
}