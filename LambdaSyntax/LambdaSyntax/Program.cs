using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaSyntax
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Lambda expression syntax being used with LINQ aggregates (Sum, Count, Min, Max) on a Collection.

            /*Code borrowed starts*/

            // Count() function returns Counts the number of elements.
            //@ Link https://www.tutorialsteacher.com/linq/linq-aggregation-operator-count

            // Creates a list of elements with type as int(integer numbers).
            IList<int> intListCount = new List<int>() { 10, 21, 30, 45, 50 };

            // Assigning a variable with number of int values in list.The Count() function will count how many numbers are there in the list.
            var totalElements = intListCount.Count();

            // It will write the output Total number of Elements in the list. 
            Console.WriteLine("Total Elements: {0}", totalElements);

            // This line is using the Lambda expression “x => x % 2 == 0”, that will check if a number is even and then the Count() function will count the even numbers in the list. The variable “var evenElements” is assigned with the value returned by the Count() function.
            var evenElements = intListCount.Count(x => x % 2 == 0);

            // It will write the output Even Elements in the list. 

            Console.WriteLine("Even Elements: {0}", evenElements);

            // Sum() function returns Sum of the elements in the list.
            // @ Link https://www.tutorialsteacher.com/linq/linq-aggregation-operator-sum

            IList<int> intListSum = new List<int>() { 10, 21, 30, 45, 50, 87 };

            var total = intListSum.Sum();

            Console.WriteLine("Sum: {0}", total);

            var sumOfEvenElements = intListSum.Sum(i => {
                if (i % 2 == 0)
                    return i;

                return 0;
            });

            Console.WriteLine("Sum of Even Element: {0}", sumOfEvenElements);

            // Max() function returns Largest number in the list.
            // @ Link https://www.tutorialsteacher.com/linq/linq-aggregation-operator-max

            IList<int> intListMax = new List<int>() { 10, 21, 30, 45, 50, 87 };

            var largest = intListMax.Max();

            Console.WriteLine("Largest Element: {0}", largest);

            var largestEvenElements = intListMax.Max(i => {
                if (i % 2 == 0)
                    return i;

                return 0;
            });

            Console.WriteLine("Largest Even Element: {0}", largestEvenElements);

            // Min() function returns smallest number in the list.

            IList<int> intListMin = new List<int>() { 9,10,13,15};

            var smallest = intListMin.Min();

            Console.WriteLine("Smallest Element: {0}", smallest);

            var smallestOddElements = intListMin.Min(i =>
            {
                if (i % 2 != 0)
                    return i;
                
                return i;
            });

            Console.WriteLine("Smallest Odd Element: {0}", smallestOddElements);

            /*Code borrowed ends*/

        }
    }
 }
