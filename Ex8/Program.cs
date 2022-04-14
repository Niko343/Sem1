Console.Write("Введите максимальный индекс массива: ");  //Показать четные числа от 1 до N
int a = int.Parse(Console.ReadLine());
int count = 0;

while(count < a)
{
    if (count % 2 == 0)
    {
        Console.Write(count);
        Console.Write(" ");
        count = count + 1;
    }
    else 
    {
        count = count + 1;
    }
}
