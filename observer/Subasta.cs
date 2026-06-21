using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace observer
{
    public class Subasta
    {
        List<ICliente> clientes = new List<ICliente>();
        public Subasta()
        {

        }

        public void NotificarClientes(string mensaje)
        {
            foreach (var cliente in clientes)
            {
                cliente.Actualizar(mensaje);
            }
        }
        public void AgregarCliente(ICliente cliente)
        {
            clientes.Add(cliente);
        }
        public void EliminarCliente(ICliente cliente)
        {
            clientes.Remove(cliente);
        }
    }
}