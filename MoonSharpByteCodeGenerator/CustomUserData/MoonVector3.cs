using MoonSharp.Interpreter;
using System.Numerics;

namespace MoonSharpByteCodeGenerator.CustomUserData
{
    [MoonSharpUserData]
    internal class MoonVector3
    {
        public float x { get; set; }

        public float y { get; set; }

        public float z { get; set; }

        [MoonSharpHidden]
        public MoonVector3()
        {

        }


        [MoonSharpUserDataMetamethod("__call")]
        public static MoonVector3 New()
        {
            return new MoonVector3() { x = 0, y = 0, z = 0 };
        }

        [MoonSharpUserDataMetamethod("__call")]
        public static MoonVector3 New(float x, float y, float z)
        {
            return new MoonVector3 { x = x, y = y, z = z };
        }


        public MoonVector3 Normal()
        {
            float length = MathF.Sqrt(x*x + y*y + z*z);

            if(length == 0)
            {
                return New();
            }
            return new MoonVector3()
            {
                x = x / length,
                y = y / length,
                z = z / length
            };
        }


        public static DynValue CTOR()
        {
            return CreateHandle(new Vector3());
        }

        public static DynValue CTOR(float x, float y, float z)
        {
            return CreateHandle(new Vector3(x, y, z));
        }

        public static float Field_X(DynValue obj)
        {
            if(TryGetHandle<Vector3>(obj, out Vector3 value))
            {
                return value.X;
            }
            throw new Exception();
        }
        
        public static float Field_Y(DynValue obj)
        {
            if(TryGetHandle<Vector3>(obj, out Vector3 value))
            {
                return value.Y;
            }
            throw new Exception();
        }
        
        public static float Field_Z(DynValue obj)
        {
            if(TryGetHandle<Vector3>(obj, out Vector3 value))
            {
                return value.Z;
            }
            throw new Exception();
        }



        private const string CLR_HANDLE_NAME = "!clr_handle";
        private const string CRL_HANDLE_TYPE_VER = "!clr_handle_type";

        private static T GetHandle<T>(Table obj)
        {
            return (T)obj[CLR_HANDLE_NAME];
        }

        private static bool TryGetHandle<T>(DynValue obj, out T handle)
        {
            handle = default;
            if (obj == null) return false;
            if (obj.Type == DataType.Table)
            {
                var table = obj.Table;
                var handleContainer = table[CLR_HANDLE_NAME];
                if (handleContainer == null) return false;
                if(handleContainer is HandleHolder hh)
                {
                    handle = (T)hh.Handle;
                    return true;
                }
            }
            return false;
        }

        private static DynValue CreateHandle(object obj) 
        {
            var value = DynValue.NewTable(Form1.ScriptInstance);
            value.Table[CLR_HANDLE_NAME] = DynValue.FromObject(Form1.ScriptInstance, new HandleHolder(obj));
            return value;
        }




    }
}
