/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int CalculatePositive(int[] array)
{
    int count=0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
    return count;
}

int size;
int count;
Console.Write("Введите размер массива: ");
size = int.Parse(Console.ReadLine());
int [] array = FillArray(size);
count = CalculatePositive(array);
Console.WriteLine($"В массиве {count} чисел больше 0.");