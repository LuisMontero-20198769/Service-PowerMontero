using System;

namespace Service_PowerMontero
{
    class Menu
    {

        static void Main(string[] args)
        {
            int opcion; //variable declarada
            do
            {
                Console.Clear();//Limpiar la pantalla...
                //Menu principal de la Empresa Service Power Montero & Asoc.
                Console.WriteLine("***** Service Power Montero & Asoc. ***** \n");
                Console.WriteLine("\n Menu Principal:");
                Console.WriteLine("\n1) Gruas.");
                Console.WriteLine("2) Escalera Hidraulica.");
                Console.WriteLine("3) Retroexcabadora.");
                Console.WriteLine("4) Tractor.");
                Console.WriteLine("5) Salir.\n");
                Console.WriteLine("Eliga la opcion deseada: ");

                opcion = int.Parse(Console.ReadLine());//Aqui se lee el valor de la variable

                if(opcion == 5) 
                {
                    Console.Clear();//limpiador de pantalla....
                    Console.WriteLine("\n Ha colminado el servicio. Vuelva pronto!");
                    Console.WriteLine("\n Press 'ENTER' para cerrar ventana....");
                    Environment.Exit(0);//Metodo que cierra el programa.
                }
                ICampana select = Factory.opciones(opcion);
                select.Servicios();
                Console.ReadKey();

            } while (opcion != 0); //Condicion para finalizar el ciclo do-while (hacer-mientras)
        }
    }
}
