using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net2MoonWorkBench.MoonAdditions.Types
{
    [MoonSharpUserData]
    internal static class Moon_System_Int32
    {

        public static string ToString(DynValue dynValue)
        {
            return ((int)dynValue.Number).ToString();
        }

    }
}
