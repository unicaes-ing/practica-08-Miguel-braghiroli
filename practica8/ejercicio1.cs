using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    class ejercicio1
    {
        public struct Estudiante
        {
            public string Num_Carnet;
            public string Nombre;
            public string Carrera;
            private double CUM;
            public void setCum(double cum)
            {
                if (cum >= 0)
                {
                    if (cum <= 10)
                    {
                        this.CUM = cum;
                    }
                }
            }
            public double getCum()
            {
                return CUM;
            }
        }
        static void Main(string[] args)
        {
            Estudiante est1 = new Estudiante();
            Console.WriteLine("Escriba su numero de Num_Car: ");
            Console.WriteLine("===================================");
            est1.Num_Carnet = Console.ReadLine();

            Console.WriteLine("Escriba su Nombre: ");
            Console.WriteLine("===================================");
            est1.Nombre = Console.ReadLine();

            Console.WriteLine("Escriba el Nombre de su Carrera: ");
            Console.WriteLine("===================================");
            est1.Carrera = Console.ReadLine();

            Console.WriteLine("Ingrese su cum: ");
            Console.WriteLine("===================================");
            est1.setCum(Convert.ToDouble(Console.ReadLine()));

            Console.Clear();
            Console.WriteLine("N° Carnet: " + est1.Num_Carnet);
            Console.WriteLine("Nombre del estudiante: " + est1.Nombre);
            Console.WriteLine("Nombre de la Carrera: " + est1.Carrera);
            Console.WriteLine("Cum: " + est1.getCum());
        }
    }
}
