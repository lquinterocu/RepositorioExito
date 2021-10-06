using System;
using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioControles
    {
        public void GuardarControles(Controles controles);

        public void EliminarControles(int Id);

        public Controles ActualizarControles(Controles controles);

        public Controles ConsultarControles(string nombre);
    }
}