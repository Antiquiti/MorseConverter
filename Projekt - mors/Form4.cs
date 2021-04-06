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
    public partial class Form4 : Form
    {
        public Form4(int dotLength, int dashLength, int MorseSpace, int SpaceBetweenChars, int SpaceBetweenWords)
        {
            InitializeComponent();
            dotLengthTB.Text = dotLength.ToString();
            dashLengthTB.Text = dashLength.ToString();
            spaceBetweenMorseLettersTB.Text = MorseSpace.ToString();
            spaceBetweenCharactersTB.Text = SpaceBetweenChars.ToString();
            spaceBetweenWordsTB.Text = SpaceBetweenWords.ToString();
        }

        Form1 main = new Form1();        
        private void changeLengthsBtn_Click(object sender, EventArgs e)
        {
            main.setDotLength = Int32.Parse(dotLengthTB.Text);
            main.setDashLength = Int32.Parse(dashLengthTB.Text);
            main.setSpaceBetweenMorseCharsLength = Int32.Parse(spaceBetweenMorseLettersTB.Text);
            main.setSpaceBetweenCharactersLength = Int32.Parse(spaceBetweenCharactersTB.Text);
            main.setSpaceBetweenWordsLength = Int32.Parse(spaceBetweenWordsTB.Text);
            this.Close();
        }
    }
}
