using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstract_factory
{
    public class MotherboardIntel : IMotherboard
    {
        public MotherboardIntel() { }
        public string Modelo()
        {
            return "Motherboard Intel";
        }
    }
}