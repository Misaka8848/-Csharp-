namespace FlyChessGame
{
    enum E_GameSence
    {
        StartMenu,
        GamePlay,
        GameOver,
    }
    internal class Program
    {

        static string[] option = {
                "开始游戏",
                "结束游戏",
                "关于我们"
            };
        static bool userInputCheck(char i)
        {
            char[] validInput = {
            'w','W','a','A','s','S','d','D','j','J'
        };
            foreach (char c in validInput)
            {
                if (c == i)
                {
                    //PrintSystemMsg("                                     ");
                    return true;


                }

            }
            //PrintSystemMsg("输入有误,请输入W/S上下移动,J确认");
            return false;

        }
        static int printCenterString(string str)
        {
            return (Console.WindowWidth - str.Length) / 2;
        }

        static void RanderOption(int titleY, int activeIndex = 0)
        {
            for (int i = 0; i < option.Length; i++)
            {
                if (activeIndex == i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.SetCursorPosition(printCenterString(option[i]), titleY + 1 + 2 * (i + 1));
                Console.WriteLine(option[i]);

            }
        }
        static void PrintSystemMsg(string msg)
        {
            Console.SetCursorPosition(2, 48);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
        }
        static int RenderStartMenu()
        {
            string title = "飞 行 棋 游 戏";
            int activeIndex = 0;

            int titleY = 20;
            Console.SetCursorPosition(printCenterString(title), titleY);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(title);
            PrintSystemMsg("W/S移动,J确认");
            RanderOption(titleY);

            char userInput = '\0';
            while (true)
            {
                userInput = Console.ReadKey(true).KeyChar;
                if (userInputCheck(userInput))
                {
                    switch (userInput)
                    {
                        case 'w':
                        case 'W': --activeIndex; activeIndex = activeIndex < 0 ? option.Length - 1 : activeIndex; break;
                        case 's':
                        case 'S': ++activeIndex; activeIndex = activeIndex > option.Length - 1 ? 0 : activeIndex; break;
                        case 'j':
                        case 'J': return activeIndex + 1;
                            //default: PrintSystemMsg("输入错误"); break;

                    }
                    RanderOption(titleY, activeIndex);
                }
            }

        }




        static void Main(string[] args)
        {
            //初始化
            E_GameSence GameSence = E_GameSence.StartMenu;

            Console.CursorVisible = false;
            Console.SetWindowSize(100, 50);
            Console.SetBufferSize(100, 50);
            Console.Clear();
            while (true)
            {
                switch (GameSence)
                {
                    case E_GameSence.StartMenu:
                        GameSence = (E_GameSence)RenderStartMenu();
                        break;
                    case E_GameSence.GamePlay:
                        Console.Clear();
                        Console.WriteLine("1");
                        Console.ReadKey();
                        break;
                    case E_GameSence.GameOver:
                        Console.Clear();
                        Console.WriteLine("2");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}