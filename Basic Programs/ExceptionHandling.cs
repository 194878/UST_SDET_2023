﻿using Basic_Programs.Exceptionmess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ExceptionHandling
    {
        public ExceptionHandling(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Num1 { get; set; }
        public int Num2 { get; set; }


        public void Divide()
        {
            int[] num = { 10, 20, 30 };
            int res = Num1 / Num2;
            Console.WriteLine(res);
            for (int i = 0; i < 3; i++)
            {
                res = num[i] / Num2;
                Console.WriteLine(res);
            }


        }
        public void NumCheck()
        {
            MyExceptions myExceptions = new MyExceptions();
            if (Num1 >= 100)
            {
                Console.WriteLine("congrats");
            }
            else
            {
                throw new ArgumentException(MyExceptions.excmesslist["NotHunt"]);
            }
            if (Num2 < 100)
            {
                Console.WriteLine("congrats");
            }
            else {
                throw new ArgumentException(MyExceptions.excmesslist["NotHunt2"]);
            }
            void NumCheck1()
            {
                MyExceptions myExceptions = new MyExceptions();

                if (Num2 < 100)
                {
                    Console.WriteLine("congrats");
                }
                else
                {
                    throw new ArgumentException(MyExceptions.excmesslist["NotHunt2"]);
                }
            }

        }
    } }
