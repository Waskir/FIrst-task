using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrst_task
{
    public class Menu
    {
        public static void GetFigure()
        {
            Console.WriteLine("Witaj w Programie który narysuje ci figurę");
            ChooseMenu();
            char getShape = Console.ReadKey().KeyChar;
            double get = Char.GetNumericValue(getShape);
            Console.WriteLine();
            {
                while (true)
                {
                    switch (get)
                    {
                        case 1:
                            Rectangle square = new Rectangle();
                            GetSymbol();
                            GetFilling();
                            GetSize(get);
                            square.Draw();
                            Console.WriteLine();
                            break;
                        case 2:
                            Rectangle rectangle = new Rectangle();
                            GetSymbol();
                            GetFilling();
                            GetSize(get);
                            rectangle.Draw();
                            Console.WriteLine();
                            break;
                        case 3:
                            Triangle triangle = new Triangle();
                            GetSymbol();
                            GetFilling();
                            GetSize(get);
                            triangle.Draw();
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("Do widzenia!");
                            return;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Podałeś złą odpowiedź spróbuj jeszcze raz");
                            Console.WriteLine();
                            break;
                    }

                    ChooseMenu();
                    getShape = Console.ReadKey().KeyChar;
                    get = Char.GetNumericValue(getShape);
                    Console.WriteLine();
                }
            }
        }

       public static void GetSymbol()
        {
            Console.WriteLine();
            Console.WriteLine("Wybierz jaki symbol wybierasz");
            char getSymbol = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }

        public static void GetFilling()
        {
            Console.WriteLine();
            Console.WriteLine("Chcesz żeby figura była wypełniona?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            char filling = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }

        public static void GetSize(double get)
        {
            int X;
            int Y;

            Console.WriteLine();
            Console.WriteLine("Podaj X: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (get == 2)
            {
                Console.WriteLine("Podaj Y: ");
                Y = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            else
            {
                Y = X;
            }

        }

        public static void ChooseMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Jaką figurę wybirasz ?");
            Console.WriteLine("1. Kwadrat");
            Console.WriteLine("2. Prostokąt");
            Console.WriteLine("3. Trójkąt");
            Console.WriteLine("4. jeżeli chcesz zakończyć");
        }
    }
}
