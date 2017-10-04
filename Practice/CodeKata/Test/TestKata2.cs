using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CodeKata.Test
{
    public class TestKata2
    {
        private static void WriteResult(int ix, bool result)
        {
            Console.WriteLine("Test {0}: {1}", ix, result);
        }

        public static void RunChop1()
        {
            int i = 0;
            WriteResult(++i, int.Equals(-1, Kata2.chop1(3, new int[] {})));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(3, new int[] {1})));
            WriteResult(++i, int.Equals(0,  Kata2.chop1(1, new int[] {1})));
  
            /*4 - Issue: Inverted condition when looking for zero-th item */ 
            WriteResult(++i, int.Equals(0,  Kata2.chop1(1, new int[] {1, 3, 5})));
            WriteResult(++i, int.Equals(1,  Kata2.chop1(3, new int[] {1, 3, 5})));
            /*6 - Isse: Right-side subset needs +1 index value*/
            WriteResult(++i, int.Equals(2,  Kata2.chop1(5, new int[] {1, 3, 5})));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(0, new int[] {1, 3, 5})));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(2, new int[] {1, 3, 5})));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(4, new int[] {1, 3, 5})));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(6, new int[] {1, 3, 5})));
      
            /*11*/
            WriteResult(++i, int.Equals(0,  Kata2.chop1(1, new int[] {1, 3, 5, 7})));
            /*12*/
            WriteResult(++i, int.Equals(1,  Kata2.chop1(3, new int[] {1, 3, 5, 7})));
            WriteResult(++i, int.Equals(2,  Kata2.chop1(5, new int[] {1, 3, 5, 7})));
            /*14*/
            WriteResult(++i, int.Equals(3,  Kata2.chop1(7, new int[] {1, 3, 5, 7})));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(0, new int[] {1, 3, 5, 7})));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(2, new int[] {1, 3, 5, 7})));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(4, new int[] {1, 3, 5, 7})));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(6, new int[] {1, 3, 5, 7})));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(8, new int[] {1, 3, 5, 7})));

            /* Personal tests */
            WriteResult(++i, int.Equals(0, Kata2.chop1(1, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(1, Kata2.chop1(3, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(2, Kata2.chop1(5, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(3, Kata2.chop1(7, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(4, Kata2.chop1(9, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(0, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(2, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(4, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(6, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(8, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(10, new int[] { 1, 3, 5, 7, 9 })));

            WriteResult(++i, int.Equals(0, Kata2.chop1(1, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(1, Kata2.chop1(3, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(2, Kata2.chop1(5, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(3, Kata2.chop1(7, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(4, Kata2.chop1(9, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(5, Kata2.chop1(11, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(0, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(2, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(4, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(6, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(8, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(10, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop1(12, new int[] { 1, 3, 5, 7, 9, 11 })));

        }

        public static void RunChop2()
        {
            Console.WriteLine("Chop2");
            int i = 0;
            /* Did not consider empty array*/
            WriteResult(++i, int.Equals(-1, Kata2.chop2(3, new int[] { })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(3, new int[] { 1 })));
            WriteResult(++i, int.Equals(0, Kata2.chop2(1, new int[] { 1 })));

            WriteResult(++i, int.Equals(0, Kata2.chop2(1, new int[] { 1, 3, 5 })));
            WriteResult(++i, int.Equals(1, Kata2.chop2(3, new int[] { 1, 3, 5 })));
            WriteResult(++i, int.Equals(2, Kata2.chop2(5, new int[] { 1, 3, 5 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(0, new int[] { 1, 3, 5 })));
            /* Cannot apply the same formula to defining the window on even or uneven sets */
            WriteResult(++i, int.Equals(-1, Kata2.chop2(2, new int[] { 1, 3, 5 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(4, new int[] { 1, 3, 5 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(6, new int[] { 1, 3, 5 })));

            /* Assuming index landed on first half on even sets, it lands in second half of the array */
            WriteResult(++i, int.Equals(0, Kata2.chop2(1, new int[] { 1, 3, 5, 7 })));
            WriteResult(++i, int.Equals(1, Kata2.chop2(3, new int[] { 1, 3, 5, 7 })));
            WriteResult(++i, int.Equals(2, Kata2.chop2(5, new int[] { 1, 3, 5, 7 })));
            /* Forgot to make the right-side window short */
            WriteResult(++i, int.Equals(3, Kata2.chop2(7, new int[] { 1, 3, 5, 7 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(0, new int[] { 1, 3, 5, 7 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(2, new int[] { 1, 3, 5, 7 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(4, new int[] { 1, 3, 5, 7 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(6, new int[] { 1, 3, 5, 7 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(8, new int[] { 1, 3, 5, 7 })));

            /* Personal tests */
            WriteResult(++i, int.Equals(0, Kata2.chop2(1, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(1, Kata2.chop2(3, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(2, Kata2.chop2(5, new int[] { 1, 3, 5, 7, 9 })));
            /* Out of range when window is 2 */
            WriteResult(++i, int.Equals(3, Kata2.chop2(7, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(4, Kata2.chop2(9, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(0, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(2, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(4, new int[] { 1, 3, 5, 7, 9 })));
            /* Out of range when window is 2 */
            WriteResult(++i, int.Equals(-1, Kata2.chop2(6, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(8, new int[] { 1, 3, 5, 7, 9 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(10, new int[] { 1, 3, 5, 7, 9 })));

            WriteResult(++i, int.Equals(0, Kata2.chop2(1, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(1, Kata2.chop2(3, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(2, Kata2.chop2(5, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(3, Kata2.chop2(7, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(4, Kata2.chop2(9, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(5, Kata2.chop2(11, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(0, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(2, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(4, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(6, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(8, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(10, new int[] { 1, 3, 5, 7, 9, 11 })));
            WriteResult(++i, int.Equals(-1, Kata2.chop2(12, new int[] { 1, 3, 5, 7, 9, 11 })));

        }

        private static int chop3Counter = 0;
        public static void RunChop3() 
        {
            Console.WriteLine("Chop3");
            chop3Counter = 0;
            WriteChop3(3, new int[] { });
            WriteChop3(3, new int[] { 1 });
            WriteChop3(1, new int[] { 1 });

            int[] list1 = { 1, 3, 5 };
            int[] list2 = { 0, 2, 4, 6 };

            for (int i = 3; i <= 10; i++)
            {
                foreach (int l1 in list1)
                {
                    WriteChop3(l1, list1);
                }
                foreach (int l2 in list2)
                {
                    WriteChop3(l2, list1);
                }

                list1 = list1.Concat(new int[] { list1.Last() + 2 }).ToArray<int>();
                list2 = list2.Concat(new int[] { list2.Last() + 2 }).ToArray<int>();
            }

        }
        private static void WriteChop3(int value, int[] array)
        {
            int ixof = array.ToList<int>().IndexOf(value);
            int chop3res = Kata2.chop3(value, array);
            Console.WriteLine("Test {0}: {1} (Len{2}) = {3}", ++chop3Counter, value, array.Length, int.Equals(ixof, chop3res));
        }

        private static int chop4Counter = 0;
        public static void RunChop4()
        {
            Console.WriteLine("Chop4");
            chop4Counter = 0;
            WriteChop4(3, new int[] { });
            WriteChop4(3, new int[] { 1 });
            WriteChop4(1, new int[] { 1 });

            int[] list1 = { 1, 3, 5 };
            int[] list2 = { 0, 2, 4, 6 };

            for (int i = 3; i <= 10; i++)
            {
                foreach (int l1 in list1)
                {
                    WriteChop4(l1, list1);
                }
                foreach (int l2 in list2)
                {
                    WriteChop4(l2, list1);
                }

                list1 = list1.Concat(new int[] { list1.Last() + 2 }).ToArray<int>();
                list2 = list2.Concat(new int[] { list2.Last() + 2 }).ToArray<int>();
            }

        }
        private static void WriteChop4(int value, int[] array)
        {
            int ixof = array.ToList<int>().IndexOf(value);
            int chop4res = Kata2.chop4(value, array);
            Console.WriteLine("Test {0}: {1} (Len{2}) = {3}", ++chop4Counter, value, array.Length, int.Equals(ixof, chop4res));
        }
    }
}
