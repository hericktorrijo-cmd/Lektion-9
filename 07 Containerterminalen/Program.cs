int[,] containerWeights = new int[4, 4]
{
    {7, 4, 6, 8 },
    {5, 14, 12, 5 },
    {11, 15, 2, 5 },
    {10, 6, 9, 2 },
};

Console.WriteLine("--- CONTAINERHAMNENS VIKTKARA (TON) ---");

for (int r = 0; r < containerWeights.GetLength(0); r++)
{
    for (int c = 0; c < containerWeights.GetLength(1); c++)
    {
        Console.Write($"{containerWeights[r, c], -10}");
    }
    Console.WriteLine();
}

Console.Write("\n\nTryck på valfri tangent för att stänga ner konsolen...");
Console.ReadKey();