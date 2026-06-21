using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace observer
{
    public class Cliente : ICliente
    {
        public string Nombre { get; set; }
        public Cliente(string nombre)
        {
            Nombre = nombre;
        }
        public void Actualizar(string mensaje)
        {
            Console.WriteLine($"Cliente {Nombre} recibió el mensaje: {mensaje}");
        }
    }
}