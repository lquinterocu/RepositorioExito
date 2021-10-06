using System;
using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioEmpleado
    {


        public void GuardarEmpleado(Empleado empleado);

        public void EliminarEmpleado(int Id);

        public Empleado ActualizarEmpleado(Empleado empleado);

        public Empleado ConsultarEmpleadoCedula(string cedula);


    }
}