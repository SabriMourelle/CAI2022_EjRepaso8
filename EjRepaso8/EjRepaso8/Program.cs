using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjRepaso8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio VIII
            //Crear una aplicación que, cuando el usuario ingrese una fecha, calcule la diferencia entre
            //ésta y el día de hoy, mostrando por pantalla "La diferencia de fechas es de *nnnnn* días."

            DateTime hoy = DateTime.Today;
            string valor;
            DateTime fecha;
            bool pasarAfecha = false;
            TimeSpan dias;

            do
            {
                Console.WriteLine("Ingrese una fecha en el formato mm/dd/yyyy");
                valor = Console.ReadLine();
                pasarAfecha = DateTime.TryParse(valor, out fecha);
                if (pasarAfecha==true)
                {
                    fecha = DateTime.Parse(valor);
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es fecha, ingrese uno nuevo");
                }
            
            } while (pasarAfecha==false);
            
            dias = hoy - fecha;

            Console.WriteLine("Usted ingresó el día "+fecha + ", hoy es "+hoy+", entre ambas fechas hay "+dias+" de diferencia");
            Console.ReadKey();
        }
    }
}
