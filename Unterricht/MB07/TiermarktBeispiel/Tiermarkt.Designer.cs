namespace MB07.TiermarktBeispiel
{
    partial class Tiermarkt
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
            TxtNamePerson = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            CmdCreatePerson = new Button();
            groupBox2 = new GroupBox();
            NumAgeDog = new NumericUpDown();
            TxtNameDog = new TextBox();
            CmdCreateAnimal = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtOutput = new TextBox();
            LstPerson = new ListBox();
            LstDogs = new ListBox();
            CmdBuy = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumAgeDog).BeginInit();
            SuspendLayout();
            // 
            // TxtNamePerson
            // 
            TxtNamePerson.Location = new Point(51, 30);
            TxtNamePerson.Name = "TxtNamePerson";
            TxtNamePerson.Size = new Size(143, 23);
            TxtNamePerson.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CmdCreatePerson);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtNamePerson);
            groupBox1.Location = new Point(12, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Person";
            // 
            // CmdCreatePerson
            // 
            CmdCreatePerson.Location = new Point(51, 71);
            CmdCreatePerson.Name = "CmdCreatePerson";
            CmdCreatePerson.Size = new Size(140, 23);
            CmdCreatePerson.TabIndex = 2;
            CmdCreatePerson.Text = "Erstellen";
            CmdCreatePerson.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(NumAgeDog);
            groupBox2.Controls.Add(TxtNameDog);
            groupBox2.Controls.Add(CmdCreateAnimal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(230, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(212, 132);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hund";
            // 
            // NumAgeDog
            // 
            NumAgeDog.Location = new Point(80, 59);
            NumAgeDog.Name = "NumAgeDog";
            NumAgeDog.Size = new Size(120, 23);
            NumAgeDog.TabIndex = 3;
            // 
            // TxtNameDog
            // 
            TxtNameDog.Location = new Point(79, 30);
            TxtNameDog.Name = "TxtNameDog";
            TxtNameDog.Size = new Size(121, 23);
            TxtNameDog.TabIndex = 2;
            // 
            // CmdCreateAnimal
            // 
            CmdCreateAnimal.Location = new Point(80, 88);
            CmdCreateAnimal.Name = "CmdCreateAnimal";
            CmdCreateAnimal.Size = new Size(120, 23);
            CmdCreateAnimal.TabIndex = 2;
            CmdCreateAnimal.Text = "Erstellen";
            CmdCreateAnimal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 59);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 1;
            label3.Text = "Alter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 32);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 208);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 4;
            label4.Text = "Alle Personen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 208);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 5;
            label5.Text = "Alle Hunde";
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(18, 356);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.ReadOnly = true;
            TxtOutput.Size = new Size(424, 112);
            TxtOutput.TabIndex = 6;
            // 
            // LstPerson
            // 
            LstPerson.FormattingEnabled = true;
            LstPerson.ItemHeight = 15;
            LstPerson.Location = new Point(18, 226);
            LstPerson.Name = "LstPerson";
            LstPerson.Size = new Size(120, 109);
            LstPerson.TabIndex = 7;
            // 
            // LstDogs
            // 
            LstDogs.FormattingEnabled = true;
            LstDogs.ItemHeight = 15;
            LstDogs.Location = new Point(230, 226);
            LstDogs.Name = "LstDogs";
            LstDogs.Size = new Size(120, 109);
            LstDogs.TabIndex = 8;
            // 
            // CmdBuy
            // 
            CmdBuy.Location = new Point(367, 312);
            CmdBuy.Name = "CmdBuy";
            CmdBuy.Size = new Size(75, 23);
            CmdBuy.TabIndex = 9;
            CmdBuy.Text = "Kaufen";
            CmdBuy.UseVisualStyleBackColor = true;
            // 
            // Tiermarkt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 502);
            Controls.Add(CmdBuy);
            Controls.Add(LstDogs);
            Controls.Add(LstPerson);
            Controls.Add(TxtOutput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Tiermarkt";
            Text = "Tiermarkt";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumAgeDog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNamePerson;
        private Label label1;
        private GroupBox groupBox1;
        private Button CmdCreatePerson;
        private GroupBox groupBox2;
        private NumericUpDown NumAgeDog;
        private TextBox TxtNameDog;
        private Button CmdCreateAnimal;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox TxtOutput;
        private ListBox LstPerson;
        private ListBox LstDogs;
        private Button CmdBuy;
    }
}