using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_Herencia
{
    class Terreno : Inmuieble
    {


        public override void Detalles()
        {
            base.Detalles();
            Console.WriteLine("CLASE TERRENO");
        }
    }
}
