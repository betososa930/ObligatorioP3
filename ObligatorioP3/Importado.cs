using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    class Importado : Producto
    {
        private string pais;
        private int cantMin;
        public string Pais
        {
            set { this.pais = value; }
            get { return this.pais; }
        }
        public int CantMin
        {
            set { this.cantMin = value; }
            get { return this.cantMin; }
        }


    }
}
