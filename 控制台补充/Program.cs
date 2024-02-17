namespace 控制台补充
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char userInput;
            //userInput = Console.ReadKey(true).KeyChar; // true就是不显示 KeyChar是输入的值
            //Console.WriteLine(userInput); 
            // 清空缓冲区
            Console.Clear();
            // 设置窗口大小
            Console.SetWindowSize(100, 50);
            // 设置缓冲区大小 缓冲区就是显示内容的区域 不能小于窗口大小
            //Console.SetBufferSize(100, 100);
            // 设置光标位置
            // 控制台左上角原点00 右侧X+ 下侧Y+
            // 在缓冲区范围内  1y = 2x 视觉上
            Console.SetCursorPosition(10, 55);
            Console.WriteLine("^(*￣(oo)￣)^");
            //文字颜色 
            Console.ForegroundColor = ConsoleColor.Green;
            //背景颜色
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            // 光标显隐
            Console.CursorVisible = false;
            // 关闭控制台
            Environment.Exit(0);
        }
    }
}