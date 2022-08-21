internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите число");
        int A=Convert.ToInt32(Console.ReadLine());
        int result = A%2;
        if(result ==0)
        {
            Console.Write(A);
            Console.Write(" -> ДА");
        }
        else
        {
            Console.Write(A);
            Console.Write(" -> НЕТ");
        }
    }
}