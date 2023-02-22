namespace MaximumProblemUsingGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to maximum problem using generics");

            double num1 = 7.9, num2 = 1.8, num3 = 19.8;

            double value = MaximumNumber.MaximumFloatNumber(num1, num2, num3);

            Console.WriteLine(value + " is greatest");
        }
    }
}