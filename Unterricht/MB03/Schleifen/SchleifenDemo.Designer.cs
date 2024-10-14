namespace MB03.Schleifen
{
    partial class SchleifenDemo
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
            CmdFor = new Button();
            CmdWhile = new Button();
            CmdDoWhile = new Button();
            TxtShow = new TextBox();
            SuspendLayout();
            // 
            // CmdFor
            // 
            CmdFor.Location = new Point(30, 31);
            CmdFor.Name = "CmdFor";
            CmdFor.Size = new Size(75, 23);
            CmdFor.TabIndex = 0;
            CmdFor.Text = "For";
            CmdFor.UseVisualStyleBackColor = true;
            CmdFor.Click += CmdFor_Click;
            // 
            // CmdWhile
            // 
            CmdWhile.Location = new Point(125, 31);
            CmdWhile.Name = "CmdWhile";
            CmdWhile.Size = new Size(75, 23);
            CmdWhile.TabIndex = 1;
            CmdWhile.Text = "While";
            CmdWhile.UseVisualStyleBackColor = true;
            CmdWhile.Click += CmdWhile_Click;
            // 
            // CmdDoWhile
            // 
            CmdDoWhile.Location = new Point(219, 31);
            CmdDoWhile.Name = "CmdDoWhile";
            CmdDoWhile.Size = new Size(75, 23);
            CmdDoWhile.TabIndex = 2;
            CmdDoWhile.Text = "Do...While";
            CmdDoWhile.UseVisualStyleBackColor = true;
            CmdDoWhile.Click += CmdDoWhile_Click;
            // 
            // TxtShow
            // 
            TxtShow.Location = new Point(30, 75);
            TxtShow.Multiline = true;
            TxtShow.Name = "TxtShow";
            TxtShow.Size = new Size(264, 169);
            TxtShow.TabIndex = 3;
            // 
            // SchleifenDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 809);
            Controls.Add(TxtShow);
            Controls.Add(CmdDoWhile);
            Controls.Add(CmdWhile);
            Controls.Add(CmdFor);
            Name = "SchleifenDemo";
            Text = "SchleifenDemo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdFor;
        private Button CmdWhile;
        private Button CmdDoWhile;
        private TextBox TxtShow;
    }
}