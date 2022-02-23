using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolving
{
    public class Problems
    {

        public void PrintDectionary<T, E>(Dictionary<T, E> dictionary)
        {
              foreach(var (key, value) in dictionary)
            {
                Console.WriteLine(key +" : "+value);
            }
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
    }
}
