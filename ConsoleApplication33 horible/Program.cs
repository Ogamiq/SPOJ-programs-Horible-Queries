using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33_horible
{
    class Program
    {

        static void addInRange(long[] arr, long beginIndex, long endIndex, long nToAdd)
        {
            for(long i = beginIndex; i <= endIndex; i++)
            {
                arr[i] += nToAdd;
            }
        }
        static long getConstrainedSum(long[] arr, long beginIndex, long endIndex)
        {
            long sum = 0;
            for(long i = beginIndex; i <= endIndex; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static bool getInputAndInform(out long beginIndex, out long endIndex, out long nToAdd)
        {
            //returns true for input like "0 2 4 26" and false for input like "1 4 8"
            //assigns input to variables and propagates them as longs.
            string[] s_input = Console.ReadLine().Split(' ');
            long[] l_input = new long[4];
            int length = s_input.Length;
            for(int i = 0; i < length; i++)
            {
                l_input[i] = long.Parse(s_input[i]);
            }
            long inputType = l_input[0];
            beginIndex = l_input[1];
            endIndex = l_input[2];
            nToAdd = l_input[3];
            if(inputType == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void Main(string[] args)
        {

            long N = 8 + 1; // this N is given in input. <-- length of initial array.
            long C = 6; // this C is given in input. <-- number of commands. 
            long[] initialArray = new long[N]; 
            long beginIndex, endIndex, nToAdd = 0;
            for(int i = 0; i < C; i++)
            {
                if(getInputAndInform(out beginIndex, out endIndex, out nToAdd))
                {
                    addInRange(initialArray, beginIndex, endIndex, nToAdd);
                    
                }
                else
                {
                    Console.WriteLine(getConstrainedSum(initialArray, beginIndex, endIndex)); 
                }
            }
         
            Console.ReadKey();

            //Console.WriteLine("beginIndex: {0}, endIndex: {1}, nToAdd: {2}"
            //    ,beginIndex,endIndex,nToAdd);
        }
    }
}
