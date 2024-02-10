// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkermanF(int m, int n)
{
	if (m == 0)
	{
		return n + 1;
	}
	else
		if (n == 0)
	{
		return akkermanF(m - 1, 1);
	}
	else
	{
		return akkermanF(m - 1, akkermanF(m, n - 1));
	}
}

Console.Write($"Функция Аккермана равно {akkermanF(m, n)} ");