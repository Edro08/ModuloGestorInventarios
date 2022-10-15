using ModuloGestorInventarios._Repositories;
using ModuloGestorInventarios.Inventarios.Model;
using System.Collections.Generic;

namespace ModuloGestorInventarios.Inventarios._Repository
{
    class InventarioRepository : Connection, IInventario
    {
        public InventarioRepository(string Cadena)
        {
            this.ConnnectionString = Cadena;
        }

        public List<Inventario> Buscar(string value, int tipoFiltro, int datoFiltro)
        {
            List<Inventario> inventario = new List<Inventario>();
            inventario.Add(new Inventario() { Id = 10, Codigo = 049567, Nombreproducto = "Coca Cola", Existencias = 90, Existenciasmax = 100, Existenciasmin = 5 });
            return inventario;
        }

        public List<FiltroInventario> SetComboBoxFlitro()
        {
            List<FiltroInventario> filtroInventario = new List<FiltroInventario>();

            filtroInventario.Add(new FiltroInventario() {IdFiltro = 0, FiltroNombre = "Seleccionar..." });
            filtroInventario.Add(new FiltroInventario() {IdFiltro = 1, FiltroNombre = "Categorias de Productos"});
            filtroInventario.Add(new FiltroInventario() {IdFiltro = 2, FiltroNombre = "Marca de Productos" });
            filtroInventario.Add(new FiltroInventario() {IdFiltro = 3, FiltroNombre = "Estado de Productos" });

            return filtroInventario;
        }

        public List<Inventario> setDataSourceInventario()
        {
            List<Inventario> inventario = new List<Inventario>();

            for (int i = 1; i <= 200; i ++) {

                if (i % 7 == 0)
                {
                    inventario.Add(new Inventario() { Id = i, Codigo = 7140, Nombreproducto = "Tropical Uva", Existencias = 90, Existenciasmax = 100, Existenciasmin = 5 });
                }
                else if (i % 5 == 0)
                {
                    inventario.Add(new Inventario() { Id = i, Codigo = 5100, Nombreproducto = "Pepsi", Existencias = 90, Existenciasmax = 100, Existenciasmin = 5 });
                }
                else if (i % 3 == 0)
                {
                    inventario.Add(new Inventario() { Id = i, Codigo = 3690, Nombreproducto = "Fanta", Existencias = 90, Existenciasmax = 100, Existenciasmin = 5 });
                }
                else if (i % 2 == 0)
                {
                    inventario.Add(new Inventario() { Id = i, Codigo = 2468, Nombreproducto = "Coca Cola", Existencias = 90, Existenciasmax = 100, Existenciasmin = 5 });
                }
                else
                {
                    inventario.Add(new Inventario() { Id = i, Codigo = 1000, Nombreproducto = "Dr.Pe", Existencias = 90, Existenciasmax = 100, Existenciasmin = 5 });
                }
            }
            return inventario;
        }

        public void Update(List<Inventario> listaInventario)
        {
            throw new System.NotImplementedException();
        }
    }
}
