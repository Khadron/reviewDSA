using System;

namespace DSCodes.Main.Stack
{

    /// <summary>
    /// 顺序栈
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SeqStack<T> : IStack<T>
    {
        private int maxsize; // 顺序栈的容量
        private T[] data; // 数组用于存储顺序栈中的数据元素
        private int top; // 指示顺序栈的栈顶

        // 索引器
        public T this[int index]
        {
            get
            {
                return data[index];
            }
        }

        // 容量属性
        public int Maxsize
        {
            get
            {
                return maxsize;
            }
            set
            {
                maxsize = value;
            }
        }
        // 栈顶属性
        public int Top
        {
            get
            {
                return top;
            }
        }
        // 构造器
        public SeqStack(int size)
        {
            data = new T[size];
            maxsize = size;
            top = -1;
        }

        public void Clear()
        {
            top = -1;
        }

        public int GetLength()
        {
            return top + 1;
        }

        public T GetTop()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }
            return data[top];
        }

        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T Pop()
        {
            T tmp = default(T);
            if (this.IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return tmp;
            }
            tmp = data[top];
            --top;
            return tmp;
        }

        public void Push(T item)
        {
            if (this.IsFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }
            data[++top] = item;
        }

        public bool IsFull()
        {
            if (top == maxsize - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}