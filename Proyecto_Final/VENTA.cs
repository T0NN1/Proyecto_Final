using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class Joyas
    {

        public static string Cadenas { get; set; }
        public static string Aretes { get; set; }
        public static string Dijes { get; set; }
        public static string Pulsos { get; set; }


        public void JOYERIA()
        {
            Console.WriteLine("----------JOYERIA DISPONIBLE----------");
            Console.WriteLine("Cadenas, Aretes, Dijes y Pulsos");
            Console.WriteLine("Nombre del producto");

            string nombre = Console.ReadLine(); 
         
                if (nombre == "Cadenas")
                {

                    Console.WriteLine("Numero de Cadenas que desea comprar");
                    int cantidad = int.Parse(Console.ReadLine());
                }
                
                if (nombre == "Aretes")
                {
                     
                    Console.WriteLine("Numero de pares de Aretes que desea comprar");
                    int cantidad = int.Parse(Console.ReadLine());

                }

                if (nombre == "Dijes")
                {

                   Console.WriteLine("Numero de Dijes que desea comprar");
                   int cantidad = int.Parse(Console.ReadLine());
                }
            
            
                if (nombre == "Pulsos")
                {

                    Console.WriteLine("Numero de Pulsos que desea comprar");
                    int cantidad = int.Parse(Console.ReadLine());
                }
                
            
                Console.WriteLine("Desea agregar otra cosa?");
                Console.WriteLine("Presiona (1) para si y (2) para pagar");
                int m = int.Parse(Console.ReadLine());
            switch (m)
            {
                case 1:
                    Console.Clear();
                    Joyas joyas = new Joyas();
                    joyas.JOYERIA();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Inserta la cantidad con la que pagaras");
                    int pago = int.Parse(Console.ReadLine());
                    Console.WriteLine("GRACIAS POR TU COMPRA");
                    Console.WriteLine("Preciona (3) para salir");
                    break;
            }
            int c = int.Parse(Console.ReadLine());
            switch (c) { case 3: Console.Clear();
                                 Console.WriteLine("ADIOS!!");
                                 Console.ReadKey();
                                 break;
            }

            
            
        }
    }
}
