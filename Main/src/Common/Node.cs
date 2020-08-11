using System;

namespace DSCodes.Main.Common
{
    /// <summary>
    /// 链表节点类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        private T data; // 数据域
        private Node<T> next; // 引用域

        public Node(T val, Node<T> p)
        {
            data = val;
            next = p;
        }

        public Node(T val)
        {
            data = val;
            next = null;
        }
        /// <summary>
        /// 数据域属性
        /// </summary>
        /// <value></value>
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        /// <summary>
        /// 引用域属性
        /// </summary>
        /// <value></value>
        public Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }
}
