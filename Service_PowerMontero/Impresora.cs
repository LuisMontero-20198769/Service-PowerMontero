using System;
using System.Collections.Generic;
using System.Text;

namespace Service_PowerMontero
{
    class Impresora
    {
        private static Impresora imprimir; //Instancia de la clase
        int valor; //variable declarada

        //Constructor de la clase
        private Impresora()
        {
            switch (valor)
            {
                //Cada caso u opcion traera su propio comprobante...
                case 1:
                    Gruas grua = new Gruas();//Objeto de la clase Gruas
                    grua.Comprobante();

                    break;

                case 2:
                    Escalera_hidraulica escalaera = new Escalera_hidraulica();
                    escalaera.Comprobante();

                    break;

                case 3:
                    Retroexcabadora exc = new Retroexcabadora();
                    exc.Comprobante();

                    break;

                case 4:
                    Tractor tr = new Tractor();
                    tr.Comprobante();
                    break;
            }

        }

        public static Impresora GetImprimir()
        {
            //Este condicional evaluara si existe una instancia de la clase Impresora
            if (imprimir == null) //Si es null, es decir, que no existe...
            {
                imprimir = new Impresora();//Pues, procedera a crear una

                return imprimir;//Aqui se retorna la instancia ya sea creada o ya existente
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n La impresión de más de un comprobante no es valida ._.");
                return imprimir;
            }
            
        }
    }
}
