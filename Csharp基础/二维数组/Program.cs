namespace 二维数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDarr = new int[2, 3]; // 构建对象声明二行三列的数组 ,默认值是0
            int[,] twoDarr2 = { { 1,2,3}
                               ,{ 4,5,6} }; // 直接声明
            Console.WriteLine(twoDarr2[0, 2]); // 第一行第二列

            //遍历二维数组
            for (int i = 0; i < twoDarr2.GetLength(0); i++) // 获取行
            {
                for (int j = 0; j < twoDarr2.GetLength(1); j++)// 获取列
                {
                    Console.Write(twoDarr2[i, j]);
                    Console.WriteLine($"索引是[{i},{j}]");
                }
            }

        }
    }
}