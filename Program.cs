using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparisonMark1
{
    class NumberOrganiser
    {

        static long GetNumberFromUser()
        {
            string input;
            input = Console.ReadLine();
            long r;
            r = Convert.ToInt64(input);
            return r;
        }

        static void Main()
        {

            long long1FromUser;
            long long2FromUser;
            Console.WriteLine(" N U M B E R  O R G A N I S E R ");
            Console.ReadLine();
            Console.WriteLine(" I can organise numbers, and tell you which number is larger!");
            Console.ReadLine();
            Console.WriteLine(" Please input your first number");
            long1FromUser = GetNumberFromUser();
            Console.WriteLine(" Please input your second number");
            long2FromUser = GetNumberFromUser();
            Console.WriteLine("Your two numbers are " + long1FromUser + " and " + long2FromUser + "." + "The largest number of the two are... ");
            Console.ReadLine();


            if (long1FromUser > long2FromUser)
            {
                Console.WriteLine(long1FromUser + "!");

            }
            if (long2FromUser > long1FromUser)
            {
                Console.WriteLine(long2FromUser + "!");
            }
            if (long2FromUser == long1FromUser)
            {
                Console.WriteLine("you sly dog. did you really think that I did not know that " + long1FromUser + " and " + long2FromUser + " were the same number? foolish child.");
            }
            Console.ReadLine();
        }
        
            

            

      

      
        
        
    }

}
/*string GuessInput = Console.ReadLine();
Guess = Convert.ToInt32(GuessInput)*/