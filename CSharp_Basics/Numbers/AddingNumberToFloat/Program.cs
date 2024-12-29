//Description
//Prompt the user to enter a number. After the user enters a number,
//add .5 to the number and output it back to the console.

//Example
//>>Enter a number: << 17.3
//>> 17.8

Console.WriteLine("Enter a number: ");
double number = Convert.ToDouble(Console.ReadLine());
double newNumber = number + 0.5;
Console.WriteLine(newNumber);