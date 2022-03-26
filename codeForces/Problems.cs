using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolving
{
    public class Problems
    {

        public void PrintDectionary<T, E>(Dictionary<T, E> dictionary, string label)
        {
             Console.WriteLine(label + " :\n");

              foreach(var (key, value) in dictionary)
            {
                Console.WriteLine(key +" : "+value);
            }
            Console.WriteLine("===========================================");
        }
        public void PrintList<T>(List<T> list, string label)
        {
            Console.WriteLine(label + " :\n");
            foreach(var item in list)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine("\n=============================");
        }

        public Dictionary<int, int> CountNumberRepeatedInArray( int []arr)
        {
            var res = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!res.ContainsKey(arr[i]))
                {
                    res.Add(arr[i], 1);
                }
                else
                {
                    res[arr[i]] += 1;
                }
            }

            return res;
        }

        public List<int> GetPrimeNumbersInList(List<int> listNumbers)
        {
            var res = new List<int>();
            
                foreach(var num in listNumbers)
            {
                if (this.IsPrimeNumber(num))
                {
                    res.Add(num);
                }
            }
            return res;
        }

        private bool IsPrimeNumber(int num)
        {
            if (num == 1)
                return false;
            if (num == 2)
                return true;

            for (int i = 2; i <= Math.Floor(Math.Sqrt(num)); i++)
            {
                if ((num % i == 0))
                {
                    return false;
                }
            }
            return true;
        }

        public string Balanced(string str)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                 if(stack.Count > 0 && this.IsBalance(stack.Peek(), str[i]))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(str[i]);
                }
            }

             
            return stack.Count == 0 ? $"is balanced '{str}'" : $"not balanced '{str}'";
        }

        private bool IsBalance(char c1, char c2)
        {
            if (c1 == '(' && c2 == ')')
                return true;
            if (c1 == '[' && c2 == ']')
                return true;
            if (c1 == '{' && c2 == '}')
                return true;

            return false;
        }

        public int SeconedGreaterNumber(int[] arr)
        {
            int max;
            int temp;

             if(arr[0] > arr[1])
            {
                 max = arr[0];
                 temp = arr[1];
            }
            else
            {
                max = arr[1];
                temp = arr[0];
            }


            for (int i = 2; i < arr.Length; i++)
            {
                  if(arr[i] > max)
                {
                    temp = max;
                    max = arr[i];
                }else if(arr[i] > temp)
                {
                    temp = arr[i];
                }
            }


            return temp;
        }

        public string AddMinuteToClock(string clock, int minute) {

            string []arr = clock.Split(':');
            int h = int.Parse(arr[0]);
            int m = int.Parse(arr[1]);

            int minutes = (h * 60) + m + minute;

            h = minutes / 60;
            m = minutes % 60;


            return (h==24 ? "00": h < 10 ? $"0{h}":h) +":"+(m < 10 ? $"0{m}":m);
        }

        public int FirstIntRepeted(int [] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    return arr[i];
                }
                else
                {
                    dic.Add(arr[i], 1);
                }
            }
            return 0;
        } 
    }
}
