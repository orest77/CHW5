using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Programmer : IDeveloper
    {
        public Programmer()
        {
        }

        public Programmer(string lang)
        {
            language = lang;
        }

        private string language;

        public string Tool { get { return language; } set { language = value; } }
            
        
        public void Create()
        {
            Console.WriteLine("Create {0}", language);
        }

        public void Destroy()
        {
            Console.WriteLine("Destroy {0}", language);
        }
    }
}
