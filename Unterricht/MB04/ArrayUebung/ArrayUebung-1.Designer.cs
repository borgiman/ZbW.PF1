namespace MB04.ArrayUebung
{
    partial class ArrayUebung_1
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
            NumNumberToAdd = new NumericUpDown();
            CmdAdd = new Button();
            CmdPrint = new Button();
            CmdRemove = new Button();
            TxtShowNumbers = new TextBox();
            NumNumberToRemove = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumNumberToAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumNumberToRemove).BeginInit();
            SuspendLayout();
            // 
            // NumNumberToAdd
            // 
            NumNumberToAdd.Location = new Point(12, 12);
            NumNumberToAdd.Name = "NumNumberToAdd";
            NumNumberToAdd.Size = new Size(122, 23);
            NumNumberToAdd.TabIndex = 0;
            // 
            // CmdAdd
            // 
            CmdAdd.Location = new Point(12, 41);
            CmdAdd.Name = "CmdAdd";
            CmdAdd.Size = new Size(122, 23);
            CmdAdd.TabIndex = 1;
            CmdAdd.Text = "Hinzufügen";
            CmdAdd.UseVisualStyleBackColor = true;
            CmdAdd.Click += CmdAdd_Click;
            // 
            // CmdPrint
            // 
            CmdPrint.Location = new Point(12, 95);
            CmdPrint.Name = "CmdPrint";
            CmdPrint.Size = new Size(122, 23);
            CmdPrint.TabIndex = 2;
            CmdPrint.Text = "Ausgeben";
            CmdPrint.UseVisualStyleBackColor = true;
            CmdPrint.Click += CmdPrint_Click;
            // 
            // CmdRemove
            // 
            CmdRemove.Location = new Point(12, 338);
            CmdRemove.Name = "CmdRemove";
            CmdRemove.Size = new Size(120, 23);
            CmdRemove.TabIndex = 4;
            CmdRemove.Text = "Entfernen";
            CmdRemove.UseVisualStyleBackColor = true;
            CmdRemove.Click += CmdRemove_Click;
            // 
            // TxtShowNumbers
            // 
            TxtShowNumbers.Location = new Point(12, 131);
            TxtShowNumbers.Multiline = true;
            TxtShowNumbers.Name = "TxtShowNumbers";
            TxtShowNumbers.ReadOnly = true;
            TxtShowNumbers.Size = new Size(122, 172);
            TxtShowNumbers.TabIndex = 5;
            // 
            // NumNumberToRemove
            // 
            NumNumberToRemove.Location = new Point(12, 309);
            NumNumberToRemove.Name = "NumNumberToRemove";
            NumNumberToRemove.Size = new Size(122, 23);
            NumNumberToRemove.TabIndex = 6;
            // 
            // ArrayUebung_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 406);
            Controls.Add(NumNumberToRemove);
            Controls.Add(TxtShowNumbers);
            Controls.Add(CmdRemove);
            Controls.Add(CmdPrint);
            Controls.Add(NumNumberToAdd);
            Controls.Add(CmdAdd);
            Name = "ArrayUebung_1";
            Text = "Array Übung";
            ((System.ComponentModel.ISupportInitialize)NumNumberToAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumNumberToRemove).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumNumberToAdd;
        private Button CmdAdd;
        private Button CmdPrint;
        private Button CmdRemove;
        private TextBox TxtShowNumbers;
        private NumericUpDown NumNumberToRemove;
    }
}