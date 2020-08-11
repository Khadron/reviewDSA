using System;

namespace DSCodes.Main.Queue
{
    public class CSeqQueue<T> : IQueue<T>
    {
        /// <summary>
        /// 循环顺序队列的容量
        /// </summary>
        private int maxsize;
        /// <summary>
        /// 数组，用于存储循环顺序队列中的数据元素
        /// </summary>
        private T[] data;
        /// <summary>
        /// 指示循环队列的队头（数组索引）
        /// </summary>
        private int front;
        /// <summary>
        /// 指示循环顺序队列的队尾（数组索引）
        /// </summary>
        private int rear;

        public T this[int index]
        {
            get
            {
                return data[index];
            }
        }

        /// <summary>
        /// 容量
        /// </summary>
        /// <value></value>
        public int Maxsize
        {
            get
            {
                return maxsize;
            }
        }

        /// <summary>
        /// 队头
        /// </summary>
        /// <value></value>
        public int Front
        {
            get
            {
                return front;
            }
            set
            {
                front = value;
            }
        }

        /// <summary>
        /// 队尾
        /// </summary>
        /// <value></value>
        public int Rear
        {
            get
            {
                return rear;
            }
            set
            {
                rear = value;
            }
        }

        public CSeqQueue(int size)
        {
            data = new T[size];
            maxsize = size;
            front = rear = -1;
        }
        public void Clear()
        {
            front = rear = -1;
        }

        public T GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue  is empty!");
                return default(T);
            }
            int index = (++rear) % maxsize;
            return data[index];
        }

        public int GetLength()
        {
            return (rear - front + maxsize) % maxsize;
        }

        public void In(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            int index = (++rear) % maxsize;
            data[index] = item;
        }

        public bool IsEmpty()
        {
            if (front == rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T Out()
        {
            T tmp = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return tmp;
            }
            int index = (++front) % maxsize;
            tmp = data[index];
            return tmp;
        }

        public bool IsFull()
        {
            if ((rear + 1) % maxsize == front)
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
