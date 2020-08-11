
namespace DSCodes.Main.Stack
{
    public interface IStack<T>
    {
        /// <summary>
        /// 求栈的长度
        /// </summary>
        /// <returns></returns>
        int GetLength();
        /// <summary>
        /// 判断栈是否为空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
        /// <summary>
        /// 清空操作
        /// </summary>
        void Clear();
        /// <summary>
        /// 入栈操作
        /// </summary>
        /// <param name="item"></param>
        void Push(T item);
        /// <summary>
        /// 出栈操作
        /// </summary>
        /// <returns></returns>
        T Pop();
        /// <summary>
        /// 取栈顶元素
        /// </summary>
        /// <returns></returns>
        T GetTop();
    }
}

