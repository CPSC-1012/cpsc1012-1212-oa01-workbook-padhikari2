
/*  Purpose: Compute the weekly wage of an employee.
 *  
 *  Inputs:  regular hourly rate
 *           regular hours worked 
 *           overtime hourly rate
 *           overtime hours worked
 *           
 * 
 *  Outputs:  regularWages
 *            overtimeWages
 *            
 * Algorithm: Step 1: Prompt for regulaar hourly rate
 *                    regular hours worked
 *                    overtime hourly rate
 *                    overtime hours worked
 *          
 *          step 2: Compute the following values:
 *               regularWages = regularHourlyRate * regularHoursWorked
 *               overtimeWages = overtimeHourlyRate * overtimeHoursWorked
 *               totalWages = regularWages + overtimeWages
 *               
 *          Step 3: Display the wages for the week     
 * */
// Declar variables for inputs and outputs
double basePay;
double regularHours;
double overtimeHours;
double overtimePay;
double regularWages;
double overtimeWages;
double totalWages;

//Prompt and read in the values for regular hour rate

Console.Write("What is your base pay: ");
basePay = double.Parse(Console.ReadLine());
Console.Write("How many hours did you work: ");
regularHours = double.Parse(Console.ReadLine());
Console.Write("What is your overtime pay: ");
overtimePay = double.Parse(Console.ReadLine());
Console.Write("How many overtime hours did you work: ");
overtimeHours = double.Parse(Console.ReadLine());
 

//
regularWages = basePay * regularHours;
overtimeWages = overtimePay * overtimeHours;
totalWages = regularWages + overtimeWages;

//provide the output
Console.Write($"The total wage for this pay cycle is:,{totalWages :C}");




