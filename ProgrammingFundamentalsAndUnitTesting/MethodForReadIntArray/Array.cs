// File: ArrayHelper.cs
using System;
using System.Linq;

public static class ArrayHelper  // Make sure this is a static class
{
    public static int[] ReadIntArray()  // This is your helper method
    {
        return Console.ReadLine()
            .Split()              // Split the input into separate strings
            .Select(int.Parse)    // Convert each string into an integer
            .ToArray();           // Convert the collection into an array
    }
}