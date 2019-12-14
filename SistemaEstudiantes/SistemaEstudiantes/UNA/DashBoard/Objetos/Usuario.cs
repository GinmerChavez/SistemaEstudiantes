namespace UNA.DashBoard.Objetos
{
    public class Usuario
    {
        public string Nombre
        {
            set;
            get;
        }

        public string Contraseña
        {
            set;
            get;
        }

        public Usuario()
        {
        }
        public bool Autenticar = true;
    }
}