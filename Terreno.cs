using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_Herencia
{
    class Terreno : Inmuieble, IAcciones
    {
        public double CalcularCosto(double avaluo)
        {
            return avaluo * 1.16;
        }

        public double Cotizacion(double enganche, int materiales)
        {
            throw new NotImplementedException();
        }

        public override void Detalles()
        {
            base.Detalles();
            Console.WriteLine("CLASE TERRENO");
        }
    }
}
