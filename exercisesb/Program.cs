using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace exercisesb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringUtility.StringMethods();

            string sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";

            string summary = StringUtility.SummariseText(sentence, 80);
            Console.WriteLine(summary);
            Console.WriteLine("");

            DateDemos.DateMethods();

            TimespanDemo.TimeMethods();

            ArraysDemo.ArrayMethods();

            ArraysDemo.ListMethods();

            StringbuilderDemo.StringBuilderMethods();

            //Exercise1.Exercise_1();
            //Exercise2.Exercise_2();
            //Exercise3.Exercise_3();
            //Exercise4.Exercise_4();
            //Exercise5.Exercise_5();
            //Exercise6.Exercise_6();
            //Exercise7.Exercise_7();
            //Exercise8.Exercise_8();
        }
    }
}
