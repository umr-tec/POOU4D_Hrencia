using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_Herencia
{
    class Departamento : Inmuieble
    {
        int numeroPiso, numeroInterior;
        //Constructores
        public Departamento() { }

        public Departamento(int numeroPiso, string nombreDueno, string calle,
            string colonia, string ciudad, string esatdo,
            string numeroInmueble, string codigoPostal,
            int metrosCuadrados, int numeroEscrituras) 
            :base(nombreDueno,calle,colonia,ciudad,esatdo,
                 numeroInmueble,codigoPostal,metrosCuadrados,
                 numeroEscrituras)
        {
            //Asigar el valor del parametro al campo
            this.numeroPiso = numeroPiso;           
        }

        public Departamento(int numeroPiso, string nombreDueno, string calle,
            string colonia, string ciudad, string esatdo,
            string numeroInmueble, string codigoPostal,
            int metrosCuadrados)
            : base(nombreDueno, calle, colonia, ciudad, esatdo,
                 numeroInmueble, codigoPostal, metrosCuadrados)
        {
            //Asigar el valor del parametro al campo
            this.numeroPiso = numeroPiso;
        }

        public Departamento(int numeroPiso, int numeroInterior, string nombreDueno, string calle,
            string colonia, string ciudad, string esatdo,
            string numeroInmueble, string codigoPostal,
            int metrosCuadrados)
            : base(nombreDueno, calle, colonia, ciudad, esatdo,
                 numeroInmueble, codigoPostal, metrosCuadrados)
        {
            //Asigar el valor del parametro al campo
            this.numeroPiso = numeroPiso;
            this.numeroInterior = numeroInterior;
        }


        //Generar metodos poliformicos
        public override void Detalles()
        {
            
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Información del departamento");
            Console.WriteLine("Numero de piso {0}, número interior {1}", numeroPiso, numeroInterior);
            base.Detalles();
        }

    }
}
