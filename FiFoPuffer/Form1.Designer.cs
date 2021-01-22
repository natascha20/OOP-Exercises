
namespace FiFoPuffer
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEingabe = new System.Windows.Forms.TextBox();
            this.textBoxAusgabe = new System.Windows.Forms.TextBox();
            this.buttonPut = new System.Windows.Forms.Button();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonGetAll = new System.Windows.Forms.Button();
            this.buttonPufferErstellen = new System.Windows.Forms.Button();
            this.numericUpDownPuffergroesse = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPuffergroesse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puffergrösse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eingabe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ausgabe";
            // 
            // textBoxEingabe
            // 
            this.textBoxEingabe.Location = new System.Drawing.Point(134, 160);
            this.textBoxEingabe.Name = "textBoxEingabe";
            this.textBoxEingabe.Size = new System.Drawing.Size(119, 20);
            this.textBoxEingabe.TabIndex = 3;
            // 
            // textBoxAusgabe
            // 
            this.textBoxAusgabe.Location = new System.Drawing.Point(211, 257);
            this.textBoxAusgabe.Name = "textBoxAusgabe";
            this.textBoxAusgabe.Size = new System.Drawing.Size(122, 20);
            this.textBoxAusgabe.TabIndex = 4;
            // 
            // buttonPut
            // 
            this.buttonPut.Location = new System.Drawing.Point(278, 155);
            this.buttonPut.Name = "buttonPut";
            this.buttonPut.Size = new System.Drawing.Size(135, 23);
            this.buttonPut.TabIndex = 5;
            this.buttonPut.Text = "Put";
            this.buttonPut.UseVisualStyleBackColor = true;
            this.buttonPut.Click += new System.EventHandler(this.buttonPut_Click);
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(26, 249);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(69, 26);
            this.buttonGet.TabIndex = 6;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonGetAll
            // 
            this.buttonGetAll.Location = new System.Drawing.Point(28, 287);
            this.buttonGetAll.Name = "buttonGetAll";
            this.buttonGetAll.Size = new System.Drawing.Size(66, 25);
            this.buttonGetAll.TabIndex = 7;
            this.buttonGetAll.Text = "GetAll";
            this.buttonGetAll.UseVisualStyleBackColor = true;
            this.buttonGetAll.Click += new System.EventHandler(this.buttonGetAll_Click);
            // 
            // buttonPufferErstellen
            // 
            this.buttonPufferErstellen.Location = new System.Drawing.Point(279, 47);
            this.buttonPufferErstellen.Name = "buttonPufferErstellen";
            this.buttonPufferErstellen.Size = new System.Drawing.Size(134, 25);
            this.buttonPufferErstellen.TabIndex = 8;
            this.buttonPufferErstellen.Text = "Puffer Erstellen";
            this.buttonPufferErstellen.UseVisualStyleBackColor = true;
            this.buttonPufferErstellen.Click += new System.EventHandler(this.buttonPufferErstellen_Click);
            // 
            // numericUpDownPuffergroesse
            // 
            this.numericUpDownPuffergroesse.Location = new System.Drawing.Point(133, 53);
            this.numericUpDownPuffergroesse.Name = "numericUpDownPuffergroesse";
            this.numericUpDownPuffergroesse.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPuffergroesse.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 366);
            this.Controls.Add(this.numericUpDownPuffergroesse);
            this.Controls.Add(this.buttonPufferErstellen);
            this.Controls.Add(this.buttonGetAll);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.buttonPut);
            this.Controls.Add(this.textBoxAusgabe);
            this.Controls.Add(this.textBoxEingabe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fifo Puffer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPuffergroesse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEingabe;
        private System.Windows.Forms.TextBox textBoxAusgabe;
        private System.Windows.Forms.Button buttonPut;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonGetAll;
        private System.Windows.Forms.Button buttonPufferErstellen;
        private System.Windows.Forms.NumericUpDown numericUpDownPuffergroesse;
    }
}

