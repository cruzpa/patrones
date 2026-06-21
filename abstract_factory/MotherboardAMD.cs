using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstract_factory
{
    public class MotherboardAMD : IMotherboard
    {
        public MotherboardAMD() { }
        public string Modelo()
        {
            return "Motherboard AMD";
        }
    }
}