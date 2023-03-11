Console.Clear();
Console.Write("Введите число ");
int namber=Convert.ToInt32(Console.ReadLine());
if (namber>999)
{
    while (namber>999)
    {
        namber=namber/10;
    }
    namber=namber%10;
    Console.WriteLine(namber);
}
else
{
    Console.WriteLine("Третей цыфры нет");
}


