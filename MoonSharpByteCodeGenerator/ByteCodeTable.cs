using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Execution.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonSharpByteCodeGenerator
{
    public partial class ByteCodeTable : Form
    {
        Script script;
        List<Instruction>? instructions;
        int offset = 0;
        public ByteCodeTable(Script script, int offset)
        {
            this.script = script;
            this.instructions = script.Instructions;
            this.offset = offset;
            InitializeComponent();
        }

        private void ByteCodeTable_Load(object sender, EventArgs e)
        {
            ResetInstructions(script, offset);
        }

        public void ResetInstructions(Script script, int offset) 
        {
            if(this.script != null)
            {
                this.script.ProcessorDebugContext.OnProcessorExecuteInstruction -= ProcessorDebugContext_OnProcessorExecuteInstruction;
            }
            this.script = script;

            dataGridView1.Rows.Clear();

            this.instructions = script.Instructions;
            script.ProcessorDebugContext.OnProcessorExecuteInstruction += ProcessorDebugContext_OnProcessorExecuteInstruction;
            this.offset = offset;
            int count = instructions.Count;
            for (int i = offset; i < count; i++)
            {
                var code = instructions[i];

                string symbols = string.Empty;
                if (code.SymbolList != null && code.SymbolList.Length > 0)
                {
                    foreach (var symbol in code.SymbolList)
                    {
                        symbols += $"{symbol}; ";
                    }
                }

                dataGridView1.Rows.Add(i.ToString("D8"),
                    code.OpCode.ToString(),
                    code.Name,
                    code.NumVal,
                    code.NumVal2,
                    code.Value,
                    code.Symbol,
                    symbols);
            }
        }

        private void ProcessorDebugContext_OnProcessorExecuteInstruction()
        {
            var dbg = script.ProcessorDebugContext;
            dataGridView1.ClearSelection();
            dataGridView1.Rows[dbg.currentInstruction - offset].Selected = true;
        }
    }
}
