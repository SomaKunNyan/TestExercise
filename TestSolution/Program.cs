using System;
using System.Diagnostics;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int elementsCount = 2;
            Console.WriteLine("Write count of elements of array ");
            elementsCount = Int32.Parse(Console.ReadLine());
            int[] filledArray = FillArray(elementsCount);
            SumOfMaxArrValues SumOfElements = new SumOfMaxArrValues(filledArray);
            MultiplicationOfMaxArrValues MultOfElements = new MultiplicationOfMaxArrValues(filledArray);
            stopwatch.Start();
            Console.WriteLine("Summ of 2 max elements in array = "+SumOfElements.GetResult());
            Console.WriteLine("Multiplication of 2 max elements in array = "+MultOfElements.GetResult());
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
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
            int[] maxValues = new []{values[0],values[0]};
            for (int i = 0; i < values.Length-1; i++)
            {
                if (values[i] > maxValues[0])
                {
                    maxValues[0] = values[i];
                }
                else if (values[i] > maxValues[1]) maxValues[1] = values[i];
            }
            return maxValues[0] + maxValues[1];
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
            int[] maxValues = new []{values[0],values[0]};
            for (int i = 0; i < values.Length-1; i++)
            {
                if (values[i] > maxValues[0])
                {
                    maxValues[0] = values[i];
                }
                else if (values[i] > maxValues[1]) maxValues[1] = values[i];
            }
            return maxValues[0] * maxValues[1];
        }
    }
}