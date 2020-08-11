using System;

namespace DSCodes.Main.Stack
{
    public class StackSample
    {
        public StackSample() { }

        // 数制转换
        public void Conversion(int n)
        {
            LinkStack<int> s = new LinkStack<int>();
            int initNum = n;
            while (n > 0)
            {
                s.Push(n % 8);
                n = n / 8;
            }
            string result = "";
            while (!s.IsEmpty())
            {
                n = s.Pop();
                result += n;
            }
            Console.WriteLine("{0}转换后的八进制数：{1}", initNum, result);
        }

        // 括号匹配
        public bool MatchBracket(char[] charlist)
        {
            SeqStack<char> s = new SeqStack<char>(50);
            int len = charlist.Length;
            for (int i = 0; i < len; ++i)
            {
                char c = charlist[i];
                if (i == 0 && (c == ')' || c == ']'))
                {
                    return false;
                }

                if (s.IsEmpty())
                {
                    s.Push(c);
                }
                else if ((s.GetTop() == '(' && c == ')')
                || (s.GetTop() == '[' && c == ']'))
                {
                    s.Pop();
                }
                else
                {
                    s.Push(c);
                }
            }
            if (s.IsEmpty())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 表达式求值（四则运算）
        public int EvaluteExpression()
        {
            SeqStack<char> optr = new SeqStack<char>(20);
            SeqStack<int> opnd = new SeqStack<int>(20);
            optr.Push('?');
            Console.WriteLine("栈应用简单示例，只支持个位数运算，输入规则：1+1?");
            Console.WriteLine("请输入要计算的表达式（四则运算）");
            char input = (char)Console.Read();
            char theta;
            int n1, n2;
            while (input != '?' || optr.GetTop() != '?')
            {
                if (input == '\n' || input == '\r')
                {
                    input = (char)Console.Read();
                }
                else
                {
                    if (input != '?' && input != '+' && input != '-'
                                    && input != '*' && input != '/'
                                    && input != '(' && input != ')')
                    {
                        opnd.Push((int)Char.GetNumericValue(input));
                        Console.WriteLine("opnd 入栈：{0}", input);
                        input = (char)Console.Read();
                    }
                    else
                    {
                        switch (Precede(optr.GetTop(), input))
                        {
                            case '<':
                                optr.Push(input);
                                Console.WriteLine("optr 入栈：{0}", input);
                                input = (char)Console.Read();
                                break;
                            case '=':
                                optr.Pop();
                                input = (char)Console.Read();
                                break;
                            case '>':
                                theta = optr.Pop();
                                n2 = opnd.Pop();
                                n1 = opnd.Pop();
                                Console.WriteLine("最终表达式：{0}{1}{2}", n1, theta, n2);
                                opnd.Push(Operate(n1, theta, n2));
                                break;
                            default:
                                input = (char)Console.Read();
                                break;
                        }
                    }
                }
            }
            return opnd.GetTop();
        }

        private char Precede(char opt, char input)
        {
            char result = 'N';
            switch (input)
            {
                case '+':
                    if (opt == '(' || opt == '?')
                    {
                        result = '<';
                    }
                    else
                    {
                        result = '>';
                    }
                    break;
                case '-':
                    if (opt == '(' || opt == '?')
                    {
                        result = '<';
                    }
                    else
                    {
                        result = '>';
                    }
                    break;
                case '*':
                    if (opt == '+' || opt == '-' || opt == '(' || opt == '?')
                    {
                        result = '<';
                    }
                    else
                    {
                        result = '>';
                    }
                    break;
                case '/':
                    if (opt == '+' || opt == '-' || opt == '(' || opt == '?')
                    {
                        result = '<';
                    }
                    else
                    {
                        result = '>';
                    }
                    break;
                case '(':
                    if (opt == '+' || opt == '-' || opt == '(' || opt == '*' || opt == '/' || opt == '?')
                    {
                        result = '<';
                    }
                    break;
                case ')':
                    if (opt == '+' || opt == '-' || opt == '*' || opt == '/' || opt == ')')
                        result = '>';
                    else if (opt == '(')
                        result = '=';
                    break;
                case '?':
                    if (opt == '?')
                    {
                        result = '=';
                    }
                    else
                    {
                        result = '>';
                    }
                    break;
                default:
                    Console.WriteLine("输入超出范围");
                    break;

            }
            Console.WriteLine("运算符优先级比较，opt:{0} {1} input:{2}", opt, result, input);
            return result;
        }

        private int Operate(int n1, char theta, int n2)
        {
            int result = 0;
            switch (theta)
            {
                case '+':
                    result = (n1 + n2);
                    break;
                case '-':
                    result = (n1 - n2);
                    break;
                case '*':
                    result = (n1 * n2);
                    break;
                case '/':
                    result = (n1 / n2);
                    break;
            }
            Console.WriteLine("计算结果：{0}", result);
            return result;
        }
    }
}
