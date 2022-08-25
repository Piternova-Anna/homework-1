// принимает число N  и выдает все четные от 1 до n;
Console.WriteLine("введите число n:");
int n - int.Parse(Console.ReadLine());
int count=2;

if(n<1),
{
Console.WriteLine("ошибка");
}
else
{
    Console.WriteLine("четные числа от 1 до заданного числа");
}

while (count<n)
{
    if(count%2=0)
    {
        Console.WriteLine(count);
    }
    count=count+1;
}