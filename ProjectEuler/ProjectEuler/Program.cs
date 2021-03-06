﻿using System;
using System.Collections.Generic;
using System.Configuration;
using ProjectEuler.Helpers;
using ProjectEuler.Interfaces;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var tests = new List<IRunEuler>();

            if (ConfigurationManager.AppSettings["Problem001"].ParseBoolValue())
                tests.Add(new Problem001() as IRunEuler);
            if (ConfigurationManager.AppSettings["Problem002"].ParseBoolValue())
                tests.Add(new Problem002() as IRunEuler);

            //Check for Problems to run and display each's answer
            if (tests != null && tests.Count > 0)
            {
                foreach (var test in tests)
                {
                    test.Execute();
                }
            }

            Console.ReadLine();
        }
    }
}
