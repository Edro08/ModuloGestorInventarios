using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloGestorInventarios.Inventarios.Model
{
    public class Inventario
    {
        private int id;
        private int codigo;
        private string nombreproducto;
        private int existencias;
        private int existenciasmin;
        private int existenciasmax;

        public int Id { get => id; set => id = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombreproducto { get => nombreproducto; set => nombreproducto = value; }
        public int Existencias { get => existencias; set => existencias = value; }
        public int Existenciasmin { get => existenciasmin; set => existenciasmin = value; }
        public int Existenciasmax { get => existenciasmax; set => existenciasmax = value; }
    }
}
