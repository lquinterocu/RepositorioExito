using System;
using Persistencia;
using Dominio;
using System.Linq;

namespace Consolap
{
    public class RepositorioControles : IRepositorioControles
    {
        Conexion conexion= new Conexion();

        public void GuardarControles(Controles controles){
            conexion.Controless.Add(controles);
            conexion.SaveChanges();
        }

        public void EliminarControles(int Id){
            var controles= conexion.Controless.First(e=> e.id==Id);
            conexion.Controless.Remove(controles);
            conexion.SaveChanges();
        }

        public Controles ActualizarControles(Controles controles){
            var controlesBusqueda= conexion.Controless.First(c=> c.id==controles.id);
            controlesBusqueda.Nombre =controles.Nombre;
            controlesBusqueda.Version =controles.Version;
            controlesBusqueda.Fabricante =controles.Fabricante;
            controlesBusqueda.PrecioCompra =controles.PrecioCompra;
            controlesBusqueda.PrecioVenta =controles.PrecioVenta;
            controlesBusqueda.Tipo =controles.Tipo;
            conexion.SaveChanges();
            return controlesBusqueda;
        }

        public Controles ConsultarControles(string nombre){
            var controles= conexion.Controless.First(e=> e.Nombre==nombre);
            return controles;
        }

    }
} 