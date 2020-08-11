using System;
using System.Collections.Generic;
using DSCodes.Main.Queue;

namespace DSCodes.Main.Tree
{
    public class BiTree<T> : IBiTree<BiNode<T>>
    {

        /// <summary>
        /// 头引用
        /// </summary>
        private BiNode<T> head;
        public BiNode<T> Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }

        public BiTree()
        {
            head = null;
        }

        public BiTree(T data)
        {
            BiNode<T> BiNode = new BiNode<T>(data);
            head = BiNode;
        }

        public BiTree(T data, BiNode<T> leftBiNode, BiNode<T> rightBiNode)
        {
            BiNode<T> BiNode = new BiNode<T>(data, leftBiNode, rightBiNode);
            head = BiNode;
        }

        /// <summary>
        /// 先序遍历（DLR）
        /// </summary>
        public void PreOrder(BiNode<T> root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine("{0}", root.Data);

            // 先序遍历左子树
            PreOrder(root.LeftChild);

            // 先序遍历右子树
            PreOrder(root.RightChild);
        }

        /// <summary>
        /// 中序遍历（LDR）
        /// </summary>
        public void InOrder(BiNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            // 中序遍历左子树
            InOrder(root.LeftChild);

            Console.WriteLine("{0}", root.Data);

            // 中序遍历右子树
            InOrder(root.RightChild);
        }

        /// <summary>
        /// 后序遍历（LRD）
        /// </summary>
        public void PostOrder(BiNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            // 后序遍历左子树
            PostOrder(root.LeftChild);

            // 后序遍历右子树
            PostOrder(root.RightChild);

            Console.WriteLine("{0}", root.Data);
        }

        /// <summary>
        /// 层序遍历（Level Order）
        /// </summary>
        public void LevelOrder(BiNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            CSeqQueue<BiNode<T>> sq = new CSeqQueue<BiNode<T>>(100);
            sq.In(root); // 根节点入队

            while (!sq.IsEmpty())
            {
                BiNode<T> tmp = sq.Out();

                Console.WriteLine("{0}", tmp.Data);

                if (tmp.LeftChild != null)
                {
                    sq.In(tmp.LeftChild);
                }

                if (tmp.RightChild != null)
                {
                    sq.In(tmp.RightChild);
                }
            }
        }

        public int GetNodeCount(BiNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }

            return GetNodeCount(node.LeftChild) + GetNodeCount(node.RightChild) + 1;
        }

        public int GetLeavesCount(BiNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.LeftChild == null && node.RightChild == null)
            {
                return 1;
            }

            return GetLeavesCount(node.LeftChild) + GetLeavesCount(node.RightChild);
        }

        public int GetDepth(BiNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            int left_depth = GetDepth(node.LeftChild) + 1;
            int right_depth = GetDepth(node.RightChild) + 1;
            return left_depth > right_depth ? left_depth : right_depth;
        }

        public int GetLevelNodeCount(BiNode<T> node, int k)
        {
            if (node == null)
            {
                return 0;
            }
            if (k == 1)
            {
                return 1;
            }

            return GetLevelNodeCount(node.LeftChild, k - 1) + GetLevelNodeCount(node.RightChild, k - 1);
        }

        public bool StructCompare(BiNode<T> node1, BiNode<T> node2)
        {
            if (node1 == null && node2 == null)
            {
                return true;
            }
            else if (node1 == null || node2 == null)
            {
                return false;
            }

            return StructCompare(node1.LeftChild, node2.LeftChild) && StructCompare(node1.RightChild, node2.RightChild);
        }

        public void Mirror(BiNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            BiNode<T> temp = node.LeftChild;
            node.LeftChild = node.RightChild;
            node.RightChild = temp;

            Mirror(node.LeftChild);
            Mirror(node.RightChild);
        }

        public BiNode<T> FindLCA(BiNode<T> root, BiNode<T> target1, BiNode<T> target2)
        {
            if (root == null)
            {
                return null;
            }
            if (root == target1 || root == target2)
            {
                return root;
            }

            BiNode<T> left = FindLCA(root.LeftChild, target1, target2);
            BiNode<T> right = FindLCA(root.RightChild, target1, target2);
            if (left != null && right != null)
            {
                return root;
            }

            return left != null ? left : right;

        }


        public int FindLevel(BiNode<T> root, BiNode<T> target)
        {
            if (root == null)
                return -1;
            if (root == target)
                return 0;

            int level = FindLevel(root.LeftChild, target);  // 先在左子树找
            if (level == -1)
                level = FindLevel(root.RightChild, target);  // 如果左子树没找到，在右子树找

            if (level != -1)  // 找到了，回溯
                return level + 1;

            return -1;  // 如果左右子树都没找到
        }
        public int FindDist(BiNode<T> root, BiNode<T> target1, BiNode<T> target2)
        {
            BiNode<T> lca = this.FindLCA(root, target1, target2);
            int level1 = this.FindLevel(lca, target1);
            int level2 = this.FindLevel(lca, target2);
            return level1 + level2;
        }

        public bool FindParents(BiNode<T> root, BiNode<T> target, IList<BiNode<T>> parents)
        {
            if (root == null)
                return false;
            if (root == target)
                return true;

            if (FindParents(root.LeftChild, target, parents) || FindParents(root.RightChild, target, parents))  // 找到了
            {
                parents.Add(root);
                return true;  // 回溯
            }

            return false;  // 如果左右子树都没找到
        }

        public bool IsCBT(BiNode<T> root)
        {
            bool flag = false;
            if (root == null)
            {
                return false;
            }
            CSeqQueue<BiNode<T>> sq = new CSeqQueue<BiNode<T>>(100);
            sq.In(root); // 根节点入队
            while (!sq.IsEmpty())
            {
                BiNode<T> p = sq.Out();
                if (flag)
                {

                    if (p.LeftChild != null || p.RightChild != null)
                    {
                        return false;
                    }
                }
                else
                {
                    if (p.LeftChild != null && p.RightChild != null)
                    {
                        sq.In(p.LeftChild);
                        sq.In(p.RightChild);
                    }
                    else if (p.RightChild != null) // 只有右结点
                    {
                        return false;
                    }
                    else if (p.LeftChild != null) // 只有左结点
                    {
                        sq.In(p.LeftChild);
                        flag = true;
                    }
                    else // 没有结点
                    {
                        flag = true;
                    }
                }
            }
            return true;
        }
    }
}