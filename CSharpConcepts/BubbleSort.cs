using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    class BubbleSort
    {
        public void Sort()
        {
            int[] numbers = new int[] { 89, 76, 45, 92, 67, 12, 99 };

            for(int i=0; i< numbers.Length; i++)
            {
                for(int j=i+1; j< numbers.Length-1; j++)
                {
                    int temp = 0;

                    if(numbers[i]> numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
                
            }
        }
    }
}
