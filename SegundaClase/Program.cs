using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un programa que vamos a ingresar la nota de 10 alumnos
            //Promedio 10 alumnos
            //La nota mayor
            //La nota menor
            //Se aprueba con 14, cantidad de alumnos aprobados, cantidad de alumnos desaprobados
            Alumno alumno1 = new Alumno();
            alumno1.Dni = "45524520";
            alumno1.Nombres = "Hugo Felipe";
            alumno1.Apellidos = "Torrico Márquez";
            alumno1.Nota = 18;

            Console.WriteLine( alumno1.ObtenerNombresCompletos());
            Console.WriteLine(alumno1.EstaAprobado());


            Rectangulo rectangulo = new Rectangulo();

            rectangulo.x1 = 4;
            rectangulo.y1 = 4;
            rectangulo.x2 = 12;
            rectangulo.y2 = 4;
            rectangulo.x3 = 12;
            rectangulo.y3 = 10;
            rectangulo.x4 = 4;
            rectangulo.y4 = 10;

            Console.WriteLine(rectangulo.CalcularArea());
            Console.WriteLine(rectangulo.CalcularPerimetro());





            //List<Alumno> alumnos = new List<Alumno>();
            //int total = 0;
            //decimal promedio;
            //int cantidadAlumnos = 5;
            //int notaMayor = 0;
            //int notaMenor = 20;

            ////Ingresamos Datos del alumno
            //for (int i = 0; i < cantidadAlumnos; i++)
            //{
            //    int notaLeida = 0;
            //    string nombre = "";
            //    string apellido = "";
            //    string dni = "";


            //    //Lectura Datos
            //    Console.WriteLine("Ingresar DNI " + (i + 1));
            //    dni = Console.ReadLine();

            //    Console.WriteLine("Ingresar Nombre " + (i + 1));
            //    nombre = Console.ReadLine();

            //    Console.WriteLine("Ingresar Apellido " + (i + 1));
            //    apellido = Console.ReadLine();

            //    Console.WriteLine("Ingresar Nota " + (i + 1));
            //    notaLeida = Convert.ToInt32(Console.ReadLine());



            //    alumnos.Add(new Alumno
            //    {
            //        Dni = dni,
            //        Apellidos = apellido,
            //        Nombres = nombre,
            //        Nota = notaLeida
            //    });
            //    //notas.Add(notaLeida);

            //}


            Console.Read();

        }
        static void Arreglos ()
            {
            List<int> notas = new List<int>();
            int total = 0;
            decimal promedio;
            int cantidadNotas = 5;
            int notaMayor = 0;
            int notaMenor = 20;

            //Ingresar notas
            for (int i = 0; i < cantidadNotas; i++)
            {
                int notaLeida = 0;
                Console.WriteLine("Ingresar Nota " + (i + 1));
                notaLeida = Convert.ToInt32(Console.ReadLine());
                notas.Add(notaLeida);
            }


            foreach (var item in notas)
            {
                //Calculando el total
                total = total + item;

                //Calculando la nota mayor
                if (item > notaMayor)
                    notaMayor = item;

                //Calculando la nota menor
                if (item < notaMenor)
                    notaMenor = item;

            }

            promedio = total / cantidadNotas;

            Console.WriteLine("El total es " + total);
            Console.WriteLine("El total es " + promedio);
            Console.WriteLine("La nota mayor es " + notaMayor);
            Console.WriteLine("La nota mayor es " + notaMenor);
        }
    }
}
