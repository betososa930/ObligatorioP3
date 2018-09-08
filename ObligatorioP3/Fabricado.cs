using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    class Fabricado : Producto
    {
        private int tiempoFB;
        private List<Tarea> tareas;
        private int idFabricado;
        public int TiempoFB
        {
            set { this.tiempoFB = value; }
            get { return this.tiempoFB; }
        }
        public List<Tarea> Tareas
        {
            set { this.tareas = value; }
            get { return this.tareas; }
        }


    }
}
