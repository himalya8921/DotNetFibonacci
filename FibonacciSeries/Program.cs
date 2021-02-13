using System;
using System.Collections;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
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


            Console.WriteLine("Hello World");

            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)

            Console.WriteLine("Sum is " + sum1);
            Console.WriteLine("Multiplication " + sum2 * sum1);
            Console.WriteLine("Division " + sum2 / sum1);

            int x = 5;
            x += 5;
            Console.WriteLine(x);


            if (sum1 >= sum2 && sum1 >= sum3)
            {
                Console.WriteLine("{0} is greatest", sum1);
            }
            else if (sum2 >= sum1 && sum2 >= sum3)
            {
                Console.WriteLine("{0} is greatest", sum2);
            }
            else if (sum3 >= sum2 && sum3 >= sum1)
            {
                Console.WriteLine("{0} is greatest", sum3);
            }
            else
            {
                Console.WriteLine("All are same");
            }


            int integer = 88;
            char character = 'c';
            bool boolean = true;
            double d = 3.99;
            float f = 2.11f;
            long l = 2;
            var v = 5;
            dynamic dy;

            dy = 90;
            dy = " this is the of type dynamic type";

            Console.WriteLine("Int is " + integer);
            Console.WriteLine("Char is " + character);
            Console.WriteLine("Bool is " + boolean);
            Console.WriteLine("Double is " + d);
            Console.WriteLine("Float is " + f);
            Console.WriteLine("Long is " + l);
            Console.WriteLine("Var is " + v);
            Console.WriteLine("Dynamic is " + dy);


            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Well done");
                    break;
                case 'D':
                    Console.WriteLine("You passed");
                    break;
                case 'F':
                    Console.WriteLine("Better try again");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }


            int flag = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    break;
                    flag = 1;
                }
                else
                {
                    if (i == 4)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }


                int x1 = 10, y1 = 100;

                var result = x1 > y1 ? "x is greater than y" : "x is less than y";

                Console.WriteLine(result);






            }

            if (flag == 1)
            {
                Console.WriteLine("From break");
            }


            int[] n = new int[10];


            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }


            string str1 = "Last night I dreamt of San Pedro";
            string str2 = "This is text";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }


            if (str1.Contains("night"))
            {
                Console.WriteLine("The sequence 'night' was found.");
            }


            string substr = str1.Substring(23);
            Console.WriteLine(substr);


            // collections 

            ArrayList al = new ArrayList();
            string str = "THis is a string";
            int val = 7;
            DateTime d1 = DateTime.Parse("8-oct-1985");
            al.Add(str);
            al.Add(val);
            al.Add(d1);

            foreach (object o in al)
            {
                Console.Write(o);
            }

            Console.WriteLine();
            Console.WriteLine("Hashtable ");

            // hashtable

            Hashtable recordTable = new Hashtable();
            recordTable.Add("1", "Himalya");
            recordTable.Add("2", "Manan");
            recordTable.Add("3", "Abhi");
            recordTable.Add("4", "Ankush");

            foreach (DictionaryEntry de in recordTable)
            {
                Console.Write(de.Value + " " + de.Key);
            }
            Console.WriteLine();
            Console.WriteLine("Stack ");


            // stack

            Stack stacks = new Stack();
            stacks.Push("apple");
            stacks.Push("Mango");
            stacks.Push("banana");

            foreach (var o in stacks)
            {
                Console.Write(o + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Queue ");

            // Queue

            Queue queue = new Queue();
            queue.Enqueue("Himalya");
            queue.Enqueue("Manan");
            queue.Enqueue("Abhi");

            foreach (object o in queue)
            {
                Console.Write(o + " ");
            }



            // jagged Array

            int[][] jagged_arr = new int[4][];

            // Initialize the elements 
            jagged_arr[0] = new int[] { 1, 2, 3, 4 };
            jagged_arr[1] = new int[] { 11, 34, 67 };
            jagged_arr[2] = new int[] { 89, 23 };
            jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

            // Display the array elements: 
            for (int n1 = 0; n1 < jagged_arr.Length; n1++)
            {

                // Print the row number 
                System.Console.Write("Row({0}): ", n1);

                for (int k = 0; k < jagged_arr[n1].Length; k++)
                {

                    // Print the elements in the row 
                    System.Console.Write("{0} ", jagged_arr[n1][k]);
                }
                System.Console.WriteLine();
            }







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
