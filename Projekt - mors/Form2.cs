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
    public partial class Form2 : Form
    {
        public Form2(String dot, String dash, String space)
        {
            InitializeComponent();
            firstCharTB.Text = dot;
            secondCharTB.Text = dash;
            thirdCharTB.Text = space;
        }

        Form1 main = new Form1();

        private void changeCharBtn_Click(object sender, EventArgs e)
        {
            main.setDot = firstCharTB.Text;
            main.setDash = secondCharTB.Text;
            main.setSpaceBetweenWords = thirdCharTB.Text;
            main.updateDictionary();
            this.Close();
        }
    }
}
