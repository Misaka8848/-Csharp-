namespace FlyChessGame
{
    enum E_GameSence
    {
        StartMenu,
        GamePlay,
        GameOver,
    }
    struct MapObj
    {
        public string name;
        public int x;
        public int y;
        public ConsoleColor color;
        public string shape;

        public MapObj(string name, int x, int y, ConsoleColor color, string shape)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.color = color;
            this.shape = shape;

        }

    }


    internal class Program
    {
        // 一些固定值
        static int upperY = 0, megUpperY = 30, megBottumY = megUpperY + 5, sysMegUpperY = 47, bottumY = 49;
        static int leftX = 1, rightX = 98;
        static string[] option = {
                "开始游戏",
                "结束游戏",
                "关于我们"
            };


        static MapObj none = new MapObj("none", 0, 0, ConsoleColor.White, "  ");
        static MapObj player = new MapObj("player", 0, 0, ConsoleColor.Blue, "☆");
        static MapObj cpu = new MapObj("player", 0, 0, ConsoleColor.Magenta, "△");
        static MapObj covered = new MapObj("player", 0, 0, ConsoleColor.Green, "◎");
        static MapObj normalGrid = new MapObj("player", 0, 0, ConsoleColor.White, "□");
        static MapObj pauseGrid = new MapObj("player", 0, 0, ConsoleColor.Cyan, "||");
        static MapObj boomGrid = new MapObj("player", 0, 0, ConsoleColor.DarkRed, "●");
        static MapObj tunnelGrid = new MapObj("player", 0, 0, ConsoleColor.Cyan, "¤");
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

        static void RenderOptions(int titleY, int activeIndex = 0)
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
        static void ClearLine(int y)
        {
            if (y > upperY && y < megBottumY && y != megUpperY && y != megBottumY && y != sysMegUpperY)
            {
                Console.SetCursorPosition(leftX + 1, y);
                string clear = " ";
                for (int i = 1; i < rightX - leftX; i++)
                {
                    clear += " ";
                }
                Console.WriteLine(clear);
            }
        }

        static void RenderMap()
        {
            MapObj[,] map = new MapObj[15, 11];
            //线性变换系数
            int kX = 2;
            //线性变换常数
            int linearX = (Console.WindowWidth - map.GetLength(1) * kX) / 2;
            int linearY = (megUpperY - map.GetLength(0)) / 2;
            //初始化map结构
            for (int i = 0; i < map.GetLength(0); i++)
            {
                switch (i)
                {
                    case 0:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            map[i, j] = normalGrid;
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }
                        break;
                    case 1:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            map[i, j] = j == map.GetLength(1) - 1 ? normalGrid : none; ;
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }
                        break;
                    case 2:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            map[i, j] = j == 0 ? none : normalGrid;
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }
                        break;
                    case 3:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            map[i, j] = j == 1 ? normalGrid : none;
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }
                        break;
                    case 4:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            switch (j)
                            {
                                case 0:
                                    map[i, j] = none; break;
                                case 10:
                                    map[i, j] = tunnelGrid; break;
                                default:
                                    map[i, j] = normalGrid; break;
                            }
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }
                        break;
                    case 5:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            switch (j)
                            {

                                case 10:
                                    map[i, j] = normalGrid; break;
                                default:
                                    map[i, j] = none; break;
                            }
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }
                        break;
                    case 6:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            switch (j)
                            {

                                case 8:
                                    map[i, j] = tunnelGrid; break;
                                default:
                                    map[i, j] = normalGrid; break;
                            }
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }
                        break;
                    case 7:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            switch (j)
                            {

                                case 1:
                                    map[i, j] = normalGrid; break;
                                default:
                                    map[i, j] = none; break;
                            }
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }

                        break;
                    case 8:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            switch (j)
                            {

                                case 0:
                                    map[i, j] = none; break;
                                case 3:
                                    map[i, j] = boomGrid; break;
                                case 4:
                                    map[i, j] = boomGrid; break;
                                default:
                                    map[i, j] = normalGrid; break;
                            }
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }

                        break;
                    case 9:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            switch (j)
                            {
                                case 10:
                                    map[i, j] = normalGrid; break;
                                default:
                                    map[i, j] = none; break;
                            }
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }

                        break;
                    case 10:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            switch (j)
                            {
                                case 0:
                                    map[i, j] = none; break;
                                case 10:
                                    map[i, j] = tunnelGrid; break;
                                default:
                                    map[i, j] = normalGrid; break;
                            }
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }

                        break;
                    case 11:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            switch (j)
                            {
                                case 1:
                                    map[i, j] = normalGrid; break;
                                default:
                                    map[i, j] = none; break;
                            }
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }

                        break;
                    case 12:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            switch (j)
                            {
                                case 0:
                                    map[i, j] = none; break;
                                case 2:
                                    map[i, j] = tunnelGrid; break;
                                default:
                                    map[i, j] = normalGrid; break;
                            }
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }

                        break;
                    case 13:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            switch (j)
                            {
                                case 10:
                                    map[i, j] = boomGrid; break;
                                default:
                                    map[i, j] = none; break;
                            }
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }

                        break;
                    case 14:
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            //
                            switch (j)
                            {
                                case 9:
                                    map[i, j] = boomGrid; break;
                                case 10:
                                    map[i, j] = boomGrid; break;
                                default:
                                    map[i, j] = none; break;
                            }
                            map[i, j].x = linearX + j * kX;
                            map[i, j].y = linearY + i;
                        }

                        break;
                }

            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.SetCursorPosition(map[i, j].x, map[i, j].y);
                    Console.ForegroundColor = map[i, j].color;
                    Console.Write(map[i, j].shape);
                }
            }
        }

        // 场景
        static E_GameSence RenderStartMenu()
        {
            string title = "飞 行 棋 游 戏";
            int activeIndex = 0;

            // 打印标题
            int titleY = 20;
            Console.SetCursorPosition(printCenterString(title), titleY);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(title);
            PrintSystemMsg("W/S移动,J确认");
            RenderOptions(titleY);

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
                        case 'J': return (E_GameSence)(activeIndex + 1);
                            //default: PrintSystemMsg("输入错误"); break;

                    }
                    RenderOptions(titleY, activeIndex);
                }
            }

        }
        static E_GameSence RenderGameplay()
        {
            // 渲染边框UI和提示说明
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            RenderMap();

            char userInput = '\0';
            while (true)
            {
                userInput = Console.ReadKey(true).KeyChar;
                //扔色子
                //改变位置
                //新位置是否遇到什么 如果到结束就退出循环
                //遇到逻辑 改变位置

                //更新位置
                //新位置是否遇到什么 直到普通格子

                //渲染新地图
                RenderMap();
            }


            return E_GameSence.GameOver;
        }



        static void Main(string[] args)
        {
            //初始化
            E_GameSence GameSence = E_GameSence.StartMenu;
            int GameWidth = 100;
            int GameHeight = 50;

            Console.CursorVisible = false;
            Console.SetWindowSize(GameWidth, GameHeight);
            Console.SetBufferSize(GameWidth, GameHeight);
            Console.Clear();


            while (true)
            {
                switch (GameSence)
                {
                    case E_GameSence.StartMenu:
                        GameSence = RenderStartMenu();
                        break;
                    case E_GameSence.GamePlay:
                        GameSence = RenderGameplay();
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