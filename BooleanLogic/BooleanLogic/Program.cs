using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(true && false); //asks if both are true. prints false
                Console.WriteLine(true && true); //asks if both are true, prints true
                Console.WriteLine(false && false); //asks if both are true, prints false 

                Console.WriteLine(true || true); //asks if one is true, prints true
                Console.WriteLine(true || false); //asks if one is true, prints true 
                Console.WriteLine(false || true); //asks if one is true, prints false 

                Console.WriteLine(true == true); //asks if true equals true, prints true
                Console.WriteLine(true == false); //asks if true equals false, prints false
                Console.WriteLine(false == false); //asks if false equals false, prints true

                Console.WriteLine(true != true); //asks if true does not equal true, prints false
                Console.WriteLine(true != false); //asks if true does not equal false, prints true
                Console.WriteLine(false != false); //asks if false does not equal false, print false

                Console.WriteLine(true ^ true); //asks if only one is true but not both, prints false
                Console.WriteLine(true ^ false); //asks if only one is true but not both, prints true
                Console.WriteLine(false ^ false); //asks if only one is true but not both, prints false

                Console.WriteLine(true && true && true && false); //asks if all are true, prints false
                Console.WriteLine(true && true && true || false); //asks if all are true or if last expression is false, prints true

                Console.ReadLine();

            }
        }
    }
}
