using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class Producto : Interface1
    {
        public int cadenas = 200;
        public int aretes = 150;
        public int dijes = 230;
        public int pulsos = 250;
        
        

        public int Aretes()
        {
            return 150;
        }

        public int Cadenas()
        {
            return 200;
        }

        public int Dijes()
        {
            return 230;
        }
        public int Pulsos()
        {
            return 250;
        }

        public virtual void PRODUCTO()
        {
            Console.WriteLine("----------JOYERIA DISPONIBLE----------");
            Console.WriteLine("Cadenas $" + cadenas + " Aretes $" + aretes + " Dijes $" + dijes + " Pulsos $" + pulsos);
            Console.WriteLine("Nombre del producto");
        }

    }
}
