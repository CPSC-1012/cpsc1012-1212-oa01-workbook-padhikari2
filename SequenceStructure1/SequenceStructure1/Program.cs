/*
 *  Inputs: name
 *          age
 *          expected annual salary
 *      
 *  Outputs: My name is Don Iveson, my age is 45 and i hope to earn $204,747.00 per year.
 *           
 *  Algorithm Step 1:Prompt for user's name
 *                   Prompt for user's age
 *                   Prompt for user's expected annual salary
 *                   
 *           Step 2: Read the user's input and display it in a sentence. 
 * 
*/

//Declare variables for inputs and outputs.

string userName;
int userAge;
double expectedSalary;

//Prompt and read in the values

Console.Write("What is your name: ");
userName = Console.ReadLine();
Console.Write("How old are you: ");
userAge = int.Parse(Console.ReadLine());
Console.Write("What is your expected annual salary: ");
expectedSalary = double.Parse(Console.ReadLine());

//provide the output

Console.Write($"My name is {userName},my age is {userAge} and I hope to earn {expectedSalary:C} per year");
