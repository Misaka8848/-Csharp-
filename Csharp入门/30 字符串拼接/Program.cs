namespace _30_字符串拼接
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //string str = "123";
            ////用+拼接
            //str += "456";
            //// 复合运算符
            //str += "7";
            //// 自动调用 .ToString 是隐式转换
            //str += 8;
            //// 会传染, +=优先级低于+
            //str += 1 + 2 + 3+4;
            #region 练习题1
            string userName = "Alter";
            Console.WriteLine("你好, "+userName);
            #endregion
            #region 练习题2
            string userName2 = "Alter";
            int age = 10;
            Console.WriteLine(userName2+age+"岁了");
            #endregion
            #region 练习题3
            string myName = "Alter";
            int myAge = 19;
            string myEmail = "4673422@qq.com";
            string myAddress = "翻斗花园";
            double mySalary = 8842138.2;
            Console.WriteLine("名字: "+ myName);
            Console.WriteLine("年龄: " + myAge);
            Console.WriteLine("邮箱: " + myEmail);
            Console.WriteLine("期望薪水: " + mySalary);
            Console.WriteLine("地址: " + myAddress);
            // Console.WriteLine("名字: {0}\n年龄: {1}\n邮箱: {2}\n",  ,   ,  );
            #endregion
            #region 练习题4
            string userName4 = "";
            int userAge4 = 0;
            string userClass = "";
            try
            {
                Console.WriteLine("输入你的用户名");
                userName4 = Console.ReadLine();
                Console.WriteLine("输入你的年龄");
                userAge4 = int.Parse(Console.ReadLine());
                Console.WriteLine("输入你的班级");
                userClass = Console.ReadLine();
            }
            catch 
            {
                Console.WriteLine("输入无效");
                
            }
            Console.WriteLine("你的用户名是: {0}, 年龄是: {1}, 班级是: {2}", userName4, userAge4, userClass);


            #endregion


        }
    }
}