using problemSolving;

int []arr = {11,22,3,41,5,11, 22, 5, 7 , 8, 8, 8, 22};
var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,21,22,31 };



   Problems problem = new Problems();



//var res1 = problem.CountNumberRepeatedInArray(arr);
//    problem.PrintDectionary<int, int>(res1, "Number Repeated In Array");

//var res2 = problem.GetPrimeNumbersInList(numbers);
//    problem.PrintList(res2, "Prime Numbers");

   Console.WriteLine(problem.Balanced("{(()[]{})}"));
 


//int[] arr2 = { 11, 22, 3, 4, 15 };
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

