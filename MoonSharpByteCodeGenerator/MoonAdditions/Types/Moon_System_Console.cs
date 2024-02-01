using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net2MoonWorkBench.MoonAdditions.Types
{
    [MoonSharpUserData]
    internal static class Moon_System_Console
    {

        public static void WriteLine(DynValue message)
        {
            Console.WriteLine(message.ToPrintString());
        }


    }
}
