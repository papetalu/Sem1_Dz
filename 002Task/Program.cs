Console.Clear();
Console.WriteLine("Введите число 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int z = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
   if (x > z)
   {
      Console.Write("max = ");
      Console.WriteLine(x);
   }
   else
   {
      Console.Write("max = ");
      Console.WriteLine(z);
   }
}
else
{
   if (y > z)
   {
      Console.Write("max = ");
      Console.WriteLine(y);
   }
   else
   {
      Console.Write("max = ");
      Console.WriteLine(z);
   }
}