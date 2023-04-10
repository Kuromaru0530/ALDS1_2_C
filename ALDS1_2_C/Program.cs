using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static int Value(string a)
    {
        int x = (int)Char.GetNumericValue(a[1]);
        return x;
    }
    public static string BubbleSort(string[] c)
    {
        for (int i = 0; i < c.Length; i++)
        {
            for (int j = c.Length - 1; j > i; j--)
            {
                if (Value(c[j]) < Value(c[j - 1]))
                {
                    string a = c[j];
                    c[j] = c[j - 1];
                    c[j - 1] = a;
                }
            }
        }
        string ans1 = string.Join(" ", c);
        return ans1;
    }
    public static string SelectionSort(string[]c)
    {
        for(int i = 0; i < c.Length; i++)
        {
            int minj = i;
            for(int j = i; j < c.Length; j++)
            {
                if(Value(c[j]) < Value(c[minj]))
                {
                    minj = j;
                }
            }
            string a = c[minj];
            c[minj] = c[i];
            c[i] = a;
        }
        string ans2 = string.Join(" ", c);
        return ans2;
    }
    public static bool IsStable(string a, string b)
    {
        if (object.ReferenceEquals(a, b)) return true;
        else
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (!a[i].Equals(b[i]))
                {
                    return false;
                }
            }
        }
        return true;
        
    }
    static void Main()
    {
        _ = int.Parse(Console.ReadLine());
        var sample1 = Console.ReadLine().Split(' ');
        var sample2 = new string [sample1.Length];
        
        Array.Copy(sample1, sample2, sample1.Length);

        var ans1 = BubbleSort(sample1);
        var ans2 = SelectionSort(sample2);

        if (IsStable(ans1, ans2) == true)
        {
            Console.WriteLine(ans1);
            Console.WriteLine("Stable");
            Console.WriteLine(ans2);
            Console.WriteLine("Stable");
        }
        else
        {
            Console.WriteLine(ans1);
            Console.WriteLine("Stable");
            Console.WriteLine(ans2);
            Console.WriteLine("Not stable");
        }
        
    }
}