namespace Projekt___mors
{
    partial class Form4
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
            this.changeLengthsBtn = new System.Windows.Forms.Button();
            this.dotLengthTB = new System.Windows.Forms.TextBox();
            this.dashLengthTB = new System.Windows.Forms.TextBox();
            this.spaceBetweenMorseLettersTB = new System.Windows.Forms.TextBox();
            this.spaceBetweenCharactersTB = new System.Windows.Forms.TextBox();
            this.spaceBetweenWordsTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeLengthsBtn
            // 
            this.changeLengthsBtn.Location = new System.Drawing.Point(379, 83);
            this.changeLengthsBtn.Name = "changeLengthsBtn";
            this.changeLengthsBtn.Size = new System.Drawing.Size(75, 23);
            this.changeLengthsBtn.TabIndex = 0;
            this.changeLengthsBtn.Text = "Zapisz";
            this.changeLengthsBtn.UseVisualStyleBackColor = true;
            this.changeLengthsBtn.Click += new System.EventHandler(this.changeLengthsBtn_Click);
            // 
            // dotLengthTB
            // 
            this.dotLengthTB.Location = new System.Drawing.Point(42, 51);
            this.dotLengthTB.Name = "dotLengthTB";
            this.dotLengthTB.Size = new System.Drawing.Size(47, 20);
            this.dotLengthTB.TabIndex = 1;
            // 
            // dashLengthTB
            // 
            this.dashLengthTB.Location = new System.Drawing.Point(214, 49);
            this.dashLengthTB.Name = "dashLengthTB";
            this.dashLengthTB.Size = new System.Drawing.Size(47, 20);
            this.dashLengthTB.TabIndex = 2;
            // 
            // spaceBetweenMorseLettersTB
            // 
            this.spaceBetweenMorseLettersTB.Location = new System.Drawing.Point(42, 99);
            this.spaceBetweenMorseLettersTB.Name = "spaceBetweenMorseLettersTB";
            this.spaceBetweenMorseLettersTB.Size = new System.Drawing.Size(47, 20);
            this.spaceBetweenMorseLettersTB.TabIndex = 2;
            // 
            // spaceBetweenCharactersTB
            // 
            this.spaceBetweenCharactersTB.Location = new System.Drawing.Point(214, 99);
            this.spaceBetweenCharactersTB.Name = "spaceBetweenCharactersTB";
            this.spaceBetweenCharactersTB.Size = new System.Drawing.Size(47, 20);
            this.spaceBetweenCharactersTB.TabIndex = 2;
            // 
            // spaceBetweenWordsTB
            // 
            this.spaceBetweenWordsTB.Location = new System.Drawing.Point(118, 161);
            this.spaceBetweenWordsTB.Name = "spaceBetweenWordsTB";
            this.spaceBetweenWordsTB.Size = new System.Drawing.Size(47, 20);
            this.spaceBetweenWordsTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "krótki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "długi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Przerwa między znakami Morsa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Przerwa między znakami (tekst)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Przerwa między wyrazami";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 212);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spaceBetweenWordsTB);
            this.Controls.Add(this.spaceBetweenCharactersTB);
            this.Controls.Add(this.spaceBetweenMorseLettersTB);
            this.Controls.Add(this.dashLengthTB);
            this.Controls.Add(this.dotLengthTB);
            this.Controls.Add(this.changeLengthsBtn);
            this.Name = "Form4";
            this.Text = "Zmiana długości dźwięków";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeLengthsBtn;
        private System.Windows.Forms.TextBox dotLengthTB;
        private System.Windows.Forms.TextBox dashLengthTB;
        private System.Windows.Forms.TextBox spaceBetweenMorseLettersTB;
        private System.Windows.Forms.TextBox spaceBetweenCharactersTB;
        private System.Windows.Forms.TextBox spaceBetweenWordsTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}