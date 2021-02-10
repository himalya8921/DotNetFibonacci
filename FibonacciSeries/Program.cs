using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
		   // added to the development branch
           //space added in the feature branch
            int size = 7;
            int[] fibonacciNumbers = new int[size];
            int index = 0;
            
            Console.WriteLine(" Fibonacci Series");
            int index0 = 0, index1 = 1, c = 0;

            fibonacciNumbers[index++] = index0;
            fibonacciNumbers[index++] = index1;
            int noOfElements = size - 2;

            //fibonacciNumbers = GetFactorialUsingWhile(fibonacciNumbers, noOfElements, index);
            fibonacciNumbers = GetFactorialUsingFor(fibonacciNumbers, noOfElements , index);


            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("End of Code");

        }

         static int[] GetFactorialUsingWhile(int[] fibonacciNumbers, int noOfElements, int index)
        {
            int next = 0;
            int index0 = 0, index1 = 1;

            while (noOfElements != 0)
            {
                next = index0 + index1;
                fibonacciNumbers[index++] = c;
                index0 = index1;
                index1 = next;
                noOfElements--;

            }

            return fibonacciNumbers;
        }

        static int[] GetFactorialUsingFor(int[] fibonacciNumbers, int noOfElements, int index)
        {
            int next = 0;
            int index0 = 0, index1 = 1;

            for (int i = 0; i < noOfElements; i++)
            {

                next = index0 + index1;
                fibonacciNumbers[index++] = next;
                index0 = index1;
                index1 = next;

            }

            return fibonacciNumbers;
			
        }




    }
}
