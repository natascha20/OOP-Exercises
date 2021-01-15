
namespace Reise_zum_Mond
{
    partial class FormReisezumMond
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
            this.radioButtonDays = new System.Windows.Forms.RadioButton();
            this.radioButtonHoures = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButtonDays
            // 
            this.radioButtonDays.AutoSize = true;
            this.radioButtonDays.Location = new System.Drawing.Point(108, 39);
            this.radioButtonDays.Name = "radioButtonDays";
            this.radioButtonDays.Size = new System.Drawing.Size(67, 17);
            this.radioButtonDays.TabIndex = 0;
            this.radioButtonDays.TabStop = true;
            this.radioButtonDays.Text = "in Tagen";
            this.radioButtonDays.UseVisualStyleBackColor = true;
            // 
            // radioButtonHoures
            // 
            this.radioButtonHoures.AutoSize = true;
            this.radioButtonHoures.Location = new System.Drawing.Point(240, 39);
            this.radioButtonHoures.Name = "radioButtonHoures";
            this.radioButtonHoures.Size = new System.Drawing.Size(76, 17);
            this.radioButtonHoures.TabIndex = 1;
            this.radioButtonHoures.TabStop = true;
            this.radioButtonHoures.Text = "in Stunden";
            this.radioButtonHoures.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Geschwindligkeit in km/h:";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(240, 72);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 3;
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Location = new System.Drawing.Point(111, 123);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(232, 23);
            this.buttonBerechnen.TabIndex = 4;
            this.buttonBerechnen.Text = "Reidsedauer Berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ausgabe Reisedauer:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(240, 226);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 6;
            // 
            // FormReisezumMond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 283);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBerechnen);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonHoures);
            this.Controls.Add(this.radioButtonDays);
            this.Name = "FormReisezumMond";
            this.Text = "Reisedauer zum Mond";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonDays;
        private System.Windows.Forms.RadioButton radioButtonHoures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

