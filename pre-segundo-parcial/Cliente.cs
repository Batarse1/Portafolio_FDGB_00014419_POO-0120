using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace pre_segundo_parcial
{
    public partial class Cliente : Form
    {
        public int idC;
        public Cliente(Usuario cliente)
        {
            idC=cliente.idUsuario;
            InitializeComponent();
            
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM PRODUCTO";

            DataTable dt = ConnectionBD.realizarConsulta(sql);
            List<Producto> lista = new List<Producto>();
            foreach (DataRow fila in dt.Rows)
            {
                Producto p = new Producto();
                p.idProducto=Convert.ToInt32(fila[0].ToString());
                p.nombre = fila[1].ToString();
                p.precio =Convert.ToDouble(fila[2].ToString());
                p.cantidad=Convert.ToInt32(fila[3].ToString());
                p.descripcion=fila[4].ToString();
                lista.Add(p);
            }

            comboBox1.DisplayMember = "nombre";
            comboBox1.DataSource = lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = idC;
                Producto p = (Producto) comboBox1.SelectedItem;
                int idProducto = Convert.ToInt32(p.idProducto);
                int cantidad = Convert.ToInt32(textBox1.ToString());
                double precio = p.precio*cantidad;
                string nonquery = $"INSERT INTO PEDIDO (idUsuario,idProducto, cantidadP, precio) VALUES ({idUsuario},{idProducto},{cantidad},{precio})";
                ConnectionBD.realizarAccion(nonquery);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}