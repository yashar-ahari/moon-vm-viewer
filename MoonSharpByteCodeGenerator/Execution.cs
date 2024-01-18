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
using System.Xml.Linq;

namespace MoonSharpByteCodeGenerator
{
    public partial class Execution : Form
    {

        private Script? script;

        public Execution(Script script)
        {
            InitializeComponent();
            InitScript(script);
        }

        private void InitScript(Script script)
        {
            if (this.script != null)
            {
                this.script.ProcessorDebugContext.OnProcessorExecuteInstruction -= ProcessorDebugContext_OnProcessorExecuteInstruction;
            }
            this.script = script;
            this.script.ProcessorDebugContext.OnProcessorExecuteInstruction += ProcessorDebugContext_OnProcessorExecuteInstruction;
            ProcessorDebugContext_OnProcessorExecuteInstruction();
        }

        public void ReloadScript(Script script)
        {
            InitScript(script);
        }

        private void ProcessorDebugContext_OnProcessorExecuteInstruction()
        {
            var debugContext = this.script.ProcessorDebugContext;
            this.NextInstructions.Rows.Clear();
            if (script.Instructions != null)
            {
                for (int i = debugContext.currentInstruction; i < debugContext.currentInstruction + 2; i++)
                {
                    var instruction = script.Instructions[i];


                    string symbolsList = string.Empty;
                    if (instruction.SymbolList != null)
                    {
                        foreach (var symbl in instruction.SymbolList)
                        {
                            symbolsList += symbl.ToString() + " ";
                        }
                    }
                    this.NextInstructions.Rows.Add(
                        debugContext.currentInstruction.ToString("D8"),
                        instruction.OpCode.ToString(),
                        instruction.NumVal.ToString(),
                        instruction.NumVal2.ToString(),
                        instruction.Name,
                        instruction.Value?.ToString(),
                        instruction.Symbol?.ToString(),
                        symbolsList
                        );
                }
            }

            if (debugContext.v_Stack != null)
            {
                Vstack.Items.Clear();
                for (int i = debugContext.v_Stack.Count - 1; i >= 0; --i)
                {
                    Vstack.Items.Add(debugContext.v_Stack[i]);
                }
            }
            if (debugContext.e_Stack != null)
            {
                e_StackTree.Nodes.Clear();
                for (int i = debugContext.e_Stack.Count - 1; i >= 0; --i)
                {
                    AddFrameToTree(debugContext.e_Stack[i]);
                }
            }
        }

        private void AddFrameToTree(CallStackItem stackItem)
        {
            TreeNode node = new TreeNode($"Stack Item {stackItem.Flags}, base {stackItem.BasePointer}, returns {stackItem.ReturnAddress}");
            if (stackItem.LocalScope != null)
            {
                foreach (var item in stackItem.LocalScope)
                {
                    if(item ==  null || item.Type == DataType.Nil)
                    {
                        node.Nodes.Add(new TreeNode("Nil"));
                    }
                    else if (item.Type == DataType.Table)
                    {

                        PushTable("Table", item, node);
                        //TreeNode treeNode = new TreeNode($"(Table)");
                        //foreach (var subitem in item.Table.Pairs)
                        //{
                        //    TreeNode tableItemNode = new TreeNode($"{subitem.Key} : {subitem.Value}");
                        //    treeNode.Nodes.Add(tableItemNode);
                        //}
                        //node.Nodes.Add(treeNode);
                    }
                    else
                    {
                        TreeNode childNode = new TreeNode(item.ToString());
                        node.Nodes.Add(childNode);
                    }

                }
            }

            e_StackTree.Nodes.Add(node);
        }

        void PushTable(string name, DynValue table, TreeNode root, int level = 0)
        {
            if(level > 10)
            {
                return;
            }
            TreeNode treeNode = new TreeNode($"{name} : (Table)");
            foreach (var subitem in table.Table.Pairs)
            {
                if (subitem.Value.Type == DataType.Table)
                {
                    PushTable(subitem.Key.String, subitem.Value, treeNode, level+1);
                }
                else
                {
                    TreeNode tableItemNode = new TreeNode($"{subitem.Key} : {subitem.Value}");
                    treeNode.Nodes.Add(tableItemNode);
                }
            }
            root.Nodes.Add(treeNode);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Execution_Load(object sender, EventArgs e)
        {

        }

        private void runNext_Click(object sender, EventArgs e)
        {
            if (script != null)
            {
                script.ProcessorDebugContext?.NextStep();
            }
        }
    }
}
