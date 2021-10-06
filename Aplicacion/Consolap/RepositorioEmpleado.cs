using System;
using Persistencia;
using Dominio;
using System.Linq;

namespace Consolap
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        Conexion conexion= new Conexion();
        

        public void GuardarEmpleado(Empleado empleado){
            conexion.Empleados.Add(empleado);
            conexion.SaveChanges();
        }

        
        public void EliminarEmpleado(int Id){
            var empleado = conexion.Empleados.First(e=> e.id==Id);
            conexion.Empleados.Remove(empleado);
            conexion.SaveChanges();
        }

        public Empleado ActualizarEmpleado(Empleado empleado){
            var empleadoBusqueda= conexion.Empleados.First(e=> e.id==empleado.id);
            empleadoBusqueda.Nombre =empleado.Nombre;
            empleadoBusqueda.Apellido =empleado.Apellido;
            empleadoBusqueda.Cedula =empleado.Cedula;
            empleadoBusqueda.RolEmpleado =empleado.RolEmpleado;
            empleadoBusqueda.CodigoEmpleado =empleado.CodigoEmpleado;
            empleadoBusqueda.Sucursal =empleado.Sucursal;
            empleadoBusqueda.Usuario =empleado.Usuario;
            empleadoBusqueda.Password =empleado.Password;
            conexion.SaveChanges();
            return empleadoBusqueda;
        }

        public Empleado ConsultarEmpleadoCedula(string cedula){
            var empleado = conexion.Empleados.First(e=> e.Cedula==cedula);
            return empleado;
        }

    }
}