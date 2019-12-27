namespace Lekcja9
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
            this.button3 = new System.Windows.Forms.Button();
            this.TextMiasto1 = new System.Windows.Forms.TextBox();
            this.TextMiasto2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 86);
            this.button3.TabIndex = 2;
            this.button3.Text = "Od którego do którego miasta chcesz wyszukać najszybszą drogę";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextMiasto1
            // 
            this.TextMiasto1.Location = new System.Drawing.Point(345, 66);
            this.TextMiasto1.Name = "TextMiasto1";
            this.TextMiasto1.Size = new System.Drawing.Size(100, 22);
            this.TextMiasto1.TabIndex = 7;
            this.TextMiasto1.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // TextMiasto2
            // 
            this.TextMiasto2.Location = new System.Drawing.Point(345, 130);
            this.TextMiasto2.Name = "TextMiasto2";
            this.TextMiasto2.Size = new System.Drawing.Size(100, 22);
            this.TextMiasto2.TabIndex = 8;
            this.TextMiasto2.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 362);
            this.Controls.Add(this.TextMiasto2);
            this.Controls.Add(this.TextMiasto1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TextMiasto1;
        private System.Windows.Forms.TextBox TextMiasto2;
    }
}

