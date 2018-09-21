using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of fruits starting with the letter L...");
            LuckyFruits();
            Console.ReadLine();

            Console.WriteLine("List of numbers that are multiples of 4 or 6");
            fourSixMultiples();
            Console.ReadLine();

            Console.WriteLine("List of student names in alphabetical order...");
            StudentNames();
            Console.ReadLine();

            Console.WriteLine("List numbers in order from least to greatest...");
            numbersInOrder();
            Console.ReadLine();

            Console.WriteLine("How many numbers are in this list: 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96");
            countingNumbers();
            Console.ReadLine();

            Console.WriteLine("How much money have we made? $2340.29, $745.31, $21.76, $34.03, $4786.45, $879.45, $9442.85, $2454.63, $45.65");
            countingMoney();
            Console.ReadLine();

            Console.WriteLine("What is the largest price? $879.45, $9442.85, $2454.63, $45.65, $2340.29, $34.03, $4786.45, $745.31, $21.76?" );
            largetAmount();
            Console.ReadLine();

            /*Console.WriteLine("Output the perfect square");
            whereDaSquaresAt();
            Console.ReadLine();*/
        }

        static void LuckyFruits()
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            var LFruits = from fruit in fruits // designating where the information is coming from
                          where fruit.Contains("L") // grabs the list of fruit and checks for the character L in that list
                          select fruit; // defines the variable that is checked under this condition

            foreach (var luckyFruits in LFruits)
            {
                Console.WriteLine(luckyFruits);
            }
        }

        static void fourSixMultiples()
        {
            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>() { 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96};

            var fourSixMultiples = numbers.Where(number => number % 6 == 0 || number % 4 == 0);
            foreach (int multiple in fourSixMultiples) {
                Console.WriteLine(multiple);
            }
        }

        // Order these student names alphabetically, in descending order (Z to A)
        static void StudentNames()
        {
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
                {
                    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                    "Francisco", "Tre"
                };

            var descendingOrder = from name in names
                          orderby name descending
                          select name;

            foreach (var kidNames in descendingOrder)
            {
                Console.WriteLine(kidNames);
            }
        }

        static void numbersInOrder()
        {
            // Build a collection of these numbers sorted in ascending order
            List<int> numbers = new List<int>() { 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96};

            var newNumbers = from number in numbers
                             orderby number ascending
                             select number;

            foreach (int orderNumberz in newNumbers)
            {
                Console.WriteLine(orderNumberz);
            }
        }

        static void countingNumbers()
        {
            // Output how many numbers are in this list
            List<int> numbers = new List<int>() { 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96};

            var counting = numbers.Count();
            Console.WriteLine(counting);
        }

        static void countingMoney()
        {
            // How much money have we made?
            List<double> purchases = new List<double>() {2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65};

            var sumOfMoney = purchases.Sum();
            Console.WriteLine(sumOfMoney);
        }

        static void largetAmount()
        {
            // What is our most expensive product?
            List<double> prices = new List<double>() { 879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76};

            var largestPrice = prices.Max();
            Console.WriteLine(largestPrice);
        }

        /*static void whereDaSquaresAt()
        {
            
            Store each number in the following List until a perfect square
            is detected.
             Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx 
             
            List<int> wheresSquaredo = new List<int>() { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14};


        }*/
    }
}
