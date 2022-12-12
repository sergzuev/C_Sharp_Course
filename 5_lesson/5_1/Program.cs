// Напишите программу замены элементов массива: положительные элементы замените на
// соответствующие отрицательные и наоборот.
// [-4,-8,8,2] -> [4,8,-8,-2]

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
       Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Massiv(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
       arr[i] = new Random().Next(-100,100);
    return arr;
}

void Massiv1(int[] arr_1)
{
    for(int i = 0; i < arr_1.Length; i++)
      arr_1[i] = - arr_1[i];

}

int[] arr_1 = Massiv(int.Parse(Console.ReadLine()));
Print(arr_1);
Massiv1(arr_1);
Print(arr_1);



