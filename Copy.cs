using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    internal class Copy
    {
     public string copy_name { get; set; }

     public Copy(string copy_name)
     {
       this.copy_name = copy_name;
     }

        public override string ToString()
        {
            return this.copy_name;
        }


    }
}
