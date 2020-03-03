namespace PracaDomowaLab1
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRecepty = new System.Windows.Forms.Button();
            this.labelKoszary = new System.Windows.Forms.Label();
            this.textBoxInterwal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(345, 132);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 43);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonRecepty
            // 
            this.buttonRecepty.Location = new System.Drawing.Point(345, 263);
            this.buttonRecepty.Name = "buttonRecepty";
            this.buttonRecepty.Size = new System.Drawing.Size(100, 43);
            this.buttonRecepty.TabIndex = 2;
            this.buttonRecepty.Text = "Recepty";
            this.buttonRecepty.UseVisualStyleBackColor = true;
            this.buttonRecepty.Click += new System.EventHandler(this.buttonRecepty_Click);
            // 
            // labelKoszary
            // 
            this.labelKoszary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelKoszary.Location = new System.Drawing.Point(150, 32);
            this.labelKoszary.Name = "labelKoszary";
            this.labelKoszary.Size = new System.Drawing.Size(100, 47);
            this.labelKoszary.TabIndex = 3;
            this.labelKoszary.Text = "KOSZARY";
            this.labelKoszary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInterwal
            // 
            this.textBoxInterwal.Location = new System.Drawing.Point(345, 345);
            this.textBoxInterwal.Name = "textBoxInterwal";
            this.textBoxInterwal.Size = new System.Drawing.Size(100, 22);
            this.textBoxInterwal.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxInterwal);
            this.Controls.Add(this.labelKoszary);
            this.Controls.Add(this.buttonRecepty);
            this.Controls.Add(this.buttonStart);
            this.DoubleBuffered = true;
            this.Name = "FormStart";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRecepty;
        private System.Windows.Forms.Label labelKoszary;
        private System.Windows.Forms.TextBox textBoxInterwal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

