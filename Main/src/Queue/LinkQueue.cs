using System;
using DSCodes.Main.Common;

namespace DSCodes.Main.Queue
{
    public class LinkQueue<T> : IQueue<T>
    {
        private Node<T> front;
        private Node<T> rear;
        private int num;
        /// <summary>
        /// 队列头指示器
        /// </summary>
        /// <value></value>
        public Node<T> Front
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
        /// 队尾属性
        /// </summary>
        /// <value></value>
        public Node<T> Rear
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
        /// <summary>
        /// 队列节点个数属性
        /// </summary>
        /// <value></value>
        public int Num
        {
            get
            {
                return num;
            }
        }

        public void Clear()
        {
            front = rear = null;
            num = 0;
        }

        public T GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            return front.Data;
        }

        public int GetLength()
        {
            return num;
        }

        public void In(T item)
        {
            Node<T> q = new Node<T>(item);
            if (rear == null)
            {
                rear = q;
            }
            else
            {
                rear.Next = q;
                rear = q;
            }
            ++num;
        }

        public bool IsEmpty()
        {
            if ((front == rear) && (num == 0))
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
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            Node<T> p = front;
            front = front.Next;
            if (front == null)
            {
                rear = null;
            }
            --num;
            return p.Data;
        }
    }
}