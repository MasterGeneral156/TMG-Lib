using System;
using System.Security.Cryptography;

namespace TMGLib
{
    public class RandomUtils
    {
        /*
         * Function to randomly generate numbers input by user.
         * int min = Minimum number to be chosen
         * int max = Maximum number to be chosen
         * 
         * returns int
         */
        public static int getRNG(int min, int max)
        {
            if (max <= min)
                max = min + 1;
            return new Random().Next(min, max);
        }
        /*
         * Function to randomly generate numbers input by user.
         * Uses int min and int max as values.
         * 
         * returns int
         */
        public static int getRNG()
        {
            return new Random().Next(int.MinValue, int.MaxValue);
        }
    }
}
