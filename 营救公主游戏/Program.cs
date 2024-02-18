using System.Runtime.InteropServices;

namespace 营救公主游戏
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int START = 0, BATTLE = 1, END = 2, QUIT = 4;
            const char SQUARE = '■';
            const int WIDTH = 100;
            const int HEIGHT = 50;
            int activeIndex = 0;
            int gameSence = END;
            bool isExit = false;
            const byte topBorder = 1, msgBorder = 39, botBorder = 49, leftBorder = 2, rightBorder = 98;
            const char HERO = '●', MONSTER = '■', princess = '♀';
            const ConsoleColor HEROCOLOR = ConsoleColor.White, MONSCOLOR = ConsoleColor.Blue;



            Random rand = new Random();// 放最外面 防止生成多个Random实例 不同的Random可能会产生相同的随机序列

            Console.SetWindowSize(WIDTH, HEIGHT);// 先设置Window 再设置Buffer, 这里的单位是什么
            Console.SetBufferSize(WIDTH, HEIGHT);
            Console.CursorVisible = false;
            while (true)
            {
                
                switch (gameSence)
                {
                    case START:
                        #region 开始场景
                        // 开始场景
                        while (true)
                        {
                            Console.Clear();
                            // 开始界面

                            //确定标题y轴位置
                            int topPadding = 0;
                            topPadding = (int)(Console.WindowHeight - Console.WindowHeight / 1.6); //这里会隐式转换为浮点数
                            for (int i = 0; i < topPadding; i++)
                            {
                                Console.WriteLine();
                            }
                            //确定标题x轴位置
                            int leftPadding = 0;
                            string gametitle = "Alter营救公主";
                            leftPadding = (Console.WindowWidth - gametitle.Length) / 2;
                            for (int i = 0; i < leftPadding; i++)
                            {
                                gametitle = " " + gametitle;
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(gametitle);
                            Console.WriteLine();
                            Console.WriteLine();
                            //打印开始游戏
                            gametitle = "开始游戏";
                            leftPadding = (Console.WindowWidth - gametitle.Length) / 2;
                            for (int i = 0; i < leftPadding; i++)
                            {
                                gametitle = " " + gametitle;
                            }
                            if (activeIndex == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            Console.WriteLine(gametitle);

                            Console.WriteLine();

                            //打印退出游戏
                            gametitle = "退出游戏";
                            leftPadding = (Console.WindowWidth - gametitle.Length) / 2;
                            for (int i = 0; i < leftPadding; i++)
                            {
                                gametitle = " " + gametitle;
                            }

                            if (activeIndex == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine(gametitle);
                            Console.WriteLine();

                            // 输入逻辑
                            char userInput = Console.ReadKey(true).KeyChar;

                            switch (userInput)
                            {
                                case 'w':
                                case 'W':
                                    activeIndex--;
                                    activeIndex = activeIndex < 0 ? 1 : activeIndex;
                                    break;
                                case 's':
                                case 'S':
                                    activeIndex++;
                                    activeIndex = activeIndex > 1 ? 0 : activeIndex;
                                    break;
                                case 'f':
                                    isExit = true;
                                    if (activeIndex == 0)
                                    {
                                        gameSence = 1;

                                    }
                                    else if (activeIndex == 1)
                                    {
                                        gameSence = 4;
                                    }
                                    break;
                            }
                            if (isExit)
                            {
                                break;
                            }

                        }
                        break;
                    #endregion
                    case BATTLE:
                        Console.Clear();
                        #region 游戏场景

                        #region 固定外墙
                        Console.ForegroundColor = ConsoleColor.Red;
                        // 横着的
                        for (int i = 0; i < Console.BufferWidth; i+=2)
                        {

                            Console.SetCursorPosition(i, 0);
                            Console.Write(SQUARE);
                            Console.SetCursorPosition(i, 40);
                            Console.Write(SQUARE);
                            Console.SetCursorPosition(i, 49);
                            Console.Write(SQUARE);
                        }
                        // 竖着的
                        for(int i = 0;i < Console.BufferHeight; i++)
                        {
                            Console.SetCursorPosition(0, i);
                            Console.Write(SQUARE);
                            Console.SetCursorPosition(98, i);
                            Console.Write(SQUARE);
                        }


                        #endregion



                        //渲染初始角色和怪物
                        // 战斗相关
                        //战斗数据
                        int heroAtk = 0, heroDef = 10, heroHp = 20, heroDmg = 0;
                        int monsAtk = 0, monsDef = 12, monsHp = 40, monsDmg = 0;

                        //位置数据
                        int heroXPos = 10, heroYPos = 20;
                        int monsXPos = 50, monsYPos = 30;
                        int priXPos = 20, priYPos = 10;
                        

                        //控制
                        bool isPrinceExis = false;
                        bool isBossNearby = false;
                        bool isPrinceNearby = false;
                        // 渲染角色和怪物图标
                        Console.ForegroundColor = HEROCOLOR;
                        Console.SetCursorPosition(heroXPos, heroYPos);
                        Console.Write(HERO);
                        Console.ForegroundColor = MONSCOLOR;
                        Console.SetCursorPosition(monsXPos, monsYPos);
                        Console.Write(MONSTER);
                        //移动控制
                        char playerInput = ' '; // 这里如果还用前面的userInput 会报 CS0136 
                        while (true)
                        {
                            playerInput = Console.ReadKey(true).KeyChar;
                            //清除上一个位置
                            Console.SetCursorPosition(heroXPos, heroYPos);
                            Console.Write("  ");
                            // 输入
                            switch (playerInput)
                            {
                                case 'w':
                                    heroYPos--;
                                    break;
                                case 's':
                                    heroYPos++;
                                    break;
                                case 'a':
                                    heroXPos -= 2;
                                    break;
                                case 'd':
                                    heroXPos += 2;
                                    break;

                            }
                        
                            //边界检测
                            heroXPos = heroXPos < 2 ? 2 : heroXPos;
                            heroXPos = heroXPos > 96 ? 96 : heroXPos;
                            heroYPos = heroYPos < 1? 1 : heroYPos;
                            heroYPos = heroYPos > 39 ? 39 : heroYPos;
                            //和boss碰撞检测
                            
                            if (monsHp>0&&(heroXPos == monsXPos && (heroYPos == monsYPos +1|| heroYPos == monsYPos-1))||(heroYPos ==monsYPos &&(heroXPos == monsXPos -2 || heroXPos ==monsXPos+2))) { 
                                isBossNearby = true;
                            }
                            else
                            {
                                isBossNearby = false;
                            }


                            //更新位置
                            Console.SetCursorPosition(heroXPos, heroYPos);
                            Console.ForegroundColor = HEROCOLOR;
                            Console.Write(HERO);
                            // 在BOSS旁就进入战斗
                            if (isBossNearby)
                            {
                                #region 战斗部分


                                Console.SetCursorPosition(2, msgBorder + 2); //meg第一行的位置
                                Console.WriteLine("开始战斗,按f继续");
                                char battleInput;
                                // 战斗确认
                                do
                                {
                                    battleInput = Console.ReadKey(true).KeyChar;

                                } while (battleInput != 'f');
                                // 战斗开始
                                Console.SetCursorPosition(2, msgBorder + 2);
                                //清除单行
                                for (int i = leftBorder; i < rightBorder; i++)
                                {
                                    Console.Write(' ');
                                }
                                Console.SetCursorPosition(2, msgBorder + 2);
                                Console.WriteLine("战斗开始!按d攻击");
                                // 战斗逻辑
                                while (true)
                                {
                                    // 一次互相攻击
                                    heroAtk = rand.Next(8, 20);
                                    monsAtk = rand.Next(8, 13);
                                    heroDmg = heroAtk - monsDef > 0 ? heroAtk - monsDef : 0;
                                    monsDmg = monsAtk - heroDef > 0 ? monsAtk - heroDef : 0;
                                    heroHp -= monsDmg;
                                    monsHp -= heroDmg;
                                    //日志
                                    // 按d攻击 
                                    do
                                    {
                                        battleInput = Console.ReadKey(true).KeyChar;
                                    } while (battleInput != 'd');
                                    Console.SetCursorPosition(2, msgBorder + 3);//清除第二行
                                    for (int i = leftBorder; i < rightBorder; i++)
                                    {
                                        Console.Write(' ');
                                    }
                                    Console.SetCursorPosition(2, msgBorder + 3);
                                    Console.ForegroundColor = ConsoleColor.White;

                                    
                                     

                                    Console.WriteLine($"你造成了 {heroDmg} 点伤害, 怪物还剩余 {monsHp} 点血量");
                                    Console.SetCursorPosition(2, msgBorder + 4);// 清除第三行
                                    for (int i = leftBorder; i < rightBorder; i++)
                                    {
                                        Console.Write(' ');
                                    }
                                    Console.SetCursorPosition(2, msgBorder + 4);
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine($"怪物造成了 {monsDmg} 点伤害, 你还剩余 {heroHp} 点血量");
                                    //战斗结束
                                    if (heroHp <= 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("你噶了");
                                        Console.WriteLine();
                                        break;
                                    }
                                    if (monsHp <= 0)
                                    {   
                                        //擦除怪物
                                        Console.SetCursorPosition(monsXPos, monsYPos);
                                        Console.Write("  ");
                                        monsXPos = -1;
                                        monsYPos = -1;
                                        // 擦除msg区域
                                        for (int i = 2; i < 5; i++)
                                        {
                                            Console.SetCursorPosition(2, msgBorder + i);
                                            for (int j = leftBorder; j < rightBorder; j++)
                                            {
                                                Console.Write(' ');
                                            }
                                        }
                                        Console.SetCursorPosition(2, msgBorder + 2);
                                        Console.WriteLine("你战胜了BOSS快去营救公主吧");
                                        Console.SetCursorPosition(2, msgBorder + 3);
                                        Console.WriteLine("在公主身边按F营救公主");
                                        break;
                                    }
                                    
                                    
                                }

                                //do
                                //{
                                //    battleInput = Console.ReadKey(true).KeyChar;
                                //} while (battleInput != 'f');
                                #endregion

                            }
                            // 救公主
                            // 生成公主图标
                            
                            if (monsHp < 0 && isPrinceExis == false)
                            {
                                //生成公主
                                Console.SetCursorPosition(priXPos, priYPos);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(princess); 
                                isPrinceExis = true;
                            }
                            // 公主碰撞检测
                            if (isPrinceExis)
                            {
                                if((heroXPos == priXPos && (heroYPos == priYPos + 1 || heroYPos == priYPos - 1)) || (heroYPos == priYPos && (heroXPos == priXPos - 2 || heroXPos == priXPos + 2)))
                                {
                                    isPrinceNearby = true;
                                }
                            }
                            if (isPrinceNearby)
                            {
                                char userInput ;
                                do
                                {
                                    userInput = Console.ReadKey(true).KeyChar;
                                } while (userInput!='f');
                                gameSence = END;
                                break;
                            }

                            
                        }

                        #endregion
                        
                        break;
                    case END:
                        #region 结束场景
                        // 结束场景
                        Console.Clear();
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition((Console.WindowWidth-8)/2,25);
                        Console.WriteLine("游戏结束, 你赢了!");
                        Console.WriteLine();
                        isExit = false;
                        
                        activeIndex = 0;
                        while (true)
                        {
                            if (activeIndex == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.SetCursorPosition((100 - 10) / 2, 27);
                            Console.WriteLine("返回主菜单");
                            Console.WriteLine();
                            if (activeIndex == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.SetCursorPosition((100 - 8) / 2, 29);
                            Console.WriteLine("退出游戏");
                            // 输入逻辑
                            char userInput = Console.ReadKey(true).KeyChar;

                            switch (userInput)
                            {
                                case 'w':
                                case 'W':
                                    activeIndex--;
                                    activeIndex = activeIndex < 0 ? 1 : activeIndex;
                                    break;
                                case 's':
                                case 'S':
                                    activeIndex++;
                                    activeIndex = activeIndex > 1 ? 0 : activeIndex;
                                    break;
                                case 'f':
                                    isExit = true;
                                    if (activeIndex == 0)
                                    {
                                        gameSence = 0;

                                    }
                                    else if (activeIndex == 1)
                                    {
                                        gameSence = 4;
                                    }
                                    break;
                            }
                            if (isExit)
                            {
                                break;
                            }

                        }

                        #endregion
                        break;
                    case QUIT:
                        Console.Clear();
                        Console.SetCursorPosition((100-21)/2,25);
                        Console.WriteLine("感谢游玩, 按任意键退出");
                        Console.ReadKey(true);
                        Environment.Exit(0);
                        break;
                        
                }

            }
                

               




                }
            }
            
            
            
        }
