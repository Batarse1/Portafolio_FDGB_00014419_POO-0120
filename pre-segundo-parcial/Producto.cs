namespace pre_segundo_parcial
{
    public class Producto
    {
        public string nombre { get; set; }
        public int idProducto { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        
        public Producto()
        {
            nombre = "";
            idProducto = 0;
            descripcion = "";
            cantidad = 0;
            precio=0.0d;
        }
    }
}