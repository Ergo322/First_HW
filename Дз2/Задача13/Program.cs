internal class Program
{
    private static void Main(string[] args)
    {

            Console.Clear();
            Console.WriteLine("Введите число");
            int A = Convert.ToInt32(Console.ReadLine());
            int D = A;
            if (A > 999)
            {
                while (D > 999)
                {
                    D = D / 10;
                }
                int X4 = D % 10;
                Console.Write(A + " —> " + X4);
            }
            else
            {
                if (A > 99)
                {
                    int X3 = A % 10;
                    Console.Write(A + " —> " + X3);
                }
                else
                {
                    Console.Write(A + " —> Третьей цифры нет");
                }

        }
    }
}