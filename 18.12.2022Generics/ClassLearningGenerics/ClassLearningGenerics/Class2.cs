﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLearningGenerics
{
    internal class Generics2<T>
    {
        public static void Run()
        {
            var f = new Generics2<int>();
            f.Re1t<int>(12);
        }
        public int Ret(int a)
        {
            return a + a;
        }

        public T Re1t<T>(T a)
        {
            if (a is int)
            {
                T b = (T)a;
                int c = (int)Convert.ChangeType(a, typeof(T));
                c++;
                T ret = (T)Convert.ChangeType(c, typeof(T));
                return ret;
            }
            if (a.GetType() == typeof(int))
            {

            }
            if (a.GetType() == typeof(string))
            {

            }
            a.ToString();
            return a;
        }
    }
}
