using System;

double number1;
double number2;
char action;
double result;

while (true)
{

    Console.WriteLine("Input number1. If number is fractional use comma as separator.");
    number1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Input number2.If double use comma as separator.If number is fractional use comma as separator.");
    number2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Input action. Allowed list is +, -, *, /");
    action = char.Parse(Console.ReadLine());

    if (action == '+')
    {
        result = Addition(number1, number2);
        Console.WriteLine(result);
    }
    else if (action == '-')
    {
        result = Subtraction(number1, number2);
        Console.WriteLine(result);
    }
    else if (action == '*')
    {
        result = Multiplication(number1, number2);
        Console.WriteLine(result);
    }
    else if (action == '/')
    {
        if (number2 != 0)
        {
            result = Division(number1, number2);
            Console.WriteLine(result);
        }
        else if (number2 == 0)
        {
            Console.WriteLine("Impossible to divede by 0!");
        }
    }
    else
    {
        Console.WriteLine("Please input action from allowed list!");
    }
}


double Addition(double a, double b)
{
    return a + b;
}

double Subtraction(double a, double b)
{
    return a - b;
}

double Multiplication(double a, double b)
{
    return a * b;
}

double Division(double a, double b)
{
    return a / b;
}