using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class MarkoException : Exception
    {
        public MarkoException(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
            
    }
}
