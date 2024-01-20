namespace MoonSharpByteCodeGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button1 = new Button();
            showByteTable = new Button();
            btnGen = new Button();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            luaTextBox = new RichTextBox();
            groupBox2 = new GroupBox();
            resultTextBox = new RichTextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadDumpToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(showByteTable);
            panel1.Controls.Add(btnGen);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 56);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(276, 8);
            button1.Name = "button1";
            button1.Size = new Size(248, 40);
            button1.TabIndex = 2;
            button1.Text = "Exec";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // showByteTable
            // 
            showByteTable.Location = new Point(544, 8);
            showByteTable.Name = "showByteTable";
            showByteTable.Size = new Size(248, 40);
            showByteTable.TabIndex = 1;
            showByteTable.Text = "BTable";
            showByteTable.UseVisualStyleBackColor = true;
            showByteTable.Click += showByteTable_Click;
            // 
            // btnGen
            // 
            btnGen.Location = new Point(8, 8);
            btnGen.Name = "btnGen";
            btnGen.Size = new Size(248, 40);
            btnGen.TabIndex = 0;
            btnGen.Text = "Generate";
            btnGen.UseVisualStyleBackColor = true;
            btnGen.Click += btnGen_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 89);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(800, 677);
            splitContainer1.SplitterDistance = 253;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(luaTextBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 253);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lua Code";
            // 
            // luaTextBox
            // 
            luaTextBox.Dock = DockStyle.Fill;
            luaTextBox.Location = new Point(3, 27);
            luaTextBox.Name = "luaTextBox";
            luaTextBox.Size = new Size(794, 223);
            luaTextBox.TabIndex = 0;
            luaTextBox.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(resultTextBox);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 420);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Byte Code";
            // 
            // resultTextBox
            // 
            resultTextBox.Dock = DockStyle.Fill;
            resultTextBox.Location = new Point(3, 27);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(794, 390);
            resultTextBox.TabIndex = 0;
            resultTextBox.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadDumpToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadDumpToolStripMenuItem
            // 
            loadDumpToolStripMenuItem.Name = "loadDumpToolStripMenuItem";
            loadDumpToolStripMenuItem.Size = new Size(270, 34);
            loadDumpToolStripMenuItem.Text = "Load Dump";
            loadDumpToolStripMenuItem.Click += loadDumpToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 766);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Lua ByteCode";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnGen;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private RichTextBox luaTextBox;
        private GroupBox groupBox2;
        private RichTextBox resultTextBox;
        private Button showByteTable;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadDumpToolStripMenuItem;
    }
}