using System;
using System.Collections.Generic;
using System.Text;

namespace Service_PowerMontero
{
    class Tractor: ICampana
    {
        //Atributos de la clase
        String Marca;
        int  Precio; 


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
                Impresora.GetImprimir();//La instancia de la clase Impresora que trae su metodo
                                        //que imprimira los datos..
               

            }
            if(opcionImp == 2)
            {
                Console.WriteLine("Gracias por su compra! :)");
            }

        }

        //Metodo comprovante que guarda los datos ingresados al sistema
        public void Comprobante()
        {
            var fecha = DateTime.Now;//Fecha del sistema...
            Console.WriteLine("Equipo rentado: Tractor");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Fecha: "+ fecha.ToString("d"));//Fecha del sistema...
            Console.WriteLine("Hora: " + fecha.ToString("t"));//Hora del sistema

        }
    }
}
