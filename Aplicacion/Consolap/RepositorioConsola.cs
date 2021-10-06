using System;
using Persistencia;
using Dominio;
using System.Linq;

namespace Consolap
{
    public class RepositorioConsola : IRepositorioConsola
    {
        Conexion conexion= new Conexion();

        public void GuardarConsola(Consola consola){
            conexion.Consolas.Add(consola);
            conexion.SaveChanges();
        }

        public void EliminarConsola(int Id){
            var consola= conexion.Consolas.First(e=> e.id==Id);
            conexion.Consolas.Remove(consola);
            conexion.SaveChanges();
        }

        public Consola ActualizarConsola(Consola consola){
            var consolaBusqueda= conexion.Consolas.First(c=> c.id==consola.id);
            consolaBusqueda.Nombre =consola.Nombre;
            consolaBusqueda.Version =consola.Version;
            consolaBusqueda.Fabricante =consola.Fabricante;
            consolaBusqueda.PrecioCompra =consola.PrecioCompra;
            consolaBusqueda.PrecioVenta =consola.PrecioVenta;
            consolaBusqueda.Almacenamiento =consola.Almacenamiento;
            consolaBusqueda.Disco =consola.Disco;
            consolaBusqueda.MemoriaRam =consola.MemoriaRam;
            consolaBusqueda.VelocidadProcesamiento =consola.VelocidadProcesamiento;
            consolaBusqueda.NumeroControles =consola.NumeroControles;
            conexion.SaveChanges();
            return consolaBusqueda;
        }

        public Consola ConsultarConsola(string nombre){
            var consola= conexion.Consolas.First(e=> e.Nombre==nombre);
            return consola;
        }

    }
}