using System;
using System.Windows.Forms;

namespace pre_segundo_parcial
{
    public partial class Admin : Form
    {
        public Admin(Usuario administrador)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionBD.realizarAccion(textBox1.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}