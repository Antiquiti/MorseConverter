namespace Projekt___mors
{
    partial class Form3
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
            this.changeFrequuencyBtn = new System.Windows.Forms.Button();
            this.changeFrequencyTB = new System.Windows.Forms.TextBox();
            this.changeFrequencyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeFrequuencyBtn
            // 
            this.changeFrequuencyBtn.Location = new System.Drawing.Point(178, 83);
            this.changeFrequuencyBtn.Name = "changeFrequuencyBtn";
            this.changeFrequuencyBtn.Size = new System.Drawing.Size(75, 23);
            this.changeFrequuencyBtn.TabIndex = 18;
            this.changeFrequuencyBtn.Text = "Zapisz";
            this.changeFrequuencyBtn.UseVisualStyleBackColor = true;
            this.changeFrequuencyBtn.Click += new System.EventHandler(this.changeFrequuencyBtn_Click);
            // 
            // changeFrequencyTB
            // 
            this.changeFrequencyTB.Location = new System.Drawing.Point(101, 86);
            this.changeFrequencyTB.Name = "changeFrequencyTB";
            this.changeFrequencyTB.Size = new System.Drawing.Size(46, 20);
            this.changeFrequencyTB.TabIndex = 17;
            // 
            // changeFrequencyLabel
            // 
            this.changeFrequencyLabel.AutoSize = true;
            this.changeFrequencyLabel.Location = new System.Drawing.Point(98, 63);
            this.changeFrequencyLabel.Name = "changeFrequencyLabel";
            this.changeFrequencyLabel.Size = new System.Drawing.Size(155, 13);
            this.changeFrequencyLabel.TabIndex = 16;
            this.changeFrequencyLabel.Text = "Zmiana częstotliwości dźwięku:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 168);
            this.Controls.Add(this.changeFrequuencyBtn);
            this.Controls.Add(this.changeFrequencyTB);
            this.Controls.Add(this.changeFrequencyLabel);
            this.Name = "Form3";
            this.Text = "Zmiana częstotliwości";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeFrequuencyBtn;
        private System.Windows.Forms.TextBox changeFrequencyTB;
        private System.Windows.Forms.Label changeFrequencyLabel;
    }
}