//на входе принимает два числа и выдает макс и миним из них;
Console.WriteLine("введите число 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите число 2");
int b = int.Parse(Console.ReadLine());
if (a>b)
{
   int max=a;
   int min=b;
    Console.WriteLine(max, min);
}
else
{
    int max=b;
    int min=a;
    Console.WriteLine(max, min);
}
