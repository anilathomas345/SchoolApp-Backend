using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArray.Program
{
    internal class Demo3
    {
        static void Main()
        {
            //2-dimenstional array
            //datatype[,]array_name=new datatype[row_size,col_size]
            int[,] _2darray = new int[3, 2];//array elements in 3 rows and 2 columns
            //assign value
            _2darray[0, 0] = 98;
            _2darray[1, 0] = 45;
            //2nd row
            _2darray[1, 0] = 56;
            _2darray[1, 1] = 44;
            //3rd row
            _2darray[2, 0] = 99;
            _2darray[2, 1] = 33;
            foreach(int i in _2darray) 
                Console.WriteLine(i);
            Console.WriteLine("Display values in matrix format");
            for(int i=0;)
        }
    }
}
