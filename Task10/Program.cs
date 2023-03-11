Console.Clear();
Console.Write("Введите трехзначное число ");
int namber=Convert.ToInt32(Console.ReadLine());
namber=namber/10;
namber=namber%10;
Console.WriteLine(namber);
