namespace obsah_geometrickeho_telesa
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPocitej = new System.Windows.Forms.Button();
            this.textInStrana = new System.Windows.Forms.TextBox();
            this.textInJednotky = new System.Windows.Forms.TextBox();
            this.textOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPocitej
            // 
            this.buttonPocitej.Location = new System.Drawing.Point(560, 229);
            this.buttonPocitej.Name = "buttonPocitej";
            this.buttonPocitej.Size = new System.Drawing.Size(83, 53);
            this.buttonPocitej.TabIndex = 0;
            this.buttonPocitej.Text = "button1";
            this.buttonPocitej.UseVisualStyleBackColor = true;
            this.buttonPocitej.Click += new System.EventHandler(this.buttonPocitej_Click);
            // 
            // textInStrana
            // 
            this.textInStrana.Location = new System.Drawing.Point(228, 91);
            this.textInStrana.Name = "textInStrana";
            this.textInStrana.Size = new System.Drawing.Size(140, 20);
            this.textInStrana.TabIndex = 1;
            // 
            // textInJednotky
            // 
            this.textInJednotky.Location = new System.Drawing.Point(228, 185);
            this.textInJednotky.Name = "textInJednotky";
            this.textInJednotky.Size = new System.Drawing.Size(140, 20);
            this.textInJednotky.TabIndex = 2;
            this.textInJednotky.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textOut
            // 
            this.textOut.Location = new System.Drawing.Point(77, 266);
            this.textOut.Multiline = true;
            this.textOut.Name = "textOut";
            this.textOut.ReadOnly = true;
            this.textOut.Size = new System.Drawing.Size(350, 140);
            this.textOut.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(71, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Strana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(71, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jednotka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.textInJednotky);
            this.Controls.Add(this.textInStrana);
            this.Controls.Add(this.buttonPocitej);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPocitej;
        private System.Windows.Forms.TextBox textInStrana;
        private System.Windows.Forms.TextBox textInJednotky;
        private System.Windows.Forms.TextBox textOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

