using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    class Producto
    {
        private string codigo;
        private string nombre;
        private string descripcion;
        private double costo;
        private double precioSV;
        private Empleado empleado;

        public string Codigo
        {
            set { this.codigo = value; }
            get { return this.codigo; }
        }
        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
        public string Descripcion
        {
            set { this.descripcion = value; }
            get { return this.descripcion; }
        }
        public double Costo
        {
            set { this.costo = value; }
            get { return this.costo; }
        }
        public double PrecioSV
        {
            set { this.precioSV = value; }
            get { return this.precioSV; }
        }
        public Empleado Empleado
        {
            set { this.empleado = value; }
            get { return this.empleado; }
        }
    }
}
