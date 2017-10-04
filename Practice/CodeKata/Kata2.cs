using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CodeKata
{
    class Kata2
    {
        public static int chop1(int value, int[] array)
        {

            if (array.Length == 0)
            {
                return -1;
            }
            else if(array.Length == 1) {
                if(array[0] == value)
                {
                    return 0;
                }
                else 
                {
                    return -1;
                }
            }
            else 
            {
                int index = (array.Length / 2);
                if(array[index] == value)
                {
                    return index;
                }
                else if(value < array[index])
                {
                    if(index == 0) {
                        return -1;
                    }
                    int[] subarray = array.Take(index).ToArray();
                    int subindex = chop1(value, subarray);
                    return subindex;
                }
                else 
                { 
                    if(index == array.Length - 1)
                    {
                        return -1;
                    }
                    int[] subarray = array.Skip(index + 1).ToArray();
                    int subindex = chop1(value, subarray);
                    if(subindex >= 0)
                    {
                        return index + subindex + 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public static int chop2(int value, int[] array)
        {
            if (array.Length == 0)
            {
                return -1;
            }

            int index = array.Length / 2;
            int window = array.Length;

            do
            {
                if(array[index] == value)
                {
                    return index;
                }
                else if (array[index] != value && window <= 1) 
                {
                    return -1;
                }
                else
                {
                    if (window == 2)
                    {
                        if (array[index - 1] == value) 
                        {
                            return index - 1;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else if (window == 3)
                    {
                        if (array[index - 1] == value)
                        {
                            return index - 1;
                        }
                        else if (array[index + 1] == value)
                        {
                            return index + 1;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else if (window % 2 == 0)
                    {
                        if (value < array[index])
                        {
                            index = index - window/2 +1;
                            window = (window / 2);
                        }
                        else
                        {
                            index = index + (window/2 - 1);
                            window = (window / 2) - 1;
                            
                        }
                    }
                    else
                    {
                        
                        if (value < array[index])
                        {
                            index = index - window/2 + 1;
                        }
                        else
                        {
                            index = index + (window/2/2)+1;
                        }
                        window /= 2;
                    }
                }
            }
            while (window > 0 && index >= 0 && index < array.Length);

            return -1;
        }

        public static int chop3(int value, int[] array)
        {
            // Approach: Cycle through different ranges N..M, when length is 3+ check middle pivot, when 2, check both, when 1 check one value.
            return -1;
        }

        public static int chop4(int value, int[] array)
        {
            // Split array into smaller pieces
            // Check middle item, rounding up- Exclude from halves

            int middleIx = (int)decimal.Floor((decimal)array.Length / 2);

            if(array.Length == 0)
            {
                return -1;
            }
            else if (array[middleIx] == value)
            {
                return middleIx;
            }
            else 
            {
                if (array.Length == 1)
                {
                    return -1;
                }
                else if (value < array[middleIx])
                {
                    int ret1 = chop4(value, array.Take(middleIx).ToArray());
                    return ret1 >= 0 ? ret1 : ret1;
                }
                else if (value > array[middleIx])
                {
                    int ret2 = chop4(value, array.Skip(middleIx + 1).ToArray());
                    return ret2 >= 0 ? middleIx + 1 + ret2 : ret2;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
