// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int size = 6;
int[] array = new int[size];
FullArray(array);
System.Console.WriteLine("Начальный массив: ");
PrintArray(array);
System.Console.WriteLine("Перевернутый массив: ");
coupArray(array);


void FullArray(int[] size)
{
    for (int i = 0; i < size.Length; i++)
    {
        array[i] = new Random().Next(1, 21);
    }
}

void PrintArray(int[] size)
{
    for (int i = 0; i < size.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void coupArray(int[] size, int i = 0)
{
    if (i < size.Length)
    {
      
        coupArray(size, i + 1);
        System.Console.Write($"{size[i]} ");

    }

}