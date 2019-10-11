using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    class ejercicio3
    {
        public struct materia
        {
            public string Nombre;
            private double Nota;
            public void setNota(double nota)
            {
                if (nota <= 6.0)
                {
                    this.Nota = nota;
                }
                else
                {
                    this.Nota = nota;
                }
            }
            public double getNota()
            {
                if (Nota <= 6.0)
                {
                    Console.WriteLine("reprobado");
                }
                else
                {
                    Console.WriteLine("aprobado");
                }
                return Nota;
            }
        }
        public struct Alumno
        {
            public string Num_Car;
            public string Alum_Nom;
            public string Carrera;
            public materia materiaN1;
            public materia materiaN2;
            public materia materiaN3;
            public materia materiaN4;
        }
        static void Main(string[] args)
        {
            int cant;
            Console.Write("Cantidad de alumnos a registrar: ");
            cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Alumno[] alum = new Alumno[cant];
            for (int c = 0; c < alum.Length; c++)
            {
                Console.WriteLine("Alumno N°{0}", c + 1);
                Console.WriteLine("Numero de carnet: ");
                alum[c].Num_Car = Console.ReadLine();

                Console.WriteLine("Nombre del alumno: ");
                alum[c].Alum_Nom = Console.ReadLine();

                Console.WriteLine("Carrera que cursa: ");
                alum[c].Carrera = Console.ReadLine();


                Console.WriteLine("Nota de la materia N°1: ");
                alum[c].materiaN1.setNota(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Nota de la materia N°2: ");
                alum[c].materiaN2.setNota(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Nota de la materia N°3: ");
                alum[c].materiaN3.setNota(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Nota de la materia N°4: ");
                alum[c].materiaN4.setNota(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine();
            }
            Console.WriteLine("Presione <Enter> para ver los datos de los alumnos registrados.");
            Console.ReadKey();
            Console.Clear();
            int n = 0;
            foreach (Alumno a in alum)
            {
                n++;
                Console.WriteLine("Datos del alumno N°{0}", n);
                Console.WriteLine("Numero de carnet: {0}", a.Num_Car);
                Console.WriteLine("Nombre del alumno: {0}", a.Alum_Nom);
                Console.WriteLine("Carrera: {0}", a.Carrera);

                Console.WriteLine("Materias cursadas");
                Console.WriteLine("=================================");
                Console.WriteLine("Nota materia N°1: {0}", a.materiaN1.getNota());
                Console.WriteLine("Nota materia N°2: {0}", a.materiaN2.getNota());
                Console.WriteLine("Nota materia N°3: {0}", a.materiaN3.getNota());
                Console.WriteLine("Nota materia N°4: {0}", a.materiaN4.getNota());
            }
        }
    }
}
