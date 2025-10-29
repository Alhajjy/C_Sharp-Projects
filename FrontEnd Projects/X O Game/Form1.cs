using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* LOGIC */

        public void NewMatch()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        public void RestartGame()
        {
            the_winner.Text = "In Progress..";
            the_turn.Text = "x";

            button1.Text = "?";
            button2.Text = "?";
            button3.Text = "?";
            button4.Text = "?";
            button5.Text = "?";
            button6.Text = "?";
            button7.Text = "?";
            button8.Text = "?";
            button9.Text = "?";
            NewMatch();
        }

        public void StopThisMatch()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        public bool CheckWinner()
        {
            // افقي
            if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Text != "?")
            {
                the_winner.Text = button1.Text;
                return true;
            }

            if (button4.Text == button5.Text && button4.Text == button6.Text && button4.Text != "?")
            {
                the_winner.Text = button4.Text;
                return true;
            }

            if (button7.Text == button8.Text && button7.Text == button9.Text && button7.Text != "?")
            {
                the_winner.Text = button7.Text;
                return true;
            }

            // شاقولي
            if (button1.Text == button4.Text && button1.Text == button7.Text && button1.Text != "?")
            {
                the_winner.Text = button1.Text;
                return true;
            }

            if (button2.Text == button5.Text && button2.Text == button8.Text && button2.Text != "?")
            {
                the_winner.Text = button2.Text;
                return true;
            }

            if (button3.Text == button6.Text && button3.Text == button9.Text && button3.Text != "?")
            {
                the_winner.Text = button3.Text;
                return true;
            }

            // مائل
            if (button1.Text == button5.Text && button1.Text == button9.Text && button1.Text != "?")
            {
                the_winner.Text = button1.Text;
                return true;
            }

            if (button3.Text == button5.Text && button3.Text == button7.Text && button3.Text != "?")
            {
                the_winner.Text = button3.Text;
                return true;
            }

            return false;
        }

        public void PlayTurn(Button btn)
        {
            if (btn.Text == "?")
            {

                if (the_turn.Text == "x") btn.Text = "x";
                else if (the_turn.Text == "o") btn.Text = "o";
            }
            else
            {
                MessageBox.Show("Wrong Choice");
            }
            if (CheckWinner()) StopThisMatch();


            if (the_turn.Text == "o")
                the_turn.Text = "x";
            else the_turn.Text = "o";

        }

        /* FORM */
        private void Form1_Load(object sender, EventArgs e)
        {
            RestartGame();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Red = Color.FromArgb(255, 255, 25, 0);

            Pen Pen = new Pen(Red);
            Pen.Width = 7;

            // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // عمودي
            e.Graphics.DrawLine(Pen, 680, 50, 680, 280);
            e.Graphics.DrawLine(Pen, 580, 50, 580, 280);

            // افقي
            e.Graphics.DrawLine(Pen, 500, 110, 750, 110);
            e.Graphics.DrawLine(Pen, 500, 210, 750, 210);

        }


        /* BUTTONS */
        private void button_click(object sender, EventArgs e)
        {
            PlayTurn((Button)sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
