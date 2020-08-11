using System.Runtime.CompilerServices;
using System;

namespace DSCodes.Main.Tree
{
    public class PTree<T> : IPTree<PNode<T>>
    {
        /// <summary>
        /// 结点个数
        /// </summary>
        private int _count;

        /// <summary>
        /// 树结构存储
        /// </summary>
        private PNode<T>[] store;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        PTree(int count)
        {
            _count = count;
            store = new PNode<T>[count];
        }

        public bool InsertNode(PNode<T> node)
        {
            // if (node != "#")
            // {
            //     this.store[this._count++] = node;
            //     return true;
            // }
            return false;
        }

        public bool InsertParent(PNode<T> parent, PNode<T> node)
        {
            // int place1, place2;
            // place1 = -1; place2 = -1;
            // for (int i = 0; i < T.NodeNum; i++)//查找两点是否存在
            // {
            //     if (node1 == T.parent[i].data) place1 = i;
            //     if (node2 == T.parent[i].data) place2 = i;
            // }
            // if (place1 != -1 && place2 != -1)//两点均存在
            // {
            //     T.parent[place2].parent = place1;
            //     return true;
            // }
            return false;

        }

        public int GetIndegree(PNode<T> node)
        {
            throw new NotImplementedException();
        }

        public int GetOutdegree(PNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void PreOrder()
        {
            throw new NotImplementedException();
        }

        public void PostOrder()
        {
            throw new NotImplementedException();
        }

        public void LevelOrder()
        {
            throw new NotImplementedException();
        }
    }
}