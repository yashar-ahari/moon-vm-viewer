using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter.Execution.VM
{
	public class CallStackItem
	{
		public int Debug_EntryPoint;
		public SymbolRef[] Debug_Symbols;

		public SourceRef CallingSourceRef;

		public CallbackFunction ClrFunction;
		public CallbackFunction Continuation;
		public CallbackFunction ErrorHandler;
		public DynValue ErrorHandlerBeforeUnwind;

		public int BasePointer;
		public int ReturnAddress;
		public DynValue[] LocalScope;
		public ClosureContext ClosureScope;

		public CallStackItemFlags Flags;

        public override string ToString()
        {
			string s = string.Empty;

			if (LocalScope != null)
			{
				foreach (var item in LocalScope)
				{
					s += item?.ToString() + " ";
				}
			}
			return s;
        }
    }

}
