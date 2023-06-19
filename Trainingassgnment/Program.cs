// function to take input
using System.ComponentModel;

int[] takeInput(int n)
{
    int[] num = new int[n];
    if (n == 1)
    {
        Console.WriteLine("Enter the number:");
        return new int[] { Convert.ToInt32(Console.ReadLine()) };
    }
    else
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("Enter the 1st Number:");
            }
            else if (i == 1)
            {
                Console.WriteLine("Enter the 2nd Number:");
            }
            else if (i == 2)
            {
                Console.WriteLine("Enter the 3rd Number:");
            }
            else
                Console.WriteLine($"Enter the {i + 1}th number:");
            num[i] = Convert.ToInt32(Console.ReadLine());
            }
    return num;
}

// Write a C# Sharp program to accept two integers and check whether they are equal or not.
void checkEqual()
{
    int[] num = takeInput(2);
    if (num[0] == num[1])
    {
        Console.WriteLine("The two numbers are equal");
    }
    else
    {
        Console.WriteLine("The two numbers are not equal");
    }
}

// Write a C# Sharp program to check whether a given number is positive or negative.
void checkPositive()
{
    int[] num = takeInput(1);
    if (num[0] > 0)
    {
        Console.WriteLine("The number is positive");
    }
    else
    {
        Console.WriteLine("The number is negative");
    }
}

// Write a C# Sharp program to find out whether a given year is a leap year or not.
void checkLeapYear()
{
    int[] num = takeInput(1);
    if (num[0]%4 == 0)
    {
        Console.WriteLine("The year is a leap year");
    }
    else
        Console.WriteLine("The year is not a leap year");
}

// Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
void checkEligible()
{
    int[] num = takeInput(1);
    if (num[0] >= 18)
    {
        Console.WriteLine("The candidate is eligible for voting");
    }
    else
        Console.WriteLine("The candidate is not eligible for voting");
}

// Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
void checkValue()
{
    int[] num = takeInput(1);
    if (num[0] > 0)
    {
        Console.WriteLine("The value of n is 1");
    }
    else if (num[0] == 0)
    {
        Console.WriteLine("The value of n is 0");
    }
    else
        Console.WriteLine("The value of n is -1");
}

// Write a program in C# Sharp to display the first 10 natural numbers.
void displayNatural()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }
}

// Write a C# Sharp program to find the sum of the first 10 natural numbers.
void sumof10()
{
    int sum = 0;
    for (int i = 1; i <= 10; i++)
    {
        sum += i;
    }
    Console.WriteLine(sum);
}

// Write a C# Sharp program that displays the sum of n natural numbers.
void sumofN()
{
    int[] num = takeInput(1);
    int sum = 0;
    for (int i = 1; i <= num[0]; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Sum of first {num[0]} natural numbers is {sum}");
}

// Write a C# Sharp program to read 10 numbers and find their average and sum.
void Averageof10()
{
    int[] num = takeInput(10);
    int sum = 0;
    for (int i = 0; i < 10; i++)
    {
        sum += num[i];
    }
    int avg = sum / 10;
    Console.WriteLine($"The sum of the numbers is {sum} and the average is {avg}");
}

// Write a C# Sharp program to display the cube of an integer up to given number.
void cubes()
{
    int[] num = takeInput(1);
    for (int i = 1; i <= num[0]; i++)
    {
        Console.WriteLine($"Number is {i} and cube of {i} is {i * i * i}");
    }
}

// Write a program in C# Sharp to display the multiplication table of a given integer.
void displayTable()
{
    int[] num = takeInput(1);
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{num[0]} * {i} = {num[0] * i}");
    }
}

// Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
// Multiplication table from 1 to 8
// 1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
// ...
// 1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80
void displayTableVertically()
{
    int[] num = takeInput(1);
    int n = num[0];
    for (int i = 1; i <= 10; i++)
    {
        for( int j = 1; j <= n; j++)
        {
            Console.Write($"{i} x {j} = {i * j} ");
        }
        Console.WriteLine();
    }
}

