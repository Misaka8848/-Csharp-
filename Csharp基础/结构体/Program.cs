

namespace 结构体
{
    // namespace中声明
    struct Point
    {
        public int x, y; //不能直接初始化 ,默认是私有的 外部不能访问
        public void PrintCo()
        {
            int x;
            int y;
            x = this.x; y = this.y;    // x和y是局部变量,this是表示结构体本身,this.x是方法外面属性的那个x
            Console.WriteLine(x + "," + y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(); // 初始化构建
            a.x = 1; // 访问并且初始化值
            a.y = 2;
            a.PrintCo(); //调用方法
        }
    }
}