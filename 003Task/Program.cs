Console.Clear();
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 2 == 0)
{
   Console.Write("Число четное");
}
else
{
   Console.Write("Число нечетное");
}