// Write a C# Sharp program to display the n terms of odd natural numbers and their sums.
void sumOdd()
{
    int[] num = takeInput(1);
    int sum = 0;
    for (int i = 1; i <= num[0]; i++)
    {
        Console.WriteLine($"{2 * i - 1}");
        sum += 2 * i - 1;
    }
    Console.WriteLine($"The sum of the numbers is {sum}");
}

// Write a program in C# Sharp to display a right angle triangle with an asterisk.
void starpattern()
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

// Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
void numberpattern()
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write($"{j + 1} ");
        }
        Console.WriteLine();
    }
}
// Write a program in C# Sharp to make such a pattern like a right angle triangle with a number which repeats a number in a row.
void numberpatternrepeat()
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write($"{i + 1} ");
        }
        Console.WriteLine();
    }
}

// Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1.
void numberpatternincrease()
{
    int val = 0;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write($"{++val} ");
        }
        Console.WriteLine();
    }
}

// Write a C# Sharp program to calculate the factorial of a given number.
void factorial()
{
    int[] num = takeInput(1);
    int fact = 1;
    for (int i = 1; i <= num[0]; i++)
    {
        fact *= i;
    }
    Console.WriteLine($"The factorial of {num[0]} is {fact}");
}

// Write a program in C# Sharp to display the n terms of even natural number and their sum.
void sumEven()
{
    int[] num = takeInput(1);
    int sum = 0;
    Console.WriteLine("The even numbers are :");
    for (int i = 1; i <= num[0]; i++)
    {
        Console.Write($"{2 * i}");
        sum += 2 * i;
    }
    Console.WriteLine($"The sum of the numbers is {sum}");
}

Console.WriteLine("To call the functions, type the number mentioned beside the function name");
Console.WriteLine("1. Check if 2 numbers are equal");
Console.WriteLine("2. Check if a number is positive or negative");
Console.WriteLine("3. Check the year is leap year or not");
Console.WriteLine("4. Check if the candidate is eligible to vote");
Console.WriteLine("5. Read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.");
Console.WriteLine("6. Display the first 10 natural numbers.");
Console.WriteLine("7. Calculate the sum of first 10 natural numbers.");
Console.WriteLine("8. Calculate the sum of first N natural numbers.");
Console.WriteLine("9. Read 10 numbers and find their average and sum.");
Console.WriteLine("10. Display the cube of an integer up to given number.");
Console.WriteLine("11. Display the multiplication table of a given integer.");
Console.WriteLine("12. Display the multiplication table vertically from 1 to n.");
Console.WriteLine("13. Display the n terms of odd natural numbers and their sums.");
Console.WriteLine("14. Display a right angle triangle with an asterisk.");
Console.WriteLine("15. Display a pattern like a right angle triangle with a number.");
Console.WriteLine("16. Display a pattern like a right angle triangle with a number which repeats a number in a row.");
Console.WriteLine("17. Make such a pattern like a right angle triangle with the number increased by 1.");
Console.WriteLine("18. Calculate the factorial of a given number.");
Console.WriteLine("19. Display the n terms of even natural number and their sum.");
Console.WriteLine("20. Exit");

while (true)
{
    Console.WriteLine("Enter the number of the function you want to call");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            checkEqual();
            break;
        case 2:
            checkPositive();
            break;
        case 3:
            checkLeapYear();
            break;
        case 4:
            checkEligible();
            break;
        case 5:
            checkValue();
            break;
        case 6:
            displayNatural();
            break;
        case 7:
            sumof10();
            break;
        case 8:
            sumofN();
            break;
        case 9:
            Averageof10();
            break;
        case 10:
            cubes();
            break;
        case 11:
            displayTable();
            break;
        case 12:
            displayTableVertically();
            break;
        case 13:
            sumOdd();
            break;
        case 14:
            starpattern();
            break;
        case 15:
            numberpattern();
            break;
        case 16:
            numberpatternrepeat();
            break;
        case 17:
            numberpatternincrease();
            break;
        case 18:
            factorial();
            break;
        case 19:
            sumEven();
            break;
        case 20:
            return;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}
