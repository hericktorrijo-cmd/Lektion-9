string[,] pallets = new string[6, 6]
{
    {"PALL-101", "PALL-102", "PALL-103", "PALL-104", "PALL-105", "TOM" },
    {"TOM", "PALL-108", "PALL-109", "PALL-110", "PALL-111", "PALL-112" },
    {"PALL-113", "PALL-114", "PALL-115", "PALL-116", "TOM", "PALL-118" },
    {"PALL-119", "PALL-120", "PALL-121", "PALL-122", "PALL-123", "PALL-124" },
    {"TOM", "PALL-126", "PALL-127", "PALL-128", "PALL-129", "PALL-130" },
    {"PALL-131", "TOM", "TOM", "PALL-134", "PALL-135", "PALL-136" },
};
Console.Write("Ange pall-ID: ");
string userInput = Console.ReadLine();

bool found = false;
int foundRow = -1;
int foundColumn = -1;

for (int r = 0; r < pallets.GetLength(0); r++)
{
    for (int c = 0; c < pallets.GetLength(1); c++)
    {
        if (pallets[r, c].Equals(userInput, StringComparison.OrdinalIgnoreCase))
        {
            found = true;
            foundRow = r;
            foundColumn = c;
            goto EndOfLoops;
        }
    }
}
EndOfLoops:

if (found)
{
    Console.WriteLine($"Jippie! {userInput} hittad på hyllplats: Rad {foundRow}, Sektion {foundColumn}");
}
else
{
    Console.WriteLine($"Fel: Kunde inte hitta något objekt med ID '{userInput.ToUpper()}'");
}


Console.Write("\n\nTryck på valfri tangent för att stänga ner konsolen...");
Console.ReadKey();
