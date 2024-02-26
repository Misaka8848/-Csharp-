namespace 静态成员
{
    //静态类用于工具集
    static class MyUtilities
    {
        public static void ClearMeg()
        {
            // 清理工作台
        }
    }
    class Config
    {
        // 静态字段 用于在同一个类的所有实例之间共享值
        static string dataBaseAdress = "123123";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
