int[,] freezePocket = new int[3, 2]
{
    {-24, -22 },
    {-33, -16 },
    {-25, -18 }
};

int highetsTemperature = freezePocket[0, 0];
int hottestRow = 0;
int hottestCol = 0;

for (int row = 0; row < freezePocket.GetLength(0); row++)
{
    for (int column = 0; column < freezePocket.GetLength(1); column++)
    {
        if (freezePocket[row, column] > highetsTemperature)
        {
            highetsTemperature = freezePocket[row, column];
            hottestRow = row;
            hottestCol = column;
        }
    }
}

Console.WriteLine($"Varmast temperatur: {highetsTemperature} och ligger på plats {hottestRow} {hottestCol}");

Console.Write("\n\nTryck på valfri tangent för att stänga ner konsolen...");
Console.ReadKey();
