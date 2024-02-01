using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Interop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoonSharpByteCodeGenerator.CustomUserData
{
    internal class SPD
    {
        public static void RegisterType(Type type, Table table)
        {
            if (type != null)
            {
                string typeFullName = type.FullName;
                int typeCode = typeFullName.GetHashCode();

                Debug.WriteLine($"Register {typeFullName}");

                foreach(var method in  type.GetMethods())
                {
                    RegisterMethod(method, typeFullName, table);
                }
            }
        }


        private static void RegisterMethod(MethodInfo method, string callingTypeName, Table table) 
        {

            string param_s = string.Empty;
            bool a = false;
            foreach(var param in method.GetParameters())
            {
                param_s = $"{param.ParameterType.FullName},";
                a = true;
            }
            if (a)
            {
                param_s = param_s.Remove(param_s.Length - 1);
            }
            string fullname = $"{method.ReturnType.FullName} {callingTypeName}::{method.Name}({param_s})";

            int code = fullname.GetHashCode();

            string subName = $"il{code.ToString("X")}";
            try
            {
                //table[subName] = Method
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            Debug.WriteLine($"{subName} -> {fullname}");
        }
    }
}
