using System.Runtime.InteropServices;

namespace 营救公主游戏
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int START = 0, BATTLE = 1, END = 2;
            const char SQUARE = '▓';
            const int WIDTH = 100;
            const int HEIGHT = 50;
            int activeIndex = 0;
            int gameSence = BATTLE;
            bool isExit = false;
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
                        
                        int topBorder = 1, megBorder = 38, bottBorder = 48;
                        int leftBorder = 2, rightBorder = 96;
                        
                        // 战斗相关
                        const char HERO = '\u25CF';
                        const char MONSTER = '\u25A0';
                        
                        for (int j =0; j<2;j++)
                        {
                            
                            // 渲染敌人和主角

                            

                            int heroXPos = rand.Next(1, Console.WindowWidth - 2);
                            int heroYPos = rand.Next(1, 39);
                            int monsXPos = rand.Next(1, Console.WindowWidth - 2);
                            int monsYPos = rand.Next(1, 39);
                            bool isBattle = false;
                            

 

                            
                            while (!isBattle)
                            {
                                
                                //渲染边框 每次都要重新画
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Magenta;

                                for (int i = 0; i < Console.WindowWidth; i++)
                                {
                                    Console.Write('▓');
                                }
                                Console.SetCursorPosition(0, 39);
                                for (int i = 0; i < Console.WindowWidth; i++)
                                {
                                    Console.Write('▓');
                                }
                                Console.SetCursorPosition(0, 49);
                                for (int i = 0; i < Console.WindowWidth; i++)
                                {
                                    Console.Write('▓');
                                }
                                // 竖着的
                                for (int i = 0; i < Console.WindowHeight; i++)
                                {
                                    Console.SetCursorPosition(0, i);
                                    Console.Write('▓');

                                }

                                for (int i = 0; i < Console.WindowHeight; i++)
                                {
                                    Console.SetCursorPosition(98, i);
                                    Console.Write('▓');

                                }
                                // 渲染玩家和怪物
                                Console.SetCursorPosition(heroXPos, heroYPos);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(HERO);
                                Console.SetCursorPosition(monsXPos, monsYPos);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(MONSTER);

                                // 战斗检测
                                if ((heroYPos == monsYPos && (heroXPos == monsXPos - 2 || heroXPos == monsXPos + 2)) || (heroXPos == monsXPos && (heroYPos == monsYPos - 1 || heroYPos == monsYPos + 1)))
                                {
                                    isBattle = true;
                                    break;

                                }
                                //获取输入
                                char userInput1 = Console.ReadKey(true).KeyChar;
                                switch (userInput1)
                                {
                                    case 'w':
                                        heroYPos -= 1;
                                        heroYPos = heroYPos < topBorder ? topBorder : heroYPos;

                                        break;
                                    case 'a':
                                        heroXPos -= 2;
                                        heroXPos = heroXPos < leftBorder ? leftBorder : heroXPos;
                                        break;
                                    case 's':
                                        heroYPos += 1;
                                        heroYPos = heroYPos > megBorder ? megBorder : heroYPos;
                                        break;
                                    case 'd':
                                        heroXPos += 2;
                                        heroXPos = heroXPos > rightBorder ? rightBorder : heroXPos;
                                        break;
                                }
                                

                            }

                            // 战斗
                            Console.SetCursorPosition(leftBorder,megBorder+2);
                            Console.WriteLine("开始战斗,按F继续");
                            
                            int heroAtk = 0;
                            int monsDef = 10;
                            int monsHeal = 20;
                            int dmg = 0;
                            
                            while(true)
                            {
                                char userInput = Console.ReadKey(true).KeyChar;
                                if (userInput == 'f')
                                {
                                    // 打怪物模拟
                                    while (monsHeal > 0)
                                    {
                                        // 战斗逻辑
                                        heroAtk = rand.Next(8, 13);
                                        dmg = heroAtk - monsDef > 0 ? heroAtk - monsDef : 0;
                                        monsHeal -= dmg;

                                        // 日志渲染
                                    }
                                }
                                

                            }
                            
                            
                           
                            


                            
                            
                        }
                        

                        break;

                }
            }
            
            
            
        }
    }
}