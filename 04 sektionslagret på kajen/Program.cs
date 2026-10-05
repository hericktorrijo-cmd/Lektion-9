int[,] totalBoxes = new int[3, 4]
{
    {3, 5, 6, 7 },
    {2, 6, 9, 2 },
    {1, 5, 8, 9 }
};

int totalRowTwo = 0;
int paintRow = 1;

for (int kolumn = 0; kolumn < totalBoxes.GetLength(1); kolumn++)
{
    totalRowTwo += totalBoxes[paintRow, kolumn];
}
Console.WriteLine($"Totalt antal paket i andra raden = {totalRowTwo} st");

Console.Write("\n\nTryck på valfri tangent för att stänga ner konsolen...");
Console.ReadKey();