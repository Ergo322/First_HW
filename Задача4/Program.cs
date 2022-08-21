internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите три числа");
        int A =Convert.ToInt32(Console.ReadLine());
        int B =Convert.ToInt32(Console.ReadLine());
        int C =Convert.ToInt32(Console.ReadLine());

        int max = A;

        if (A > max) max = A;
        if (B > max) max = B;
        if (C > max) max = C;


        Console.Write ("MAX = ");
        Console.Write (max);
    }
}