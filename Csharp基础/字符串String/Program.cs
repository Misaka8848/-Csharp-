namespace 字符串String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "1";
            string b = a;
            a = "2";
            int[] arr1 = { 1, 2 };
            int[] arr2 = arr1;
            arr1[0] = 2;
            Console.WriteLine(arr2[0]);

            Console.WriteLine(b);

        }
    }
}