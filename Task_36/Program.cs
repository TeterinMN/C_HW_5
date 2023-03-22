void CreatingArray (int[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

int Sum (int[] array) {
    int sum = 0;
        for (int i = 1; i < array.Length; i += 2){
            sum += array[i];
        }
        return sum;
}

Console.Clear();
Console.Write("Введите размер массива: >> ");
int num = int.Parse (Console.ReadLine()!);
int[] array = new int[num];
CreatingArray(array);
Sum(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {Sum(array)}");
Console.WriteLine();