namespace 冒泡排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] arr = new int[100];
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
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }


                }
            }

        }
    }
}