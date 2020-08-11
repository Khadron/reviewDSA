using System;

namespace DSCodes.Main.Queue
{
    public interface IQueue<T>
    {
        /// <summary>
        /// 求队列的长度
        /// </summary>
        /// <returns></returns>
        int GetLength(); 
        /// <summary>
        /// 判断队列是否为空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
        /// <summary>
        /// 清空队列
        /// </summary>
        void Clear();
        /// <summary>
        /// 入队
        /// </summary>
        /// <param name="item">T</param>
        void In(T item);
        /// <summary>
        /// 出队
        /// </summary>
        /// <returns>T</returns>
        T Out(); 
        /// <summary>
        /// 取队头元素 
        /// </summary>
        /// <returns>T</returns>
        T GetFront();
    }
}
