using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArray.Program
{
    internal class Demo2
    {
        static void Main()
        {
            //Array class member
            int[] n = { 12, 23, 24, 36, 21 };//dynamic array
            Console.WriteLine("size:"+n.Length);//returns size of the array
            Console.WriteLine("Dimension:" + n.Rank);//Rank returns dimension of array
            //sort array elements
            Array.Sort(n);
            foreach (int i in n) Console.WriteLine(i);
            //reverse array elements
            Array.Reverse(n);
            foreach (int i in n) Console.WriteLine(i);
            if (Array.BinarySerach(n, 134 >=0))//search  a value with in the array
            {
                Console.WriteLine("Value exist");
            }
            else
                Console.WriteLine("value not exist");
        }

    }
}
