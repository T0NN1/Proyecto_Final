using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto_Final
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            int sc;
                do
                {
                    MENU();
                    MENU1();
                 try { 
                    Console.WriteLine("Precione (1) Para ver las opciones");
                    sc = int.Parse(Console.ReadLine());
                  }
                  catch { throw new MarkoException("Error!!! Solo puedes poner numeros"); }
                    switch (sc)
                    {
                        case 1:
                            Console.Clear();
                            Joyas joyeria = new Joyas();
                        joyeria.JOYERIA();
                        
                        break;
                    }
                  
                } while (sc != 1);
           
           
        }
        public static void MENU()
        {
            StreamWriter fichero;
            string nombrefichero = "C:\\Users\\walmart\\Documents\\Proyecto\\"  + ".txt"; 
            fichero = File.CreateText(nombrefichero);
            fichero.WriteLine("----------BIENBENIDOS--------------");
            fichero.WriteLine("---------FragaR joyeria------------");
            fichero.WriteLine("AQUI TENEMOS LA MEJOR JOYERIA DE PLATA");
            fichero.WriteLine("TE ASEGURAMOS QUE TE VA A ENCANTAR!!!");
            fichero.Close();

        }
        public static void MENU1()
        {
            StreamReader fichero;
            string nombrefichero = "C:\\Users\\walmart\\Documents\\Proyecto\\"  + ".txt"; 
            fichero = File.OpenText(nombrefichero);
            

            string linea = "";
            while (linea  != null)
            {
                linea = fichero.ReadLine();
                Console.WriteLine(linea);
            }
            fichero.Close();
            
        }

    }
}
