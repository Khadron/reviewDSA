
using System;

namespace DSCodes.Main.Tree
{
    public class PNode<T>
    {

        private T data;
        private int parentIndex;

        /// <summary>
        /// 数据域
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
        /// 父级结点所在索引位置
        /// </summary>
        /// <value></value>
        public int ParentIndex
        {
            get
            {
                return parentIndex;
            }
            set
            {
                parentIndex = value;
            }
        }

        public PNode(T data)
        {
            this.data = data;
            this.parentIndex = -1;
        }

        public PNode(T data, int parentIndex)
        {
            this.data = data;
            this.parentIndex = parentIndex;
        }
    }
}
