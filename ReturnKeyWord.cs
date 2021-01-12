using System;

namespace _04.Test
{
    class Program
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
            return number; // keyword retunr stops method execution and gives back some result! 
            // when we want to give back a result out function must have delivberately a type !
            
        }
       
    }
}
