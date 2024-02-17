namespace _33逻辑运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exp1 = 1 > 2; // F
            bool exp2 = 1 < 2; // T
            // 与 都T才T 有一个F就F
            bool andExp = exp1 && exp2;
            // 或 有一个T就T 都F才F
            bool orExp = exp1 || exp2;
            // ! 反转布尔 
            bool a = !true == false;
            Console.WriteLine(andExp+ " " + orExp);
            // 短路运算符 左面出结果 右面就不计算了
            // &&看有一个假就是假 没假就是真 ||看有一个真就是真 没有就是假
            // 对于与来说 一假都假
            bool andExp2 = 1<2 && 1>2+3*7612 ; // F
            // 对于或来说 一真都真 后面的一坨都wtf(whatever the fuck)
            bool andExp3 = 1 > 2 && 1 > 2 + 3 * 7612;//T
            #region 习题
            //1.true true true false false
            //2.true
            #endregion

        }
    }
}