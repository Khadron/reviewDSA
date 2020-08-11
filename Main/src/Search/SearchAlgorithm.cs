using System;
namespace Main.src.Search
{
    public class SearchAlgorithm
    {

        public void Entry()
        {


        }

        /// <summary>
        /// 顺序查找
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int SequenceSearch(int[] arr, int key)
        {
            for (int i = 0, length = arr.Length; i < length; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// 二分查找（递归实现）
        /// </summary>
        /// <param name="arr">数据源</param>
        /// <param name="low">区间开始索引</param>
        /// <param name="height">区间结束索引</param>
        /// <param name="key">关键字</param>
        /// <returns></returns>
        public static int BinarySearch(int[] arr, int low, int high, int key)
        {
            int mid = (low + high) / 2;
            if (low > high)
            {
                return -1;
            }
            else
            {
                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (arr[mid] > key)
                {
                    return BinarySearch(arr, low, mid - 1, key);
                }
                else
                {
                    return BinarySearch(arr, mid + 1, high, key);
                }
            }
        }

        /// <summary>
        /// 二分查找（非递归）
        /// </summary>
        /// <param name="arr">数据源</param>
        /// <param name="key">关键字</param>
        /// <returns></returns>
        public static int BinarySearch(int[] arr, int key)
        {
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (arr[mid] > key)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }


// 哈希查找


    }
}