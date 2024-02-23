namespace 选择排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] arr = new int[100];
            int maxIndex = 0;
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
                arr[i] = r.Next(101);
                if (arr[i] < 10)
                {
                    Console.Write(arr[i] + "  ");
                }
                else
                {
                    Console.Write(arr[i] + " ");

                }


            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }

                }
                temp = arr[i];
                arr[i] = arr[maxIndex];
                arr[maxIndex] = temp;


            }
        }
    }
}