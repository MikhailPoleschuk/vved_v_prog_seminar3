// 22 принимает на вход N и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1,4,9,16,25
// 2-> 1,4

Console.Clear();
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());
//int[] array1 = new int[N];
int i = 1;
while (i <= N)
{
    double sqr = Math.Pow(i,2); //добавил для запоминая после разбора Math.Pow также нужно использовать Double тк метод Math.Pow возвращает тип данных Double
    Console.WriteLine(sqr);
    i++;
}
