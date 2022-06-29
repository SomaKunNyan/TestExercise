using System;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsCount = 2;
            Console.WriteLine("Write count of elements of array ");
            elementsCount = Int32.Parse(Console.ReadLine());
            int[] filledArray = FillArray(elementsCount);
            SumOfMaxArrValues SumOfElements = new SumOfMaxArrValues(filledArray);
            MultiplicationOfMaxArrValues MultOfElements = new MultiplicationOfMaxArrValues(filledArray);
            Console.WriteLine("Summ of 2 max elements in array = "+SumOfElements.GetResult());
            Console.WriteLine("Multiplication of 2 max elements in array = "+MultOfElements.GetResult());
        }

        static int[] FillArray(int lenght)
        {
            Random random = new Random();
            int[] filledArray = new int[lenght];
            for (int i = 0; i < lenght-1; i++)
            {
                filledArray[i] = random.Next(1, 10000);
            }

            return filledArray;
        }
    }

    class SumOfMaxArrValues
    {
        public int[] values; 
        public SumOfMaxArrValues(int[] n)
        {
            values = n;
        }
        
        public int GetResult()
        {
            int[] sortedArr = values;
            Array.Sort(sortedArr);
            return values[values.Length - 1] + values[values.Length - 2];
        }
    }
    
    class MultiplicationOfMaxArrValues
    {
        public int[] values; 
        public MultiplicationOfMaxArrValues(int[] arr)
        {
            values = arr;
        }

        public int GetResult()
        {
            int[] sortedArr = values;
            Array.Sort(sortedArr);
            return values[values.Length - 1] * values[values.Length - 2];
        }
    }
}