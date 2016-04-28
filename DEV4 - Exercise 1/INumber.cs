using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV4___Exercise_1
{
    interface INumber
    {
        void visit(INumberVisitor INV);
    }
}
