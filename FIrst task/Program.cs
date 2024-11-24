using FIrst_task;

Console.WriteLine("Witaj w Programie który narysuje ci figurę");
Console.WriteLine("Jaką figurę wybirasz ?");
Console.WriteLine("1. Kwadrat");
Console.WriteLine("2. Prostokąt");
Console.WriteLine("3. Trójkąt");

string choiceF = Console.ReadLine();

Console.WriteLine("Wybierz jaki symbol wybirasz");
Char choiceS = Console.ReadKey().KeyChar;

Console.WriteLine();
Console.WriteLine("Chcesz żeby figura była wypełniona?");
Console.WriteLine("1. Tak");
Console.WriteLine("2. Nie");
string choiceW = Console.ReadLine();

var service = new Serwices();

switch (choiceF)
{
    case "1":
        if (choiceW == "1")
        {
            service.DrawSquareFull(choiceS);
        }
        if (choiceW == "2")
        {
            service.DrawSquare(choiceS);
        }
        break;

    case "2":
        if (choiceW == "1")
        { 
           service.DrawRectangleFull(choiceS); 
        }
        if (choiceW == "2")
        {
            service.DrawRectangle(choiceS);
        }
        break;

    case "3":
        if (choiceW == "1")
        {
            service.DrawTriangleFull(choiceS); 
        }
        if (choiceW == "2")
        {
            service.DrawTriangle(choiceS);
        }
        break;

    default:
        Console.WriteLine("Nieprawidłowy wybór!");
        break;
}

Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
Console.ReadKey();