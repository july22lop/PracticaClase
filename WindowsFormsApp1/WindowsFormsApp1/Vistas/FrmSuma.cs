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
    public partial class FrmSuma : Form
    {
        public FrmSuma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                double ope = Convert.ToString(textBox1.Text);
                double ope2 = Convert.ToString(textBox2.Text);
                double re = Convert.ToString(textBox3.Text);

                re = ope + ope2;

                textBox3.Text = re.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Operacion incompleta");

            }
        }

    }

}
