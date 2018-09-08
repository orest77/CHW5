using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<IDeveloper> dev = new List<IDeveloper>();

            //dev.Add(new Programmer("C#"));
            //dev.Add(new Programmer("Ruby"));
            //dev.Add(new Programmer("Chef"));

            //dev.Add(new Builder("Hummer"));
            //dev.Add(new Builder("Drill"));
            //dev.Add(new Builder("Bobbin"));

            //foreach (var devi in dev)
            //{
            //    devi.Create();
            //    devi.Destroy();
            //    Console.WriteLine();
            //}

            Dictionary<uint, string> dic = new Dictionary<uint, string>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter key {0}: ", i + 1);
                uint id = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Enter value {0}: ", i + 1);
                string name = Console.ReadLine();
                dic.Add(id, name);

            }

            Console.WriteLine("Find value by key:");
            
            foreach (KeyValuePair<uint, string>keyValue in dic)
            {
                uint serchValue = Convert.ToUInt32(Console.ReadLine());
                if (keyValue.Key == serchValue)
                {
                    Console.WriteLine("Finde name = {0}", dic[serchValue] );
                }
                else
                {
                    Console.WriteLine("Values with such keys were found");
                }
            }         

            Console.ReadKey();
        }
    }
}
