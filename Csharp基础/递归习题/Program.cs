namespace 递归习题
{
    internal class Program
    {
        static void PrintNumber(int n = 0)
        {

            if (n > 10)
            {
                return;
            }
            Console.Write(n + " ");
            PrintNumber(n + 1);
        }
        static int JieCheng(int a)
        {
            if (a == 1)
            {
                return a;
            }
            return a * JieCheng(a - 1);
        }

        static int SumJieCheng(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            return JieCheng(a) + SumJieCheng(a - 1);
        }
        static int ZhuGan(int d = 10)
        {
            if (d == 0)
            {
                return 100;
            }
            return ZhuGan(d - 1) / 2;
        }
        static int Test5(int a = 200)
        {
            Console.Write(a + " ");
            return a == 1 ? 1 : Test5(a - 1);
        }
        static void Main(string[] args)
        {
            int activeTest = 1;//想要运行哪个题目
            bool isRun = true;

            string userInput = " ";
            while (isRun)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("输入想要运行的题目序号,输入F退出,回车确认");

                userInput = Console.ReadLine();
                Console.Clear();
                if (userInput == "f" || userInput == "F") { break; }
                activeTest = int.Parse(userInput);
                switch (activeTest)
                {
                    case 1:
                        {
                            #region 习题1
                            //1.使用递归的方式打印0~10
                            PrintNumber();
                            #endregion
                        }

                        break;
                    case 2:
                        {
                            #region 习题2
                            //传入一值，递归求该值的阶乘并返回,5 != 1 * 2 * 3 * 4 * 5
                            Console.WriteLine(JieCheng(5));

                            #endregion
                        }

                        break;
                    case 3:
                        {
                            #region 习题3
                            //使用递归求1！+2！+3！+4！+.....+10!
                            Console.WriteLine(SumJieCheng(10));
                            #endregion
                        }

                        break;
                    case 4:
                        {
                            #region 习题4
                            // 一根竹竿长100m，每天砍掉一半，求第十天它的长度是多少（从第0天
                            Console.WriteLine("ZhuGan");
                            #endregion
                        }

                        break;
                    case 5:
                        {
                            #region 习题5
                            // 不允许使用循环语句、条件语句，在控制台中打印出1-200这200个数(提示：递归 + 短路）
                            Test5();
                            #endregion
                        }

                        break;
                    case 6:
                        {
                            #region 习题6

                            #endregion
                        }

                        break;
                    case 7:
                        {
                            #region 习题7

                            #endregion
                        }

                        break;
                    case 8:
                        {
                            #region 习题8

                            #endregion
                        }

                        break;

                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine($"习题 {activeTest} 运行完毕!");
                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}