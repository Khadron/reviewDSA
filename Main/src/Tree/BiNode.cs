namespace DSCodes.Main.Tree
{
    public class BiNode<T>
    {
        /// <summary>
        /// 数据域
        /// </summary>
        private T data;
        /// <summary>
        /// 左孩子
        /// </summary>
        private BiNode<T> leftChild;
        /// <summary>
        /// 右孩子
        /// </summary>
        private BiNode<T> rightChild;

        public BiNode(T data, BiNode<T> leftBiNode, BiNode<T> rightBiNode)
        {
            this.data = data;
            this.leftChild = leftBiNode;
            this.rightChild = rightBiNode;
        }

        public BiNode(BiNode<T> leftBiNode, BiNode<T> rightBiNode)
        {
            this.data = default(T);
            this.leftChild = leftBiNode;
            this.rightChild = rightBiNode;
        }

        public BiNode(T data)
        {
            this.data = data;
            this.leftChild = null;
            this.rightChild = null;
        }

        public BiNode()
        {
            this.data = default(T);
            this.leftChild = null;
            this.rightChild = null;
        }

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

        public BiNode<T> LeftChild
        {
            get
            {
                return leftChild;
            }
            set
            {
                leftChild = value;
            }
        }

        public BiNode<T> RightChild
        {
            get
            {
                return rightChild;
            }
            set
            {
                rightChild = value;
            }
        }
    }
}