using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtyCode2
{
    public class ArrayOperations<T> where T : struct, IComparable
    {


        public T[] MyArray { get; set; }


        public ArrayOperations(int size)
        {
            MyArray = new T[size];
        }
        public static T GetInput()
        {

            string input = Console.ReadLine();
            return (T)Convert.ChangeType(input, typeof(T));
        }
        public void Populate()
        {

            Console.WriteLine($"Enter {MyArray.Length} numbers for array :");
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = GetInput();
            }


        }

        public static double[] SumTwoArrays(T[] arr1, T[] arr2)
        {


            var resultArr = new double[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                resultArr[i] = Convert.ToDouble(arr1[i]) + Convert.ToDouble(arr2[i]);
            }
            Console.WriteLine("The sum of arrays is:");

            return resultArr;
        }


        public void Average()
        {


            if (MyArray is int[] or double[] or decimal[] or float[])
            {
                double sum = 0;
                for (int i = 0; i < MyArray.Length; i++)
                {
                    sum += Convert.ToDouble(MyArray[i]);
                }
                double average = sum / MyArray.Length;

                Console.WriteLine("The average of array  is: " + average);

            }
            else
            {

                Console.WriteLine("Cant Calculate Average for this type");
            }


        }

        public void Print()
        {
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write(MyArray[i] + " ");
            }

            Console.WriteLine();
        }


        public void Max()
        {
            T max = MyArray[0];
            for (int i = 1; i < MyArray.Length; i++)
            {
                if (MyArray[i].CompareTo(max) > 0)
                {
                    max = MyArray[i];
                }
            }

            Console.WriteLine("The maximum value in array  is: " + max);
        }


    }
}
