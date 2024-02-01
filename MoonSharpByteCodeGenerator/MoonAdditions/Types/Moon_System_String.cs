using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net2MoonWorkBench.MoonAdditions.Types
{
    [MoonSharpUserData]
    internal static class Moon_System_String
    {


        public static string Concat(string a, string b)
        {
            return string.Concat(a, b);
        }


    }
}
