using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace decorator
{
    public class Edulcorante : AgregadoDecorator
    {
        public Edulcorante(Bebida bebida) : base(bebida)
        {
        }
        public override float Costo()
        {
            return base.Costo() + 0.5f;
        }
        public override string Descripcion()
        {
            return base.Descripcion() + ", Edulcorante";
        }
    }
}