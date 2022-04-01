using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Proyecto_Final
{
    internal class Joyas : Producto
    {
        public override void PRODUCTO()
        {
            base.PRODUCTO();
        }
        int cantidad = 0;



        public void JOYERIA()
        {
            int subtotal1 = 0;
            int subtotal2 = 0;
            int subtotal3 = 0;
            int subtotal4 = 0;
            Producto producto = new Producto();
            producto.PRODUCTO();
            string nombre = Console.ReadLine();


            if (nombre == "Cadenas")
            {
               
                Console.WriteLine("Numero de Cadenas que desea comprar");
                cantidad = int.Parse(Console.ReadLine());
                subtotal1 = cadenas * cantidad;
                Console.WriteLine("El total de las cadenas es de $" + subtotal1);
                Console.WriteLine("Desea agregar otra cosa?");
                Console.WriteLine("Presiona (1) para si y (2) para pagar");
                int m = int.Parse(Console.ReadLine()); 
                if (m == 1) { JOYERIA(); }
                if (m == 2) { COMPRA(); }
            }
            if (nombre == "Aretes")
            {
                Console.WriteLine("Numero de pares de Aretes que desea comprar");
                cantidad = int.Parse(Console.ReadLine());
                subtotal2 = aretes * cantidad;
                Console.WriteLine("El total de los pares de aretes es de $" + subtotal2);
                Console.WriteLine("Desea agregar otra cosa?");
                Console.WriteLine("Presiona (1) para si y (2) para pagar");
                int m = int.Parse(Console.ReadLine()); 
                if (m == 1) { JOYERIA(); }
                if (m == 2) { COMPRA(); }
            }          

            if (nombre == "Dijes")
            {
                
                Console.WriteLine("Numero de Dijes que desea comprar");
                cantidad = int.Parse(Console.ReadLine());
                subtotal3 = dijes * cantidad;
                Console.WriteLine("El total de los dijes es de $" + subtotal3);
                Console.WriteLine("Desea agregar otra cosa?");
                Console.WriteLine("Presiona (1) para si y (2) para pagar");
                int m = int.Parse(Console.ReadLine());
                if (m == 1) { JOYERIA(); }
                if (m == 2) { COMPRA(); }
                
                    
                
            }

                if (nombre == "Pulsos")
                {

                    Console.WriteLine("Numero de Pulsos que desea comprar");
                    cantidad = int.Parse(Console.ReadLine());
                    subtotal4 = pulsos * cantidad;
                    Console.WriteLine("El total de los pulsos es de $" + subtotal4);
                    Console.WriteLine("Desea agregar otra cosa?");
                    Console.WriteLine("Presiona (1) para si y (2) para pagar");
                    int m = int.Parse(Console.ReadLine());
                    if (m == 1) { JOYERIA(); }
                    if (m == 2) { COMPRA(); }
                }
        }
        public static void COMPRA()
        {
            Console.WriteLine(" Inserte la cantidad con que pagara ");
            int pago = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------GRACIAS POR SU COMPRA---------");
            Console.ReadKey();
        }

    }
}
