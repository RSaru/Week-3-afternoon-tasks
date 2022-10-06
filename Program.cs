// See https://aka.ms/new-console-template for more information
int firstNumber;
Console.WriteLine("Please enter a number");
firstNumber = Convert.ToInt32(Console.ReadLine());

int secondNumber;
Console.WriteLine("Please enter a second number");
secondNumber = Convert.ToInt32(Console.ReadLine());

char symbol;
Console.WriteLine("Please enter one of the following: *, +, -, /, % to proceed with the calculation");
symbol = Convert.ToChar(Console.ReadLine());

if (symbol == '*' )
{
    Console.WriteLine(firstNumber*secondNumber);
}
else if (symbol == '+')
{
    Console.WriteLine(firstNumber+secondNumber);
}
else if (symbol == '-')
{
    Console.WriteLine(firstNumber-secondNumber);
}
else if (symbol == '/')
{
    Console.WriteLine(firstNumber/secondNumber);
}
else if (symbol == '%')
{
    Console.WriteLine(firstNumber%secondNumber);
}
else
{
    Console.WriteLine("That is not a valid symbol");
}


Console.ReadLine();