void CreatingArray(double[] array) {
        for (int i = 0; i < array.Length; i++) {
            array[i] = Math.Round (new Random().NextDouble() * 100, 2);
        }
    }
        Console.Clear();
        Console.Write("Введите размер массива: >> ");
        int num = int.Parse(Console.ReadLine()!);
        double[] array = new double[num];
        CreatingArray(array);
        Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
        double max = array[0];
        double min = array[0];
        for (int i = 1; i < num; i++) {
            if (array[i] > max) {
                max = array[i];
            }
            if (array[i] < min) {
                min = array[i];
            }
        }
        double diff = max - min;
        Console.WriteLine("Максимальное число в массиве: " + max);
        Console.WriteLine("Минимальное число в массиве: " + min);
        Console.WriteLine("Разница между максимальным и минимальным числами: " + Math.Round(diff, 2));
        Console.WriteLine();