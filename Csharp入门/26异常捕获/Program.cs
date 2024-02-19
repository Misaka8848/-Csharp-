namespace _26异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 作用
            //Console.WriteLine("异常捕获");
            //Console.WriteLine("输入年龄");
            //// 这里默认用户输入的会是整数,没有考虑意外, Parse(字符串)如果输入了转换不了的就会报错卡死
            //// 异常捕获可以避免这点
            //string str = Console.ReadLine();

            //int age = int.Parse(str);
            //Console.WriteLine("年龄是:" + age);
            #endregion


            #region 基本语法
            
            try
            {
                //希望进行异常捕获的代码,注意相关的代码都要放进去,比如对出错代码的引用
                //如果出错 不会卡死程序 而是转到catch

            }
            catch (Exception e)
            {

                //catch (Exception e)可以通过e得到具体的错误
            }
            finally
            {
                //无论如何都会执行的代码
            }
            #endregion
            #region 实践
            //try
            //{
            //    string str = Console.ReadLine();
            //    int i = int.Parse(str);
            //    Console.WriteLine(i);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("非法输入");
            //}
            #endregion
            #region 练习题一
            Console.WriteLine("请输入一个数字");
            try
            {
                string str2 = Console.ReadLine();
                float i = float.Parse(str2);
            }
            catch (Exception e)
            {
                Console.WriteLine("输入有误");
            }
            #endregion
            #region 练习题二
            int yuWen = 0, shuXue = 0, yingYu = 0; // 初始化 即使
            string name = "";
            Console.WriteLine("输入姓名");
            string str = Console.ReadLine();
            name = str;

            try
            {
    
                Console.WriteLine("输入语文成绩");
                str = Console.ReadLine();
                yuWen = int.Parse(str);
                Console.WriteLine("输入数学");
                str = Console.ReadLine();
                shuXue = int.Parse(str);
                Console.WriteLine("输入英语");
                str = Console.ReadLine();
                yingYu = int.Parse(str);
            }
            catch (Exception)
            {

                Console.WriteLine("输入有误");
            }
            
            

            Console.WriteLine(yuWen+shuXue+yingYu);
            #endregion
        }
    }
}