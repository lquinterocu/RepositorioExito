using System;
using Dominio;
using Persistencia;
using System.Linq;

namespace Consolap
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RepositorioVideojuego repositorioVideojuego= new RepositorioVideojuego();
            
            Videojuego videojuego = new Videojuego();
            
            
            videojuego=repositorioVideojuego.ConsultarVideojuego("psp");
            
            
            

            

            
            
        }
    }
}
