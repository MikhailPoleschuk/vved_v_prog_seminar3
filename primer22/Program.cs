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
    int sqr = i*i;
    Console.WriteLine(sqr);
    i++;
}
