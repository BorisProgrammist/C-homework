
        
        int[] array = { 45, 22, 78, 5, 90, 30, 15, 75, 12, 50 };

        int countInRange = 0;

        // Находим количество элементов в отрезке [20, 90]
        foreach (int n in array)
        {
            if (n >= 20 && n <= 90)
            {
                Console.Write($"{n} ");
                countInRange++;
            }
        }

        Console.WriteLine($"\nКоличество элементов в отрезке [20, 90]: {countInRange}");

        Console.ReadLine(); 
    

