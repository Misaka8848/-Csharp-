namespace 其他运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sizeof()返回数据类型的大小,整数 单位字节
            int intSize = sizeof(int);
            // ?: 条件表达式
            // 表达式1 ? 表达式2 : 表达式3 如果表达式1为真就返回表达式2的值否则3
            int hp = 0;
            bool gameOver = false;
            gameOver = hp > 0 ? false : true;
            Console.WriteLine(gameOver);

            #region 习题1
            int a1=1 ,b1=2 , max1;
            max1 = b1 > a1 ? b1 : a1;
            Console.WriteLine(max1);

            #endregion
            #region 习题2
            string userInput, outPut;
            Console.WriteLine("输入一个姓名");
            userInput = Console.ReadLine();
            outPut = userInput == "帅哥" ? "帅哥" : "美女";
            Console.WriteLine("你好," + userInput + outPut);
            #endregion
            #region 习题3
            string stuName = "";
            float cSharpScr = 0, unityScr = 0;
            bool graduate = false;
            Console.WriteLine("输入C#成绩");
            cSharpScr = float.Parse(Console.ReadLine());
            Console.WriteLine("输入unity成绩");
            unityScr = float.Parse(Console.ReadLine());
            graduate = cSharpScr > 90 && unityScr > 90 ? true : false;
            Console.WriteLine("你的毕业状态是:" + graduate);
            #endregion
            #region 习题4
            int yearInput = 0;
            bool isRunYear = false;
            Console.WriteLine("输入年份");
            try
            {
                yearInput = int.Parse(Console.ReadLine());
                // 错isRunYear = yearInput % 400 == 0 ? true : false;
                // 加括号可以先判断左边是否满足 方便短路
                isRunYear = (yearInput % 400 == 0) ||yearInput %4==0 && yearInput %100 !=0;
                Console.WriteLine(isRunYear);
            }
            catch (Exception)
            {

                Console.WriteLine("输错了");
            }
            
            #endregion

        }
    }
}