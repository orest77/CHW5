using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Builder : IDeveloper
    {
        private string tool;
        public Builder()
        {
        }

        public Builder(string tool)
        {
            this.tool = tool;
        }

        public string Tool { get { return tool; } set { tool = value;} }

        public void Create()
        {
            Console.WriteLine("Create builder {0}", Tool);
        }

        public void Destroy()
        {
            Console.WriteLine("Destroy BUilder {0}", Tool);
        }
    }
}
