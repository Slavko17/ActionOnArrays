using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {   
        Arr.Array();
    }
}
public class Arr
{
    public static void Array()
    {
        Console.Write("The number of elements in the array: ");
        sbyte numElement = Convert.ToSByte(Console.ReadLine());
        double[] arr = new double[numElement];
        for (sbyte Element = 0; Element < arr.Length; Element++)
        {
                Console.Write("Enter element: ");
            arr[Element] = Convert.ToDouble(Console.ReadLine());
        }
        
        foreach (double x in arr) Console.Write(x + "\t");
     
        Act.SmallestIndex(arr);
        Act.BetweenNegative(arr);
        Act.FirstModule1(arr);
    }
}
public class Act
{
    public static void SmallestIndex(double[] arr)
    {
        int a = Array.FindIndex(arr, i => i == arr.Min());
        Console.WriteLine("\nIndex of the smallest value: " + a);
    }
    public static void BetweenNegative(double[] arr)
    {
        double sum = 0;
        int First = Array.FindIndex(arr, i => i < 0);
        int Last = Array.FindIndex(arr, First + 1, i => i < 0);
       
        for (int i = First + 1; i < Last; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("\nThe sum between negative numbers: " + sum);
    }
    public static void FirstModule1(double[] arr)
    {
        Console.WriteLine("\nSorted array with module 1:\n");
        double[] a = Array.FindAll(arr, i => i >= -1 && i <= 1);
        double[] b = Array.FindAll(arr, i => i < -1 || i > 1);
        
        double[] c = a.Take(a.Length).Concat(b.Take(b.Length)).ToArray();        
        foreach (double i in c) Console.Write(i + "\t");
    }
}