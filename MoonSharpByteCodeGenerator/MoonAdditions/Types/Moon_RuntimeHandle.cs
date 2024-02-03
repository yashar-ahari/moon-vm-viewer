using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net2MoonWorkBench.MoonAdditions.Types
{
    [MoonSharpUserData]
    internal class Moon_RuntimeHandle
    {


        public enum TokenType
        {
            Field,
            Method,
            Type
        }


        [MoonSharpHidden]
        public string token;

        [MoonSharpHidden]
        public TokenType type;

        [MoonSharpHidden]
        public byte[] initialData;


        [MoonSharpHidden]
        public Moon_RuntimeHandle(string token) 
        {
            this.token = token;
            string[] splits = token.Split('%');
            if(splits.Length > 0 && splits[0] == "t")
            {
                type = (TokenType)int.Parse(splits[1]);
                initialData = Convert.FromBase64String(splits[2]);
            }
        }

        public static Moon_RuntimeHandle LdToken(string spec)
        {
            return new Moon_RuntimeHandle(spec);
        }






    }
}
