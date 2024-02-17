namespace _14变量本质
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = sizeof(sbyte);
            Console.WriteLine("sb占用字节数量是" + a);
        }
    }
}