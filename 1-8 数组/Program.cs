using System;

// 任何类型都可以成为数组元素：
/* int[] nums;
 * string[] names;
 * float[] scores;
 * bool[] flags;
 * int[][] map; // int[]加上中括号代表数组类型的数组，即它是一个数组，每一个元素都是数组
 */


namespace _1_8_数组
{
    class Program
    {
        // 1.查找元素int FindElement(int[] array,int num);（寻找下标元素，没找到返回-1）
        static int FindElement(int[] array, int num)
        {
            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    return i;
                }
            }
            // 没有找到(之所以要在for循环后面加入没有找到：证明一个结论是悖论只需要一个反例，但是要证明一个恒成立，需要每一个都成立）
            return -1;
        }

        // 2.判断是否包含某元素
        static bool HasElement(int[] array,int num)
        {
            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    return true;
                }
            }
            // 没有找到
            return false;
        }

        // 3.求数组中最大的元素
        static int MaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                { max = array[i]; }
            }
            return max;
        }

        static void Main(string[] args)
        {
            // 1.数组基本操作
            int[] array = new int[8];
            int[] array2 = new int[] { 4, 5, 6, 7, 8, 9 };
            int[] array3 = { 4, 5, 6, 7, 8, 9 };
            string[] array_s = new string[] { "abc", "Hello", "Hi" };

            int[][][][][][] some_array;      // 不要使用嵌套数组

            // 写和读
            array[0] = 5;
            array[1] = 6;
            array[7] = 23;
            // array[8] = 23; IndexOutOfRangeException索引超出了数组界限

            // Console.WriteLine(array[7]);

            // 2.数组不支持增加，删除元素

            // 数组内置了部分函数，可以方便使用（二分查找，拷贝，FindIndex，LastIndexOf）

            // for循环
            //for (int i = 0; i< array.Length;i++)
            //{
            //    Console.WriteLine(i + ":" + array[i]);
            //}

            //for (int i = 0; i < array_s.Length; i++)
            //{
            //    Console.WriteLine(i + ":" + array_s[i]);
            //}

            // 在array2数组中查找7
            //bool found = false;
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    if(array2[i] == 7)
            //    {
            //        Console.WriteLine("7的下标是:" + i);
            //        found = true;
            //        break;
            //    }
            //}
            //if (!found)
            //{
            //    Console.WriteLine("没有找到7。");
            //}

            //Console.WriteLine("7的下标是：" + Array.IndexOf(array2, 7));  // 如果显示下标是-1，则意味着没有找到（现在的显示是3）

            // 如果这个数组里面有多个7，那么IndexOf显示的是第一个显示的7，而LastIndexOf是最后一次出现的7

            // Reverse是颠倒整个数组，Sort是对数组进行自动的排序

            // 测试
            Console.WriteLine("array2中是否包含7" + HasElement(array2, 7));   // 结果是True或者False
            Console.WriteLine("array2中7的下标" + FindElement(array2, 7));    // 结果是下标
            Console.WriteLine("array2中的最大元素" + MaxElement(array2));     //结果是array2中的最大元素

            Console.ReadKey();



        }
    }
}
