char[,] radarScreen = new char[5, 5];

for (int r = 0; r < radarScreen.GetLength(0); r++)
{
    for (int k = 0;  k < radarScreen.GetLength(1); k++)
    {
        radarScreen[r, k] = '.';
    }
}

//Skriv ut hela radarskärmen först

for (int r = 0; r < radarScreen.GetLength(0); r++)
{
    for (int k = 0; k < radarScreen.GetLength(1); k++)
    {
        Console.Write($"{radarScreen[r, k]}");
    }
    Console.WriteLine();
}

Console.WriteLine();


radarScreen[1, 3] = 'K';
radarScreen[4, 3] = 'B';

for (int r = 0; r < radarScreen.GetLength(0); r++)
{
    for (int k = 0; k < radarScreen.GetLength(1); k++)
    {
        if (radarScreen[r, k] == 'B')
        {
            Console.WriteLine($"BÅT ('B') upptäckt på koordinatorer: Rad {r}, Kolumn {k}");
        }
        else if (radarScreen[r, k] == 'K')
        {
            Console.WriteLine($"KLIPPA ('K') upptäckt på koordinatorer: Rad {r}, Kolumn {k}");
        }
    }
}

Console.WriteLine();
//Skriv ut hela radarskärmen efter

for (int r = 0; r < radarScreen.GetLength(0); r++)
{
    for (int k = 0; k < radarScreen.GetLength(1); k++)
    {
        Console.Write($"{radarScreen[r, k]}");
    }
    Console.WriteLine();
}

Console.WriteLine();







Console.Write("\n\nTryck på valfri tangent för att stänga ner konsolen...");
Console.ReadKey();
