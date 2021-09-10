using System;
using System.Collections.Generic;
using System.Text;

namespace Service_PowerMontero
{
    //Clase Factory y que implementara la funcion del mismo
    class Factory
    {
        public static ICampana opciones(int opcion) 
        {
            if (opcion == 1)
            {
                return new Gruas();
            }
            if (opcion == 2)
            {
                return new Escalera_hidraulica();
            }
            if (opcion == 3)
            {
                return new Retroexcabadora();
            }
            if (opcion == 4)
            {
                return new Tractor();
            }
            return null;
        }
            
    }
}
