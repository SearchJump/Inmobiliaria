using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria
{
    public class Propiedad
    {
        public enum TipoPropiedad
        {
            Casa,
            Apartamento,
            Oficina
        }

        public TipoPropiedad Tipo{ get; set; }
        public double PrecioPorDia { get; set; }
    }
}
