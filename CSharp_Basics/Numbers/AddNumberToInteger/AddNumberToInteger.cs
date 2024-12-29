//Description
//Prompt the user to enter a number. After the user enters a number, add 1 to the number and output it back to the console.

//Example
//>>Enter a number: << 52
//>> 53


Console.WriteLine("Enter a number: "); // Prompt the user to enter a number
int number = int.Parse(Console.ReadLine()); // Read the number entered by the user
int newNumber = number + 1; // Add 1 to the number
Console.WriteLine(newNumber);
