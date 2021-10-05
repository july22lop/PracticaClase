using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Vistas
{
    public partial class Estudiante : Form
    {
        public Estudiante()
        {
            InitializeComponent();
        }

        private void Estudiante_Load(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.MdiParent = this;
            estudiante.Show();

        }
    }
}
