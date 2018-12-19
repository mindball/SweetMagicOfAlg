using System;
using System.Collections.Generic;


//this algorithm may also have a condition: delete a minimum number of numbers from the array to be arranged in ascending order.
//The same task only as formulated in another way
class LIS
{
    static void Main()
    {
        //int len = LengthOfLIS(new int[] { 0, 10, 20, 30, 30, 40, 1, 50, 2, 3, 4, 5, 6 });
        int len = LengthOfLIS(new int[] { 11, 10, 2, 3 });

        /* Look at closely how work binary search when number is not found, pay attention to the return value
         * insertion point:
         * //int[] list = {2, 4, 7, 10, 11, 45, 50, 59, 60, 66, 69, 70, 79};
           //               1^ 2^ 3^  4^  5^  
         int index = theList.BinarySearch(num);

        if (index >= 0)
        {
            //exists
            ...
        }
        else
        {
            // doesn't exist
        int indexOfBiggerNeighbour = ~index; //bitwise complement of the return value

        if (indexOfBiggerNeighbour == theList.Count)
        {
            // bigger than all elements
            ...
        }

        else if (indexOfBiggerNeighbour == 0)
        {
            // smaller than all elements
            ...
        }

        else
        {
            // Between 2 elements
            int indexOfSmallerNeighbour = indexOfBiggerNeighbour - 1;
            ...
        }

        **/
    }


    static public int LengthOfLIS(int[] nums)
    {
        if (nums == null || nums.Length == 0) return 0;
        var orderednum = new List<int>();

        foreach (var num in nums)
        {
            var index = orderednum.BinarySearch(num);
            if (index < 0) index = -(index + 1);

            if (index == orderednum.Count) orderednum.Add(num);
            else orderednum[index] = num;
        }

        return orderednum.Count;
    }




}

