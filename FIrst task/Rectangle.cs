using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrst_task
{
    public class Rectangle : IShape
    {
        public char getSymbol { get; set; }
        public char filling { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public void Draw()
        {
            if (filling == (char)1)
            {
                for (int i = 0; i < X; i++)
                {
                    for (int j = 0; j < Y; j++)
                    {
                        Console.Write(getSymbol);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < X; i++)
                {
                    for (int j = 0; j < Y; j++)
                    {
                        if (i == 0 || i == X - 1 || j == 0 || j == Y - 1)
                            Console.Write(getSymbol);
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
