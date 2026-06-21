using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factory_method
{
    public class PizzeriaArgentina : Pizzeria
    {
        public override Pizza CrearPizza()
        {
            return new PizzaCancha();
        }
    }
}