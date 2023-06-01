using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_Herencia
{
    interface IAcciones
    {
        double CalcularCosto(double avaluo);
        double Cotizacion(double enganche, int materiales);
    }
}
