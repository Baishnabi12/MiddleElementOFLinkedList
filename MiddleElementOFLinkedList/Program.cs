using System;
using System.Collections.Generic;
public class MiddleElement {
    static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        list.AddLast(4);
        list.AddLast(5);
        list.AddLast(6);
        int a = 0;
        a = list.Count / 2;
        Console.WriteLine(list.ElementAt<int>(a));
    }
}

