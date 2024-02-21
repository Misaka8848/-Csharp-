namespace 变长参数和默认值
{
    internal class Program
    {
        static int Sum(string m = "**************", params int[] a)
        {
            Console.WriteLine(m);
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }

            return sum;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(Sum("gaga", 1, 2, 3));
            Console.WriteLine(Sum());
        }
    }
}