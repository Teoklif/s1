Console.WriteLine("Enter first number");
double a= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second number");
double b= Convert.ToDouble(Console.ReadLine());

double max = a;
if (max < b)
{
    max = b;
    Console.WriteLine("max = "+b);
    Console.WriteLine("min = "+a);
}
else 
{
    Console.WriteLine("max = "+a);
    Console.WriteLine("min = "+b);
}
