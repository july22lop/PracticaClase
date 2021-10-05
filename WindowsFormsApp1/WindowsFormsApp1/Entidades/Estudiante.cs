using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class Estudiante : Persona
    {
        private String carrera;
      

        public string Carrera { get => carrera; set => carrera = value; }
    }
}
