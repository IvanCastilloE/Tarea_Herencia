using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Alumno_POO
{
    class Alumno
    {
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public Alumno() { } 

        public Alumno(string nombre, int edad, string sexo, double altura, double peso)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Altura = altura;
            Peso = peso;
        }
    }
}
