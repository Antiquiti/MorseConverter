using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt___mors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string dot = ".";
        private static string dash = "-";
        private static string spaceBetweenCharacters = " ";
        private static string spaceBetweenWords = "/";
        private static int frequency = 440;
        private static int dotLength = 150;
        private static int dashLength = 450;
        private static int spaceBetweenCharactersLength = 450;
        private static int spaceBetweenWordsLength = 1050;
        private static int spaceBetweenMorseCharactersLength = 100;
        Graphics gp;
        bool fill = false;
        bool shortBeep = false;
        bool pauseChars = false;
        bool pauseBetweenChars = false;
        bool pauseBetweenWords = false;

        public string setDot
        {
            get { return dot; }
            set { dot = value; }
        }

        public string setDash
        {
            get { return dash; }
            set { dash = value; }
        }

        public string setSpaceBetweenWords
        {
            get { return spaceBetweenWords; }
            set { spaceBetweenWords = value; }
        }

        public int setFrequency
        {
            get { return frequency; }
            set { frequency = value; }
        }

        public int setDotLength
        {
            get { return dotLength; }
            set { dotLength = value; }
        }

        public int setDashLength
        {
            get { return dashLength; }
            set { dashLength = value; }
        }

        public int setSpaceBetweenCharactersLength
        {
            get { return spaceBetweenCharactersLength; }
            set { spaceBetweenCharactersLength = value; }
        }

        public int setSpaceBetweenWordsLength
        {
            get { return spaceBetweenWordsLength; }
            set { spaceBetweenWordsLength = value; }
        }

        public int setSpaceBetweenMorseCharsLength
        {
            get { return spaceBetweenMorseCharactersLength; }
            set { spaceBetweenMorseCharactersLength = value; }
        }

        static Dictionary<char, string> morseAlphabet;

        private void Form1_Load(object sender, EventArgs e)
        {
            updateDictionary();
        }

        private void RealTimeTranslator_CheckedChanged(object sender, EventArgs e)
        {
            if(RealTimeTranslator.Checked)
            {
                ConvertBtn.Visible = false;
                MorseBeepRB.Enabled = false;
                PLtoMorseRB.Checked = true;
            }
            else
            {
                ConvertBtn.Visible = true;
                MorseBeepRB.Enabled = true;
            }
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            if (PLtoMorseRB.Checked)
            {
                ConvertToMorse();
            }
            if(MorseToPLrb.Checked)
            {
                ConvertToPL();
            }
            if(MorseBeepRB.Checked)
            {
                MorseBeep();
            }
        }

        private void PLTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RealTimeTranslator.Checked)
            {
                if (PLtoMorseRB.Checked)
                {
                    ConvertToMorse();
                }
            }
        }

        private void MorseTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RealTimeTranslator.Checked)
            {
                ConvertToPL();
            }
        }

        private void changeCharactersMenu_Click(object sender, EventArgs e)
        {
            Form2 changeChars = new Form2(dot,dash,spaceBetweenWords);
            changeChars.Show();
        }

        private void changeLengthMenu_Click(object sender, EventArgs e)
        {
            Form4 changeLength = new Form4(dotLength,dashLength,spaceBetweenMorseCharactersLength, spaceBetweenCharactersLength, spaceBetweenWordsLength);
            changeLength.Show();
        }

        private void changeFrequencyMenu_Click(object sender, EventArgs e)
        {
            Form3 changeFrequency = new Form3(frequency);
            changeFrequency.Show();
        } 

        public void ConvertToMorse()
        {
            String text = PLTextBox.Text;
            text = text.ToLower();
            String Morse = "";

            foreach (var letter in text)
            {
                if (morseAlphabet.ContainsKey(letter))
                {
                    Morse += morseAlphabet[letter];
                    Morse += " ";
                }
            }
            MorseTextBox.Text = Morse;
        }

        public void ConvertToPL()
        {
            String morse = MorseTextBox.Text;
            String PL = "";
            String splitMorse = "";

            foreach(var ch in morse)
            {
                if(ch != ' ')
                {
                    splitMorse += ch;
                }
                else
                {
                    if(morseAlphabet.ContainsValue(splitMorse))
                    {
                        PL += morseAlphabet.FirstOrDefault(x => x.Value == splitMorse).Key;
                        splitMorse = "";
                    }
                }
            }

            if (morseAlphabet.ContainsValue(splitMorse))
            {
                PL += morseAlphabet.FirstOrDefault(x => x.Value == splitMorse).Key;
                splitMorse = "";
            }

            PLTextBox.Text = PL;
            MorseTextBox.SelectionStart = MorseTextBox.Text.Length;
        }

        public void MorseBeep()
        {
            ConvertToMorse();
            String morse = MorseTextBox.Text;
            timer.Start();
            System.Threading.Thread thread = new System.Threading.Thread(
            new System.Threading.ThreadStart(
            delegate ()
            {
                foreach (var ch in morse)
                {
                    if (ch == Convert.ToChar(dot))
                    {
                        shortBeep = true;
                        Console.Beep(frequency, dotLength);
                        System.Threading.Thread.Sleep(spaceBetweenMorseCharactersLength);
                    }
                    if (ch == Convert.ToChar(dash))
                    {
                        shortBeep = false;
                        Console.Beep(frequency, dashLength);
                        System.Threading.Thread.Sleep(spaceBetweenMorseCharactersLength);
                    }
                    if (ch == Convert.ToChar(spaceBetweenCharacters))
                    {
                        pauseBetweenChars = true;
                        System.Threading.Thread.Sleep(spaceBetweenCharactersLength);
                    }
                    if (ch == Convert.ToChar(spaceBetweenWords))
                    {
                        pauseBetweenWords = true;
                        System.Threading.Thread.Sleep(spaceBetweenWordsLength);
                    }
                }
                timer.Stop();
                timer.Interval = 1;
            }
            ));
            thread.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            gp = e.Graphics;
            Pen pen = new Pen(Color.Black, 5);
            gp.DrawEllipse(pen, 390, 120, 100, 100);
            if (fill == true)
            {
                using (SolidBrush brush = new SolidBrush(Color.Gold))
                {
                    gp.FillEllipse(brush, 390, 120, 100, 100);
                }
            }
            else
            {
                using (SolidBrush brush = new SolidBrush(Color.Transparent))
                {
                    gp.FillEllipse(brush, 390, 120, 100, 100);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pauseBetweenWords == false)
            {
                if (pauseBetweenChars == false)
                {
                    if (pauseChars == false)
                    {
                        if (shortBeep == true)
                        {
                            fill = true;
                            timer.Interval = dotLength;
                            pauseChars = true;
                        }
                        else
                        {
                            fill = true;
                            timer.Interval = dashLength;
                            pauseChars = true;
                        }
                    }
                    else
                    {
                        fill = false;
                        timer.Interval = spaceBetweenMorseCharactersLength;
                        pauseChars = false;
                    }
                }
                else
                {
                    fill = false;
                    timer.Interval = spaceBetweenCharactersLength;
                    pauseBetweenChars = false;
                }
            }
            else
            {
                fill = false;
                timer.Interval = spaceBetweenWordsLength;
                pauseBetweenWords = false;
            }
            this.Invalidate();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            PLTextBox.Text = "";
            MorseTextBox.Text = "";
        }

        public void updateDictionary()
        {
            morseAlphabet = new Dictionary<char, string>{
            {'a', dot + dash },
            {'b', dash + dot + dot + dot},
            {'c', dash + dot + dash + dot},
            {'d', dash + dot + dot},
            {'e', dot},
            {'f', dot + dot + dash + dot},
            {'g', dash + dash + dot},
            {'h', dot + dot + dot + dot},
            {'i', dot + dot},
            {'j', dot + dash + dash + dash},
            {'k', dash + dot + dash},
            {'l', dot + dash + dot + dot},
            {'m', dash + dash},
            {'n', dash + dot},
            {'o', dash + dash + dash},
            {'p', dot + dash + dash + dot},
            {'q', dash + dash + dot + dash},
            {'r', dot + dash + dot},
            {'s', dot + dot + dot},
            {'t', dash},
            {'u', dot + dot + dash},
            {'v', dot + dot + dot + dash},
            {'w', dot + dash + dash},
            {'x', dash + dot + dot + dash},
            {'y', dash + dot + dash + dash},
            {'z', dash + dash + dot + dot},
            {'ą', dot + dash + dot + dash},
            {'ć', dash + dot + dash + dot + dot},
            {'ę', dot + dot + dash + dot + dot},
            {'ł', dot + dash + dot + dot + dash},
            {'ń', dash + dash + dot + dash + dash},
            {'ó', dash + dash + dash + dot},
            {'ś', dot + dot + dot + dash + dot + dot + dot},
            {'ż', dash + dash + dot + dot + dash + dot},
            {'ź', dash + dash + dot + dot + dash},
            { ' ', spaceBetweenWords}
        };
        }
    }
}
