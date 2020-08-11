using System;
namespace DSCodes.Main.Sort
{
    public class SortAlgorithm
    {

        public static void Print(int[] arr)
        {
            for (int i = 0, len = arr.Length; i < len; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine("");
        }
        public static void Bubble(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len - 1; i++) // 次数
            {
                for (int j = 0; j < len - 1 - i; j++) //对比
                {
                    int temp;
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void QuickSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                Console.WriteLine("范围：{0}~{1}", l, r);
                //p为快速排序返回的基准的位置
                int p = Partition2(arr, l, r);
                Print(arr);
                //对基准左边的数进行快排
                QuickSort(arr, l, p - 1);
                //对基准右边的数进行快排
                QuickSort(arr, p + 1, r);
            }
        }

        protected static int Partition2(int[] arr, int l, int r)
        {
            //基准元素设为最后一个
            int p = arr[l];
            Console.WriteLine("基准：{0}", p);
            //i指向第一个元素，j指向基准的前一个元素，
            int i = l, j = r;
            // 从左往右是找到大于基准的数，从右往左是找到小于基准的数
            Console.WriteLine("条件i和j，{0},{1}", i, j);

            while (i < j)
            {
                // 下面的顺序很重要，先找小，后找大，也就是先右到左，然后左到右
                // 从右往左找到大于等于基准的数，为之后找到小于基准的数创造条件
                while (arr[j] >= p && i < j)
                {
                    j--;
                }

                // 从左往右找到小于等于基准的数，为之后找到大于基准的数创造条件
                while (arr[i] <= p && i < j)
                {
                    i++;
                }

                Console.WriteLine("找到数了，i:{0}，j:{1}", arr[i], arr[j]);
                // 找到后交换两个数
                swap(arr, i, j);
            }
            Console.WriteLine("基准位置交换，p:{0}，i:{1}", arr[l], arr[j]);
            // 把基准数到i和j汇合的位置
            swap(arr, l, j);
            //返回基准元素所在新位置
            return j;
        }

        protected static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}