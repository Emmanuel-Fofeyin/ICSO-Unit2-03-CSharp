// Created by: Emmanuel Fofeyin
// Created on: March 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        string streetNumber;
        int name;

        Console.WriteLine("This program gets a user's street number and name.");
        Console.WriteLine("");

        Console.Write("Enter street number: ");
        Console.Write("Enter street name: ");
        Console.Write("Your street adress is: ");
        streetNumber = Console.ReadLine();
        Console.Write("Enter your name: ");
        name = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Your info is: " + streetNumber + ", name " + name + ".");

        Console.WriteLine("\nDone.");
    }
}