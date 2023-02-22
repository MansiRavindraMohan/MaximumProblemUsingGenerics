namespace MaximumProblemUsingGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to maximum problem using generics");

            int num1 = 70, num2 = 120, num3 = 100;

            int value = MaximumNumber.MaximumIntegerNumber(num1, num2, num3);

            Console.WriteLine(value + " is greatest");
        }
    }
}