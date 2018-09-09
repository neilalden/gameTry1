using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameTry1
{
    public partial class z : Form
    {
        Random random = new Random();
        string[] trivia;
        public z()
        {
            InitializeComponent();
        }

        public void z_Load(object sender, EventArgs e)
        {
            trivia = new string[6];
            trivia[0] = "How did Adam and Eve feel about their nakedness at first?";
            trivia[1] = "What was Esau doing while Jacob stole his blessing?";
            trivia[2] = "What did Samson find in the carcass of the animal he had killed at a later time?";
            trivia[3] = "How many books of the Bible are named for women?";
            trivia[4] = "How long was Jonah in the whale's stomach";
            trivia[5] = "Which musical instrument did David play for Saul?";
            lblTrivia.Text = trivia[random.Next(0, 6)];
            if (lblTrivia.Text == trivia[0])
            {
                radioA.Text = "They were not ashamed";
                radioB.Text = "They were ashamed";
                radioC.Text = "They were sad";
                radioD.Text = "They were happy";
            }
            else if (lblTrivia.Text == trivia[1])
            {
                radioA.Text = "hunting";
                radioB.Text = "watching";
                radioC.Text = "driving";
                radioD.Text = "diving";
            }
            else if (lblTrivia.Text == trivia[2])
            {
                radioA.Text = "bees and honey";
                radioB.Text = "bread and wine";
                radioC.Text = "meat and bone";
                radioD.Text = "sugar and salt";
            }
            else if (lblTrivia.Text == trivia[3])
            {
                radioA.Text = "one";
                radioB.Text = "two";
                radioC.Text = "three";
                radioD.Text = "four";
            }
            else if (lblTrivia.Text == trivia[4])
            {
                radioA.Text = "one";
                radioB.Text = "two";
                radioC.Text = "three";
                radioD.Text = "four";
            }
            else if (lblTrivia.Text == trivia[5])
            {
                radioA.Text = "harp";
                radioB.Text = "guitar";
                radioC.Text = "trumpet";
                radioD.Text = "horn";
            }
        }
        
        private void btnAns_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lblScore.Text);
            if (lblTrivia.Text == trivia[0])
            {
                if (radioA.Checked == true)
                {
                    score++;
                    lblScore.Text = score.ToString();
                    DialogResult result = MessageBox.Show("correct!", "congrats!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.OK)
                    {
                        do
                        {
                            lblTrivia.Text = trivia[random.Next(0, 6)];
                        }
                        while (trivia[0] == trivia[random.Next(0, 6)]);
                    }
                }
                else
                {
                    DialogResult resulta = MessageBox.Show("wrong answer. Continue? click 'yes' if you want to continue and 'no' if you want to close the program", "try again", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resulta == DialogResult.Yes)
                    {
                        do
                        {
                            lblTrivia.Text = trivia[random.Next(0, 6)];
                        }
                        while (trivia[0] == trivia[random.Next(0, 6)]);
                    }
                    else if (resulta == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }
            else if(lblTrivia.Text == trivia[1])
            {
                if (radioA.Checked == true)
                {
                    score++;
                    lblScore.Text = score.ToString();
                    DialogResult result = MessageBox.Show("correct!", "congrats!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.OK)
                    {
                        do
                        {
                            lblTrivia.Text = trivia[random.Next(0, 6)];
                        }
                        while (trivia[1] == trivia[random.Next(0, 6)]);
                    }
                }
                else
                {
                    DialogResult resulta = MessageBox.Show("wrong answer. Continue? click 'yes' if you want to continue and 'no' if you want to close the program", "try again", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resulta == DialogResult.Yes)
                    {
                        do
                        {
                            lblTrivia.Text = trivia[random.Next(0, 6)];
                        }
                        while (trivia[1] == trivia[random.Next(0, 6)]);
                    }
                    else if (resulta == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }
            else if (lblTrivia.Text == trivia[2])
            {
                if (radioA.Checked == true)
                {
                    score++;
                    lblScore.Text = score.ToString();
                    DialogResult result = MessageBox.Show("correct!", "congrats!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.OK)
                    {
                        do
                        {
                            lblTrivia.Text = trivia[random.Next(0, 6)];
                        }
                        while (trivia[2] == trivia[random.Next(0, 6)]);
                    }
                }
                else
                {
                    DialogResult resulta = MessageBox.Show("wrong answer. Continue? click 'yes' if you want to continue and 'no' if you want to close the program", "try again", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resulta == DialogResult.Yes)
                    {
                        do
                        {
                            lblTrivia.Text = trivia[random.Next(0, 6)];
                        }
                        while (trivia[2] == trivia[random.Next(0, 6)]);
                    }
                    else if (resulta == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }
            else if (lblTrivia.Text == trivia[3])
            {
                if (radioB.Checked == true)
                {
                    score++;
                    lblScore.Text = score.ToString();
                    DialogResult result = MessageBox.Show("correct!", "congrats!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.OK)
                    {
                        do
                        {
                            lblTrivia.Text = trivia[random.Next(0, 6)];
                        }
                        while (trivia[3] == trivia[random.Next(0, 6)]);
                    }
                }
                else
                {
                    DialogResult resulta = MessageBox.Show("wrong answer. Continue? click 'yes' if you want to continue and 'no' if you want to close the program", "try again", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resulta == DialogResult.Yes)
                    {
                        do
                        {
                            lblTrivia.Text = trivia[random.Next(0, 6)];
                        }
                        while (trivia[3] == trivia[random.Next(0, 6)]);
                    }
                    else if (resulta == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }
            else if (lblTrivia.Text == trivia[4])
            {
                if (radioC.Checked == true)
                {
                    score++;
                    lblScore.Text = score.ToString();
                    DialogResult result = MessageBox.Show("correct!", "congrats!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.OK)
                    {
                        do
                        {
                            lblTrivia.Text = trivia[random.Next(0, 6)];
                        }
                        while (trivia[4] == trivia[random.Next(0, 6)]);
                    }
                }
                else
                {
                    DialogResult resulta = MessageBox.Show("wrong answer. Continue? click 'yes' if you want to continue and 'no' if you want to close the program", "try again", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resulta == DialogResult.Yes)
                    {
                        do
                        {
                            lblTrivia.Text = trivia[random.Next(0, 6)];
                        }
                        while (trivia[4] == trivia[random.Next(0, 6)]);
                    }
                    else if (resulta == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }
            else if (lblTrivia.Text == trivia[5])
            {
                if (radioA.Checked == true)
                {
                    score++;
                    lblScore.Text = score.ToString();
                    DialogResult result = MessageBox.Show("correct!", "congrats!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.OK)
                    {
                        do
                        {
                            lblTrivia.Text = trivia[random.Next(0, 6)];
                        }
                        while (trivia[5] == trivia[random.Next(0, 6)]);
                    }
                }
                else
                {
                    DialogResult resulta = MessageBox.Show("wrong answer. Continue? click 'yes' if you want to continue and 'no' if you want to close the program", "try again", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resulta == DialogResult.Yes)
                    {
                        do
                        {
                            lblTrivia.Text = trivia[random.Next(0, 6)];
                        }
                        while (trivia[5] == trivia[random.Next(0, 6)]);
                    }
                    else if (resulta == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }
            if (lblTrivia.Text == trivia[0])
            {
                radioA.Text = "They were not ashamed";
                radioB.Text = "They were ashamed";
                radioC.Text = "They were sad";
                radioD.Text = "They were happy";
            }
            else if (lblTrivia.Text == trivia[1])
            {
                radioA.Text = "hunting";
                radioB.Text = "watching";
                radioC.Text = "driving";
                radioD.Text = "diving";
            }
            else if (lblTrivia.Text == trivia[2])
            {
                radioA.Text = "bees and honey";
                radioB.Text = "bread and wine";
                radioC.Text = "meat and bone";
                radioD.Text = "sugar and salt";
            }
            else if (lblTrivia.Text == trivia[3])
            {
                radioA.Text = "one";
                radioB.Text = "two";
                radioC.Text = "three";
                radioD.Text = "four";
            }
            else if (lblTrivia.Text == trivia[4])
            {
                radioA.Text = "one";
                radioB.Text = "two";
                radioC.Text = "three";
                radioD.Text = "four";
            }
            else if (lblTrivia.Text == trivia[5])
            {
                radioA.Text = "harp";
                radioB.Text = "guitar";
                radioC.Text = "trumpet";
                radioD.Text = "horn";
            }
        }
    }
}
