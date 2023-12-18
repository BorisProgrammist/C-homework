
    //    Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, 
    //    значения которых лежат в отрезке [20,90]. 
       
    //     int[] array = { 45, 22, 78, 5, 90, 30, 15, 75, 12, 50 };

    //     int countInRange = 0;

    //     // Находим количество элементов в отрезке [20, 90]
    //     foreach (int n in array)
    //     {
    //         if (n >= 20 && n <= 90)
    //         {
    //             Console.Write($"{n} ");
    //             countInRange++;
    //         }
    //     }

    //     Console.WriteLine($"\nКоличество элементов в отрезке [20, 90]: {countInRange}");

    //     Console.ReadLine(); 
    //-------------------------------------------------------------------------------------------------------------------------

    // Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

         int[] array = { 5, 12, 7, 30, 42, 18, 63, 91, 20, 8 };

        Console.WriteLine("Массив:");
        foreach (int n in array)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();
        int countEvenNumbers = 0;
        foreach (int n in array)
        {
           
            if (n % 2 == 0)
            {
                countEvenNumbers++;
            }
        }
        Console.WriteLine($"Количество чётных чисел в массиве: {countEvenNumbers}");
        Console.ReadLine(); 
    

