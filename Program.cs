Console.WriteLine("Введите координты пушки х0: "); 
double x0 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты пушки y0: "); 
double y0 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите начальную скорость снаряда v0: "); 
double v0 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите угол вылета снаряда из пушки alpha: "); 
double alpha = double.Parse(Console.ReadLine());

double alphaRadian = alpha * (MathF.PI / 180); 
double Vx0 = v0 * Math.Cos(alphaRadian);
double Vy0 = v0 * Math.Sin(alphaRadian);
double x = x0;
double y = y0;  
double t = 1;
double g = 9.81;
x = x0 + Vx0 * t;
y = y0 + Vy0 * t - (g * Math.Pow(t, 2)) / 2;

List<double> coordinatesX = new List<double>();
List<double> coordinatesY = new List<double>();
while (y >= 0)
{
    x = x0 + Vx0 * t;
    y = y0 + Vy0 * t - (g * Math.Pow(t, 2)) / 2;
    t += 1;
   coordinatesX.Add(x);
   coordinatesY.Add(y);
}
double maxX = coordinatesX.Max();
double maxY = coordinatesY.Max();
StreamWriter sw = new StreamWriter("C:\\Users\\prdb\\source\\repos\\ConsoleApp9\\task5.txt");
Console.WriteLine("Координаты y:");
sw.WriteLine("Координаты y:");
foreach (double n in coordinatesY)
{
    Console.WriteLine(n);
    sw.WriteLine(n);
}
Console.WriteLine("");
sw.WriteLine("");
Console.WriteLine("Координаты x:");
sw.WriteLine("Координаты x:");
foreach (double n in coordinatesX)
{
    Console.WriteLine(n);
    sw.WriteLine(n);
}
Console.WriteLine("Координаты максимальных значений:");
sw.WriteLine("Координаты максимальных значений:");
Console.WriteLine();
Console.WriteLine($"{maxX}, {maxY}");
sw.WriteLine($"{maxX}, {maxY}");
sw.Close();