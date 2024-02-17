using System.Diagnostics.CodeAnalysis;

namespace 循环While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 习题1
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
            #endregion
            #region 习题2
            int i2 = 1,mySum = 0;
            while (i2 <= 100)
            {
                mySum += i2;
                i2++;
            }
            #endregion
            #region 习题3
            int i3 = 0, mySum3 = 0;
            while (i3 <= 100)
            {
                
                if (i3 / 7 == 0)
                {
                    i3++;
                    continue;
                }
                i3++;
                mySum3 += i3;
                
            }
            #endregion
            #region 习题4
            int userInput4 = 0; 
            int n4 = 2;
            bool isPrime = true;
            Console.WriteLine("输入一个数字");
            try
            {
                userInput4 = int.Parse(Console.ReadLine());
                if (userInput4 < 2)
                {
                    Console.WriteLine("这不是质数");
                }
                else
                {
                    while (n4 < userInput4)
                    {
                        if (userInput4 % n4 == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        
                        n4++;
                        
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("这是质数");

                }else { Console.WriteLine("这不是质数"); }


                
                
            }
            catch (Exception)
            {

                throw;
            }

            #endregion
            #region 习题5
            string userName = "";
            string userPassword = "";
            while (true)
            {
                Console.WriteLine("请输入用户名");
                userName = Console.ReadLine();
                Console.WriteLine("请输入密码");
                userPassword = Console.ReadLine();
                if(userName == "admin"&&userPassword== "8888") {
                    break;
                }
                Console.WriteLine("用户名或密码错误");
            }



            #endregion
            #region 习题6
            int classNumber = 0, mySum6 = 0, avg = 0, i6 = 1;
            Console.WriteLine("输入班级人数");
            try
            {
                classNumber = int.Parse(Console.ReadLine());
                while (i6<=classNumber) {
                    Console.WriteLine();
                }

            }
            catch (Exception)
            {

                throw;
            }



            #endregion
            #region 习题7
            int sum7 = 0;
            int i7 = 1;
            while (i7 <= 100)
            {
                sum7 += i7;
                
                if (sum7>500) { break; }
                i7++;
            }
            Console.WriteLine($"第{i7}个数");

            #endregion
            #region 习题8
            float i8 = 100;
            float n8 = 0;
            while (i8<1000) {
                i8 *= 1.2f;
                n8++;
            }
            Console.WriteLine($"经历过{n8}个月 到达1000人");
            #endregion
            #region 习题9
            //int j1 = 1, j2 = 1, j3 = 0, j4 = 0, i9 = 0;  明确每个变量确切含义 i9是计数器代表当前是第几个数 我们是从第三个数开始计算的 循环过后i9+1代表当前数 所以初始为2
            //while (i9<20) {
            //    j3 = j1 + j2;
            //    j4 = j2+ j3;
            //    j1 = j3;
            //    j2 = j4; 简化逻辑 最基本的结构 就是 3 = 1 + 2
            //    i9++;    
            //}
            //Console.WriteLine($"第20位是{j4}");
            int j1 = 1, j2 = 1, j3 = 0, i9 = 2; // 注意这里将i9初始化为2，因为我们已经有了前两个数
            while (i9 < 20)
            {
                j3 = j1 + j2;
                j1 = j2;
                j2 = j3;
                i9++;
            }
            Console.WriteLine($"第20位是{j3}");

            #endregion
            #region 习题10
            //int i10 = 2, j10 = 2;
            //while (i10<=100) {
           
            //    while (j10 < i10)先写里层循环 再写外层循环
            //    {
            //        if(i10 % j10 == 0)
            //        {
            //            Console.WriteLine(i10); 里层循环目的是确定是否为prime 要返回一个bool 这样明确
            //        }                                    
            //        j10++;
            //    }
            //    i10++;  

            //}
            int i10 = 2;
            while (i10 < 100)
            {
                int j10 = 2; // 每次都初始化 
                bool isPrime10 = true;
                while (j10 < i10)
                {
                    if (i10 % j10 == 0)
                    {
                      
                        isPrime10 = false;
                        break;

                    }
                    j10++;
                }
                if (isPrime10)
                {
                    Console.WriteLine(i10);
                }
                
                i10++;
            }
            #endregion

        }
    }
}