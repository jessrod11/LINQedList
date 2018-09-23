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

            Console.WriteLine("List of student names in descending order...");
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
            largestAmount();
            Console.ReadLine();

            Console.WriteLine("Output the perfect square");
            whereDaSquaresAt();
            Console.ReadLine();

            Console.WriteLine("List the millionaire's names and how many millionaires per bank...");
            nameThatMillionaire();
            Console.ReadLine();

            Console.WriteLine("FINALLY!!! THE LAST ONE!");
            moreAboutMillionaires();
            Console.ReadLine();   
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

        static void largestAmount()
        {
            // What is our most expensive product?
            List<double> prices = new List<double>() { 879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76};

            var largestPrice = prices.Max();
            Console.WriteLine(largestPrice);
        }
  
        static void whereDaSquaresAt()
        {
            
            /*Store each number in the following List until a perfect square
            is detected.*/
             
            List<int> wheresSquaredo = new List<int>() { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14};

            var perfectSquare = wheresSquaredo.TakeWhile(n => Math.Sqrt(n) % 1 != 0);

            foreach (var perfection in perfectSquare)
            {
                Console.WriteLine(perfection);
            }
        }
        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }
        static void nameThatMillionaire()
        {
            // Build a collection of customers who are millionaires
            var customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            var allMillionaires = new List<Customer>();

            foreach (var customer in customers)
            {
                if(customer.Balance >= 1000000)
                {
                    allMillionaires.Add(customer);
                }
            }

            foreach(var millionaire in allMillionaires)
            {
                Console.WriteLine(millionaire.Name);
            }

            /*  Given the same customer set, display how many millionaires per bank.

             Example Output:
             WF 2
             BOA 1
             FTB 1
             CITI 1
         */
            var results = from a in allMillionaires
                          group a.Balance by a.Bank into g
                          select new { Bank = g.Key, balances = g.ToList() };

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Bank} : {result.balances.Count()}");
            }

        }
        /*
    TASK:
    As in the previous exercise, you're going to output the millionaires,
    but you will also display the full name of the bank. You also need
    to sort the millionaires' names, ascending by their LAST name.

    Example output:
        Tina Fey at Citibank
        Joe Landy at Wells Fargo
        Sarah Ng at First Tennessee
        Les Paul at Wells Fargo
        Peg Vale at Bank of America
*/

        // Define a bank
        public class Bank
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
        }
        static void moreAboutMillionaires()
        {
            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

            // Create some customers and store in a List
            List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };
            var millionaireReport = from bank in banks
                                    join customer in customers on bank.Symbol equals customer.Bank
                                    orderby customer.Name.Split(" ").Last()
                                    select new { BankName = bank.Name, Customer = customer.Name, customer.Balance };
            Console.WriteLine("List  millionaires by last name with the last name in ascending order at their specified bank...");

        foreach (var customer in millionaireReport)

                if(customer.Balance >= 1000000)
            {
                Console.WriteLine($"{customer.Customer} at {customer.BankName}");
            }

        }
    }
}
