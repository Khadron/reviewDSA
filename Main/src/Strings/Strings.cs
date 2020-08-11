using System;
namespace DSCodes.Main.Strings
{
    public class Strings
    {
        private char[] data;// 字符数组

        /// <summary>
        /// 串长度
        /// </summary>
        /// <value></value>
        public int Length
        {
            get
            {
                return data.Length;
            }
        }

        /// <summary>
        /// 串索引器
        /// </summary>
        /// <value></value>
        public char this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public Strings(char[] arr)
        {
            data = new char[arr.Length];
            for (int i = 0; i < arr.Length; ++i)
            {
                data[i] = arr[i];
            }
        }

        public Strings(Strings ss)
        {
            for (int i = 0; i < ss.Length; ++i)
            {
                data[i] = ss[i];
            }
        }

        public Strings(int len)
        {
            data = new char[len];
        }

        /// <summary>
        /// 比较串，长度和字符都相等返回0，有相等的字符返回1，反之返回-1
        /// </summary>
        /// <param name="ss"></param>
        /// <returns></returns>
        public int Compare(Strings ss)
        {
            int len = this.Length <= ss.Length ? this.Length : ss.Length;
            int i = 0;
            for (i = 0; i < len; ++i)
            {
                if (this[i] != ss[i])
                {
                    break;
                }
            }
            if (i <= len)
            {
                if (this[i] < ss[i])
                {
                    return -1;
                }
                else if (this[i] > ss[i])
                {
                    return 1;
                }
            }
            else if (this.Length == ss.Length)
            {
                return 0;
            }
            else if (this.Length < ss.Length)
            {
                return -1;
            }

            return 1;
        }

        /// <summary>
        /// 截取串
        /// </summary>
        /// <param name="index"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public Strings SubString(int index, int len)
        {
            if (index < 0 || index > this.Length - 1
            || len < 0 || len > this.Length - index - 1)
            {
                Console.WriteLine("Position or Length is error!");
                return null;
            }

            Strings ss = new Strings(len);
            for (int i = index; i < len; ++i)
            {
                ss[i] = this[index];
            }
            return ss;
        }

        /// <summary>
        /// 合并串
        /// </summary>
        /// <param name="ss"></param>
        /// <returns></returns>
        public Strings Concat(Strings ss)
        {
            Strings s1 = new Strings(this.Length + ss.Length);
            for (int i = 0; i < this.Length; ++i)
            {
                s1.data[i] = this[i];
            }
            for (int j = 0; j < ss.Length; ++j)
            {
                s1.data[this.Length + j] = s1[j];
            }
            return s1;
        }

        /// <summary>
        /// 串插入
        /// </summary>
        /// <returns></returns>
        public Strings Insert(int index, Strings ss)
        {
            int len1 = ss.Length;
            int len2 = len1 + this.Length;
            if (index < 0 || index > this.Length - 1)
            {
                Console.WriteLine("Position is error!");
                return null;
            }
            Strings ss1 = new Strings(len2);
            for (int i = 0; i < index; ++i)
            {
                ss1[i] = this[i];
            }

            for (int i = index; i < index + len1; ++i)
            {
                ss1[i] = ss[i - index];
            }

            for (int i = index + len1; i < len2; ++i)
            {
                ss1[i] = this[i - len1];
            }
            return ss1;
        }


        public Strings Delete(int index, int len)
        {
            if (index < 0 || index > this.Length - 1 || len < 0 || len > this.Length - index)
            {
                Console.WriteLine("Position or Length is error!");
                return null;
            }
            Strings ss = new Strings(this.Length - len);
            for (int i = 0; i < index; ++i)
            {
                ss[i] = this[i];
            }
            for (int i = index + len; i < this.Length; ++i)
            {
                ss[i] = this[i];
            }
            return ss;
        }

        public int IndexOf(Strings ss)
        {
            if (this.Length < ss.Length)
            {
                Console.WriteLine("There is not string ss");
                return -1;
            }
            int i = 0;
            int len = this.Length - ss.Length;
            while (i < len)
            {
                if (this[i] == ss[i])
                {
                    break;
                }
                else
                {
                    i++;
                }
            }

            if (i < len)
            {
                return i;
            }
            return -1;
        }

        public override string ToString()
        {
            return new String(data);
        }
    }
}