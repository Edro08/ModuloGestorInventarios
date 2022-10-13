using System.Collections.Generic;

namespace ModuloGestorInventarios.Inventarios.Model
{
    interface IInventario
    {
        List<FiltroInventario> SetComboBoxFlitro();
        List<Inventario> setDataSourceInventario();

        void Update(List<Inventario> listaInventario);
        List<Inventario> Buscar(string value, int tipoFiltro, int datoFiltro);
    }
}
