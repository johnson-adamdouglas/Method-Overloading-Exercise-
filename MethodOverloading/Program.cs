namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            if (isTrue == true)
            {
                if (num1 + num2 > 1)
                {
                    return num1 + num2 + " dollars";
                }
                else
                {
                    return num1 + num2 + " dollar";
                }
            }
            else return "false";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 0, true));
        }
    }
}
