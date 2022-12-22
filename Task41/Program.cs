Console.Clear();
Console.WriteLine("Вводите числа через пробел:");
int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int sum=0;
foreach (int element in s)
{
	if(element>0)
		sum++;
}
Console.WriteLine($"Количество положительных чисел равно {sum}");