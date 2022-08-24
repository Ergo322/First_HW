internal class Program
{
    private static void Main(string[] args)
    {
        void SecondNumber()
            {
                Console.Clear();
                Console.WriteLine("Введите трехзначное число");
                int A = Convert.ToInt32(Console.ReadLine());

                int X2 = A / 10 % 10;

                Console.Write(A + " —> " + X2);
            }

            SecondNumber();
    }
}