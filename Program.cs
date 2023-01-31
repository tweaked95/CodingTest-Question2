using System;
using System.Linq;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 1, 4, 2, 3, 2, 4, 2, 5, 2, 6, 4 };
            Console.WriteLine(Solution(6,array));
        }

        public static int Solution(int X, int[] A)
        {
            bool[] pathTracker = new bool[X + 1];
            pathTracker[0] = true;

            for (int i = 0; i < A.Length; i++)
            {
                if (!pathTracker[A[i]])
                {
                    pathTracker[A[i]] = true;
                    if (pathTracker.All(x=>x))
                    {
                        return i;
                    }
                }
            }

            return -1;
        }


    }
}
