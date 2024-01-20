using MoonSharp.Interpreter;
using MoonSharpByteCodeGenerator.CustomUserData;

namespace MoonSharpByteCodeGenerator
{
    public partial class Form1 : Form
    {

        Script script = new Script();
        int offset = 0;
        ByteCodeTable? byteCode = null;

        Execution? execution;

        public static Script ScriptInstance { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void ReloadProcessor(string code = null, Stream dump = null)
        {
            if (code == null && dump == null) return;
            resultTextBox.Text = string.Empty;
            bool showBackByteCode = false;
            if (byteCode != null)
            {
                showBackByteCode = true;
            }



            try
            {

                script = new Script();
                ScriptInstance = script;
                UserData.RegisterAssembly();
                script.Globals["Vector3"] = typeof(MoonVector3);

                if(code != null)
                {
                    script.ProcessorDebugContext.LoadString(code);
                }
                if(dump != null)
                {
                    script.ProcessorDebugContext.LoadDump(dump);
                }

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

        private void btnGen_Click(object sender, EventArgs e)
        {
            ReloadProcessor(luaTextBox.Text);
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
            if (execution != null)
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

        private void loadDumpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                if (fileInfo.Exists)
                {
                    ReloadProcessor(dump:fileInfo.OpenRead());
                }
            }
        }
    }
}