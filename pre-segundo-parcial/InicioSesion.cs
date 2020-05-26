using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace pre_segundo_parcial
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.Equals(textBox2.Text))
            {
                Usuario u = (Usuario) comboBox1.SelectedItem;

                if (u.admin.Equals("usuario común"))
                {
                     Cliente ventana = new Cliente(u);
                     ventana.Show();
                     this.Hide();   
                }
                else
                {

                    Admin ventana = new Admin(u);
                    ventana.Show();
                    this.Hide();                    
                }
            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "Clase GUI 05",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "contrasena";
            comboBox1.DisplayMember = "usuario";
            
            string sql = "SELECT * FROM USUARIO";

            DataTable dt = ConnectionBD.realizarConsulta(sql);
            Console.WriteLine(dt);
            List<Usuario> lista = new List<Usuario>();
            foreach (DataRow fila in dt.Rows)
            {
                Usuario u = new Usuario();
                u.idUsuario = Convert.ToInt32(fila[0].ToString());
                u.usuario = fila[1].ToString();
                u.contrasena = fila[2].ToString();
                u.admin = fila[3].ToString();
                lista.Add(u);
            }

            comboBox1.DataSource = lista;
        }
    }
}