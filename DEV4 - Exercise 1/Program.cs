using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV4___Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberVisitor nv = new NumberVisitor();
            INumber n = new MyInt();
            n.visit(nv);
            Console.ReadLine();
        }
    }
}
