using System;
//引用其他命名空间，这里提示不需要了，可能是已经默认包含了这个命名空间
namespace _10输入输出
//命名空间——工具包
//创建命名空间
{
    //命名空间代码块
    internal class Program
    {
        //类代码块
        //面向对象相关
        static void Main(string[] args)
        {
            //函数代码块 工具能做的事情
            //主函数——一个程序的主入口
            Console.WriteLine("输入你的名字，用enter结束");
            //打印一行字在控制台上，并且自动空一行
            Console.ReadLine();
            //读取用户的输入，需要按下enter键结束输入
            Console.Write("好");
            Console.Write("der");
            Console.WriteLine("按下任意键结束");
            Console.ReadKey();
            //读取单个字符，按下任意键就会结束

            //输入 向控制台输入内容
            //Console.ReadLine();
            //Console.ReadKey();

            //输出 向控制台输出内容
            //Console.WriteLine();
            //Console.Write();
        }
    }
}