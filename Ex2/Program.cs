﻿Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.Write("Наибольшее число: ");
    Console.Write(a);
} 
else if(a < b)
{
    Console.Write("Наибольшее число: ");
    Console.Write(b);
}
else
{
    Console.Write("Числа равны");
}
