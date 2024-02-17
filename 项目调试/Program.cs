
 namespace 控制台习题
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                const char square = '□';
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                char userInput = ' ';

                int xMove = 0, yMove = 0;
                int xPos = 0, yPos = 0;
            Console.WriteLine("方块移动");
                while (true)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Write(square);
                    Console.SetCursorPosition(0, 1);
                    Console.Write("wasd移动,q退出");
                    userInput = Console.ReadKey(true).KeyChar;
                    if (userInput == 'q') break;

                    switch (userInput)
                    {
                        case 'w': yMove = -1; xMove = 0; break;
                        case 's': yMove = 1; xMove = 0; break;
                        case 'a': xMove = -2; yMove = 0; break;
                        case 'd': xMove = 2; yMove = 0; break;
                        default: Console.SetCursorPosition(0, 2); Console.Write("输入wasd移动"); continue;
                    }

                    xPos += xMove;
                    yPos += yMove;
                    xPos = Math.Max(0, Math.Min(Console.WindowWidth - 1, xPos));
                    yPos = Math.Max(0, Math.Min(Console.WindowHeight - 2, yPos)); // 留出空间以避免覆盖提示信息

                    Console.Clear();
                    Console.SetCursorPosition(xPos, yPos);
                    Console.Write(square);
                }

                Console.Clear();
                Console.WriteLine("游戏结束 任意键退出");
                Console.ReadKey();
            }
        }
    }
