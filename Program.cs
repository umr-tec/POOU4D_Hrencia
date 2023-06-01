using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Departamento objDepartamento = new Departamento(3,"UMR","De los pinos","Sendas del bosque","Torreón","Coahuila","66","27442",246);
            objDepartamento.Detalles();
            // Departamento objDepartamento1 = new Departamento(13);

            Terreno objTerreno = new Terreno();
            objTerreno.Detalles();

            Console.ReadKey();
        }
    }
}
