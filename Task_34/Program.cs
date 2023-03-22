void CreatingArray (int[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}
int NumberCounts (int[] array) {
    int count = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] % 2 == 0) 
                count++;
        }
        return count;
}

Console.Clear();
Console.Write("Введите размер массива: >> ");
int num = int.Parse (Console.ReadLine()!);
int[] array = new int[num];
CreatingArray(array);
NumberCounts(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {NumberCounts(array)}");
Console.WriteLine();