namespace MaximumProblemUsingGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to maximum problem using generics");

            //MaximumNumber.MaximumString();
            Console.WriteLine("Executing three test cases to find the maximum String  among three strings");

            Console.WriteLine("\nTest case 1: ");
            string max1 = MaxString.FindMaxString("Peach", "Apple", "Banana");
            Console.WriteLine($"{max1} is the greatest among three Strings");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 2: ");
            string max2 = MaxString.FindMaxString("Apple", "Mango", "Coconut");
            Console.WriteLine($"{max2} is the greatest among three Strings");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 3: ");
            string max3 = MaxString.FindMaxString("Lime", "Orange", "Strawberry");
            Console.WriteLine($"{max3} is the greatest among three Strings");

        }
    }
}