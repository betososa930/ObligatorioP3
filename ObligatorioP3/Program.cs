using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Obligatorio

{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                //Empleado nueva = new Empleado()
                //{
                //    Nombre = "Juan",
                //    Contrasenia = "123455",
                //    Mail = "juan@perez.com",

                //};

                //bool ok = nueva.Guardar();
                //Console.WriteLine(ok ? "Alta exitosa" : "No se pudo dar el alta");

                //Empleado nueva = new Empleado()
                //{                    
                //    Mail = "juanperez@gmail.com"
                //};

                //bool ok = nueva.Leer();

                //if (ok)
                //{
                //    Console.WriteLine(nueva.Nombre);
                //}

                //Empleado nueva = new Empleado();

                //foreach (Empleado p in nueva.TraerTodo())
                //{
                //    Console.WriteLine(p.Nombre);
                //}

                Empleado nueva = new Empleado()
                {
                    Mail = "usu1@usuario.com"
                };

                bool ok = nueva.Leer();

                nueva.Nombre = "Nombre Cambiado";

                nueva.Actualizar();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            

            Console.ReadLine();
        }
    }
}
