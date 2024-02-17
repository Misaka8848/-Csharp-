namespace _28算数运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("算术运算符");
            #region 知识点一: 赋值符号
            // = 
            // 把右侧的值赋值给左侧
            // 右侧表达式计算完了之后赋值给左面

            string name = "jewer";
            int i1 = 0;

            #endregion
            #region 算术运算符
            int a1 = 1, b1 = 2,c1 = 3;
            float a2 = 1.0f, b2 = 3.0f, c2 = 1.1f;
            // + 
            Console.WriteLine(a1 + b1);

            // - 
            Console.WriteLine(a1 - b1);
            // *
            Console.WriteLine(a1 * b1);
            // /
            // 除法如果都是整数 那么会截断小数, 如果有一个是浮点数 那么就会保留小数
            Console.WriteLine(a1 / b1);
            Console.WriteLine(a2 / b1);
            // 无限小数会四舍五入
            Console.WriteLine(a2 / b2);

            //整除 返回余数 可以是浮点数
            Console.WriteLine("%"+c2 % b2);
            Console.WriteLine(5.5%2.0);

            // 后缀++ 先取值 最后+1
            a1 = b1++;
            // 前缀++ 先操作后操作


            a1 = ++b1;
            Console.WriteLine(a1+"++"+b1);
            #endregion
            #region 习题一
            int age = 0;
            age += 10;
            Console.WriteLine(age);
            #endregion
            #region 习题二
            const float PI = 3.14f;
            int roundR = 5;
            float roundS = 0, roundL = 0;
            roundL = 2 * PI  *roundR;
            roundS = PI * roundR * roundR;
            Console.WriteLine("周长: "+ roundL+" 面积: "+ roundS);
            #endregion
            #region 习题三
            int litS = 1, mathS = 2, engS = 1;
            
            // 要加上括号 不然从左到右执行 全转成字符串了
            // 平均分除以3f 就可以出小数der
            Console.WriteLine("总分是: "+ (litS+mathS+engS)+"平均分是: "+(litS + mathS + engS)/3f);
            // 
            #endregion
            #region 习题四
            int priceL = 285 * 2 + 720 * 3;
            // float只能float相乘
            float countP = 0.38f * priceL;

            #endregion
            #region 习题五
            // 31 30 42
            #endregion
            #region 习题六
            int a6 = 99, b6 = 87, c6 = 0;
            c6 = a6;
            a6 = b6;
            b6 = c6;
            #endregion
            #region 习题七
            int dayT= 0, hourT= 0, minT = 0, secT = 0;
            const int TT = 987652;
            secT = TT % 60;
            minT = (TT % (60 * 60))/60;
            dayT = TT / (60 * 60 * 24);
            hourT = (TT % (60 * 60 * 24))/3600;
            Console.WriteLine("天数"+dayT+"小时"+hourT+"秒数"+secT+"分钟"+minT);
            #endregion
        }
    }
}