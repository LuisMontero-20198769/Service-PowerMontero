using System;
using System.Collections.Generic;
using System.Text;

namespace Service_PowerMontero
{
    class Escalera_hidraulica : ICampana
    {
        //Atributos de la clase
        String Marca;
        int Precio;
        public void Servicios()
        {
            Console.Write("-- Ingrese la marca del vehiculo: ");
            Marca = Console.ReadLine();
            Console.Write("-- Ingrese el precio: ");
            Precio = int.Parse(Console.ReadLine());

            Console.WriteLine("\n==> Quieres imprimir un compovante? ----");
            Console.WriteLine("\n 1) Si.");
            Console.WriteLine(" 2) No.");
            Console.WriteLine("\n Elige la opcion deseada: ");
            int opcionImp = int.Parse(Console.ReadLine());//Lee la variable
            Console.WriteLine();//Salto de linea

            if (opcionImp == 1)
            {
                Comprobante();//Llamamos al metodo comprovante 
                Impresora.GetImprimir();

            }
            if (opcionImp == 2)
            {
                Console.WriteLine("Gracias por su compra! :)");
            }

        }

        public void Comprobante()
        {
            var fecha = DateTime.Now;//Fecha del sistema...
            Console.WriteLine("Equipo rentado: Escalera Hidraulica");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Fecha: " + fecha.ToString("d"));
            Console.WriteLine("Hora: " + fecha.ToString("t"));

        }
    }
}
