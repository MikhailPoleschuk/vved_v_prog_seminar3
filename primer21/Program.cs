// 21
Console.Clear();
// вариант через массивы, но читать сложнее 

// int[] a = new int[2];
// int[] b = new int[2];
// Console.WriteLine("Введите координаты X точки А:");
// a[0] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты Y точки A:");
// a[1] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты X точки B:");
// b[0] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты Y точки В:");
// b[1] = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты X точки А:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки A:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X точки B:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки В:");
int y2 = Convert.ToInt32(Console.ReadLine());

//d = √ (х А – х В) 2 + (у А – у В) 2

double D = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
double sqr = Math.Sqrt(D);
Console.WriteLine(sqr);
