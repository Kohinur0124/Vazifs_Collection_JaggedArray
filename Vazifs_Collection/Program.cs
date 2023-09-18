using System;
using System.ComponentModel.DataAnnotations;

namespace Vazifs_Collection
{

    public class Program
    {
        /*public static void YangiExtention(this int[][] arr, int index,int value)
        {
            arr[index] =arr[index].ToList().Append(value).ToArray<int>();

            
        }
        public static void YangiExtention(this int[][] arr,  int value)
        {

        }*/
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 31 };
            jaggedArray[1] = new int[] { 28, 29 };
            jaggedArray.Print();
            Console.WriteLine();
            jaggedArray.YangiExtention(1, 7);
            jaggedArray.Print();
            Console.WriteLine();
            var jarr =jaggedArray.YangiExtention(12);
            jarr.Print();

        }
    }

    public static class ExtenMethod
    {
        public static int[][] YangiExtention(this int[][] arr, int index, int value)
        {
            arr[index] = arr[index].ToList().Append(value).ToArray<int>();
            return arr;


        }
        public static int[][] YangiExtention(this int[][] arr, int value)
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length - 1] = new int[] {value};
            return arr;
           // arr[arr.Length-1] = arr[arr.Length - 1].ToList().Append(value).ToArray<int>();
            //arr.Print();
        }

        public static void Print(this int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < (arr[i]).Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }

        }
    }
}