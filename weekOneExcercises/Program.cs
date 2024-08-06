using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace weekOneExcercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXCERCISE 1.1 Echo String
                //Prompt user to enter a string. After user enters a string, output the display back to the console.
                Console.WriteLine("Enter some text: ");
                string userInput = Console.ReadLine();
                Console.WriteLine($"ECHOOO, {userInput}"); //Using String Interpolation

                //Instruction to progress - breaks porject into seperate excercises
                Console.WriteLine("Press Enter to Continue to the Next Excercise");

                //Halts program to allow user to read the output
                Console.ReadLine();

            //EXCERCISE 1.2 Adding a number to an integer
                //Prompt the user to enter a number. After the user enters a number, add 1 to the number and output it back to the console.
                Console.WriteLine("Enter a number: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your Number Plus 1 is: {userNumber + 1}"); //Using String Concatenation and a logical operator

                //Instruction to progress - breaks porject into seperate excercises
                Console.WriteLine("Press Enter to Continue to the Next Excercise");

                //Halts program to allow user to read the output
                Console.ReadLine();

            //Excercise 1.3 Adding a number to a float
                //Prompt the user to enter a number. After the user enters a number, add .5 to the number and output it back to the console.
                Console.WriteLine("Enter a number: ");
                float userFloat = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine($"Your Number Plus .5 is: {userFloat + .5})"); //Using String Concatenation and a logical operator

                //Instruction to progress - breaks porject into seperate excercises
                Console.WriteLine("Press Enter to Continue to the Next Excercise");

                //Halts program to allow user to read the output
                Console.ReadLine();

            //EXCERCISE 1.4 Adding two floats
                //Prompt the user to enter two numbers.After the user enters the numbers, add them together and output the sum back to the console.
                Console.WriteLine("Enter a number: ");
                float userFloat1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                float userFloat2 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine($"The sum of your numbers is: {userFloat1 + userFloat2}"); //Using String Concatenation and a logical operator

                //Instruction to progress - breaks porject into seperate excercises
                Console.WriteLine("Press Enter to Continue to the Next Excercise");

                //Halts program to allow user to read the output
                Console.ReadLine();

            //EXCERCISE 1.5 Multiplying two floats
                //Prompt the user to enter two numbers. After the user enters the numbers, multiply them and output the product back to the console.
                Console.WriteLine("Enter a number: ");
                float userFloat3 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                float userFloat4 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine($"The product of your numbers is: {userFloat3 * userFloat4}"); //Using String Concatenation and a logical operator

                //Instruction to progress - breaks porject into seperate excercises
                Console.WriteLine("Press Enter to Continue to the Next Excercise");

                //Halts program to allow user to read the output
                Console.ReadLine();

            //EXCERCISE 1.6 Dividing Integers
                //Use the int type here. Prompt the user to enter two numbers. After the user enters the numbers, divide them and output the result back to the console. Notice what happens when you enter two numbers that don’t divide evenly. What number do you get? Try running the program by entering decimal numbers. What happens?
                Console.WriteLine("Enter a number: ");
                int userInt1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int userInt2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The result of your numbers is: {userInt1 / userInt2}"); //Using String Concatenation and a logical operator

                //Instruction to progress - breaks porject into seperate excercises
                Console.WriteLine("Press Enter to Continue to the Next Excercise");

                //Halts program to allow user to read the output
                Console.ReadLine();

            //When 2 numbers that dont divide evenlt are entered, the result is a whole number. The decimal is removed so the answer appears to be incorrect. To make this look correct, you can convert the result to a float or double.

            //EXCERCISE 1.7 Entering Booleans
            /*Prompt the user to enter a boolean. Write out the boolean value, and then write out the opposite of the boolean variable.
            Question: What possible things can the user enter to input a valid boolean? Try different things and see if you can come up with the answer.
            Next, notice also the difference between what you type into code for a boolean value of either true or false, and what displays on the screen when you WriteLine a boolean value.*/

            Console.WriteLine("Please enter true of false: ");
            bool userBool = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"You entered: {userBool}");
            Console.WriteLine($"The opposite of your boolean is: {!userBool}");

        }
    }
}
