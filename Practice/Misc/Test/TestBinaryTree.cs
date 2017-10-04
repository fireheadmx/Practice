using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Misc.Test
{
    class TestBinaryTree
    {

        private static int minLength = 500, maxLength = 501, minNumber = -10000, maxNumber = 10000;

        public static void Run()
	    {
            BinaryTree bt = new BinaryTree();
            Random rnd = new Random();
            int length = rnd.Next(minLength, maxLength);
            int[] numbers = new int[length];
            List<int> searchItems = new List<int>();
            int collission = 0;

            Console.Write("Generated values: ");
            for (int i = 0; i < length; i++)
            {
                // Generate random int
                numbers[i] = rnd.Next(minNumber, maxNumber);
                // Add number to Binary Tree
                if (!bt.insert(numbers[i]))
                {
                    Console.Write("c{0} ", numbers[i]);
                    collission++;
                }
                else { 
                // Display generated numbers
                    Console.Write("{0} ", numbers[i]);
                }
                // Add to list of items to search
                if (rnd.Next(0, 101) <= 90)
                //if(true)
                {
                    searchItems.Add(numbers[i]);
                }
                else
                {
                    searchItems.Add(rnd.Next(minNumber, maxNumber));
                }
            }
            Console.WriteLine("Collissions: {0}", collission);
            Console.WriteLine("");
            Console.WriteLine("Sorted Values: {0}", bt.sortedTree());
            Console.WriteLine("");
            Console.WriteLine("Search Items:");
            foreach(int si in searchItems) 
            {
                Console.WriteLine("{0}: {1}", si, bt.navigationPath(si));
            }
            Console.WriteLine("");
            Console.WriteLine("Depth: {0}", bt.depth());
            Console.Write(bt.treeLevels());

	    }
    }
}
