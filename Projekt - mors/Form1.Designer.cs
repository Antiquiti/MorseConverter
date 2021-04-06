namespace Projekt___mors
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
            this.components = new System.ComponentModel.Container();
            this.PLTextBox = new System.Windows.Forms.TextBox();
            this.PLlabel = new System.Windows.Forms.Label();
            this.MorseLabel = new System.Windows.Forms.Label();
            this.MorseTextBox = new System.Windows.Forms.TextBox();
            this.PLtoMorseRB = new System.Windows.Forms.RadioButton();
            this.MorseToPLrb = new System.Windows.Forms.RadioButton();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.RealTimeTranslator = new System.Windows.Forms.CheckBox();
            this.MorseBeepRB = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCharactersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFrequencyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLengthMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.clearBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PLTextBox
            // 
            this.PLTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.PLTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PLTextBox.Location = new System.Drawing.Point(70, 37);
            this.PLTextBox.Name = "PLTextBox";
            this.PLTextBox.Size = new System.Drawing.Size(545, 24);
            this.PLTextBox.TabIndex = 0;
            this.PLTextBox.TextChanged += new System.EventHandler(this.PLTextBox_TextChanged);
            // 
            // PLlabel
            // 
            this.PLlabel.AutoSize = true;
            this.PLlabel.Location = new System.Drawing.Point(23, 44);
            this.PLlabel.Name = "PLlabel";
            this.PLlabel.Size = new System.Drawing.Size(35, 13);
            this.PLlabel.TabIndex = 1;
            this.PLlabel.Text = "Polski";
            // 
            // MorseLabel
            // 
            this.MorseLabel.AutoSize = true;
            this.MorseLabel.Location = new System.Drawing.Point(23, 73);
            this.MorseLabel.Name = "MorseLabel";
            this.MorseLabel.Size = new System.Drawing.Size(30, 13);
            this.MorseLabel.TabIndex = 2;
            this.MorseLabel.Text = "Mors";
            // 
            // MorseTextBox
            // 
            this.MorseTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.MorseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MorseTextBox.Location = new System.Drawing.Point(70, 66);
            this.MorseTextBox.Name = "MorseTextBox";
            this.MorseTextBox.Size = new System.Drawing.Size(545, 24);
            this.MorseTextBox.TabIndex = 3;
            this.MorseTextBox.TextChanged += new System.EventHandler(this.MorseTextBox_TextChanged);
            // 
            // PLtoMorseRB
            // 
            this.PLtoMorseRB.AutoSize = true;
            this.PLtoMorseRB.Checked = true;
            this.PLtoMorseRB.Location = new System.Drawing.Point(26, 129);
            this.PLtoMorseRB.Name = "PLtoMorseRB";
            this.PLtoMorseRB.Size = new System.Drawing.Size(143, 17);
            this.PLtoMorseRB.TabIndex = 4;
            this.PLtoMorseRB.TabStop = true;
            this.PLtoMorseRB.Text = "Polski -> Mors (tekstowo)";
            this.PLtoMorseRB.UseVisualStyleBackColor = true;
            // 
            // MorseToPLrb
            // 
            this.MorseToPLrb.AutoSize = true;
            this.MorseToPLrb.Location = new System.Drawing.Point(26, 152);
            this.MorseToPLrb.Name = "MorseToPLrb";
            this.MorseToPLrb.Size = new System.Drawing.Size(143, 17);
            this.MorseToPLrb.TabIndex = 5;
            this.MorseToPLrb.TabStop = true;
            this.MorseToPLrb.Text = "Mors -> Polski (tekstowo)";
            this.MorseToPLrb.UseVisualStyleBackColor = true;
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.BackColor = System.Drawing.Color.White;
            this.ConvertBtn.Location = new System.Drawing.Point(12, 206);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(187, 23);
            this.ConvertBtn.TabIndex = 6;
            this.ConvertBtn.Text = "Konwertuj";
            this.ConvertBtn.UseVisualStyleBackColor = false;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // RealTimeTranslator
            // 
            this.RealTimeTranslator.AutoSize = true;
            this.RealTimeTranslator.Location = new System.Drawing.Point(26, 96);
            this.RealTimeTranslator.Name = "RealTimeTranslator";
            this.RealTimeTranslator.Size = new System.Drawing.Size(123, 17);
            this.RealTimeTranslator.TabIndex = 7;
            this.RealTimeTranslator.Text = "Tłumacz na bieżąco";
            this.RealTimeTranslator.UseVisualStyleBackColor = true;
            this.RealTimeTranslator.CheckedChanged += new System.EventHandler(this.RealTimeTranslator_CheckedChanged);
            // 
            // MorseBeepRB
            // 
            this.MorseBeepRB.AutoSize = true;
            this.MorseBeepRB.Location = new System.Drawing.Point(26, 175);
            this.MorseBeepRB.Name = "MorseBeepRB";
            this.MorseBeepRB.Size = new System.Drawing.Size(207, 17);
            this.MorseBeepRB.TabIndex = 8;
            this.MorseBeepRB.TabStop = true;
            this.MorseBeepRB.Text = "Polski -> Mors ( tekstowo i dźwiękowo)";
            this.MorseBeepRB.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeCharactersMenu,
            this.changeFrequencyMenu,
            this.changeLengthMenu});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // changeCharactersMenu
            // 
            this.changeCharactersMenu.Name = "changeCharactersMenu";
            this.changeCharactersMenu.Size = new System.Drawing.Size(217, 22);
            this.changeCharactersMenu.Text = "Zmiana znaków";
            this.changeCharactersMenu.Click += new System.EventHandler(this.changeCharactersMenu_Click);
            // 
            // changeFrequencyMenu
            // 
            this.changeFrequencyMenu.Name = "changeFrequencyMenu";
            this.changeFrequencyMenu.Size = new System.Drawing.Size(217, 22);
            this.changeFrequencyMenu.Text = "Zmiana częstotliwości";
            this.changeFrequencyMenu.Click += new System.EventHandler(this.changeFrequencyMenu_Click);
            // 
            // changeLengthMenu
            // 
            this.changeLengthMenu.Name = "changeLengthMenu";
            this.changeLengthMenu.Size = new System.Drawing.Size(217, 22);
            this.changeLengthMenu.Text = "Zmiana długości dźwięków";
            this.changeLengthMenu.Click += new System.EventHandler(this.changeLengthMenu_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(221, 206);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 24;
            this.clearBtn.Text = "Wyczyść";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 235);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.MorseBeepRB);
            this.Controls.Add(this.RealTimeTranslator);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.MorseToPLrb);
            this.Controls.Add(this.PLtoMorseRB);
            this.Controls.Add(this.MorseTextBox);
            this.Controls.Add(this.MorseLabel);
            this.Controls.Add(this.PLlabel);
            this.Controls.Add(this.PLTextBox);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Konwerter Morse\'a";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PLTextBox;
        private System.Windows.Forms.Label PLlabel;
        private System.Windows.Forms.Label MorseLabel;
        private System.Windows.Forms.TextBox MorseTextBox;
        private System.Windows.Forms.RadioButton PLtoMorseRB;
        private System.Windows.Forms.RadioButton MorseToPLrb;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.CheckBox RealTimeTranslator;
        private System.Windows.Forms.RadioButton MorseBeepRB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCharactersMenu;
        private System.Windows.Forms.ToolStripMenuItem changeFrequencyMenu;
        private System.Windows.Forms.ToolStripMenuItem changeLengthMenu;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button clearBtn;
    }
}

