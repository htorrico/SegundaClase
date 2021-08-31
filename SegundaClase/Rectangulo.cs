using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClase
{
    class Rectangulo
    {
        public int x1 { get; set; }
        public int y1 { get; set; }

        public int x2 { get; set; }
        public int y2 { get; set; }

        public int x3 { get; set; }
        public int y3 { get; set; }

        public int x4 { get; set; }
        public int y4 { get; set; }

     decimal ObtenerBase()
        {
            decimal base1;
            base1 = Convert.ToDecimal(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            return base1;
        }
        decimal ObtenerAltura()
        {
            decimal altura;
            altura = Convert.ToDecimal(Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)));
            return altura;
        }

        public decimal CalcularArea()
        {
            decimal area;                       
            area = ObtenerBase() * ObtenerAltura();

            return area;
        }

       public decimal CalcularPerimetro()
        {
            decimal perimetro;                       
            perimetro = (ObtenerBase() + ObtenerAltura()) * 2;

            return perimetro;
        }



    }
}
