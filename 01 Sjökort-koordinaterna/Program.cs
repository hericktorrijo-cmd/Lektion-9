string[,] seaCards = new string[3, 3]
{
    {"Öppet hav", "Klippa",    "Öppet hav" },
    {"Öppet hav", "Ö",         "Kloppa" },
    {"Grund",     "Öppet hav", "Öppet hav"  }
};

string mittRuta = seaCards[1, 1];

Console.WriteLine($"Innehåll i mittrutan är: {mittRuta}");

Console.Write("\n\nTryck på valfri tangent för att stänga ner konsolen...");
Console.ReadKey();
