using ModuloGestorInventarios.Inventarios.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ModuloGestorInventarios.Inventarios.View
{
    interface IInventarioView
    {
        //Eventos
        event EventHandler BuscarInventario;
        event EventHandler UpdateInventario;
      
        //Metodos
        void setInventarioBindingSource(List<Inventario> inventarioList);
        void setComboBoxFiltro(List<FiltroInventario> listaDatos);
        void MostrarMsj(string message, string caption, MessageBoxButtons buttons);
        void LimpiarDetalleInventario();

        //Propiedades
        string Buscar { get; set; }
        int Codigo { get; set; }
        string NombreProducto { get; set; }
        int Existencias { get; set; }
        int ExistenciasMin { get; set; }
        int ExistenciasMax { get; set; }
        int Filtro { get; set; }
        int FiltroDato { get; set; }
    }
}
