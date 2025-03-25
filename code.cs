using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;


class Program
{
    private static long _x;
    private static int _n;

    static long X
    {
        get { return _x; }
        set { _x = value; }
    }

    static int N
    {
        get { return _n; }
        set { _n = value; }
    }

    static long Power(long x, int n)
    {
        if (n == 0)
        {
            return 1;
        }

        if ((n & 1) == 0)
        {
            var p = Power(x, n >> 1);
            return p * p;
        }
        else
        {
            return x * Power(x, n - 1);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Num x = ");
       var X = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Num x is accepted");

        Console.Write("Num N =  ");
        var N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Num N is accepted");

        long result = Power(X, N);
        Console.WriteLine($"Результат: {result}");
    }
}
