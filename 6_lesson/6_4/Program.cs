// Напишите программу, которая будет создавать копию заданного двумерного массива
// с помощью поэлементного копирования.

void Print(int[,] arr)
{
   int col = arr.GetLength(1);
    int row = arr.GetLength(0);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        
            Console.Write($"{arr[i,j]} ");

        Console.WriteLine();
    }
}

int[,] Massiv(int row, int col)
{
    int[,] arr = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)

        arr[i,j] = new Random().Next(100, 1000);
    }
    return arr;
}

int[,] MasClone(int[,] arr)
{
    int col = arr.GetLength(1);
    int row = arr.GetLength(0);
    int[,] new_arr = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        
            new_arr[i,j] = arr[i, j];
    }
    return new_arr;       
}

int[,] arr_1 = Massiv(int.Parse(Console.ReadLine()),
                      int.Parse(Console.ReadLine()));              
Print(arr_1);
int[,] new_array =  MasClone(arr_1);
Console.WriteLine();
Print(new_array);
