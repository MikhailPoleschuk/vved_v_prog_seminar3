// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
Console.WriteLine("Введите  пятизначное N:");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 99999 || N < 10000)
{
    Console.WriteLine("не хулиганьте, введите 5 значное число:");
    N = Convert.ToInt32(Console.ReadLine());
}
else
{
    int num = N;
    int i = 0;
    int x = 0;
    int z = 10000;
    int[] array = new int[5];
    int[] array2 = new int[5];
    while (i < 5)
    {
        array[i] = (num - x) / z;
        // так проверим что мы там навычисляли
        // Console.WriteLine($"num {num}");
        // Console.WriteLine($"x {x}");
        // Console.WriteLine($"z {z}");
        // Console.WriteLine(array[i]);
        x = x + array[i] * z;
        z = z / 10;
        i++;
    }
    // набьем еще один массивчик
    i = 0;
    int len = array.Length - 1;
    while (i < array.Length)
    {
        array2[len] = array[i];
        len--;
        i++;
    }

    for (i = 0; i < 5; i++)
    {
        // тут проверили поэлементно массивы
        // Console.WriteLine($"Элемент 1 массива {array[i]}");
        // Console.WriteLine($"Элемент 2 массива {array2[i]}");
        if (array[i] != array2[i])
        {
            Console.WriteLine("неа"); // блин как же тебя отдельно от ага вывести
            break;
        }     
    }
    Console.WriteLine("ага"); 
}