using System.Data.SqlTypes;

namespace 循环switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 习题1

            
            string comment = "";
            // 初始化字符类型 ' ' 不能是空 字符串可以是空
            char pingDing = ' ';
           
            int salary = 0;
            const int baseSalry = 4000;
            Console.WriteLine("请输入评级");
            try
            {
                comment = Console.ReadLine();
                switch (comment)
                {
                    case "兴奋": 
                        salary = baseSalry+500;
                        pingDing = 'A';
                        break;
                    case "充实":
                        salary = baseSalry;
                        pingDing = 'B';
                        break;
                    case "还好吧":
                        salary = baseSalry - 300;
                        pingDing = 'C';
                        break;
                    case "难理解":
                        salary = (baseSalry - 500);
                        pingDing = 'D';
                        break;
                    case "枯燥乏味":
                        salary = (baseSalry - 800);
                        pingDing = 'E';
                        break;

                }
                Console.WriteLine($"唐老狮的工资是:{salary}");
            }
            catch (Exception)
            {

                throw;
            }
            #endregion
            #region 习题2
            char userChoice = ' ';
            int sells = 0, left = 0;
            const int money = 10;
            const int midCup = 5, bigCup = 7, largeCup = 11;
            

            string userInput = "";
            Console.WriteLine("输入你选择的型号");
            try
            {
                userInput = Console.ReadLine();
                userChoice = char.Parse(userInput);
                switch (userChoice)
                {
                    case '1':
                        sells = 5;
                        break;
                    case '2':
                        sells = 7;
                        break;
                    case '3':
                        sells = 11;
                        break;
                    
                }
                // 把判断体最小化, 重复的部分提取出来放外面
                left = money - sells;
                if (left >= 0)
                {

                    Console.WriteLine($"购买成功,您还剩下{left}元");
                }
                else
                {
                    Console.WriteLine("钱不够");
                }

            }
            catch (Exception)
            {

                throw;
            }

            #endregion
            #region 习题3
            int stuScore = 0;
            char stuLevel = ' ';
            Console.WriteLine("输入考试成绩");
            try
            {
                stuScore = int.Parse(Console.ReadLine());
                int a = stuScore/10;
                switch (a)
                {
                    case 10:
                    case 9: stuLevel = 'A'; break;
                    case 8: stuLevel = 'B'; break;
                    case 7: stuLevel = 'C'; break;
                        case 6:stuLevel = 'D'; break;
                    default: stuLevel = 'E'; break;    
                }
                Console.WriteLine(stuLevel);
            }
            catch (Exception)
            {

                throw;
            }
            #endregion

            #region 习题4
            char userInput4 = ' ';
            char myOutput = ' ';
            Console.WriteLine("输入一个字符");
            try
            {
                userInput4 = char.Parse(Console.ReadLine());
                switch (userInput4)
                {
                    case '0':
                        myOutput = '零';
                        break;
                    case '1':
                        myOutput = '一';
                        break;
                    case '2':
                        myOutput = '二';
                        break;
                    case '3':
                        myOutput = '三';
                        break;
                    case '4':
                        myOutput = '四';
                        break;
                    case '5':
                        myOutput = '五';
                        break;
                    case '6':
                        myOutput = '六';
                        break;
                    case '7':
                        myOutput = '七';
                        break;
                    case '8':
                        myOutput = '八';
                        break;
                    case '9':
                        myOutput = '九';
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
            

            #endregion

        }
    }
}