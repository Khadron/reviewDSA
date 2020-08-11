namespace DSCodes.Main.src
{
    public class SortAlgorithm
    {
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

       public static void QuickSort(int[] arr,int l,int r){
        if(l >= r) return;
        //p为快速排序返回的基准的位置
        int p = Partition2(arr,l,r);
        //对基准左边的数进行快排
        QuickSort(arr,l,p-1);
        //对基准右边的数进行快排
        QuickSort(arr,p+1,r);
    }

     public static int Partition2(int[] arr,int l,int r){
        //基准元素设为第一个
        int v = arr[l];
        //i指向基准的下一个元素，j指向最后一个元素
        int i = l+1,j = r;
        while(true){
            while(i <= r && arr[i] < v) i++;
            while(j > l && arr[j] > v) j--;
            //循环终止条件
            if(i > j) break;
            //交换arr[i]与arr[j]
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
            i++;
            j--;
        }
        //将基准元素与arr[j]交换
        int t = arr[l];
        arr[l] = arr[j];
        arr[j] = t;
        //返回基准元素所在位置
        return j;
    }
    }
}