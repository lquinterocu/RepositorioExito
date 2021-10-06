using System;
using Persistencia;
using Dominio;
using System.Linq;


namespace Consolap
{
    public class RepositorioVideojuego  : IRepositorioVideojuego
    {
        Conexion conexion= new Conexion();

        public void GuardarVideojuego(Videojuego videojuego){
            conexion.Videojuegos.Add(videojuego);
            conexion.SaveChanges();
        }

        public void EliminarVideojuego(int Id){
            var videojuego= conexion.Videojuegos.First(v=> v.id==Id);
            conexion.Videojuegos.Remove(videojuego);
            conexion.SaveChanges();
        }

        public Videojuego ActualizarVideojuego(Videojuego videojuego){
            var videojuegoBusqueda= conexion.Videojuegos.First(c=> c.id==videojuego.id);
            videojuegoBusqueda.Nombre =videojuego.Nombre;
            videojuegoBusqueda.Version =videojuego.Version;
            videojuegoBusqueda.Fabricante =videojuego.Fabricante;
            videojuegoBusqueda.PrecioCompra =videojuego.PrecioCompra;
            videojuegoBusqueda.PrecioVenta =videojuego.PrecioVenta;
            videojuegoBusqueda.Multiplataformausing =videojuego.Multiplataformausing;
            conexion.SaveChanges();
            return videojuegoBusqueda;
        }

        public Videojuego ConsultarVideojuego(string nombre){
            var videojuego= conexion.Videojuegos.First(v=> v.Nombre==nombre);
            return videojuego;
        }

    }
}