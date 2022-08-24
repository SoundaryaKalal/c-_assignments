namespace ConsoleApp2
{
    internal class Program
    {
        public static int mul_num(int num1, int num2, int num3)
        {
            return num1* num2 * num3;
        }
        public static void MSain()
        {
            int num1, num2, num3;

            Console.Write("Input the first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = mul_num(num1, num2, num3);
            Console.WriteLine($"the output is {result}");

        }
    }
}
