using System;
using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioVideojuego
    {


        public void GuardarVideojuego(Videojuego videojuego);

        public void EliminarVideojuego(int Id);

        public Videojuego ActualizarVideojuego(Videojuego videojuego);

        public Videojuego ConsultarVideojuego(string cedula);


    }
}