Console.Clear();
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Четные числа от 1 до введенного числа: ");
for (int i = 1; i <= x; i++)
   if (i % 2 == 0)
   {
      Console.WriteLine(i);
   }
