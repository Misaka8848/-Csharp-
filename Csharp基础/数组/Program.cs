namespace 数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int[] arr; // 没有值 不占空间
            //int[] arr2 = new int[5];// 默认的值0 会占用空间
            //int[] arr3 = new int[5] { 1,2,3,4,5}; //指定值, 花括号必须和方括号数量一样
            //int[] arr4 = new int[] {1,2,3,4};
            //int[] arr5 = { 1, 2, 3, 4 };

            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            arr[0] = 22;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            // 增加元素减少元素都是通过声明一个新的 然后把原来的部分或者全部复制过去 然后把变量指向到新的内存 旧的失去引用就自动销毁了
            // 原理就是用新的代替旧的

            int[] arr2 = new int[6];

            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            arr = arr2;

            // 查找 也是要遍历
            int[] arr4 = { 1, 2, 3 };
            for (int i = 0; i < arr4.Length; i++)
            {
                if (arr4[i] == 2)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}