//Завдання 1 
//using System;
//using System.Linq;
//
//class Program
//{
//static void Main()
//{
//Console.Write("Enter the number of items in the array: ");
//int n = int.Parse(Console.ReadLine());
//
//int[] array = new int[n];
//
//Console.WriteLine("Enter the elements of the array:");
//for (int i = 0; i < n; i++)
//{
//Console.Write($"Element {i + 1}: ");
//array[i] = int.Parse(Console.ReadLine());
//        }
//
//int evenCount = array.Count(x => x % 2 == 0);
//int oddCount = array.Count(x => x % 2 != 0);
//int uniqueCount = array.Distinct().Count();
//
//Console.WriteLine($"\nNumber of paired elements: {evenCount}");
//Console.WriteLine($"Number of odd elements: {oddCount}");
//Console.WriteLine($"Number of unique elements: {uniqueCount}");
//    }
//}
//Завдання 2 
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of items in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nEnter the value of the parameter: ");
        int parameter = int.Parse(Console.ReadLine());

        int countLessThanParameter = array.Count(x => x < parameter);

        Console.WriteLine($"\nThe number of values in the array that are less than {parameter}: {countLessThanParameter}");
    }
}
