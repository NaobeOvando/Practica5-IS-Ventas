using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteDatos : IDatos<Cliente>
    {
        serviciosEntities contexto;

        public List<Cliente> lista()
        {
            return contexto.Cliente.ToList();
        }

        public bool Nuevo(Cliente Cliente)
        {
            if (contexto.Cliente.Add(Cliente) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public ObjectResult listarClientesCategoria()
        {
            return contexto.SP_Clientes();
        }


        public List<Cliente> Listar()
        {
            throw new NotImplementedException();
        }
        public Cliente BuscarID(int id)
        {
            return contexto.Cliente.Where(p => p.id == id).FirstOrDefault();
        }
        public bool Actualizar(Cliente item)
        {
            Cliente temp = new Cliente();
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Cliente item)
        {
            Cliente temp = BuscarID(item.id);
            if (temp != null)
            {
                contexto.Cliente.Remove(temp);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
