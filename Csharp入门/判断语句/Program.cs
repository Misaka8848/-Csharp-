namespace 判断语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("条件判断");
            // if... else
            // if 单独使用
            // 如果是真 就执行方括号.否则不执行
            if (false) { Console.WriteLine("执行了"); }
            Console.WriteLine("外貌");
            // if else
            // 如果为真 就执行第一个括号 假就执行第二个括号
            if (true) { }
            else { }

            // switch
            // 括号里必须是整型或没举行变量
            // case 后面必须是一个常量数值
            // 遇到break就终止Switch, 最好每个case都写break
            int i = 0;
            switch (i)
            {
                case 0:
                    Console.WriteLine("i=0");
                    break;
                case 1:
                    Console.WriteLine("i=1");
                    break;

                    { }

            }
            #region 习题1
            int userAge = 0;
            Console.WriteLine("输入你的年龄");
            try
            {
                userAge = int.Parse(Console.ReadLine());
                if (userAge > 60)
                {
                    Console.WriteLine($"今年不用缴纳交了{userAge}岁税, 享受你的晚年吧!");
                }


            }
            catch { Console.WriteLine("输入有误"); }


            #endregion
            #region 习题2
            float litS = 0, mathS = 0, engS = 0;
            bool exp1 = litS > 70 && mathS > 80 && engS > 90;
            bool exp2 = litS == 100 || mathS == 100 || engS == 100;
            bool exp3 = litS + mathS + engS > 270;
            string comment = exp1 || exp2 || exp3 ? "非常优秀" : "优秀";



            #endregion
            #region 习题3
            float myScore = 90;
            if (myScore >= 90)
            {
                Console.WriteLine("奖励100元");
            }
            else
            {
                Console.WriteLine("一个月不能玩游戏");
            }
            #endregion
            #region 习题4
            int a = 0, b = 0, outPut=0;
            
            try
            {
                Console.WriteLine("输入a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("输入b");
                b = int.Parse(Console.ReadLine());
                outPut = (a % b == 0 || b % a == 0) || (a + b > 100) ? a : b;
                
            }
            catch (Exception)
            {

                throw;
            }

            #endregion
            #region 习题5
            int a5 = 6;
            if (a5 % 2 ==0) {
                Console.WriteLine("your input is even");
            }else  {
                Console.WriteLine("your input is odd");
            }

            #endregion

            #region 习题6
            int a6 = 1, b6 = 2, c6 = 3;
            int max1 = a6>=b6?a6:b6;
            int max2 = max1>=c6?max1:c6;
            #endregion
            #region 习题7
            string userInput = "";
            double userInput2 = 0;
            Console.WriteLine("请输入一个字符");
            try
            {
                userInput = Console.ReadLine();
                userInput2= double.Parse(userInput);
                if(userInput2>=0&&userInput2<=9)
                {
                    Console.WriteLine("您输入了一个数字");
                }
                else
                {
                    Console.WriteLine("这不是一个数字");
                }
            }
            catch (Exception)
            {

                throw;
            }

            #endregion
            #region 习题8
            string userName = "", userPas = "";
            try
            {
                Console.WriteLine("请输入用户名");
                userName = Console.ReadLine();
                Console.WriteLine("请输入密码");
                userPas = Console.ReadLine();
                if (userName=="admin"&&userPas=="8888") { Console.WriteLine("bingo"); }
                else if (userName != "admin")
                {
                    Console.WriteLine("用户名不存在");
                }else if (userName == "admin")
                {
                    Console.WriteLine("密码错误");
                }
            }
            catch (Exception)
            {

                throw;
            }

            #endregion
            #region 习题9
            int userAge1 = 0;
            Console.WriteLine("输入你的年龄");
            userAge1 = int.Parse(Console.ReadLine());
            if (userAge1 >= 18)
            {
                Console.WriteLine("可以查看");
            }
            else if (userAge1 < 13)
            {
                Console.WriteLine("不可以查看");
            }
            else
            {
                string userInput3 = "", output3 = "";

                Console.WriteLine("是否继续看输入yes或no");
                userInput3 = Console.ReadLine();
                output3 = userInput3 == "yes" ? "请查看" : "退出";
                Console.WriteLine(output3);

            }
            #region 习题10
            // b=6
            #endregion
            #endregion
        }
    }
}