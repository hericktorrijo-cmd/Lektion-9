int[,] freezePocket = new int[3, 2]
{
    {-24, -22 },
    {-33, -16 },
    {-25, -18 }
};

int highetsTemperature = freezePocket[0, 0];

for (int rad = 0; rad < freezePocket.GetLength(0); rad++)
{
    for (int kolumn = 0; kolumn < freezePocket.GetLength(1); kolumn++)
    {
        if (freezePocket[rad, kolumn] > highetsTemperature)
        {
            highetsTemperature = freezePocket[rad, kolumn];
        }
    }
}

Console.WriteLine($"Varmast temperatur: {highetsTemperature}");

Console.Write("\n\nTryck på valfri tangent för att stänga ner konsolen...");
Console.ReadKey();
