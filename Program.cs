using System;

namespace MovieLibrary
{

    public class AplicacionPeliculas 
    {
        public string nombre;
        public string URL;
        public string logo;
        public string dueña;
        void AbrirAplicacion()
        {
            Console.WriteLine("Bienvenido a la aplicación");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var aplicacionPeliculas = new AplicacionPeliculas(); 
            aplicacionPeliculas.nombre = "Flick Fridays";
            aplicacionPeliculas.URL = "www.flickfridays.com";
            aplicacionPeliculas.logo = "logo.png";

        }
    }
}
