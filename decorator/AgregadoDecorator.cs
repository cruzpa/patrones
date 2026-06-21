using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace decorator
{
    public abstract class AgregadoDecorator : Bebida
    {
        public Bebida bebida;

        public AgregadoDecorator(Bebida bebida)
        {
            this.bebida = bebida;
        }
        public virtual float Costo()
        {
            return bebida.Costo();
        }
        public virtual string Descripcion()
        {
            return bebida.Descripcion();
        }
    }
}