using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductoNegocio
    {
        ProductoDatos productos;
        public ProductoNegocio()
        {
            productos = new ProductoDatos();
        }
        public List<Producto> All()
        {
            return productos.Listar();
        }

        public Producto ById(int id)
        {
            return productos.lista().Where(p=>p.idProducto==id).SingleOrDefault();
        }
        public bool insertarProducto(Producto productoNuevo)
        { 
        return productos.Nuevo(productoNuevo);
        
        }
        public bool EliminarProducto(Producto productoNuevo)
        {
            return productos.Nuevo(productoNuevo);

        }
    }
}
