//Программа, которая на вход принимает два числа и выдаёт, какое число большее
Console.Clear();
Console.WriteLine("Введите число 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == y)
{
   Console.Write("Числа равны");
}
else
{
   if (x < y)
   {
      Console.Write("max = ");
      Console.WriteLine(y);
   }
   else
   {
      Console.Write("max = ");
      Console.WriteLine(y);
   }
}