internal partial class Program
{
    private static void Main(string[] args)
    {
        void WeekEnd()
        {
                Console.Clear();
                Console.WriteLine("Введите число от 1 до 7");
                int A = Convert.ToInt32(Console.ReadLine());
                int X1 = 1;
                int X2 = 2;
                int X3 = 3;
                int X4 = 4;
                int X5 = 5;
                int X6 = 6;
                int X7 = 7;
                if (A == X1)
                {
                    Console.Write(A + " —> НЕТ");
                }
                else if (A == X2)
                {
                    Console.Write(A + " —> НЕТ");
                }
                else if (A == X3)
                {
                    Console.Write(A + " —> НЕТ");
                }
                else if (A == X3)
                {
                    Console.Write(A + " —> НЕТ");
                }
                else if (A == X4)
                {
                    Console.Write(A + " —> НЕТ");
                }
                else if (A == X5)
                {
                    Console.Write(A + " —> НЕТ");
                }
                else if (A == X6)
                {
                    Console.Write(A + " —> ДА");
                }
                else if (A == X7)
                {
                    Console.Write(A + " —> ДА");
                }
                else
                {
                    Console.Write("Ошибка ввода");
                }
        }
        WeekEnd();
    }
}