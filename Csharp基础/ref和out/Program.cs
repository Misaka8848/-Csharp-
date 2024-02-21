namespace ref和out
{
    internal class Program
    {
        static void ChangeValue1(ref int a)
        {
            a = 1;
        }
        static void ChangeValue2(ref int[] a)
        {
            // a =  { 1, 2, }; C# 不允许在方法参数赋值时直接使用数组初始化语法
            a = new int[3] { 1, 2, 3 };
        }
        static void ChangeValue3(int[] a)
        {
            a[2] = 10;
        }
        static void Main(string[] args)
        {
            int aNmuber = 0;
            ChangeValue1(ref aNmuber);
            int[] aArr1 = { 1, 2, };
            ChangeValue2(ref aArr1);
            ChangeValue3(aArr1);

        }
    }
}