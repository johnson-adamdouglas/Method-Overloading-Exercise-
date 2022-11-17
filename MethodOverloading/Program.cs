namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        //params method
        public static int Add(params int[] numbers)
        {
            var sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;
            if (isTrue == true)
            {
                if (sum > 1)
                {
                    return sum + " dollars";
                }
                else
                {
                    return sum + " dollar";
                }
            }
            else return sum.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 0, true));
        }
    }
}
