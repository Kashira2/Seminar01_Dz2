Console.WriteLine("Введите первое число: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int N3 = Convert.ToInt32(Console.ReadLine());
int max = N1;
if (N2 > max)
{
    max = N2;
}
if (N3 > max)
{
     max = N3;
}
Console.WriteLine(max);