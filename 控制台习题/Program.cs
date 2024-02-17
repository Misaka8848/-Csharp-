using System.Diagnostics.Metrics;
using System;

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
            Console.SetCursorPosition(0, 0); //初始位置
            char userInput = ' ';
            
            int xMove = 0, yMove = 0;
            int xPos=0, yPos=0;
            Console.Write(square);
            Console.WriteLine();
            Console.Write("wasd移动,q退出");
            while (true)
            {
                userInput = Console.ReadKey(true).KeyChar;
                if (userInput == 'q') { break; }
                switch (userInput)
                {
                    case 'w': yMove = -1; xMove = 0; break;
                    case 's': yMove = 1; xMove = 0; break;
                    case 'a': xMove = -2; yMove = 0; break;
                    case 'd': xMove = 2; yMove = 0; break;
                    case 'q': Environment.Exit(0); break;
                    default: Console.WriteLine("输入wasd移动"); break;
                }
                xPos += xMove;
                yPos += yMove;
                xPos = xPos < 0 ? 0 : xPos;
                yPos = yPos < 0 ? 0 : yPos;
                Console.Clear();
                Console.SetCursorPosition(xPos, yPos);
                Console.Write(square);
            }
            Console.Clear();
            Console.WriteLine("游戏结束 任意键退出");
            Console.ReadKey();
            #region 喵喵老师
//            Alter，你提供的代码已经是一个很好的开始了！不过我注意到有几个地方可以进行优化，特别是关于方块移动的逻辑和控制台的显示效果。

//方块移动速度一致性：你的代码中，左右移动(a, d键)使用的是xMove = -2和xMove = 2，这是因为控制台中字符的高宽比不是1: 1，导致左右移动看起来比上下移动(w, s键)快。这种处理方式实际上是一个很好的解决方法，不过你可能需要根据实际的控制台字体和大小调整这个值。

//边界检查：你已经添加了代码来防止方块移出控制台的左边界和上边界。但如果用户的控制台窗口很小，方块可能会超出右边界或下边界。为了防止这种情况，你可以使用Console.WindowWidth和Console.WindowHeight来获取控制台窗口的宽度和高度，然后确保xPos和yPos不会让方块超出这些边界。

//退出逻辑：你的代码中有两处处理退出的逻辑（一处是检测到q键后跳出循环，另一处是case 'q'直接调用Environment.Exit(0)）。实际上，只需要一处即可。可以去掉case 'q'中的Environment.Exit(0)，因为当用户按下q时，循环将会自然结束。

//反馈给用户的信息：当用户按下非wasd或q的键时，你打印了“输入wasd移动”。不过由于你在下一次循环迭代之初就清空了控制台，这条信息会瞬间消失，用户可能看不到。你可以考虑在方块下方或者控制台的某个固定位置显示这条信息，直到下一个有效输入被接收。

//下面是根据上述建议优化后的代码片段：

//csharp
//Copy code
//namespace 控制台习题
//    {
//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                const char square = '□';
//                Console.CursorVisible = false;
//                Console.ForegroundColor = ConsoleColor.Yellow;
//                Console.BackgroundColor = ConsoleColor.Red;
//                Console.Clear();
//                char userInput = ' ';

//                int xMove = 0, yMove = 0;
//                int xPos = 0, yPos = 0;

//                while (true)
//                {
//                    Console.SetCursorPosition(0, 0);
//                    Console.Write(square);
//                    Console.SetCursorPosition(0, 1);
//                    Console.Write("wasd移动,q退出");
//                    userInput = Console.ReadKey(true).KeyChar;
//                    if (userInput == 'q') break;

//                    switch (userInput)
//                    {
//                        case 'w': yMove = -1; xMove = 0; break;
//                        case 's': yMove = 1; xMove = 0; break;
//                        case 'a': xMove = -2; yMove = 0; break;
//                        case 'd': xMove = 2; yMove = 0; break;
//                        default: Console.SetCursorPosition(0, 2); Console.Write("输入wasd移动"); continue;
//                    }

//                    xPos += xMove;
//                    yPos += yMove;
//                    xPos = Math.Max(0, Math.Min(Console.WindowWidth - 1, xPos));
//                    yPos = Math.Max(0, Math.Min(Console.WindowHeight - 2, yPos)); // 留出空间以避免覆盖提示信息

//                    Console.Clear();
//                    Console.SetCursorPosition(xPos, yPos);
//                    Console.Write(square);
//                }

//                Console.Clear();
//                Console.WriteLine("游戏结束 任意键退出");
//                Console.ReadKey();
//            }
//        }
//    }
//    注意，这里我做了几个调整：

//边界检查：现在xPos和yPos的值会被限制在0和控制台窗口大小之间，以防止方块移动到窗口外。
//用户非法输入反馈：当用户输入非wasd或q的键时，会在控制台的固定位置显示提示信息，直到下一个有效输入被接收。
            #endregion

        }
    }
}
