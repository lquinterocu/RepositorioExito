using System;
using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioConsola
    {
        public void GuardarConsola(Consola consola);

        public void EliminarConsola(int Id);

        public Consola ActualizarConsola(Consola consola);

        public Consola ConsultarConsola(string nombre);
    }
}