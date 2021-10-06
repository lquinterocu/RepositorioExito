using System;

namespace Dominio
{
    public class Factura
    {
        public int Id {get;set;}
        public int NumeroFactura{get;set;}
        public string Sucursal{get;set;}
        public int CantidadProductos{get;set;}
        public bool CompraVenta{get;set;}
    }
}
