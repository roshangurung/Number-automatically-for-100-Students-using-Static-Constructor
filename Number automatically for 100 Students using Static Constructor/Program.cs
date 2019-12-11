using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace staticprog
{
    class sample////This C# program is used to generate register number automatically for 100 students using static constructor. The static constructor is used to initialize static fields of a class with specific values. Print the generated numbers of the students.///
    {
        int regnumber;
        static int nextnum;
        static sample()
        {
            nextnum = 1000;
        }
        sample()
        {
            regnumber = ++nextnum;
        }
        public static void Main(string[] args)
        {
            sample s = new sample();
            Console.WriteLine("#1 : {0}", s.regnumber);
            s = new sample();
            Console.WriteLine("#2 : {0}", s.regnumber);
            s = new sample();
            Console.WriteLine("#3 : {0}", s.regnumber);
            Console.ReadLine();
        }
    }
}
///Output:#1 : 1001
///#2 : 1002
///#3 : 1003