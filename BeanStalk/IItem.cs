using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanStalk
{
    internal interface IItem
    {
        int X { get; set; }
        int Y { get; set; }
        void Draw();
    }
}
