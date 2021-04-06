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
    public partial class Form3 : Form
    {
        public Form3(int frequency)
        {
            InitializeComponent();
            changeFrequencyTB.Text = Convert.ToString(frequency);
        }

        Form1 main = new Form1();

        private void changeFrequuencyBtn_Click(object sender, EventArgs e)
        {
            main.setFrequency = Int32.Parse(changeFrequencyTB.Text);
            this.Close();
        }
    }
}
