using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticktack
{
    public partial class formticktactoe : Form
    {
        bool trun = true; // when its true trun is X if false trun is Y
        int truncount = 0;

        public formticktactoe()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BY ANUJ THAPA","Tic Tac Toe game");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            if (trun)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            trun = !trun;
            b.Enabled = false;
            truncount++;
            checkForWinner();           
        }
        private void checkForWinner()
        {
            bool winnerIs = false; 
            //horizental winners
           if(btn_X.Text == button1.Text&& button1.Text== button2.Text&& !btn_X.Enabled)
            {
                winnerIs = true;
            }
            if (button3.Text == button4.Text && button4.Text == button5.Text&& !button3.Enabled)
            {
                winnerIs = true;
            }
            if (button5.Text == button6.Text && button6.Text == button7.Text && !button5.Enabled)
            {
                winnerIs = true;
            }
            //vertical winner
            if (btn_X.Text == button3.Text && button3.Text == button6.Text && !btn_X.Enabled)
            {
                winnerIs = true;
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && !button1.Enabled)
            {
                winnerIs = true;
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && !button2.Enabled)
            {
                winnerIs = true;
            }

            //cross winner
            if (btn_X.Text == button4.Text && button4.Text == button8.Text && !btn_X.Enabled)
            {
                winnerIs = true;
            }
            if (button2.Text == button4.Text && button4.Text == button6.Text && !button1.Enabled)
            {
                winnerIs = true;
            }
           

            if (winnerIs)
            {
                disableButtons();
                string winner = "";
                if (trun)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + " Wins!!");
            }
            else
            {
                if(truncount== 9)
                MessageBox.Show("Its Draw!");
            }
        }
        public void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trun = true;
            truncount = 0;
            foreach(Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        }
    }
}
