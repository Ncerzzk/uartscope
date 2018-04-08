namespace Fly_up
{
    partial class Form_Edit_Command
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
            this.Table_Command = new System.Windows.Forms.DataGridView();
            this.Column_Com_Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Button_String = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_Add_Row = new System.Windows.Forms.Button();
            this.Button_Del_Row = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Command)).BeginInit();
            this.SuspendLayout();
            // 
            // Table_Command
            // 
            this.Table_Command.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Command.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Com_Command,
            this.Column_Button_String});
            this.Table_Command.Location = new System.Drawing.Point(15, 60);
            this.Table_Command.Name = "Table_Command";
            this.Table_Command.RowTemplate.Height = 27;
            this.Table_Command.Size = new System.Drawing.Size(397, 293);
            this.Table_Command.TabIndex = 1;
            // 
            // Column_Com_Command
            // 
            this.Column_Com_Command.HeaderText = "串口命令";
            this.Column_Com_Command.Name = "Column_Com_Command";
            this.Column_Com_Command.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Com_Command.Width = 150;
            // 
            // Column_Button_String
            // 
            this.Column_Button_String.HeaderText = "按钮文字";
            this.Column_Button_String.Name = "Column_Button_String";
            // 
            // Button_Add_Row
            // 
            this.Button_Add_Row.Location = new System.Drawing.Point(15, 22);
            this.Button_Add_Row.Name = "Button_Add_Row";
            this.Button_Add_Row.Size = new System.Drawing.Size(75, 32);
            this.Button_Add_Row.TabIndex = 2;
            this.Button_Add_Row.Text = "新增";
            this.Button_Add_Row.UseVisualStyleBackColor = true;
            this.Button_Add_Row.Click += new System.EventHandler(this.Button_Add_Row_Click);
            // 
            // Button_Del_Row
            // 
            this.Button_Del_Row.Location = new System.Drawing.Point(110, 22);
            this.Button_Del_Row.Name = "Button_Del_Row";
            this.Button_Del_Row.Size = new System.Drawing.Size(75, 32);
            this.Button_Del_Row.TabIndex = 3;
            this.Button_Del_Row.Text = "删除";
            this.Button_Del_Row.UseVisualStyleBackColor = true;
            this.Button_Del_Row.Click += new System.EventHandler(this.Button_Del_Row_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(337, 22);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(75, 32);
            this.Button_Save.TabIndex = 4;
            this.Button_Save.Text = "保存";
            this.Button_Save.UseVisualStyleBackColor = true;
            // 
            // Form_Edit_Command
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 445);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Del_Row);
            this.Controls.Add(this.Button_Add_Row);
            this.Controls.Add(this.Table_Command);
            this.Name = "Form_Edit_Command";
            this.Text = "Form_Edit_Command";
            ((System.ComponentModel.ISupportInitialize)(this.Table_Command)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Table_Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Com_Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Button_String;
        private System.Windows.Forms.Button Button_Add_Row;
        private System.Windows.Forms.Button Button_Del_Row;
        private System.Windows.Forms.Button Button_Save;
    }
}