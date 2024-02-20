namespace 二维数组习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int activeTest = 1;//想要运行哪个题目
            bool isRun = true;
            Random rand = new Random();

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
                            //1. 将1到10000赋值给一个二维数组（100行100列）
                            int[,] arr = new int[100, 100];
                            int plus = 1;
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    arr[i, j] += plus;
                                    plus++;
                                }
                            }
                            Console.WriteLine(arr[99, 99]);
                            #endregion
                        }

                        break;
                    case 2:
                        {
                            #region 习题2
                            //2 .将二维数组（4行4列）的右上半部分置零（元素随机1~100）
                            int[,] arr = new int[4, 4];
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    arr[i, j] = rand.Next(1, 101);
                                    if (i < j)
                                    {
                                        arr[i, j] = 0;
                                    }
                                    Console.Write(arr[i, j] + " ");
                                    if (arr[i, j] < 10)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.WriteLine();
                            }
                            #endregion
                        }

                        break;
                    case 3:
                        {
                            #region 习题3
                            int[,] arr = new int[3, 3];
                            int sum = 0;
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    arr[i, j] = rand.Next(1, 11);
                                    if (i == j || i + j == 2)
                                    {
                                        sum += arr[i, j];
                                    }


                                }
                            }

                            // 格式化打印矩阵
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {

                                    if (i == j || i + j == 2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.SetCursorPosition(3 * j, i); // 设置间隔
                                    Console.Write(arr[i, j]);

                                }
                            }
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"总和是 {sum}");
                            #endregion
                        }

                        break;
                    case 4:
                        {
                            #region 习题4
                            //4. 求二维数组（5行5列）中最大元素值及其行列号（元素随机1~500）
                            int[,] arr = new int[5, 5];
                            int max = 0, maxI = 0, maxJ = 0;

                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    arr[i, j] = rand.Next(1, 501);
                                    if (arr[i, j] > max)
                                    {
                                        max = arr[i, j];
                                        maxI = i;
                                        maxJ = j;
                                    }
                                }
                            }

                            // 格式化打印矩阵
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    // 高亮
                                    if (i == maxI && j == maxJ)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.SetCursorPosition(4 * j, i); // 设置间隔 主要根据整数的位数+1 只有1位就是2
                                    Console.Write(arr[i, j]);

                                }
                            }
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"最大值是: {max}");
                            #endregion
                        }

                        break;
                    case 5:
                        {
                            #region 习题5
                            //5. 给一个M*N的二维数组，数组元素的值为0或者1，要求转换数组，将含有1的行和列全部置1
                            int M = 6, N = 7;
                            int[,] arr = new int[M, N];
                            int c = 0; // 获取1的数目
                            int c2 = 0;
                            //生成矩阵
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    arr[i, j] = rand.Next(2);
                                    if (arr[i, j] == 1)
                                    {
                                        c++;
                                    }
                                }
                            }
                            // 创建数组存1的行和列
                            int[] oneIndexR = new int[c];
                            int[] oneIndexC = new int[c];

                            //存储1的行列
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {

                                    if (arr[i, j] == 1)
                                    {
                                        oneIndexR[c2] = i;
                                        oneIndexC[c2] = j;
                                        c2++;
                                    }
                                }
                            }


                            // 格式化打印之前的矩阵
                            Console.WriteLine("转换前");
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    // 高亮
                                    if (arr[i, j] == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.SetCursorPosition(4 * j, i + 1); // 设置间隔 主要根据整数的位数+1 只有1位就是2
                                    Console.Write(arr[i, j]);

                                }
                            }

                            // 转换矩阵 行
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < oneIndexR.Length; j++)
                                {
                                    if (i == oneIndexR[j])
                                    {
                                        for (int k = 0; k < arr.GetLength(1); k++)
                                        {
                                            arr[i, k] = 1;
                                        }
                                        break;
                                    }
                                }
                            }
                            // 转换矩阵 列
                            for (int i = 0; i < arr.GetLength(1); i++)
                            {
                                for (int j = 0; j < oneIndexC.Length; j++)
                                {
                                    if (i == oneIndexC[j])
                                    {
                                        for (int k = 0; k < arr.GetLength(0); k++)
                                        {
                                            arr[k, i] = 1;
                                        }
                                        break;
                                    }
                                }
                            }
                            // 格式化打印之后的矩阵
                            Console.WriteLine();

                            Console.WriteLine("转换后");
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    // 高亮
                                    if (arr[i, j] == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.SetCursorPosition(4 * j, i + 8); // 设置间隔 主要根据整数的位数+1 只有1位就是2
                                    Console.Write(arr[i, j]);

                                }
                            }
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