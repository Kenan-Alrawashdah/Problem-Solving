// See https://aka.ms/new-console-template for more information
using problemSolving;

int []arr = {11,22,3,41,5,11, 22, 5, 7 , 8, 8, 8, 22};
int[] arr2 = { 11, 22, 3, 4, 15 };




//// sort ascending
//Array.Sort(arr);


// //sort descending
//Array.Sort<int>(arr2, new Comparison<int>(
//     (i1, i2) => i2.CompareTo(i1)));


//Console.WriteLine("sort ascending");
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//Console.WriteLine("\n ===============================");
//Console.WriteLine("sort descending");
//for (int i = 0; i < arr2.Length; i++)
//{
//    Console.Write(arr2[i]+" ");
//}

   Problems problem = new Problems();



     var map = problem.CountNumberRepeatedInArray(arr);

      problem.PrintDectionary<int, int>(map);
  
  

