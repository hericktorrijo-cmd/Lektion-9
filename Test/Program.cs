//using System.Data;

//Console.Write("Antal rader: ");
//int rader = int.Parse(Console.ReadLine());
//Console.Write("Antal kolumner: ");
//int kolumner = int.Parse(Console.ReadLine());

//int[,] matrix = new int[rader, kolumner];

//for(int row = 0; row < rader; row++)
//{
//    for (int col = 0; col < kolumner; col++)
//    {
//        Console.Write($"matrix[{row}], {col}] = ");
//        matrix[row, col] = int.Parse(Console.ReadLine());
//    }
//}

//Console.WriteLine();

// for (int row = 0; row < rader; row++)
//{
//    for ( int col = 0; col < kolumner; col++)
//    {
//        Console.Write(matrix[row, col] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();

int[,] nummer = { {1, 2, 3},
                  {4, 5, 6},
                  {7, 8, 9}
};

//foreach(int number in nummer)
//{
//    Console.Write(number);
//}

for(int rad = 0; rad < nummer.GetLength(0); rad++)
{
    for (int kolumn = 0; kolumn < nummer.GetLength(1); kolumn++)
    {
        Console.Write(nummer[rad, kolumn] + " ");
    }
    Console.WriteLine();
}