using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAttribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs holiday = new Songs("Holiday", "Green Day");
            Songs kashmir = new Songs("Kashmir", "Led Zeppelin");

            Console.WriteLine(Songs.songCount);
            Console.ReadLine();
        }
    }
}
