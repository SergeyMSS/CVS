using System;
using System.Collections;

public class ReverseComparer : IComparer
{
    //Вызовите CaseInsensitiveComparer.Compare с обратными параметрами.
    public int Compare(Object x, Object y)
    {
        return (new CaseInsensitiveComparer()).Compare(y, x);
    }
}

public class Example
{
    public static void Main()
    {
        // Create and initialize a new array. 
        String[] words = { "The", "QUICK", "BROWN", "FOX", "jumps", "over", "the", "lazy", "dog" };
        // Создание обратного компаратора.
        IComparer revComparer = new ReverseComparer();

        // Display the values of the array.
        Console.WriteLine("The original order of elements in the array:");
        DisplayValues(words);

        // Sort a section of the array using the default comparer.
        Array.Sort(words, 1, 3);
        Console.WriteLine("After sorting elements 1-3 by using the default comparer:");
        DisplayValues(words);

        // Sort a section of the array using the reverse case-insensitive comparer.
        Array.Sort(words, 1, 3, revComparer);
        Console.WriteLine("After sorting elements 1-3 by using the reverse case-insensitive comparer:");
        DisplayValues(words);

        // Sort the entire array using the default comparer.
        Array.Sort(words);
        Console.WriteLine("After sorting the entire array by using the default comparer:");
        DisplayValues(words);

        // Sort the entire array by using the reverse case-insensitive comparer.
        Array.Sort(words, revComparer);
        Console.WriteLine("After sorting the entire array using the reverse case-insensitive comparer:");
        DisplayValues(words);
    }

    public static void DisplayValues(String[] arr)
    {
        for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0);
              i++)
        {
            Console.WriteLine("   [{0}] : {1}", i, arr[i]);
        }
        Console.WriteLine();
    }
}