Console.WriteLine("Enter first number");
double a= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second number");
double b= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter third number");
double c= Convert.ToDouble(Console.ReadLine());


double max = a;
if (max < b)
{
    max = b;
    if (max < c)
    {
        max = c;
         Console.WriteLine("max = "+c);
    }
    else
    {
         Console.WriteLine("max = "+b);
    }

}
else 
{ if (max < c)
    {
        max = c;
         Console.WriteLine("max = "+c);
    }
    else
    {
    
    Console.WriteLine("max = "+a);

}
}