using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net2MoonWorkBench.MoonAdditions.Types
{
    [MoonSharpUserData]
    internal static class Moon_System_Object
    {
        public static void ctor(Table table)
        {
            if(table != null)
            {
                // TODO add other
            }
        }

        public static string ToString(DynValue value)
        {
            return value.ToPrintString();
        }






    }
}
