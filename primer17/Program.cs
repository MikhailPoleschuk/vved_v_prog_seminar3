// 17 
Console.Clear();
Console.WriteLine("Введите X не равное 0:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y не равное 0:");
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0) Console.WriteLine("Одно из значений равно 0, попробуйте еще раз");
else if (x > 0 & y > 0) Console.WriteLine("Координата в 1 четверти");
else if (x < 0 & y > 0) Console.WriteLine("Координата в 2 четверти");
else if (x < 0 & y < 0) Console.WriteLine("Координата в 3 четверти");
else if (x > 0 & y < 0) Console.WriteLine("Координата в 4 четверти");
