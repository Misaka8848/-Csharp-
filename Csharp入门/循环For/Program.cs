namespace 循环For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 习题1
             for (int i = 1; i <= 100; i++) {
                Console.WriteLine(i);
            }
            #endregion
            #region 习题2
            int mySum2 = 0;
            for(int i = 1;i <= 100;i++) {
                if (i %2 ==0) {
                    mySum2 += i;
                }
            }
            #endregion
            #region 习题3
            
            for (int i = 100;i<999; i++) {
                int Bai = i / 100;
                int Shi = (i % 100) / 10;
                int Ge = (i % 100) % 10;
                if (i == Ge*Ge*Ge+Shi*Shi*Shi+Bai*Bai*Bai) {
                    Console.WriteLine(i);    
                }
            }
            #endregion
            #region 习题4
            string outPut;
            for(int i = 1;i<=9;i++)
            {
                for(int j = 1;j<=i;j++)
                {
                    outPut = $" [{j}*{i}={i*j}]  ";
                    Console.Write(outPut);
                    if (i == j) { Console.Write("\n"); }
                }
                
            }
            #endregion
            #region 习题5
            for (int j = 1; j <= 10; j++)
            {
                switch (j)
                {
                    case 1:                        
                    case 10:
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write('*');
                    }
                    break;
                    default:
                        for (int i = 1; i <= 10; i++)
                        {
                            if (i == 1 || i == 10)
                            {
                                Console.Write('*');
                            }
                            else { Console.Write(' '); }
                            
                        }; break;
                }
            }
         
            #endregion
            #region 习题6
            for(int i = 1; i <= 10; i++)
            {
                for(int j =1; j <= i; j++)
                {
                    Console.Write('*');
                    if(i == j) { Console.Write('\n'); }
                }
            }
            #endregion
            #region 习题7
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 2; j <= i; j++)
            //    {
            //        Console.Write('*');

            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write('*');
            //        if (i == j) { Console.Write('\n'); }
            //    }
            //}
            //*   会变成这样
            //***
            //*****
            //*******
            //*********
            //***********
            //*************
            //***************
            //*****************
            //*******************

            #endregion
            #region 习题7
            for ( int i = 1;i <= 10; i++)
            {
                for (int j =1; j <= 10 - i; j++)
                {
                    Console.Write(' ');
                }
                for (int j =1; j <= 2*i-1; j++)
                {
                    Console.Write('*');
                    
                }
                Console.WriteLine();//换行
            }
            #endregion
        }
    }
}