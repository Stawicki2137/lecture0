﻿using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Types;

#nullable disable

public static class Program
{
    private static void Main()
    {
        ValueTypeAssignment();
        ReferenceTypeAssignment();
        PassingValueTypesAsParameter();
        PassingReferenceTypeAsParameter();
        NullValues();
    }
    private static void ValueTypeAssignment()
    {
        PrintCurrentMethodName();
        Point p1 = new Point(3, -5);
        Point p2 = p1;
        p2.X = 1; p2.Y = -1;
        Console.WriteLine($"P1: {p1.X}, {p1.Y}");
        Console.WriteLine($"P2: {p2.X}, {p2.Y}");
    }
    private static void ReferenceTypeAssignment()
    {
        PrintCurrentMethodName();
        Person alice = new Person("Alice", 16);
        Person bob = alice;
        bob.Name = "Bob";
        bob.Age = 18;
        Console.WriteLine($"Alice: {alice.Name}, {alice.Age}");
        Console.WriteLine($"Bob: {bob.Name}, {bob.Age}");


    }
    private static void NullValues()
    {
        PrintCurrentMethodName();
        Point p = new Point(3, -5);
       // p = null;
        Console.WriteLine($"P: {p.X}, {p.Y}");
        Person alice = new Person("John", 16);
        alice = null;


    }
    private static void PassingValueTypesAsParameter()
    {
        PrintCurrentMethodName();
        Point point = new Point(3, -5);
        ChangePoint(point);
        Console.WriteLine($"Point: {point.X},{point.Y}");

    }
    private static void ChangePoint(Point point)
    {
        point.X = 0; point.Y = 0;
    }
    private static void PassingReferenceTypeAsParameter()

    {
        PrintCurrentMethodName();
        Person alice = new Person("Alice", 28);
        ChangePersonName(alice);
        Console.WriteLine($"alice: {alice.Name}, Age: {alice.Age}");

    }

    //nie rozumiem tej funkcji do konca musze sie dopytac w przerwie wykladu
    private static void ChangePersonName(Person person)
    {
        person.Name = "daniel medżikul";
    }
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void PrintCurrentMethodName()
    {
        var st = new StackTrace();
        var sf = st.GetFrame(1);

        Console.WriteLine($"Method: {sf!.GetMethod()!.Name}");
    }



}