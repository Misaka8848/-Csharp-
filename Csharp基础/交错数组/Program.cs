namespace 交错数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1 };
            arr[1] = new int[] { 1, 2 };
            arr[2] = new int[] { 1, 2, 3 };

            //访问
            int a = arr[0][0];
        }
    }
}