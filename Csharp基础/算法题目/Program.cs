namespace 算法题目
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
                Console.Clear();
                if (userInput == "f" || userInput == "F") { break; }
                activeTest = int.Parse(userInput);
                switch (activeTest)
                {
                    case 1:
                        {
                            #region 习题1
                            //1.给定一个未排序的整数数组nums，找到最长递增子序列的长度。

                            //一个子序列是由数组派生出的一个序列，只不过删除了某些元素而不改变其他元素的顺序。注意，递增子序列的元素不一定是连续的。
                            //示例
                            //输入：nums = [10, 9, 2, 5, 3, 7, 101, 18]
                            //输出：4
                            //解释：最长递增子序列是[2, 3, 7, 101]，因此长度为 4 。

                            //提示
                            //1 <= nums.length <= 2500
                            //- 10 ^ 4 <= nums[i] <= 10 ^ 4

                            //初始化数组
                            Random rand = new Random();
                            int M = rand.Next(1, 2501);
                            int[] arr = new int[M];

                            for (int i = 0; i < arr.Length; i++)
                            {
                                arr[i] = rand.Next(-10000, 10001);
                            }
                            //遍历找到所有递增子序列, 保存长度
                            int maxLength = 0, subLength = 1, tempMax = int.MinValue;
                            for (int i = 0; i < arr.Length; i++)
                            {
                                subLength = 1;
                                tempMax = arr[i];
                                // 从当前位置后一位开始遍历
                                for (int j = i + 1; j < arr.Length; j++)
                                {
                                    if (arr[j] > tempMax)
                                    {
                                        tempMax = arr[j];
                                        subLength++;
                                    }
                                }
                                if (subLength > maxLength)
                                {
                                    maxLength = subLength;
                                }
                            }
                            Console.WriteLine(maxLength);
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