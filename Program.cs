namespace MaximumProblemUsingGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to maximum problem using generics");

            //MaximumNumber.MaximumString();

            Console.WriteLine("\nTest case 1: ");
            int max1 = MaximumNumber<int>.FindMaxValue(100, 15, 60);
            Console.WriteLine($"{max1} is the greatest Integer among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 2: ");
            float max2 = MaximumNumber<float>.FindMaxValue(5.6f, 1.2f, 8.9f);
            Console.WriteLine($"{max2} is the greatest Float among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 3: ");
            string max3 = MaximumNumber<string>.FindMaxValue("Blueberry", "Peach", "Orange");
            Console.WriteLine($"{max3} is the greatest String among three number");
        }
    }
}