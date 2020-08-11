using System;

namespace DSCodes.Main.Tree
{
    /// <summary>
    /// 树的遍历方式
    /// </summary>
    public enum TraverseType
    {
        PRE = 0,
        IN,
        POST,
        LEVEL
    }

    public interface ITree<T>
    {
        /// <summary>
        /// 树的根结点
        /// </summary>
        /// <returns></returns>
        T Root();
        /// <summary>
        /// 获取指定结点父级结点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        T Parent(T node);
        /// <summary>
        /// 清空树
        /// </summary>
        void Clear();
        /// <summary>
        /// 判断是否为空树
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
        /// <summary>
        /// 判断是否为子节点
        /// </summary>
        /// <returns></returns>
        bool IsLeaf(T node);
        /// <summary>
        /// 获取树的深度
        /// </summary>
        /// <returns></returns>
        int GetDepth();
    }
}