using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    class Tarea
    {
        private string descripcion;
        private int tiempo;
        private Empleado empleado;

        public string Descripcion
        {
            set { this.descripcion = value; }
            get { return this.descripcion; }
        }
        public int Tiempo
        {
            set { this.tiempo = value; }
            get { return this.tiempo; }
        }
        public Empleado Empleado
        {
            set { this.empleado = value; }
            get { return this.empleado; }
        }
    }
}
