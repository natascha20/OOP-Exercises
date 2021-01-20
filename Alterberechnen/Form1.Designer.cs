
namespace Alterberechnen
{
    partial class alterBerechnen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.radioButtonYears = new System.Windows.Forms.RadioButton();
            this.radioButtonMonths = new System.Windows.Forms.RadioButton();
            this.radioButtonWeeks = new System.Windows.Forms.RadioButton();
            this.radioButtonDays = new System.Windows.Forms.RadioButton();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geburtsdatum";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(173, 172);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alter:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(173, 251);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(200, 20);
            this.textBoxAge.TabIndex = 4;
            // 
            // radioButtonYears
            // 
            this.radioButtonYears.AutoSize = true;
            this.radioButtonYears.Location = new System.Drawing.Point(44, 52);
            this.radioButtonYears.Name = "radioButtonYears";
            this.radioButtonYears.Size = new System.Drawing.Size(68, 17);
            this.radioButtonYears.TabIndex = 5;
            this.radioButtonYears.TabStop = true;
            this.radioButtonYears.Text = "in Jahren";
            this.radioButtonYears.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonths
            // 
            this.radioButtonMonths.AutoSize = true;
            this.radioButtonMonths.Location = new System.Drawing.Point(128, 52);
            this.radioButtonMonths.Name = "radioButtonMonths";
            this.radioButtonMonths.Size = new System.Drawing.Size(78, 17);
            this.radioButtonMonths.TabIndex = 6;
            this.radioButtonMonths.TabStop = true;
            this.radioButtonMonths.Text = "in Monaten";
            this.radioButtonMonths.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeeks
            // 
            this.radioButtonWeeks.AutoSize = true;
            this.radioButtonWeeks.Location = new System.Drawing.Point(223, 52);
            this.radioButtonWeeks.Name = "radioButtonWeeks";
            this.radioButtonWeeks.Size = new System.Drawing.Size(77, 17);
            this.radioButtonWeeks.TabIndex = 7;
            this.radioButtonWeeks.TabStop = true;
            this.radioButtonWeeks.Text = "in Wochen";
            this.radioButtonWeeks.UseVisualStyleBackColor = true;
            // 
            // radioButtonDays
            // 
            this.radioButtonDays.AutoSize = true;
            this.radioButtonDays.Location = new System.Drawing.Point(328, 52);
            this.radioButtonDays.Name = "radioButtonDays";
            this.radioButtonDays.Size = new System.Drawing.Size(67, 17);
            this.radioButtonDays.TabIndex = 8;
            this.radioButtonDays.TabStop = true;
            this.radioButtonDays.Text = "in Tagen";
            this.radioButtonDays.UseVisualStyleBackColor = true;
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Location = new System.Drawing.Point(384, 170);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(75, 23);
            this.buttonBerechnen.TabIndex = 9;
            this.buttonBerechnen.Text = "Berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(384, 285);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Beenden";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // alterBerechnen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 330);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBerechnen);
            this.Controls.Add(this.radioButtonDays);
            this.Controls.Add(this.radioButtonWeeks);
            this.Controls.Add(this.radioButtonMonths);
            this.Controls.Add(this.radioButtonYears);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "alterBerechnen";
            this.Text = "Alter berechnen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.RadioButton radioButtonYears;
        private System.Windows.Forms.RadioButton radioButtonMonths;
        private System.Windows.Forms.RadioButton radioButtonWeeks;
        private System.Windows.Forms.RadioButton radioButtonDays;
        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.Button buttonExit;
    }
}

