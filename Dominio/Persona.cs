using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        string nombre;
        string apellido;
        string documento;
        int edad;
        

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Documento { get => documento; set => documento = value; }
        public int Edad { get => edad; set => edad = value; }
       
       

    }
}
