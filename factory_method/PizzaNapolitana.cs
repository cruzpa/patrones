using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factory_method
{
    public class PizzaNapolitana : Pizza
    {
        public override void Preparar()
        {
            Console.WriteLine("Preparando pizza napolitana...");
        }
    }
}