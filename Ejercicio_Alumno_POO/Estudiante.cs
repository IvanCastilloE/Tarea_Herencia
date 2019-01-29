using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Alumno_POO
{
    class Estudiante:Alumno
    {
        public int Grado { get; set; }
        private double _Calificacion1;
        private double _Calificacion2;
        private double _Calificacion3;
        private double _Calificacion4;
        private double _Calificacion5;

        public double Calificacion1
        {
            get { return _Calificacion1; }
            set { _Calificacion1 = value; }
        }
        public double Calificacion2
        {
            get { return _Calificacion2; }
            set { _Calificacion2 = value; }
        }
        public double Calificacion3
        {
            get { return _Calificacion3; }
            set { _Calificacion3 = value; }
        }
        public double Calificacion4
        {
            get { return _Calificacion4; }
            set { _Calificacion4 = value; }
        }
        public double Calificacion5
        {
            get { return _Calificacion5; }
            set { _Calificacion5 = value; }
        }
        public int NumSerie { get; set; }
        public string Materias { get; set; }
        public double Promedio()
        {
            return (Calificacion1 + Calificacion2 + Calificacion3 + Calificacion4 + Calificacion5) / 5;
        }

        public Estudiante(string nombre, int edad, string sexo, int grado, int numSerie, string materias)
        {
            Nombre = nombre;
            Grado = grado;
            NumSerie = numSerie;
            Materias = materias;
        }
    }
}
