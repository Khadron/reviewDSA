namespace DSCodes.Main.Tree
{
    public interface IPTree<T>
    {
        /// <summary>
        /// 插入子节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        bool InsertNode(T node);
        /// <summary>
        /// 插入父节点
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        bool InsertParent(T parent, T node);
        /// <summary>
        /// 获取指定结点入度
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        int GetIndegree(T node);
        /// <summary>
        /// 获取指定结点出度
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        int GetOutdegree(T node);
        /// <summary>
        /// 前序遍历
        /// </summary>
        void PreOrder();
        /// <summary>
        /// 中序遍历
        /// </summary>
        void PostOrder();
        /// <summary>
        /// 层序遍历
        /// </summary>
        void LevelOrder();


    }
}