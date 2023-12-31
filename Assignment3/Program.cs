﻿// write a program to check how many times 3 appears in a number
using System.CodeDom.Compiler;

void checkDigit()
{
    Console.WriteLine("Enter the number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    while (n > 0)
    {
        if (n % 10 == 3)
        {
            count++;
            n /= 10;
        }
        else
            n /= 10;

    }
    Console.WriteLine($"The number of times 3 appears in the number is {count}");
}

// write a program to check whether a number is a paindrome or not
void CheckPalindrome()
{
    Console.WriteLine("Enter the number: ");
    string n = Console.ReadLine();
    int len = n.Length;
    for (int i = 0; i <= len - 1; i++)
    {
        if (n[i] != n[len - i - 1])
        {
            Console.WriteLine("Not a palindrome");
            break;
        }
    }
    Console.WriteLine("Number is a palindrome");
}

// Write a method that should represent fibinacci series
void fibonacciSeries()
{
    int a = 0, b = 1;
    int c;
    Console.WriteLine("Enter the number of terms of the fibonacci series to display");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The terms of the fibonacci Series are:");
    Console.Write($"{a}, {b}");
    for (int i = 0; i < num - 2; i++)
    {
        c = b;
        b = a + b;
        a = c;
        Console.Write($", {b}");
    }
}

// Given two dates - first from the past and second as present date, write a method that returns numbers of days between these two dates.
int findDiff(DateTime d1, DateTime d2)
{
    int days = 0;
    int[] noofdaysinmonth = { 31,28,31,30,31,30,31,31,30,31,30,31};
    if(d1 <= d2)
    {
        if (d1.Year == d2.Year)
        {
            if ((d1.Month == d2.Month) && (d1.Day == d2.Day))
            {
                return 0;
            }
            if (d1.Month == d2.Month)
            {
                return d2.Day - d1.Day;
            }
            for (int i = d1.Month; i < d2.Month - 1; i++)
            {
                days += noofdaysinmonth[i];
            }
            days += noofdaysinmonth[d1.Month - 1] - d1.Day + d2.Day;
        }
        else
        {
            for (int i = d1.Month; i < d2.Month - 1; i++)
            {
                days += noofdaysinmonth[i];
                Console.WriteLine("Hi");
            }
            days += (d2.Year - d1.Year) * 365 + (d2.Year - d1.Year) / 4;
            if (d1.Month == d2.Month)
                days += d2.Day - d1.Day;
            else
            {
                days += noofdaysinmonth[d1.Month - 1] - d1.Day + d2.Day;
            }
        }
        
        return days;
    }
    else
        return findDiff(d2, d1);
}
int days(DateTime d)
{
    int days = 0;
    int[] noofdaysinmonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    days= d.Year*365;
    days += d.Year / 4 - d.Year / 400 + d.Year / 100;
    for (int i = 0; i < d.Month - 1; i++)
    {
        days += noofdaysinmonth[i];
    }

    if (d.Month == 2 && d.Day<29 )
    {
        days--;
    }
    if (d.Month == 1)
        days--;

    days += d.Day;
    return days;
}
void Difference()
{
    Console.WriteLine("Enter the first date:");
    DateTime dateTime1 = Convert.ToDateTime(Console.ReadLine());
    string date = dateTime1.ToString();
    Console.WriteLine("Enter the Second date:");
    DateTime dateTime2 = Convert.ToDateTime(Console.ReadLine());
    
    TimeSpan diff = dateTime1 - dateTime2;
    if (diff.Days<0)
    {
        diff = dateTime2 - dateTime1;
    }
    int noofdays=findDiff(dateTime1,dateTime2);
    int diffman = days(dateTime1) - days(dateTime2);
    if(diffman < 0)
    {
        diffman = -diffman;
    }
    Console.WriteLine($"The difference in between the dates is:{diff.Days}, {noofdays}, {diffman}");
}

Difference();
/*
 * Write a C# program to find the eligibility of admission for a professional course based on the following criteria: 
 * Marks in Maths >=65
 * Marks in Phy >=55
 * Marks in Chem>=50
 * Total in all three subject >=180 or Total in Math and Subjects >=140
*/

void CheckEligiblity()
{
    int Maths, Phy, Chem;
    Console.WriteLine("Enter the marks in Maths");
    Maths = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the marks in Phy");
    Phy = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the marks in Chem");
    Chem = Convert.ToInt32(Console.ReadLine());
    int Total = Maths + Phy + Chem;
    if ((Maths >= 65 && Phy >= 50 && Chem >= 50) || Total >= 180)
    {
        Console.WriteLine("The Student is Eligible");
    }
    else
        Console.WriteLine("Student is not eligible");
}

// Write a method that prints 10 by 10 multiplication table. Remember about readibility (spaces in the right place).
void MultiplicationTable()
{
    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            Console.Write($"{i * j} ");
            if (i * j < 10)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

