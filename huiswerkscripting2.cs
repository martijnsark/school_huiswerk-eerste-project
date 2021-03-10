using System;
using System.Collections.Generic;

namespace huiswerkding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("begining...");
            Console.WriteLine("==================================================================\n\n");



            Console.WriteLine("==================================================================");
            Console.WriteLine("step1 done...");
            Console.WriteLine("==================================================================\n");

            var addCollectionToList = new List<int>() { 12, 13, 10, 14, 27 };
            Console.WriteLine(addCollectionToList.Count);

            var numsList = new List<int>() { 23, 24, 29 };
            addCollectionToList.AddRange(numsList);
            Console.WriteLine(addCollectionToList.Count);

            foreach (var num in numsList)
            {
                Console.WriteLine(num);
            }

            foreach (var num2 in addCollectionToList)
            {
                Console.WriteLine(num2);
            }

            Console.WriteLine("==================================================================");
            Console.WriteLine("step2 not sure...");
            Console.WriteLine("==================================================================\n");

            //can't seem to make it into the list not sure if it has to even appear into the list ill look at it later
            Console.WriteLine("Enter a number:");
            int username = 0;
            username = Convert.ToInt32(Console.ReadLine());

            var contiansList = new List<int> { 0 };
            Console.WriteLine("Does the list contain you're number? " + contiansList.Contains(5));

            Console.WriteLine("==================================================================");
            Console.WriteLine("step3 no...");
            Console.WriteLine("==================================================================\n");

            var removeItemFromList = new List<int>() { 69, 420 };

            var random = new Random();

            removeItemFromList.Remove(69);
            int index = random.Next(removeItemFromList.Count);
            Console.WriteLine(removeItemFromList[index]);
            //ill work later on making it random being removed can't find how to do it yet...

            Console.WriteLine("==================================================================");
            Console.WriteLine("step4 no...");
            Console.WriteLine("==================================================================\n");

            //im going to reverse sort this one but i have to make it delete list above 4
            var sortList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            sortList.Reverse();

            foreach (var num in sortList)
            {
                Console.WriteLine(num);
                if (sortList.Count > 4)
                {
                    break;
                }
            }

            

            Console.WriteLine("==================================================================");
            Console.WriteLine("ending...");
            Console.WriteLine("==================================================================");
        }
    }
}
