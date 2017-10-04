using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Misc.Test.TestBinaryTree.Run();
            CodeKata.Test.TestKata2.RunChop1();
            CodeKata.Test.TestKata2.RunChop2();
            CodeKata.Test.TestKata2.RunChop3();
            CodeKata.Test.TestKata2.RunChop4();
            Misc.ShareTrade.TestShareTrade();
            HackerRank.ArrayLeftRotation.Run(args);
            Console.ReadLine();

        }
    }
}

