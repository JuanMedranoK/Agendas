using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ServiceItem
    {
        public Serializador Serializa;
        public string Filename;
        public string Directory;
        public ServiceItem()
        {
            Serializa = new Serializador();
            Directory = "Cliente";
            Filename = "Cliente.dat";

        }
        public void Agregar(Client item)
        {
            Repositorio.Instance.Cliente.Add(item);
            Serializa.Serialize(Repositorio.Instance.Cliente,Directory,Filename);
        }
        public void Editar(int index, Client item)
        {
            Repositorio.Instance.Cliente[index] = item;
            Serializa.Serialize(Repositorio.Instance.Cliente, Directory, Filename);
        }
        public void Borrar(int index)
        {
            Repositorio.Instance.Cliente.RemoveAt(index);
            Serializa.Serialize(Repositorio.Instance.Cliente, Directory, Filename);
        }

        public List<Client> GetAll()
        {
            List<Client> Clientes = (List<Client>)Serializa.Deserialize(Directory, Filename);

            if(Clientes != null)
            {
               Repositorio.Instance.Cliente = Clientes;
                return Repositorio.Instance.Cliente;

            }
            else
            {
                return Repositorio.Instance.Cliente;
            }
        }
        public Client GetByIndex(int index)
        {
            return Repositorio.Instance.Cliente[index];
        }

        
    }
}
