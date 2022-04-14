Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());



if(a > b)
{
   if(a > c)
   {
        Console.Write("Наибольшее число: ");
        Console.Write(a);
   }
   else
   {
        Console.Write("Наибольшее число: ");
        Console.Write(c);
   }
} 
else
{ 
    if(b > c)
    {
        Console.Write("Наибольшее число: ");
        Console.Write(b); 
    }
    else
   {
        Console.Write("Наибольшее число: ");
        Console.Write(c);
   }
}
