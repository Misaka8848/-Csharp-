using System;
    //引用其他命名空间，这里提示不需要了，可能是已经默认包含了这个命名空间
namespace 测试项目
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
            
            Console.WriteLine("Hello, World!");
            
                int a = 1, b = 2, c = a + b;
            a = 2;
            Console.WriteLine(c);
            

        }
    }
}