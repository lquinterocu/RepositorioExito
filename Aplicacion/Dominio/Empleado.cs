using System;

namespace Dominio
{
    public class Empleado
    {
        public int id{get;set;}
        public string Nombre{get;set;}
        public string Apellido{get;set;}
        public string Cedula{get;set;}
        public NombreRol RolEmpleado{get;set;}
        public int CodigoEmpleado{get;set;}
        public string Sucursal{get;set;}
        public string Usuario{get;set;}
        public string Password{get;set;}
    }
}
