using System;

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
        static void getStartingInput(out long N, out long C)
        {
            string[] s_input = Console.ReadLine().Split(' ');
            N = long.Parse(s_input[0]);
            C = long.Parse(s_input[1]);
        }
        static void Main(string[] args)
        {
            long T = long.Parse(Console.ReadLine());

            for (long j = 0; j < T; j++)
            {
                long beginIndex, endIndex, nToAdd, N, C = 0;
                getStartingInput(out N, out C);
                long[] initialArray = new long[N + 1];
                for (int i = 0; i < C; i++)
                {
                    if (getInputAndInform(out beginIndex, out endIndex, out nToAdd))
                    {
                        addInRange(initialArray, beginIndex, endIndex, nToAdd);

                    }
                    else
                    {
                        Console.WriteLine(getConstrainedSum(initialArray, beginIndex, endIndex));
                    }
                }
            }
        }
    }
}