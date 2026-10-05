string[,] passangerSeats = new string[4, 2];

for (int rad = 0; rad < 4; rad++)
{
    for (int kolumn = 0; kolumn < 2; kolumn++)
    {
        passangerSeats[rad, kolumn] = "Ledig";
    }
}

passangerSeats[0, 0] = "Anna";
passangerSeats[2, 1] = "Björn";

for (int rad = 0; rad < passangerSeats.GetLength(0); rad++)
{
    for (int kolumn = 0; kolumn < passangerSeats.GetLength(1); kolumn++)
    {
        Console.Write($"[Rad {rad}, Stol{kolumn}: {passangerSeats[rad, kolumn], -5}]      ");
    }
    Console.WriteLine();
}

Console.Write("\n\nTryck på valfri tangent för att stänga ner konsolen...");
Console.ReadKey();
