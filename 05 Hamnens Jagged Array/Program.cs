string[][] port = new string[3][];
port[0] = new string[3];
port[1] = new string[5];
port[2] = new string[2];

int totalCapacity = 0;

for (int i = 0; i < port.Length; i++)
{
    for (int j = 0; j < port[i].Length; j++)
    {
        port[i][j] = "Tom";
        totalCapacity++;
    }
}

Console.WriteLine($"Totalt antal båtplatser i hela hamnen: {totalCapacity}");

Console.WriteLine($"{port[1][4]}");


Console.Write("\n\nTryck på valfri tangent för att stänga ner konsolen...");
Console.ReadKey();
