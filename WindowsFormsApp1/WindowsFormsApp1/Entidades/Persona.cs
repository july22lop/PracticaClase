using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class Persona
    {

        private string nombre;
        private string password;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Password { get => password; set => password = value; }
    }
}