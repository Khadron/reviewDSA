using System.Collections.Generic;

namespace DSCodes.Main.Tree
{

    /// <summary>
    /// 结点的位置（左边，右边）
    /// </summary>
    public enum TreePosition
    {
        Left = 0,
        Right
    }

    public interface IBiTree<T>
    {
        /// <summary>
        /// 前序遍历
        /// </summary>
        void PreOrder(T node);
        /// <summary>
        /// 中序遍历
        /// </summary>
        void InOrder(T node);
        /// <summary>
        /// 后序遍历
        /// </summary>
        void PostOrder(T node);
        /// <summary>
        /// 层序遍历
        /// </summary>
        void LevelOrder(T node);
        /// <summary>
        /// 获取树的结点数
        /// </summary>
        /// <returns></returns>
        int GetNodeCount(T node);
        /// <summary>
        /// 获取树的叶子数
        /// </summary>
        /// <returns></returns>
        int GetLeavesCount(T node);
        /// <summary>
        /// 获取树的深度
        /// </summary>
        /// <returns></returns>
        int GetDepth(T node);
        /// <summary>
        ///  第k层的结点个数
        /// </summary>
        /// <returns></returns>
        int GetLevelNodeCount(T node, int k);
        /// <summary>
        /// 判断两棵树结构是否相同
        /// </summary>
        /// <returns></returns>
        bool StructCompare(T node1, T node2);
        /// <summary>
        /// 求树镜像
        /// </summary>ƒ
        void Mirror(T node);
        /// <summary>
        /// 求两个结点的最底公共祖先结点LCA（Lowest Common Ancestor）
        /// </summary>
        /// <returns></returns>
        T FindLCA(T root, T target1, T target2);
        /// <summary>
        /// 求任意两节点距离
        /// </summary>
        /// <returns></returns>
        int FindDist(T root, T target1, T target2);
        /// <summary>
        /// 找出指定结点的所有父结点
        /// </summary>
        /// <returns></returns>
        bool FindParents(T root, T target, IList<T> parents);
        /// <summary>
        /// 判断是否是完全二叉树
        /// </summary>
        /// <returns></returns>
        bool IsCBT(T root);

    }
}