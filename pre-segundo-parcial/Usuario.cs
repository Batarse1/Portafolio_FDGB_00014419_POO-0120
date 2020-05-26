namespace pre_segundo_parcial
{
    public class Usuario
    {
        public string usuario { get; set; }

        public int idUsuario { get; set; }
        public string contrasena { get; set; }
        public string admin { get; set; }

        public Usuario()
        {
            idUsuario = 0;
            usuario = "";
            contrasena = "";
            admin = "";
        }
    }
}