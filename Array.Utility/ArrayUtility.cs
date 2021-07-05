using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayUtility
{
    public class ArrayUtility
    {
        int[] array;
        


        public ArrayUtility()
        {
            array = new int[5];
        }

        public static void Resize(ref int[] array, int newSize)
        {
           
            // growing array
                int[] arr = new int[array.Length + 2];
            
            //copying data to the new array
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }
            array = arr;






        }
    }
}
