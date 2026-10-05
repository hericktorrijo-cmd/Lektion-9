char[,] waves = new char[3, 3];

for (int r = 0; r < waves.GetLength(0); r++)
{
    for(int c = 0; c < waves.GetLength(1); c++)
    {
        waves[r, c] = '~';
    }
}

int tresureRow = 1;
int tresureCol = 2;

Console.WriteLine("--- VÄLKOMMEN TILL SKATTJAKTEN TILL SJÖSS ---");
Console.Write("Gissa rad (0-2): ");
int userGuessRow = int.Parse(Console.ReadLine());

Console.WriteLine("--- VÄLKOMMEN TILL SKATTJAKTEN TILL SJÖSS ---");
Console.Write("Gissa rad (0-2): ");
int userGuessCol = int.Parse(Console.ReadLine());

if (userGuessRow == tresureRow && userGuessCol == tresureCol)
{
    Console.WriteLine("Guld! du hittade skatten!");
}
else
{
    Console.WriteLine("Fel!");
}

Console.Write("\n\nTryck på valfri tangent för att stänga ner konsolen...");
Console.ReadKey();



