using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV4___Exercise_1
{
    class NumberVisitor : INumberVisitor
    {
        public void onMyFloat(MyFloat MF)
        {
            Console.WriteLine("Found float");
        }

        public void onMyInt(MyInt MI)
        {
            Console.WriteLine("Found int");
        }
    }
}
