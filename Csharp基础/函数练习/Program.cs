namespace 函数练习
{
    internal class Program
    {
        static int Max(int a, int b)
        {

            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static double[] CircleS_L(int r)
        {
            double[] res = new double[2];
            res[0] = 3.14 * r * r;
            res[1] = 2 * 3.14 * r;
            Console.WriteLine($"周长是{res[1]},面积是{res[0]}");

            return res;
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
                            //写一个函数，比较两个数字的大小，返回最大值

                            #region 习题1
                            int max = Max(3, 4);
                            #endregion
                        }

                        break;
                    case 2:
                        {
                            #region 习题2
                            //写一个函数，用于计算一个圆的面积和周长，并返回打印
                            double[] ans = new double[2];

                            #endregion
                        }

                        break;
                    case 3:
                        {
                            #region 习题3

                            #endregion
                        }

                        break;
                    case 4:
                        {
                            #region 习题4

                            #endregion
                        }

                        break;
                    case 5:
                        {
                            #region 习题5

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