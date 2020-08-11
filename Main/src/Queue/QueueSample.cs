using System;
using DSCodes.Main.Queue;
using DSCodes.Main.Stack;

namespace DSCodes.Main.Queue
{
    public class QueueSample
    {
        public void Plalindrome()
        {
            SeqStack<char> s = new SeqStack<char>(50);
            CSeqQueue<char> q = new CSeqQueue<char>(50);
            Console.WriteLine("请输入回文：");
            string str = Console.ReadLine();
            // string str = "ABCDEDCBA";
            for (int i = 0; i < str.Length; ++i)
            {
                s.Push(str[i]);
                q.In(str[i]);
            }

            while (!s.IsEmpty() && !q.IsEmpty())
            {
                if (s.Pop() != q.Out())
                {
                    break;
                }
            }

            if (!s.IsEmpty() || !q.IsEmpty())
            {
                Console.WriteLine("这不是回文！");
            }
            else
            {
                Console.WriteLine("这是回文！");

            }

        }
    }
}