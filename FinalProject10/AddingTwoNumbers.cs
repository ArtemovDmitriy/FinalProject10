﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject10
{
    internal class AddingTwoNumbers : IAddition 
    {
        public long Sum(long Value1, long Value2) 
        {
            return checked (Value1 + Value2);
        }

        public void ShowResult(long Value1, long Value2, long result)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Value1} + {Value2} = {result}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
