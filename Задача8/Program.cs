internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите число: ");

        int A = Convert.ToInt32(Console.ReadLine());

        int count = 2;

        while (count <= A)
        {
            if (count % 2 == 0)
                Console.Write(count + ", ");
            count++;
        }
    }
}