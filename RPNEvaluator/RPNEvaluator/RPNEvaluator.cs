using System;
using System.Collections;
using System.Collections.Generic;

namespace RPNEvaluator
{
    public class RPNEvaluator
    {
        public static int Evaluate(string list, Dictionary<string, int>? dict)
        {
            
            if(list == null)
            {
                return 0;
            }

            var stack = new Stack<int>();
            int i;
            int first;
            int second;
            int result;

            for(i = 0; i < list.Length; i += 1)
            {
                if (!char.IsDigit(list[i]))
                {
                    if (list[i] == '+')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first + second;

                        stack.Push(result);
                    }

                    else if (list[i] == '-')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first - second;

                        stack.Push(result);
                    }

                    else if (list[i] == '*')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first * second;

                        stack.Push(result);
                    }

                    else if (list[i] == '/')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first / second;

                        stack.Push(result);
                    }

                    else if (list[i] == '%')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first % second;

                        stack.Push(result);
                    }

                    else
                    {
                        if (dict != null)
                        {
                            foreach (var (key, value) in dict)
                            {
                                if (key == list[i].ToString())
                                {
                                    stack.Push(value);
                                }
                            }
                        }
                     }

                }
                else
                {
                    result = list[i] - '0';
                    stack.Push(result);
                }
            }
            return stack.Pop();
        }
     public static float Evaluatef(string list, Dictionary<string, float>? dict)
        {
            if (list == null)
            {
                return 0;
            }

            var stack = new Stack<float>();
            int i;
            float first;
            float second;
            float result;

            for (i = 0; i < list.Length; i += 1)
            {
                if (!char.IsDigit(list[i]))
                {
                    if (list[i] == '+')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first + second;

                        stack.Push(result);
                    }

                    else if (list[i] == '-')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first - second;

                        stack.Push(result);
                    }

                    else if (list[i] == '*')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first * second;

                        stack.Push(result);
                    }

                    else if (list[i] == '/')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first / second;

                        stack.Push(result);
                    }

                    else if (list[i] == '%')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first % second;

                        stack.Push(result);
                    }

                    else
                    {
                        if (dict != null)
                        {
                            foreach (var (key, value) in dict)
                            {
                                if (key == list[i].ToString())
                                {
                                    stack.Push(value);
                                }
                            }
                        }
                    }

                }
                else
                {
                    result = list[i] - '0';
                    stack.Push(result);
                }
            }
            return stack.Pop();
        }

        public static float Evaluatef(string list, Dictionary<string, int>? dict)
        {
            if (list == null)
            {
                return 0;
            }

            var stack = new Stack<int>();
            int i;
            int first;
            int second;
            int result;

            for (i = 0; i < list.Length; i += 1)
            {
                if (!char.IsDigit(list[i]))
                {
                    if (list[i] == '+')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first + second;

                        stack.Push(result);
                    }

                    else if (list[i] == '-')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first - second;

                        stack.Push(result);
                    }

                    else if (list[i] == '*')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first * second;

                        stack.Push(result);
                    }

                    else if (list[i] == '/')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first / second;

                        stack.Push(result);
                    }

                    else if (list[i] == '%')
                    {
                        second = stack.Pop();
                        first = stack.Pop();
                        result = first % second;

                        stack.Push(result);
                    }

                    else
                    {
                        if (dict != null)
                        {
                            foreach (var (key, value) in dict)
                            {
                                if (key == list[i].ToString())
                                {
                                    stack.Push(value);
                                }
                            }
                        }
                    }

                }
                else
                {
                    result = list[i] - '0';
                    stack.Push(result);
                }
            }
            return stack.Pop();
        }
    }
}
