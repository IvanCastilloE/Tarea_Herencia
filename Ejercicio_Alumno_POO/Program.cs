using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Alumno_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("LOLO", 50, "MEn", 2, 420, "Todas");

            Console.WriteLine("Nombre del Alumno: ");
            estudiante.Nombre = Console.ReadLine();
            estudiante.Calificacion1 = double.Parse(Console.ReadLine());
        }
    }
}
