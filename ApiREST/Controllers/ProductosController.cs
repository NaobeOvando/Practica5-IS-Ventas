using AccesoDatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
// NOMBRE APELLIDOS: Naobe Ovando
// PARALELO: 1
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/4/2024
// PRÁCTICA No. #


namespace ApiREST.Controllers
{
    public class ProductosController : ApiController
    {
        ProductoNegocio productoNegocio = new ProductoNegocio();

        //Get
        public IHttpActionResult Get()
        {
            var respuesta = productoNegocio.All();
            return Ok(respuesta);

        }
        public IHttpActionResult Get(int id)
        {
            Producto producto = productoNegocio.ById(id);
            if (producto != null)
            {
                return Ok(producto);
            }
            return NotFound();

        }
        public IHttpActionResult Post(Producto producto)
        {
            productoNegocio.insertarProducto(producto);
            return Ok("Insertado correctamente");
        }
        public IHttpActionResult Delete(int id)
        {
            Producto producto = productoNegocio.ById(id);
            if (producto != null)
            {
                productoNegocio.EliminarProducto(producto);
                return Ok("Eliminado correctamente");
            }
            return NotFound();
        } }
    }
