using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_immod
{
    public partial class Form1 : Form
    {
        private DiceRoll diceRoll;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetAnswerOrb_Click(object sender, EventArgs e)
        {          
            ReadData();
            labelRes.Text = diceRoll.GetRolledSide().ToString(); 
        }

        void ReadData()
        {
            var N = (int)numericUpDown1.Value;
            diceRoll = new DiceRoll(N);
            diceRoll.GenerateProbArray();
        }

    }
}
