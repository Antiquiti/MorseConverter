namespace Projekt___mors
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.thirdCharTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changeCharBtn = new System.Windows.Forms.Button();
            this.secondCharTB = new System.Windows.Forms.TextBox();
            this.firstCharTB = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "spacja";
            // 
            // thirdCharTB
            // 
            this.thirdCharTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.thirdCharTB.Location = new System.Drawing.Point(196, 84);
            this.thirdCharTB.MaxLength = 1;
            this.thirdCharTB.Name = "thirdCharTB";
            this.thirdCharTB.Size = new System.Drawing.Size(39, 22);
            this.thirdCharTB.TabIndex = 29;
            this.thirdCharTB.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "długi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "krótki";
            // 
            // changeCharBtn
            // 
            this.changeCharBtn.Location = new System.Drawing.Point(259, 83);
            this.changeCharBtn.Name = "changeCharBtn";
            this.changeCharBtn.Size = new System.Drawing.Size(75, 23);
            this.changeCharBtn.TabIndex = 26;
            this.changeCharBtn.Text = "Zapisz";
            this.changeCharBtn.UseVisualStyleBackColor = true;
            this.changeCharBtn.Click += new System.EventHandler(this.changeCharBtn_Click);
            // 
            // secondCharTB
            // 
            this.secondCharTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondCharTB.Location = new System.Drawing.Point(135, 84);
            this.secondCharTB.MaxLength = 1;
            this.secondCharTB.Name = "secondCharTB";
            this.secondCharTB.Size = new System.Drawing.Size(42, 22);
            this.secondCharTB.TabIndex = 25;
            this.secondCharTB.Text = "-";
            // 
            // firstCharTB
            // 
            this.firstCharTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstCharTB.Location = new System.Drawing.Point(60, 84);
            this.firstCharTB.MaxLength = 1;
            this.firstCharTB.Name = "firstCharTB";
            this.firstCharTB.Size = new System.Drawing.Size(42, 22);
            this.firstCharTB.TabIndex = 24;
            this.firstCharTB.Text = ".";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(82, 43);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(129, 13);
            this.label.TabIndex = 23;
            this.label.Text = "Zmiana znaku w koderze:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 157);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.thirdCharTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeCharBtn);
            this.Controls.Add(this.secondCharTB);
            this.Controls.Add(this.firstCharTB);
            this.Controls.Add(this.label);
            this.Name = "Form2";
            this.Text = "Zmiana znaków";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox thirdCharTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeCharBtn;
        private System.Windows.Forms.TextBox secondCharTB;
        private System.Windows.Forms.TextBox firstCharTB;
        private System.Windows.Forms.Label label;
    }
}