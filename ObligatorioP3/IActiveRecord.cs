using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    public interface IActiveRecord<T>
    {
        bool Leer();
        bool Guardar();
        bool Actualizar();
        List<T> TraerTodo();
    }
}
