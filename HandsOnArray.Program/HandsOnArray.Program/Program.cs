using System.Numerics;
using System.Reflection;

namespace HandsOnArray.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        //array syntax
        //datatype var_name[]=new datatype[size];
        int[]marks = new int[6];
            //assign  value of array
            marks[0] = 89;
            marks[1] = 78;
            marks[2] = 67;
            marks[3] = 90;
            marks[4] = 66;
            marks[5] = 78;
            marks[6] = 88;//runtime error
            Console.WriteLine("English mark:" + marks[3]);//access value from array using index
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(marks[i]);
                
            }
        

    

