using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_in_class
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyvalue = 1921.39m; // m is there for some C# thing or whatever. remove it and check the error it gives you
            string html = String.Format("Order Total: {0:C}", moneyvalue); // what is string.format? check that out.
            Console.WriteLine(html); // write the html variable (the string)

            Console.WriteLine("Here is a for loop");
            int sum = 0; // init the sum variable for the loop

            // i is our counter variable, and using i, j, or k as a counter variable in a loop is generally accepted
            for (int i = 1; i <= 6; i++) //start i at 1; stop when i is equal or greater than 6; add 1 to i each time the loop exectues 
            {
                sum = sum + i; // add i to the sum
                Console.WriteLine("The number is: {0} and the running total is {1}", i, sum);
                //Console.WriteLine("Hello World!");
            } // end the for loop

            Console.WriteLine("\nHere is another for loop.\n");
            sum = 0; // resetting the sum to 0 so it doesnt use the value it got from the first loop

            for (int j = 6; j <= 10; j++) // no ; at the end for a for loop. i think because it has the {} brackets
            {
                sum = sum + j;
                Console.WriteLine("The number is: {0} and the running total is {1}", j, sum);
            }

            Console.WriteLine("\nAnother for loop!\n");

            for (int k = 0; k <= 5; k++)
            {
                Console.WriteLine("{0}  Hello World!", k);
            }

            // switch statements! we can use it in place of an ifelse block!

            Console.Write("Please enter your major: "); //using .write keeps you on the same line! good for using a .readline next
            string stateName = Console.ReadLine(); //Whatever the user types before hitting enter will be stored in a string named stateName!
            Console.WriteLine("Your major is:" + stateName);
            string dorm = "Unknown";
            switch (stateName)
            {
                case "ACCT":
                    Console.WriteLine("Wow! Accounting!");
                    dorm = "Carter Hall";
                    break;
                case "INFS":
                    Console.WriteLine("Wow! INFS! Whatever that is!");
                    dorm = "Reagan Hall";
                    break;

                default:
                    Console.WriteLine("I don't recognize that major...");
                    dorm = "Your mom's house.";
                    break;


            }
            Console.WriteLine("You'll be in dorm: {0}", dorm);
            Console.WriteLine("We are done.");


            /* THIS STARTS A BLOCK COMMENT!!!!
            // all of this we'll worry about later
            // it's jsut a bigger switch statement
            Console.Write("Please enter your state yo: ");
            string state = Console.ReadLine();
            string team = " ";
            switch (state)
            {
                case "Texas": // the the case that your state is texas ...
                    team = "Cowboys"; // .. your team name is the cowboys
                        break; // break "breaks" you out of the switch statement.
                    // ususally we'll use this with drop boxes. 
                    // console applications are are black and white and gross.
                    // we'll worry about hte user experience later.
                // later on you can fill this in with whatever states and teams you want
            }
            */
            // AND THAT ENDS A BLCOK COMMENT!!!!
            Console.ReadLine();
        }
    }
}
