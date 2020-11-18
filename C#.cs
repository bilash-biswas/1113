using System.IO;
using System;

class Program
{
    static void Main()
    {
    int a,b;
    bilash:
    var p = Console.ReadLine().Split();
    a = Int32.Parse(p[0]);
    b = Int32.Parse(p[1]);
    while(a!=b)
    {
     if(a>b)
    {
        Console.WriteLine("Decrescente");
    }
    if(a<b)
    {
        Console.WriteLine("Crescente");
    }
    goto bilash;
    }
    }
}
