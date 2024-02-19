namespace 习题模板
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int activeTest = 1;//想要运行哪个题目
            bool isRun = true;
            while (isRun)
            {
                switch (activeTest)
                {
                    case 1:
                        {
                            #region 习题1

                            #endregion
                        }
                        isRun = false;
                        break;
                    case 2:
                        {
                            #region 习题2

                            #endregion
                        }
                        isRun = false;
                        break;
                    case 3:
                        {
                            #region 习题3

                            #endregion
                        }
                        isRun = false;
                        break;
                    case 4:
                        {
                            #region 习题4

                            #endregion
                        }
                        isRun = false;
                        break;
                    case 5:
                        {
                            #region 习题5

                            #endregion
                        }
                        isRun = false;
                        break;
                    case 6:
                        {
                            #region 习题6

                            #endregion
                        }
                        isRun = false;
                        break;
                    case 7:
                        {
                            #region 习题7

                            #endregion
                        }
                        isRun = false;
                        break;
                    case 8:
                        {
                            #region 习题8

                            #endregion
                        }
                        isRun = false;
                        break;

                }
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine($"习题 {activeTest} 运行完毕!");
            }
        }
    }
}