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


            try
            {
                List<int> notas = new List<int>();
                int total = 0;
                decimal promedio;

                int cantidadNotas = 5;

                //Ingresar notas
                for (int i = 0; i < cantidadNotas; i++)
                {
                    int notaLeida = 0;
                    Console.WriteLine("Ingresar Nota "+( i+1));
                    notaLeida = Convert.ToInt32(Console.ReadLine());
                    notas.Add(notaLeida);
                }


                foreach (var item in notas)
                {
                    total = total + item;
                }

                promedio = total / cantidadNotas;

                Console.WriteLine("El total es " + total);
                Console.WriteLine("El total es " + promedio);



                //int nota1 = 0;
                //Console.WriteLine("Ingresar Nota");

                //nota1 =Convert.ToInt32( Console.ReadLine());

                //Console.WriteLine("La nota es:" + nota1);
                Console.Read();
            }
            catch (Exception ex)
            {

                throw ex;
            }
          



        }
    }
}
