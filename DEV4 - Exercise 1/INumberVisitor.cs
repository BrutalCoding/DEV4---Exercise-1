using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV4___Exercise_1
{
    interface INumberVisitor
    {
        void onMyInt(MyInt MI);
        void onMyFloat(MyFloat MF);

    }
}
