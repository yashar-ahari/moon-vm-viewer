namespace MoonSharpByteCodeGenerator
{
    partial class Execution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Execution));
            groupBox1 = new GroupBox();
            NextInstructions = new DataGridView();
            c_offset = new DataGridViewTextBoxColumn();
            c_opCode = new DataGridViewTextBoxColumn();
            c_NumVal = new DataGridViewTextBoxColumn();
            c_numVal2 = new DataGridViewTextBoxColumn();
            c_Name = new DataGridViewTextBoxColumn();
            c_Value = new DataGridViewTextBoxColumn();
            c_symbol = new DataGridViewTextBoxColumn();
            c_SymbolList = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            runNext = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            e_StackTree = new TreeView();
            vStackTree = new TreeView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NextInstructions).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NextInstructions);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1420, 152);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Next Instructions";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // NextInstructions
            // 
            NextInstructions.AllowUserToAddRows = false;
            NextInstructions.AllowUserToDeleteRows = false;
            NextInstructions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NextInstructions.Columns.AddRange(new DataGridViewColumn[] { c_offset, c_opCode, c_NumVal, c_numVal2, c_Name, c_Value, c_symbol, c_SymbolList });
            NextInstructions.Dock = DockStyle.Fill;
            NextInstructions.Location = new Point(3, 27);
            NextInstructions.MultiSelect = false;
            NextInstructions.Name = "NextInstructions";
            NextInstructions.ReadOnly = true;
            NextInstructions.RowHeadersWidth = 62;
            NextInstructions.RowTemplate.Height = 33;
            NextInstructions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NextInstructions.Size = new Size(1414, 122);
            NextInstructions.TabIndex = 0;
            NextInstructions.CellContentClick += dataGridView1_CellContentClick;
            // 
            // c_offset
            // 
            c_offset.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_offset.HeaderText = "Offset";
            c_offset.MinimumWidth = 8;
            c_offset.Name = "c_offset";
            c_offset.ReadOnly = true;
            // 
            // c_opCode
            // 
            c_opCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_opCode.HeaderText = "OpCode";
            c_opCode.MinimumWidth = 8;
            c_opCode.Name = "c_opCode";
            c_opCode.ReadOnly = true;
            // 
            // c_NumVal
            // 
            c_NumVal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_NumVal.HeaderText = "NumVal";
            c_NumVal.MinimumWidth = 8;
            c_NumVal.Name = "c_NumVal";
            c_NumVal.ReadOnly = true;
            // 
            // c_numVal2
            // 
            c_numVal2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_numVal2.HeaderText = "NumVal2";
            c_numVal2.MinimumWidth = 8;
            c_numVal2.Name = "c_numVal2";
            c_numVal2.ReadOnly = true;
            // 
            // c_Name
            // 
            c_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_Name.HeaderText = "Name";
            c_Name.MinimumWidth = 8;
            c_Name.Name = "c_Name";
            c_Name.ReadOnly = true;
            // 
            // c_Value
            // 
            c_Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_Value.HeaderText = "Value";
            c_Value.MinimumWidth = 8;
            c_Value.Name = "c_Value";
            c_Value.ReadOnly = true;
            // 
            // c_symbol
            // 
            c_symbol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_symbol.HeaderText = "Symbol";
            c_symbol.MinimumWidth = 8;
            c_symbol.Name = "c_symbol";
            c_symbol.ReadOnly = true;
            // 
            // c_SymbolList
            // 
            c_SymbolList.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_SymbolList.HeaderText = "SymbolList";
            c_SymbolList.MinimumWidth = 8;
            c_SymbolList.Name = "c_SymbolList";
            c_SymbolList.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(runNext);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1420, 64);
            panel2.TabIndex = 1;
            // 
            // runNext
            // 
            runNext.Anchor = AnchorStyles.Right;
            runNext.Location = new Point(1220, 8);
            runNext.Name = "runNext";
            runNext.Size = new Size(192, 48);
            runNext.TabIndex = 0;
            runNext.Text = "Step";
            runNext.UseVisualStyleBackColor = true;
            runNext.Click += runNext_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1420, 216);
            panel3.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(1420, 845);
            panel1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Size = new Size(1420, 845);
            splitContainer1.SplitterDistance = 698;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(vStackTree);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(698, 845);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "V Stack";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(e_StackTree);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(718, 845);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "E Stack";
            // 
            // e_StackTree
            // 
            e_StackTree.Dock = DockStyle.Fill;
            e_StackTree.Location = new Point(3, 27);
            e_StackTree.Name = "e_StackTree";
            e_StackTree.Size = new Size(712, 815);
            e_StackTree.TabIndex = 0;
            // 
            // vStackTree
            // 
            vStackTree.Dock = DockStyle.Fill;
            vStackTree.Location = new Point(3, 27);
            vStackTree.Name = "vStackTree";
            vStackTree.Size = new Size(692, 815);
            vStackTree.TabIndex = 0;
            // 
            // Execution
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 1061);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Execution";
            Text = "Execution";
            Load += Execution_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NextInstructions).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView NextInstructions;
        private DataGridViewTextBoxColumn c_offset;
        private DataGridViewTextBoxColumn c_opCode;
        private DataGridViewTextBoxColumn c_NumVal;
        private DataGridViewTextBoxColumn c_numVal2;
        private DataGridViewTextBoxColumn c_Name;
        private DataGridViewTextBoxColumn c_Value;
        private DataGridViewTextBoxColumn c_symbol;
        private DataGridViewTextBoxColumn c_SymbolList;
        private Panel panel2;
        private Button runNext;
        private Panel panel3;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TreeView e_StackTree;
        private TreeView vStackTree;
    }
}