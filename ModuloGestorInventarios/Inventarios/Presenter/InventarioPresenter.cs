using ModuloGestorInventarios.Inventarios.Model;
using ModuloGestorInventarios.Inventarios.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModuloGestorInventarios.Inventarios.Presenter
{
    class InventarioPresenter
    {
        private IInventarioView iInventarioView;
        private IInventario iInventario;
        private readonly string ConnnectionString;
        public InventarioPresenter(IInventarioView iInventarioView, IInventario iInventario, string ConnnectionString)
        {
            this.iInventarioView = iInventarioView;
            this.ConnnectionString = ConnnectionString;
            this.iInventario = iInventario;
            iInventarioView.setComboBoxFiltro(iInventario.SetComboBoxFlitro());
            iInventarioView.setInventarioBindingSource(iInventario.setDataSourceInventario());
            iInventarioView.BuscarInventario += Buscar;
            iInventarioView.UpdateInventario += Update;
        }

        private void Buscar(object sender, EventArgs e)
        {
            List<Inventario> datos = iInventario.Buscar(iInventarioView.Buscar, iInventarioView.Filtro, 0);
            if(datos.Count > 0)
            {
                iInventarioView.setInventarioBindingSource(datos);
            }
            else
            {
                iInventarioView.setInventarioBindingSource(iInventario.setDataSourceInventario());
                iInventarioView.MostrarMsj("Inventario no encontrado", "Resultados de Busqueda", MessageBoxButtons.OK);
            }
        }
        private void Update(object sender, EventArgs e)
        {
            
        }
    }
}
