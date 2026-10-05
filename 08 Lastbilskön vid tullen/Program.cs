string[][] truckStation = new string[2][];
truckStation[0] = new string[3] { "ABC-123", "AAA-111", "AAA-222" };
truckStation[1] = new string[2] { "BBB-111", "BBB-222"};

for (int station = 0; station < truckStation.Length; station++)
{
    for (int car = 0; car < truckStation[station].Length; car++)
    {
        Console.WriteLine($"   Plats {car + 1}: {truckStation[station][car]}");
    }
    Console.WriteLine();
}

Console.WriteLine("\n\n[HÄNDELSE]: Första lastbilen i station 1 klar.");
truckStation[0][0] = "KLAR / PASSERAD";

Console.WriteLine($"Ny status på plats 1, station 1: {truckStation[0][0]}");



Console.Write("\n\nTryck på valfri tangent för att stänga ner konsolen...");
Console.ReadKey();
