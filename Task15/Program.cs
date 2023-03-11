Console.Clear();
Console.Write("Введите день недели числом ");
int dayWeek=Convert.ToInt32(Console.ReadLine());
while (dayWeek<1 || dayWeek>7)
{
    Console.WriteLine("Вы ввели неверное число ");
    Console.Write("Введите день недели числом ");
    dayWeek=Convert.ToInt32(Console.ReadLine());
}
if (dayWeek==6 || dayWeek==7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Рабочий");
}

