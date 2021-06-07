using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionMultipleTrigger
{
    public class GreetingService
    {

        public static string Say(string name="")
        {
            var greeting = "Hello" + name; 
            Console.WriteLine("Hello !");

            return greeting; 
        }
    }
}
