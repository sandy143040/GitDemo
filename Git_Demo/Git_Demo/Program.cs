﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GitDemoClass gitDemoClass = new GitDemoClass();
            gitDemoClass.Demo();
            gitDemoClass.DemoUC2();
            Console.ReadLine();
        }
    }
}
