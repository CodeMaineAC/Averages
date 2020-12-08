using System;
/*
 * Sum and Average
 * Takes a set of numbers from the user as input and finds the sum and average (mean)
 */
namespace Averages
{
    class AveragesMainApp
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double mean; //declares a variable but not give it a value

            //prompts user for input
            Console.Write("Enter a set of numbers seperated by spaces: ");
            string userInput = Console.ReadLine();

            //takes the user input and stores it an array(list like strucure that is similiar to Python tuple in behavior)
            string[] numberSet = userInput.Split(' '); //Split on empty space

            int lenNumSet = numberSet.Length;//finds the array length

            int count = 0; 
            while(count < lenNumSet) //loop while count is less than the number of numbers we have in our set
            {
                sum += Convert.ToDouble(numberSet[count]);
                count++;//increase count value by 1, does the same thing as 'count += 1' or 'count = count + 1
            }
            mean = sum / lenNumSet; //find the average
            Console.WriteLine("The Sum is {0} \nThe mean is {1}", sum, mean); //output results using placeholders


            /*
             * Another way to output the results without using placeholders. Both do the same thing
             * This code is currently commented out and non-functioning
             */
            //Console.WriteLine("The Sum is " + sum);
            //Console.WriteLine("The mean is " + mean);

        }
    }
}
