using ModuloGestorInventarios.Inventarios.Model;
using ModuloGestorInventarios.Inventarios.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModuloGestorInventarios.Inventarios.View
{
    public partial class InventarioView : Form, IInventarioView
    {
        //Auxiliares
        private bool tpDetallesOn = false;
        private bool tpProductosOn = false;
        DataGridViewButtonColumn btnVerInventario;
        DataGridViewButtonColumn btnVerProducto;
        DataGridViewButtonColumn btnEditar;
        private int IdInventario;

        public event EventHandler BuscarInventario;
        public event EventHandler UpdateInventario;

        public InventarioView()
        {
            InitializeComponent();
            tabControlInventario.TabPages.Remove(tpDetalles);
            tabControlInventario.TabPages.Remove(tpProduto);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (tpDetallesOn == true) {
                string message = "¿Desea cerrar el modulo inventarios sin guardar los cambios?";
                string caption = "Cerrar Modulo";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                //Muestra el mensaje
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                    this.Dispose();
                }
            }
            else
            {
                this.Close();
                this.Dispose();
            }
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            if (!tpDetallesOn)
            {
                tabControlInventario.TabPages.Add(tpDetalles);
                tabControlInventario.SelectedTab = tpDetalles;
                LimpiarDetalleInventario();
                txtExistenciasMax.ReadOnly = false;
                txtExistenciasMin.ReadOnly = false;
                tpDetallesOn = true;
            }
            else
            {
                tabControlInventario.SelectedTab = tpDetalles;
                MostrarMsj("Actualmente tiene una acción pendiente por realizar", "Registro en Curso", MessageBoxButtons.OK);
            }
        }

        public void MostrarMsj(string message, string caption, MessageBoxButtons buttons)
        {
            MessageBox.Show(message, caption, buttons);
        }

        public void setComboBoxFiltro(List<FiltroInventario> listaDatos)
        {
            cbFiltro.DataSource = new BindingSource(listaDatos, null);
            cbFiltro.DisplayMember = "FiltroNombre";
            cbFiltro.ValueMember = "IdFiltro";
        }

        public void setInventarioBindingSource(List<Inventario> inventarioList)
        {
            if (btnVerInventario == null)
            {
                btnVerInventario = new DataGridViewButtonColumn();
                dgvInventario.Columns.Add(btnVerInventario);
                btnVerInventario.HeaderText = "Inventario";
                btnVerInventario.Text = "Inventario";
                btnVerInventario.Name = "btnVerInventario";
                btnVerInventario.UseColumnTextForButtonValue = true;
            }

            if (btnVerProducto == null)
            {
                btnVerProducto = new DataGridViewButtonColumn();
                dgvInventario.Columns.Add(btnVerProducto);
                btnVerProducto.HeaderText = "Ver";
                btnVerProducto.Text = "Ver";
                btnVerProducto.Name = "btnVerProducto";
                btnVerProducto.UseColumnTextForButtonValue = true;
            }

            if (btnEditar == null)
            {
                btnEditar = new DataGridViewButtonColumn();
                dgvInventario.Columns.Add(btnEditar);
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.Name = "btnEditar";
                btnEditar.UseColumnTextForButtonValue = true;
            }

            dgvInventario.DataSource = new BindingSource(inventarioList, null);
            dgvInventario.AutoResizeColumns();
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInventario.Columns.IndexOf(btnVerInventario) || e.ColumnIndex == dgvInventario.Columns.IndexOf(btnEditar))
            {
                if (!tpDetallesOn)
                {
                    tabControlInventario.TabPages.Add(tpDetalles);
                    tabControlInventario.SelectedTab = tpDetalles;
                    tpDetallesOn = true;

                    if (e.ColumnIndex == dgvInventario.Columns.IndexOf(btnVerInventario)) {
                        btnCancelar.Text = "OK";
                        btnGuardar.Visible = false;
                        txtExistenciasMax.ReadOnly = true;
                        txtExistenciasMin.ReadOnly = true;

                    } else if (e.ColumnIndex == dgvInventario.Columns.IndexOf(btnEditar)) {
                        btnCancelar.Text = "Cancelar";
                        btnGuardar.Visible = true;
                        txtExistenciasMax.ReadOnly = false;
                        txtExistenciasMin.ReadOnly = false;
                    }
                    IdInventario = (int)dgvInventario.CurrentRow.Cells["Id"].Value;
                    Codigo = (int)dgvInventario.CurrentRow.Cells["Codigo"].Value;
                    NombreProducto = (string)dgvInventario.CurrentRow.Cells["nombreproducto"].Value;
                    Existencias = (int)dgvInventario.CurrentRow.Cells["existencias"].Value;
                    ExistenciasMin = (int)dgvInventario.CurrentRow.Cells["existenciasmin"].Value;
                    ExistenciasMax = (int)dgvInventario.CurrentRow.Cells["existenciasmax"].Value;
                }
                else
                {
                    tabControlInventario.SelectedTab = tpDetalles;
                    MostrarMsj("Actualmente tiene una acción pendiente por realizar", "Registro en Curso", MessageBoxButtons.OK);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tpDetallesOn = false;
            tabControlInventario.TabPages.Remove(tpDetalles);
            LimpiarDetalleInventario();
        }

        public void LimpiarDetalleInventario()
        {
            Codigo = 0;
            NombreProducto = "";
            Existencias = 0;
            ExistenciasMin = 0;
            ExistenciasMax = 0;
        }

        public int Codigo { get => int.Parse(txtCodigo.Text.Trim()); set => txtCodigo.Text = value.ToString(); }
        public string NombreProducto { get => txtNombreProducto.Text.Trim(); set => txtNombreProducto.Text = value; }
        public int Existencias { get => int.Parse(txtExistencias.Text.Trim()); set => txtExistencias.Text = value.ToString(); }
        public int ExistenciasMin { get => int.Parse(txtExistenciasMin.Text.Trim()); set => txtExistenciasMin.Text = value.ToString(); }
        public int ExistenciasMax { get => int.Parse(txtExistenciasMax.Text.Trim()); set => txtExistenciasMax.Text = value.ToString(); }
        public string Buscar { get => txtBuscador.Text.Trim(); set => txtBuscador.Text = value; }
        public int Filtro   {get => int.Parse(cbFiltro.SelectedValue.ToString()); set{;}}
        public int FiltroDato { get => int.Parse(cbFiltroDatos.SelectedValue.ToString()); set {; } }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarInventario?.Invoke(this, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UpdateInventario?.Invoke(this, e);
        }
    }
}
