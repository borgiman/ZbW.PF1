namespace MB09.Haustierverwaltung_1
{
    partial class Haustierverwaltung1
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
            BtnAdd=new Button();
            LblName=new Label();
            LblAlter=new Label();
            TxtName=new TextBox();
            NumAge=new NumericUpDown();
            label3=new Label();
            LblNumberOfPets=new Label();
            RadCat=new RadioButton();
            RadDog=new RadioButton();
            ((System.ComponentModel.ISupportInitialize)NumAge).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location=new Point(70, 106);
            BtnAdd.Name="BtnAdd";
            BtnAdd.Size=new Size(120, 23);
            BtnAdd.TabIndex=0;
            BtnAdd.Text="Erfassen";
            BtnAdd.UseVisualStyleBackColor=true;
            BtnAdd.Click+=BtnAdd_Click;
            // 
            // LblName
            // 
            LblName.AutoSize=true;
            LblName.Location=new Point(12, 48);
            LblName.Name="LblName";
            LblName.Size=new Size(39, 15);
            LblName.TabIndex=1;
            LblName.Text="Name";
            // 
            // LblAlter
            // 
            LblAlter.AutoSize=true;
            LblAlter.Location=new Point(12, 77);
            LblAlter.Name="LblAlter";
            LblAlter.Size=new Size(32, 15);
            LblAlter.TabIndex=2;
            LblAlter.Text="Alter";
            // 
            // TxtName
            // 
            TxtName.Location=new Point(70, 45);
            TxtName.Name="TxtName";
            TxtName.Size=new Size(120, 23);
            TxtName.TabIndex=3;
            // 
            // NumAge
            // 
            NumAge.Location=new Point(70, 77);
            NumAge.Name="NumAge";
            NumAge.Size=new Size(120, 23);
            NumAge.TabIndex=4;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(265, 22);
            label3.Name="label3";
            label3.Size=new Size(147, 15);
            label3.TabIndex=5;
            label3.Text="Anzahl aktueller Haustiere:";
            // 
            // LblNumberOfPets
            // 
            LblNumberOfPets.AutoSize=true;
            LblNumberOfPets.Location=new Point(415, 22);
            LblNumberOfPets.Name="LblNumberOfPets";
            LblNumberOfPets.Size=new Size(13, 15);
            LblNumberOfPets.TabIndex=6;
            LblNumberOfPets.Text="0";
            // 
            // RadCat
            // 
            RadCat.AutoSize=true;
            RadCat.Location=new Point(137, 12);
            RadCat.Name="RadCat";
            RadCat.Size=new Size(53, 19);
            RadCat.TabIndex=7;
            RadCat.TabStop=true;
            RadCat.Text="Katze";
            RadCat.UseVisualStyleBackColor=true;
            // 
            // RadDog
            // 
            RadDog.AutoSize=true;
            RadDog.Location=new Point(70, 12);
            RadDog.Name="RadDog";
            RadDog.Size=new Size(55, 19);
            RadDog.TabIndex=8;
            RadDog.TabStop=true;
            RadDog.Text="Hund";
            RadDog.UseVisualStyleBackColor=true;
            // 
            // Haustierverwaltung1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(471, 150);
            Controls.Add(RadDog);
            Controls.Add(RadCat);
            Controls.Add(LblNumberOfPets);
            Controls.Add(label3);
            Controls.Add(NumAge);
            Controls.Add(TxtName);
            Controls.Add(LblAlter);
            Controls.Add(LblName);
            Controls.Add(BtnAdd);
            Name="Haustierverwaltung1";
            Text="Haustierverwaltung";
            ((System.ComponentModel.ISupportInitialize)NumAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private Label LblName;
        private Label LblAlter;
        private TextBox TxtName;
        private NumericUpDown NumAge;
        private Label label3;
        private Label LblNumberOfPets;
        private RadioButton RadCat;
        private RadioButton RadDog;
    }
}