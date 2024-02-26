namespace FlyChessGame
{
    enum E_GameScenes
    {
        StartMenu,
        GamePlay,
        GameOver,
    }
    enum E_GridType
    {
        NormalGrid,
        BoomGrid,
        PauseGrid,
        TunnelGrid,

    }
    enum E_PlayerType
    {
        Plyaer,
        Cpu,
    }
    struct Vector2
    {
        public int X; public int Y;
        public Vector2(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    /// <summary>
    /// 格子对象
    /// </summary>
    struct Grid
    {

        public int X;
        public int Y;
        public E_GridType GridType;
        public string Shape;
        public ConsoleColor Color;
        /// <summary>
        /// 构造地图格子
        /// </summary>
        /// <param name="gT">地图格子类型 不包括主角</param>
        /// <param name="pos">打印格子的坐标</param>
        public Grid(E_GridType gT, Vector2 pos)
        {
            GridType = gT;
            this.X = pos.X;
            this.Y = pos.Y;
            switch (GridType)
            {
                case E_GridType.NormalGrid:
                    this.Shape = "□";
                    this.Color = ConsoleColor.White;
                    break;
                case E_GridType.BoomGrid:
                    this.Shape = "●";
                    this.Color = ConsoleColor.Red;
                    break;
                case E_GridType.PauseGrid:
                    this.Shape = "||";
                    this.Color = ConsoleColor.White;
                    break;
                case E_GridType.TunnelGrid:
                    this.Shape = "¤";
                    this.Color = ConsoleColor.White;
                    break;
                default:
                    this.Shape = "  ";
                    this.Color = ConsoleColor.White; break;
            }

        }
        public void DrawGrid()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.ForegroundColor = this.Color;
            Console.Write(this.Shape);
        }
    }
    struct Map
    {

        public Grid[] MapArr;

        public Map()
        {
            Random random = new Random();
            int r;
            // 长度
            this.MapArr = new Grid[100];
            // 随机填充不同格子
            for (int i = 0; i < this.MapArr.Length; i++)
            {
                // 概率出现格子 概率逻辑可以分离
                r = random.Next(100);
                Vector2 pos = new Vector2();// 先给个默认的 绘图的时候再给真正的
                if ((i == 0 || i == MapArr.Length - 1) || r < 80)
                {
                    MapArr[i] = new Grid(E_GridType.NormalGrid, pos);
                }
                else if (r >= 80 && r < 90)
                {
                    MapArr[i] = new Grid(E_GridType.PauseGrid, pos);
                }
                else if (r >= 90 && r < 96)
                {
                    MapArr[i] = new Grid(E_GridType.BoomGrid, pos);
                }
                else
                {
                    MapArr[i] = new Grid(E_GridType.TunnelGrid, pos);
                }

            }

        }

        /// <summary>
        /// 蛇形绘制
        /// </summary>
        public void DrawMap()
        {
            int startX = (Console.WindowWidth - 10 * 2) / 2; // 起始X坐标
            int startY = 3; // 起始Y坐标
            int stepX = 2; // X方向步长
            int stepY = 1; // Y方向步长，每次换行时增加的Y坐标
            int maxPerLine = 10; // 每行最大格子数
            int maxIsc = 1; //每行之间的间隔
            int countX = 0; //水平绘制的次数
            int countY = 0; // 垂直绘制次数
            for (int i = 0, x = startX, y = startY, dir = 1; i < MapArr.Length; i++)
            {
                if (i == 0)// 入口位置
                {
                    MapArr[i].X = x - 2;
                    MapArr[i].Y = y;
                    MapArr[i].DrawGrid(); // 绘制格子
                }
                else
                {
                    // 打印当前的
                    MapArr[i].X = x;
                    MapArr[i].Y = y;
                    MapArr[i].DrawGrid();
                    // 准备下个格子的位置
                    if (countX == maxPerLine - 1) // 每行10个格子后检查是否需要换行
                    {
                        y += stepY;
                        countY++;
                        if (countY == maxIsc + 1)
                        {
                            countY = 0;
                            countX = 0;
                            dir = -dir;
                        }
                    }
                    else
                    {
                        countX++;
                        x += stepX * dir;
                    }

                }

            }
        }

    }

    struct Player
    {
        public int IndexInMapArr;
        public E_PlayerType PlayerType;

        public Player(int i, E_PlayerType p)
        {
            IndexInMapArr = i;
            PlayerType = p;
        }
        public void DrawPlayer(Map map)
        {
            Grid grid = new Grid();
            grid = map.MapArr[IndexInMapArr];
            switch (PlayerType)
            {
                case E_PlayerType.Plyaer:
                    Console.SetCursorPosition(grid.X, grid.Y);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("☆");
                    break;
                case E_PlayerType.Cpu:
                    Console.SetCursorPosition(grid.X, grid.Y);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("△");
                    break;
            }
        }
    }

    internal class Program
    {
        // 一些固定值
        static int upperY = 0, megUpperY = 30, megBottumY = megUpperY + 5, sysMegUpperY = 47, bottumY = 49;
        static int leftX = 0, rightX = 98;
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
        static void ClearMsgLine()
        {
            string clear = " ";
            for (int i = 2; i < Console.WindowWidth - 4; i++)
            {
                clear += " ";
            }
            for (int i = megBottumY + 1; i < sysMegUpperY; i++)
            {
                Console.SetCursorPosition(leftX + 2, i);
                Console.Write(clear);
            }
        }
        /// <summary>
        /// 绘制玩家图标
        /// </summary>
        /// <param name="player"></param>
        /// <param name="cpu"></param>
        /// <param name="map"></param>
        static void DrawPlayer(Player player, Player cpu, Map map)
        {
            if (player.IndexInMapArr == cpu.IndexInMapArr)
            {
                Grid grid = map.MapArr[player.IndexInMapArr];
                Console.SetCursorPosition(grid.X, grid.Y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("◎");
            }
            else
            {
                player.DrawPlayer(map);
                cpu.DrawPlayer(map);
            }
        }
        static void ClearPlayer(Player player, Player cpu, Map map)
        {
            Grid gridP = map.MapArr[player.IndexInMapArr];
            Grid gridC = map.MapArr[cpu.IndexInMapArr];
            gridP.DrawGrid();
            gridC.DrawGrid();
        }

        static void DrawUi()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 2; i < Console.WindowWidth; i += 2)
            {
                Console.SetCursorPosition(i, upperY);

                Console.Write("■");
                Console.SetCursorPosition(i, megUpperY);
                Console.Write("■");
                Console.SetCursorPosition(i, megBottumY);
                Console.Write("■");
                Console.SetCursorPosition(i, sysMegUpperY);
                Console.Write("■");
                Console.SetCursorPosition(i, bottumY);
                Console.Write("■");

            }
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(leftX, i);

                Console.Write("■");
                Console.SetCursorPosition(rightX, i);
                Console.Write("■");
            }
            Console.SetCursorPosition(leftX + 2, megUpperY + 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("□:普通格子");
            Console.SetCursorPosition(leftX + 2, megUpperY + 2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("||:暂停,一回合不动");
            Console.SetCursorPosition(leftX + 2 + "||:暂停,一回合不动".Length * 2 + "    ".Length, megUpperY + 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("●:炸蛋,倒退5格");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(leftX + 2, megUpperY + 3);
            Console.Write("¤:时空隧道,随机倒退,暂停,换位置");
            Console.SetCursorPosition(leftX + 2, megUpperY + 4);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("☆:玩家    ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("△:电脑    ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("◎:玩家电脑重合    ");
        }
        /// <summary>
        /// 根据格子改变位置
        /// </summary>
        /// <param name="pcpu.IndexInMapArr"></param>
        /// <param name="map"></param>
        /// <param name="gameOver"></param>
        /// <param name="isNormal"></param>
        /// <param name="isChangePos"></param>


        /// <summary>
        /// 根据骰子结果改变位置
        /// </summary>
        /// <param name="r"></param>
        static void ChangePos(int r, ref int pos, Map map, out bool isChangePos, out bool gameOver, out Grid grid)
        {
            bool isPause = false;
            bool isNormal = false;
            isChangePos = false;
            gameOver = false;
            Random rand = new Random();
            pos += r;
            while (true)
            {



                grid = map.MapArr[pos];
                switch (grid.GridType)
                {
                    case E_GridType.NormalGrid:
                        isNormal = true;
                        break;
                    case E_GridType.BoomGrid:
                        pos -= 5;
                        break;
                    case E_GridType.PauseGrid:
                        isPause = true;
                        break;
                    case E_GridType.TunnelGrid:
                        r = rand.Next(1, 4);
                        switch (r)
                        {
                            case 1:
                                pos += 5; break;
                            case 2: isPause = true; break;
                            case 3:
                                isChangePos = true; break;

                        }

                        break;
                }
                //新位置是否遇到什么 如果到结束或者普通格子或者换位置就退出循环
                if (gameOver || isNormal || isChangePos || isPause)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// 处理游戏扔色子过程中的打印输出
        /// </summary>
        /// <param name="gridType"></param>
        /// <param name="playerType"></param>
        /// <param name="r"></param>
        static void promptAndWait(E_GridType gridType, E_PlayerType playerType, int r)
        {
            ClearMsgLine();
            string subject = playerType == E_PlayerType.Plyaer ? "你" : "电脑";
            string oppose = playerType == E_PlayerType.Plyaer ? "电脑" : "你自己";
            if (playerType == E_PlayerType.Plyaer)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            Console.SetCursorPosition(2, megBottumY + 1);
            Console.Write(subject + $"扔出的点数为: {r}");
            Console.SetCursorPosition(2, megBottumY + 2);
            switch (gridType)
            {
                case E_GridType.NormalGrid:

                    Console.Write(subject + "到达一个安全位置");

                    break;
                case E_GridType.BoomGrid:
                    Console.Write(subject + "踩到炸弹了,后退5格");
                    break;
                case E_GridType.PauseGrid:
                    Console.Write(subject + "踩到陷阱了,暂停一回合");
                    break;
                case E_GridType.TunnelGrid:
                    Console.Write(subject + "进入时空隧道了");
                    break;

            }
            Console.SetCursorPosition(2, megBottumY + 3);
            Console.Write("按下任意键, 让" + oppose + "扔骰子");

            Console.ReadKey(true);
        }
        static void promptAndWait(string msg)
        {

            ClearMsgLine();
            Console.SetCursorPosition(2, megBottumY + 1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(msg);

            Console.ReadKey(true);
        }
        // 场景
        static E_GameScenes RenderStartMenu()
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
                        case 'J': return (E_GameScenes)(activeIndex + 1);
                            //default: PrintSystemMsg("输入错误"); break;

                    }
                    RenderOptions(titleY, activeIndex);
                }
            }

        }
        static E_GameScenes RenderGameplay()
        {
            // 渲染边框UI和提示说明
            Console.Clear();
            DrawUi();
            PrintSystemMsg("姬霓太美");
            // 初始化
            Map map = new Map();
            Random rand = new Random();

            // 画地图
            map.DrawMap();

            Player player = new Player(0, E_PlayerType.Plyaer);
            Player cpu = new Player(0, E_PlayerType.Cpu);
            int r = rand.Next(1, 7);//骰子
            bool gameOver = false;
            bool isNormal, isChangePos;
            int temp;
            char userInput = '\0';
            Grid grid;
            DrawPlayer(player, cpu, map);
            //提示玩家扔 等待输入
            promptAndWait("任意键扔色子开始游戏");

            while (true)
            {
                //玩家扔骰子
                r = rand.Next(1, 7);
                //擦除旧玩家图标
                ClearPlayer(player, cpu, map);
                //改变位置
                ChangePos(r, ref player.IndexInMapArr, map, out isChangePos, out gameOver, out grid);
                //画玩家
                DrawPlayer(player, cpu, map);
                //提示和等待输入
                promptAndWait(grid.GridType, E_PlayerType.Plyaer, r);
                if (gameOver)
                {
                    // 提示结束 等待输入
                    break;
                }
                else if (isChangePos)
                {
                    //交换位置
                    temp = cpu.IndexInMapArr;
                    cpu.IndexInMapArr = player.IndexInMapArr;
                    cpu.IndexInMapArr = temp;
                }
                // ai扔色子
                r = rand.Next(1, 7);
                ClearPlayer(player, cpu, map);


                //改变位置
                ChangePos(r, ref cpu.IndexInMapArr, map, out isChangePos, out gameOver, out grid);
                //画ai
                DrawPlayer(player, cpu, map);
                //提示和等待输入
                promptAndWait(grid.GridType, E_PlayerType.Cpu, r);
                if (gameOver)
                {
                    // 提示结束 等待输入
                    break;
                }
                else if (isChangePos)
                {
                    //交换位置
                    temp = cpu.IndexInMapArr;
                    cpu.IndexInMapArr = player.IndexInMapArr;
                    cpu.IndexInMapArr = temp;
                }

                //遇到逻辑 改变位置

                //更新位置
                //新位置是否遇到什么 直到普通格子

                //渲染新地图

            }



            return E_GameScenes.GameOver;
        }



        static void Main(string[] args)
        {
            //初始化
            E_GameScenes GameScenes = E_GameScenes.StartMenu;
            int GameWidth = 100;
            int GameHeight = 50;

            Console.CursorVisible = false;
            Console.SetWindowSize(GameWidth, GameHeight);
            Console.SetBufferSize(GameWidth, GameHeight);
            Console.Clear();


            while (true)
            {
                switch (GameScenes)
                {
                    case E_GameScenes.StartMenu:
                        GameScenes = RenderStartMenu();
                        break;
                    case E_GameScenes.GamePlay:
                        GameScenes = RenderGameplay();
                        break;
                    case E_GameScenes.GameOver:
                        Console.Clear();
                        Console.WriteLine("2");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
