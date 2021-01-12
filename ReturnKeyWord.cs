using System;

namespace _04.Test
{
    class ReturnKeyWord
    {
        static void Main(string[] args)
        {
            int num = 8;
             num = Increment(num, 2);
            Console.WriteLine(num);
;
        }
        private static int Increment(int number , int value)
        {
            number += value;
            Console.WriteLine(number);
            return number; // keyword return stops method execution and gives back some result! 
            // when we want to give back a result out of function  we must have delivberately a type return keyword !
            
        }
       
    }
}
