using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_Herencia
{
    class Inmuieble
    {
        //Campos (variables globales)
        protected string nombreDueno,calle, colonia, ciudad, esatdo, numeroInmueble, codigoPostal;
        int metrosCuadrados;
        double precio;
        protected int numeroEscritura;

        //Constructor (sobrecargar conctructor)
        public Inmuieble() { }

        public Inmuieble(string nombreDueno, string calle,
            string colonia, string ciudad, string esatdo,
            string numeroInmueble, string codigoPostal, int metrosCuadrados, int numeroEscrituras)
        {
            //Asignar valores de los paramatros a variables globales
            this.nombreDueno = nombreDueno;
            this.calle = calle;
            this.colonia = colonia;
            this.ciudad = ciudad;
            this.esatdo = esatdo;
            this.numeroInmueble = numeroInmueble;
            this.codigoPostal = codigoPostal;
            this.metrosCuadrados = metrosCuadrados;
            this.numeroEscritura = numeroEscrituras;
        }

        public Inmuieble(string nombreDueno, string calle,
            string colonia, string ciudad, string esatdo,
            string numeroInmueble, string codigoPostal, int metrosCuadrados)
        {
            //Asignar valores de los paramatros a variables globales
            this.nombreDueno = nombreDueno;
            this.calle = calle;
            this.colonia = colonia;
            this.ciudad = ciudad;
            this.esatdo = esatdo;
            this.numeroInmueble = numeroInmueble;
            this.codigoPostal = codigoPostal;
            this.metrosCuadrados = metrosCuadrados;
        }

        //POLIMORFISMO
        public virtual void Detalles() {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El Cliente {0}, es proíetario " +
                "de un inmueble en la calle {1}, colonia {2}, " +
                "ciudad {3}.", nombreDueno, calle, colonia, 
                ciudad);
            Console.WriteLine("Gracias. \n \n");
        }

        //Tarea: asignar valores y sobrecargar el constructor


    }
}
