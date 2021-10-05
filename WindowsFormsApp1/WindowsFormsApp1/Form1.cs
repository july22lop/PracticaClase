using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Persona per = new Persona();
            //per.Nombre = CapturarDatos.Text;
            //ClsPersona Persona = new ClsPersona();
            //String nombre = Persona.MostrarNombre(per);
            //MessageBox.Show(nombre);


            Persona per = new Persona();

            Persona


            per.Nombre = TxtCapturarDatos.Text;
            per.Password = TxtCapturadorPassword.Text;
            ClsPersona Persona = new ClsPersona();
            int valor = Persona.Acceso(per);
            //_ = valor;

            if (valor == 1){
                //MessangeBox.Show("welcom");

                Venta venta = new Venta();
                venta.Show();
            }
            else { MessageBox.Show("Error");  
            }

        }
    }
}
