namespace Lab10_Database_Chart_Votes
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.radioButton_2_0 = new System.Windows.Forms.RadioButton();
            this.radioButton_3_0 = new System.Windows.Forms.RadioButton();
            this.radioButton_3_5 = new System.Windows.Forms.RadioButton();
            this.radioButton_4_0 = new System.Windows.Forms.RadioButton();
            this.radioButton_4_5 = new System.Windows.Forms.RadioButton();
            this.radioButton_5_0 = new System.Windows.Forms.RadioButton();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(51, 9);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(234, 20);
            this.textBoxEmail.TabIndex = 0;
            // 
            // radioButton_2_0
            // 
            this.radioButton_2_0.AutoSize = true;
            this.radioButton_2_0.Location = new System.Drawing.Point(51, 34);
            this.radioButton_2_0.Name = "radioButton_2_0";
            this.radioButton_2_0.Size = new System.Drawing.Size(31, 17);
            this.radioButton_2_0.TabIndex = 1;
            this.radioButton_2_0.TabStop = true;
            this.radioButton_2_0.Text = "2";
            this.radioButton_2_0.UseVisualStyleBackColor = true;
            this.radioButton_2_0.CheckedChanged += new System.EventHandler(this.RadioButton_Grade_CheckedChanged);
            // 
            // radioButton_3_0
            // 
            this.radioButton_3_0.AutoSize = true;
            this.radioButton_3_0.Location = new System.Drawing.Point(88, 34);
            this.radioButton_3_0.Name = "radioButton_3_0";
            this.radioButton_3_0.Size = new System.Drawing.Size(31, 17);
            this.radioButton_3_0.TabIndex = 2;
            this.radioButton_3_0.TabStop = true;
            this.radioButton_3_0.Text = "3";
            this.radioButton_3_0.UseVisualStyleBackColor = true;
            this.radioButton_3_0.CheckedChanged += new System.EventHandler(this.RadioButton_Grade_CheckedChanged);
            // 
            // radioButton_3_5
            // 
            this.radioButton_3_5.AutoSize = true;
            this.radioButton_3_5.Location = new System.Drawing.Point(125, 34);
            this.radioButton_3_5.Name = "radioButton_3_5";
            this.radioButton_3_5.Size = new System.Drawing.Size(40, 17);
            this.radioButton_3_5.TabIndex = 3;
            this.radioButton_3_5.TabStop = true;
            this.radioButton_3_5.Text = "3,5";
            this.radioButton_3_5.UseVisualStyleBackColor = true;
            this.radioButton_3_5.CheckedChanged += new System.EventHandler(this.RadioButton_Grade_CheckedChanged);
            // 
            // radioButton_4_0
            // 
            this.radioButton_4_0.AutoSize = true;
            this.radioButton_4_0.Location = new System.Drawing.Point(171, 34);
            this.radioButton_4_0.Name = "radioButton_4_0";
            this.radioButton_4_0.Size = new System.Drawing.Size(31, 17);
            this.radioButton_4_0.TabIndex = 4;
            this.radioButton_4_0.TabStop = true;
            this.radioButton_4_0.Text = "4";
            this.radioButton_4_0.UseVisualStyleBackColor = true;
            this.radioButton_4_0.CheckedChanged += new System.EventHandler(this.RadioButton_Grade_CheckedChanged);
            // 
            // radioButton_4_5
            // 
            this.radioButton_4_5.AutoSize = true;
            this.radioButton_4_5.Location = new System.Drawing.Point(208, 34);
            this.radioButton_4_5.Name = "radioButton_4_5";
            this.radioButton_4_5.Size = new System.Drawing.Size(40, 17);
            this.radioButton_4_5.TabIndex = 5;
            this.radioButton_4_5.TabStop = true;
            this.radioButton_4_5.Text = "4,5";
            this.radioButton_4_5.UseVisualStyleBackColor = true;
            this.radioButton_4_5.CheckedChanged += new System.EventHandler(this.RadioButton_Grade_CheckedChanged);
            // 
            // radioButton_5_0
            // 
            this.radioButton_5_0.AutoSize = true;
            this.radioButton_5_0.Location = new System.Drawing.Point(254, 34);
            this.radioButton_5_0.Name = "radioButton_5_0";
            this.radioButton_5_0.Size = new System.Drawing.Size(31, 17);
            this.radioButton_5_0.TabIndex = 6;
            this.radioButton_5_0.TabStop = true;
            this.radioButton_5_0.Text = "5";
            this.radioButton_5_0.UseVisualStyleBackColor = true;
            this.radioButton_5_0.CheckedChanged += new System.EventHandler(this.RadioButton_Grade_CheckedChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(13, 13);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(13, 36);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(36, 13);
            this.labelGrade.TabIndex = 8;
            this.labelGrade.Text = "Grade";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(51, 58);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(234, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(51, 88);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(405, 103);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.radioButton_5_0);
            this.Controls.Add(this.radioButton_4_5);
            this.Controls.Add(this.radioButton_4_0);
            this.Controls.Add(this.radioButton_3_5);
            this.Controls.Add(this.radioButton_3_0);
            this.Controls.Add(this.radioButton_2_0);
            this.Controls.Add(this.textBoxEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.RadioButton radioButton_2_0;
        private System.Windows.Forms.RadioButton radioButton_3_0;
        private System.Windows.Forms.RadioButton radioButton_3_5;
        private System.Windows.Forms.RadioButton radioButton_4_0;
        private System.Windows.Forms.RadioButton radioButton_4_5;
        private System.Windows.Forms.RadioButton radioButton_5_0;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelInfo;
    }
}

