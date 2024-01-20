using MoonSharp.Interpreter;

namespace MoonSharpByteCodeGenerator.CustomUserData
{
    [MoonSharpUserData]
    public class HandleHolder
    {
        [MoonSharpHidden]
        public HandleHolder(object handle) 
        {
            this.Handle = handle;
        }

        [MoonSharpHidden]
        internal object Handle;
    }
}
