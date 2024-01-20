using MoonSharp.Interpreter;
using MoonSharp.Interpreter.DataStructs;
using MoonSharp.Interpreter.Execution.VM;
using System.Diagnostics;

namespace MoonSharpByteCodeGenerator.Moon.MoonSharp.MoonSharp.Interpreter.Execution.VM
{
    public class ProcessorDebugContext
    {
        public FastStack<DynValue>? v_Stack;
        public FastStack<CallStackItem>? e_Stack;
        public int currentInstruction;
        public CoroutineState state;
        public List<Instruction>? ByteCode;

        DynValue? entryPoint;
        Script script;
        bool complete = false;

        public event Action OnProcessorExecuteInstruction;

        internal ProcessorDebugContext(Script script) 
        {
            this.script = script;
        }

        public void LoadString(string code)
        {
            DynValue load_ret = script.LoadString(code);
            entryPoint = script.CreateCoroutine(load_ret);
            entryPoint.Coroutine.SetDebugProcessorReferences(this);
            entryPoint.Coroutine.AutoYieldCounter = 1; // run single instruction at a time.
        }

        public void LoadDump(Stream stream)
        {
            DynValue load_ret = script.LoadStream(stream);
            entryPoint = script.CreateCoroutine(load_ret);
            entryPoint.Coroutine.SetDebugProcessorReferences(this);
            entryPoint.Coroutine.AutoYieldCounter = 1; // run single instruction at a time.
        }

        public void NextStep()
        {
            if(entryPoint != null && !complete)
            {
                var result = entryPoint.Coroutine.Resume();
                if(result.Type != DataType.YieldRequest)
                {
                    complete = true;
                }
            }
        }

        internal void OnProcessorRun()
        {
            try
            {
                OnProcessorExecuteInstruction?.Invoke();
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }



    }
}
