// See https://aka.ms/new-console-template for more information
using System;

int[] array1 = { 64, 34, 25, 12, 22, 11, 90 };
// Insertion Sort
Homework.Sorts.InsertionSort.InsertionSortRecursive(array1);
Console.WriteLine("Array after Insertion Sort");
foreach (var item in array1)
{
    Console.Write(item+", ");
}
Console.WriteLine("\n");

int[] array2 = { 15, 87, 25, 99, 82, 105, 11, 3, 7 };
//SelectionSort
Homework.Sorts.SelectionSort.SelectionSortRecursive(array2);
Console.WriteLine("Array after Selection Sort");
foreach (var item in array2)
{
    Console.Write(item + ", ");
}


