﻿using System;
namespace Linecomp
{
    public class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("... Welcome to Line Comparison Computation ... ");

            checkequlityline Linecom = new checkequlityline();
            Linecom.length_line();
            Linecom.Comparelines();
            Console.ReadKey();

        }
    }
}