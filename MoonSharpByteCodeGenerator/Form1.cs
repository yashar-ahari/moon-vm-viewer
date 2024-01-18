using MoonSharp.Interpreter;

namespace MoonSharpByteCodeGenerator
{
    public partial class Form1 : Form
    {

        Script script = new Script();
        int offset = 0;
        ByteCodeTable? byteCode = null;

        Execution? execution;

        public Form1()
        {
            InitializeComponent();
        }



        private void btnGen_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Empty;
            bool showBackByteCode = false;
            if (byteCode != null)
            {
                showBackByteCode = true;
            }



            try
            {

                script = new Script();

                script.ProcessorDebugContext.LoadString(luaTextBox.Text);

                resultTextBox.Text = script.DumpByteCode(ref offset, true);

                if (showBackByteCode)
                {
                    if (byteCode != null && script != null && script.Instructions != null)
                    {
                        byteCode.ResetInstructions(script, offset);
                    }
                }

            }
            catch (Exception ex)
            {
                resultTextBox.Text = ex.Message;
                resultTextBox.SelectAll();
                resultTextBox.SelectionColor = Color.DarkRed;
            }

        }

        private void showByteTable_Click(object sender, EventArgs e)
        {
            ShowByteCodeTable();
        }

        private void ShowByteCodeTable()
        {
            if (script.Instructions != null)
            {
                byteCode = new ByteCodeTable(script, offset);
                byteCode.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(execution != null)
            {
                execution.ReloadScript(script);
                Show();
            }
            else
            {
                execution = new Execution(script);
                execution.Show();
            }
        }
    }
}