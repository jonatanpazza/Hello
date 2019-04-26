using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(createMessage());
            Console.WriteLine("teste");
            Console.ReadKey();
        }

        public static String createMessage()
        {
            return "Hello World";
        }
    }
}
