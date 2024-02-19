namespace 数组习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 习题1
            //1. 请创建一个一维数组并赋值，让其值与下标一样，长度为100
            int[] arr1 = new int[100];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = i;
            }
            #endregion
            #region 习题2
            //2. 创建另一个数组B,让数组A中的每个元素的值乘以2存入到数组B中
            int[] arrA = { 1, 2, 3 };
            int[] arrB = new int[3];
            for (int i = 0; i < arrB.Length; i++)
            {
                arrB[i] = 2 * arrA[i];
            }
            #endregion
            #region 习题3
            //3. 随机(0~100)生成1个长度为10的整数数组
            Random r = new Random();
            int[] arr3 = new int[10];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = r.Next(101);
            }

            #endregion
            #region 习题4
            int[] arr4 = new int[20];
            int avg = 0, min = int.MaxValue, max = int.MinValue, sum = 0;
            for (int i = 0; i < arr4.Length; i++)
            {
                arr4[i] = r.Next(1, 101);
                sum += arr4[i];
                if (arr4[i] < min)
                {
                    min = arr4[i];
                }
                if (arr4[i] > max)
                {
                    max = arr4[i];
                }
            }
            avg = sum / arr4.Length;


            #endregion
            #region 习题5
            //5. 交换数组中的第一个和最后一个、第二个和倒数第二个，依次类推，把数组进行反转并打印
            int[] arr5 = { 1, 2, 3, 4, 5 };
            int temp = 0;
            for (int i = 0; i < arr5.Length; i++)
            {
                if (i == arr5.Length / 2) break;
                temp = arr5[arr5.Length - 1 - i];
                arr5[arr5.Length - 1 - i] = arr5[i];
                arr5[i] = temp;

            }
            for (int i = 0; i < arr5.Length; i++)
            {
                Console.Write(arr5[i]);
            }
            // 不能直接Console.WriteLine(arr5);
            #endregion
            #region 习题6
            //6. 将一个整数数组的每一个元素进行如下的处理：如果元素是正数则将这个位置的元素值加1：如果元素是负数则将这个位置的元素值减1：如果元素是0，则不变
            int[] arr6 = new int[20];
            for (int i = 0; i < arr6.Length; i++)
            {
                arr6[i] = r.Next(-100, 101);

            }
            for (int i = 0; i < arr6.Length; i++)
            {
                if (arr6[i] == 0)
                {
                    continue;
                }
                if (arr6[i] > 0)
                {
                    arr6[i]++;
                }
                if (arr6[i] < 0)
                {
                    arr6[i]--;
                }
            }
            #endregion
            #region 习题7
            //7. 定义一个有10个元素的数组，使用for循环，输入10名同学的数学成绩，将成绩依次存入数组，然后分别求出最高分和最低分，并且求出10名同学的数学平均成绩
            int[] arr7 = new int[10];
            string userInput = " ";
            int min7 = int.MaxValue, max7 = int.MinValue, avg7 = 0, sum7 = 0;
            for (int i = 0; i < arr7.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("输入成绩");
                        userInput = Console.ReadLine();
                        arr7[i] = int.Parse(userInput);
                        break;
                    }
                    catch (Exception)
                    {

                        throw;

                    }
                }
                sum7 += arr7[i];
                if (arr7[i] > max)
                {
                    max7 = arr7[i];
                }
                if (arr7[i] < min)
                {
                    min7 = arr7[i];
                }
            }
            avg7 = sum7 / arr7.Length;

            #endregion
            #region 习题8
            // 8. 请声明一个string类型的数组（长度为25）（该数组中存储着符号），通过遍历数组的方式取出其中存储的符号打印出以下效果
            string[] arr8 = new string[25];
            for (int i = 0; i < arr8.Length; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write("\n");
                }
                if ((i + 1) % 2 == 1)
                {
                    arr8[i] = "□";
                }
                else
                {
                    arr8[i] = "■";
                }
                Console.Write(arr8[i]);

            }
            #endregion

        }
    }
}