// See https://aka.ms/new-console-template for more information
using Codility_MissingInteger;

Console.WriteLine("Hello, World!");

int[] array =  new int[] { 1, 2, 3, 5, 8, 6 };

var result = Solution.RetrieveMinMissingNumberFromArray(array);

Console.WriteLine($"Missing and smallest number: {result}");