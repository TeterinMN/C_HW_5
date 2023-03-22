Console.Clear();
int[] a = new int[100];
int[] b = new int[100];
int[] c = new int[100];
int n = 0, k = 0, d = 0;

Console.Write("Введите количество дней месяца в которые Вася получал оценки: >> ");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write($"Введите число месяца: >> ");
    a[i] = int.Parse(Console.ReadLine());
    if (a[i] % 2 == 1)
    {
        b[i] = a[i];
        k++;
    }
    else
    {
        c[i] = a[i];
        d++;
    }
}

Console.WriteLine();
Console.Write("В эти дни Вася получал тройки: ");
for (int i = 0; i < n; i++)
{
    if (b[i] != 0)
        Console.Write(b[i] + " ");
}

Console.WriteLine();
Console.Write("В эти дни Вася получал четверки: ");
for (int i = 0; i < n; i++)
{
    if (c[i] != 0)
        Console.Write(c[i] + " ");
}

Console.WriteLine();
Console.WriteLine("Ответ: ");
if (k > d)
    Console.WriteLine("NO - Нет, так как троек больше чем четверок");
else
    Console.WriteLine("YES - Да, Вася остается ударником :-)");