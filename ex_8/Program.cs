Console.WriteLine("Enter:");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count < N+1)
{
if ( count % 2 == 0)
{
    Console.Write(count +", ");
    count= count+2;
}


}
