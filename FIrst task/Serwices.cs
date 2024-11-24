namespace FIrst_task
{
    public class Serwices
    {
        public void DrawSquareFull(char choiceS)
        {
            Console.WriteLine("Podaj rozmiar kwadratu: ");

            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(choiceS);
                }
                Console.WriteLine();
            }
        }

        public void DrawSquare(char choiceS)
        {
            Console.WriteLine("Podaj rozmiar kwadratu: ");

            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                        Console.Write(choiceS);
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        public void DrawRectangleFull(char choiceS)
        {
            Console.WriteLine("Podaj wysokość prostokąta: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj szerokość prostokąta: ");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(choiceS);
                }
                Console.WriteLine();
            }
        }

        public void DrawRectangle(char choiceS)
        {
            Console.WriteLine("Podaj wysokość prostokąta: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj szerokość prostokąta: ");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                        Console.Write(choiceS);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void DrawTriangleFull(char choiceS)
        {
            Console.Write("Podaj wysokość trójkąta: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                // Rysowanie spacji przed znakami
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }

                // Rysowanie znaków
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write(choiceS);
                }

                Console.WriteLine();
            }
        }

        public void DrawTriangle(char choiceS)
        {
            Console.Write("Podaj wysokość trójkąta: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                // Rysowanie spacji przed znakami
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }

                // Rysowanie krawędzi trójkąta
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    if (j == 0 || j == 2 * i || i == height - 1) // Krawędzie trójkąta
                        Console.Write(choiceS);
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
