using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrst_task
{
    interface IShape
    {
        char getSymbol { get; set; }
        char filling { get; set; } 
        int X { get; set; }
        int Y { get; set; }
        void Draw();
    }
}
