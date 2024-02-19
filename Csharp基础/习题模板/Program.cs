namespace 习题模板
{
    internal class Program
    {
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
                if (userInput == "f" || userInput == "F") { break; }
                activeTest = int.Parse(userInput);
                switch (activeTest)
                {
                    case 1:
                        {
                            #region 习题1
                            string[] arr8 = new string[25];
                            for (int i = 0; i < arr8.Length; i++)
                            {
                                if (i % 5 == 0)
                                {
                                    Console.Write("\n");
                                }
                                if ((i + 1) % 2 == 1)
                                {
                                    arr8[i] = "■";
                                }
                                else
                                {
                                    arr8[i] = "□";
                                }
                                Console.Write(arr8[i]);

                            }
                            #endregion
                        }

                        break;
                    case 2:
                        {
                            #region 习题2

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