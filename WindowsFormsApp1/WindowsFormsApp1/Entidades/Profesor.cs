using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class Profesor
    {
        private String nombre;
        private int direccion;
        private int fechadenac;
        private String genero;
        private String titulo;
        private String designacion;
        private String dedicacion;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Direccion { get => direccion; set => direccion = value; }
        public int Fechadenac { get => fechadenac; set => fechadenac = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Designacion { get => designacion; set => designacion = value; }
        public string Dedicacion { get => dedicacion; set => dedicacion = value; }
    }
}
