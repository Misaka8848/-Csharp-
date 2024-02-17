namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 习题1
            string userName = "";
            string userPassword = "";
            do
            {
                Console.WriteLine("输入用户名");
                userName = Console.ReadLine();
                Console.WriteLine("密码");
                userPassword = Console.ReadLine();

            } while (userName!= "admin" || userPassword!="8888" );
            #endregion
            #region 习题2
            string userInput2;
            do
            {
                Console.WriteLine("输入你的名字");
                userInput2 = Console.ReadLine();

            }while (userInput2 != "q");
            #endregion
        }

    }




}