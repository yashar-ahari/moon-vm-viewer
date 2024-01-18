namespace MoonSharpByteCodeGenerator
{
    partial class ByteCodeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ByteCodeTable));
            dataGridView1 = new DataGridView();
            c_offset = new DataGridViewTextBoxColumn();
            c_OpCode = new DataGridViewTextBoxColumn();
            c_Name = new DataGridViewTextBoxColumn();
            c_NumVal1 = new DataGridViewTextBoxColumn();
            c_numVal2 = new DataGridViewTextBoxColumn();
            c_value = new DataGridViewTextBoxColumn();
            c_symbols = new DataGridViewTextBoxColumn();
            c_SymbolList = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { c_offset, c_OpCode, c_Name, c_NumVal1, c_numVal2, c_value, c_symbols, c_SymbolList });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1068, 956);
            dataGridView1.TabIndex = 0;
            // 
            // c_offset
            // 
            c_offset.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            c_offset.HeaderText = "Offset";
            c_offset.MinimumWidth = 100;
            c_offset.Name = "c_offset";
            c_offset.ReadOnly = true;
            c_offset.Resizable = DataGridViewTriState.False;
            c_offset.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // c_OpCode
            // 
            c_OpCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_OpCode.HeaderText = "OpCode";
            c_OpCode.MinimumWidth = 8;
            c_OpCode.Name = "c_OpCode";
            c_OpCode.ReadOnly = true;
            c_OpCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // c_Name
            // 
            c_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_Name.HeaderText = "Name";
            c_Name.MinimumWidth = 8;
            c_Name.Name = "c_Name";
            c_Name.ReadOnly = true;
            c_Name.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // c_NumVal1
            // 
            c_NumVal1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_NumVal1.HeaderText = "NumVal1";
            c_NumVal1.MinimumWidth = 8;
            c_NumVal1.Name = "c_NumVal1";
            c_NumVal1.ReadOnly = true;
            c_NumVal1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // c_numVal2
            // 
            c_numVal2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_numVal2.HeaderText = "NumVal2";
            c_numVal2.MinimumWidth = 8;
            c_numVal2.Name = "c_numVal2";
            c_numVal2.ReadOnly = true;
            c_numVal2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // c_value
            // 
            c_value.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_value.HeaderText = "Value";
            c_value.MinimumWidth = 8;
            c_value.Name = "c_value";
            c_value.ReadOnly = true;
            c_value.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // c_symbols
            // 
            c_symbols.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_symbols.HeaderText = "Symbol";
            c_symbols.MinimumWidth = 8;
            c_symbols.Name = "c_symbols";
            c_symbols.ReadOnly = true;
            c_symbols.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // c_SymbolList
            // 
            c_SymbolList.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_SymbolList.HeaderText = "Symbols";
            c_SymbolList.MinimumWidth = 8;
            c_SymbolList.Name = "c_SymbolList";
            c_SymbolList.ReadOnly = true;
            c_SymbolList.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ByteCodeTable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 956);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ByteCodeTable";
            Text = "ByteCodeTable";
            Load += ByteCodeTable_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn c_offset;
        private DataGridViewTextBoxColumn c_OpCode;
        private DataGridViewTextBoxColumn c_Name;
        private DataGridViewTextBoxColumn c_NumVal1;
        private DataGridViewTextBoxColumn c_numVal2;
        private DataGridViewTextBoxColumn c_value;
        private DataGridViewTextBoxColumn c_symbols;
        private DataGridViewTextBoxColumn c_SymbolList;
    }
}