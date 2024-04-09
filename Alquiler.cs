using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inmobiliaria.Propiedad;

namespace Inmobiliaria
{
    public class Alquiler
    {
        public Propiedad Propiedad { get; set; }
        public Cliente Cliente { get; set; }
        public int CantidadDias { get; set; }

        public double MontoTotal()
        {
            return Propiedad.PrecioPorDia * CantidadDias;
        }

        public double MontoDescuento()
        {
            switch (Propiedad.Tipo)
            {
                case TipoPropiedad.Casa:
                    return 0.1;
                case TipoPropiedad.Apartamento:
                    return 0.05;
                case TipoPropiedad.Oficina:
                    return 0;
            }

            return 0;
        }

        public double MontoAPagar()
        {
            return MontoTotal() - MontoDescuento();
        }
    }
}
