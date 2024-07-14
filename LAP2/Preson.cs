using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP2
{
    internal class Preson
    {
        public int Name { get; set; }

        public int Age { get; set; }

        public  int SSN {  get; set; }


        public override string ToString()
        {
            return $"Name: {Name} , Age: {Age} , SSN: {SSN} ";
        }
    }
}
