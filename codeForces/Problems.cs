using System;
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
    }
}
