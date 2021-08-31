using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClase
{
    class Alumno
    {
        

        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Nota { get; set; }

       public string ObtenerNombresCompletos()
        {
            string result = "";
            result = Nombres + " " + Apellidos;
            return result; 
        }
        public string EstaAprobado()
        {
            string result = "";
            if (Nota > 14)
                result = "Aprobado";
            else
                result = "Desaprobado";
            return result;
        }
        
    }
}
