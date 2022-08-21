internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите два числа");
        int A =Convert.ToInt32(Console.ReadLine());
        int B =Convert.ToInt32(Console.ReadLine());
        if(A>B)
        {
            Console.Write("MAX = ");
            Console.Write(A);
        }
        else
        {
            Console.Write("MAX = ");
            Console.Write(B);
        }
    }
}