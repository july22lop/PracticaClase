using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.Negocio
{
    class ClsPersona
    {
        public String MostrarNombre(Persona per)
        {
            return per.Nombre;

        }
        public int Acceso(Persona per)
        {
            if (per.Nombre == "Julissa") per.Password == "123"
            {

                return 1;
            }
            else 
            { 
            
            }
        
        }
    }
}
