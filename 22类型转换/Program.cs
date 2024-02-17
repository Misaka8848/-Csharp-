using System.Security.Cryptography.X509Certificates;

namespace _22类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ushort a = 1;
            //int b =2;
            //a = b;
            //b = a;
            //const string lenggou = "❄️🐶";

            #region 隐式转换
            //double -> float -> 整型 -> char
            //decimal -> 整型 -> char
            //long -> int -> short -> sbyte
            //ulong -> uint -> ushort -> byte
            //
            #endregion

            #region 显式转换
            // 强制转换 只适用于基本类型转换 string是引用类型
            // int a2 = (int)"2";转换不了
            int a1 = (int)22.5;// 22 不四舍五入
            

            //显式转换 Parse
            int i4 = int.Parse("1234");

            
            //显式转换 Convert
            int a2 = Convert.ToInt32(22.5); // 23 会四舍五入
            
            //布尔转数值
            int a3 = Convert.ToInt32(true); // 1
            int a4 = Convert.ToInt32(false); // 0 

            //字符转数值
            int a5 = Convert.ToInt32('A'); //65 A的ASCII码
            Console.WriteLine(a5);

            // int32就是int, int64是long, int16是short
            sbyte sb1 = Convert.ToSByte("12");
            int i1 = Convert.ToInt32("12");
            short s1 = Convert.ToInt16("12");
            long l1 = Convert.ToInt64("12");

            byte b = Convert.ToByte("1");
            ushort us = Convert.ToUInt16("2");
            uint ui = Convert.ToUInt32("1");
            ulong l = Convert.ToUInt64("1");

            float f = Convert.ToSingle("1");
            double d = Convert.ToDouble("1");
            decimal de = Convert.ToDecimal("1");

            //bool bl = Convert.ToBoolean("1");是不对的,不能把字符串1转换成bool
            bool bl = Convert.ToBoolean(1);

            char c = Convert.ToChar(24069); //可以转Unicode 反之一样
            string str = Convert.ToString("1");

            // ToString 任何其他类型都有ToString

            string str2 = 1.ToString();// str2 == 1
            string str3 = 1 + str2; // str3 == 2  这里的1 执行了1.ToString()
            #endregion
            #region 隐式转换习题
            //第一题
            //存储范围小的赋值给存储内容大的变量时候会隐式转换
            //比如
            int aa1 = 0;
            short ss1 = 0;
            float ff1 = 1;
            aa1 = ss1;
           

            #region 第二题
            int firName = '赵';
            int secName = '博';
            int tirName = '涵';
            Console.WriteLine(firName+" "+secName+" "+tirName);
            #endregion
            #endregion
            #region 显式转换习题
            #region 习题1
            //强制转换
            //语法是(目标类型)表达式
            //不会四舍五入
            int i22 = (int)1.2f;

            //Parse
            //语法是 数据类型.Parse(字符串) 专门把字符串转换为其他变量
            int i23 = int.Parse("1");
            // int i24 = int.Parse("1.0"); 错误

            bool b22 = bool.Parse("true");
            Console.WriteLine(i23+" "+b22);

            //Convert.To数据类型(表达式)
            int i31 = Convert.ToInt32(3.4); //四舍五入
            sbyte sb31 = Convert.ToSByte("1");
            short s31 = Convert.ToInt16("1");
            long l31 = Convert.ToInt64("1");

            float fl31 = Convert.ToSingle("2");
            double d31 = Convert.ToDouble("2");

            char c31 = Convert.ToChar(1); // 这里会把1视为Unicode码 运行结果为 □
            char c32 = Convert.ToChar("1");// 这里会把1视为字符的1 运行结果为 1
            Console.WriteLine(c32+"ga");
            #endregion
            #region 习题2
            char c21 = Convert.ToChar(24069);
            char c22 = (char)24069;
            
            #endregion
            #region 习题3
            string userName = "";
            sbyte litScore = 0, mathScore = 0, engScore = 0;

            Console.WriteLine("输入姓名");
            userName = Console.ReadLine()!;
            Console.WriteLine("输入语文成绩");
            litScore = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("输入数学成绩");
            mathScore = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("输入英语成绩");
            engScore = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine(userName+"的成绩分别是: "+litScore+" "+mathScore+" "+engScore);
            #endregion
            #endregion


        }
    }
}