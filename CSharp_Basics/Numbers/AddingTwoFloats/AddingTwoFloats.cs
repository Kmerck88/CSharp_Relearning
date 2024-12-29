//Prompt the user to enter two numbers. After the user enters the numbers, add them together and output the sum back to the console.

//Example
//>>Enter a number: << 12.2
//>> Enter another number: << 17.3
//>> The sum is 29.3

Console.WriteLine("Enter a number: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter another number: ");
double number2 = Convert.ToDouble(Console.ReadLine());
double sum = number1 + number2;
Console.WriteLine("The sum is " + sum);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
