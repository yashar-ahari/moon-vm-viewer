using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net2MoonWorkBench.MoonAdditions.Types
{
    [MoonSharpUserData]
    internal static class Moon_System_Runtime_CompilerServices_RuntimeHelpers
    {

        public static void InitializeArray(DynValue array, Moon_RuntimeHandle handle)
        {
            if (array.Type == DataType.Table && array.Table != null)
            {
                if (handle.type == Moon_RuntimeHandle.TokenType.Field)
                {
                    int initialDataSize = handle.initialData.Length;

                    var array_internal = array.Table;

                    int arraySize = array_internal.Values.Count();

                    int initialDataRatio = initialDataSize / arraySize;


                    switch (initialDataRatio)
                    {
                        case 1:
                            for (int i = 0; i < arraySize; ++i)
                            {
                                array_internal[i] = handle.initialData[i];
                            }
                            break;
                        case 2:
                            for (int i = 0; i < arraySize; ++i)
                            {
                                array_internal[i] = BitConverter.ToInt16(handle.initialData, i * initialDataRatio);
                            }
                            break;
                        case 4:
                            for (int i = 0; i < arraySize; ++i)
                            {
                                array_internal[i] = BitConverter.ToInt32(handle.initialData, i * initialDataRatio);
                            }
                            break;
                        case 8:
                            for (int i = 0; i < arraySize; ++i)
                            {
                                array_internal[i] = BitConverter.ToInt64(handle.initialData, i * initialDataRatio);
                            }
                            break;
                    }
                }
            }
        }


    }
}
