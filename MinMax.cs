using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinMaxProject
{
    class MinMax
    {

        public int findHighest(int[] anArray) // method to find the student with the highest mark
        {
            int Max = anArray[0]; // set first index to max
            for (int i = 0; i < anArray.Length; i++ ) // iterate over array
            {
                if (anArray[i] > Max) // check current number is greater than max
                {

                    Max = anArray[i]; // swap if greater is true

                }


            }




            return Max;
        }







        static void Main(string[] args)
        {
        }
    }
}
