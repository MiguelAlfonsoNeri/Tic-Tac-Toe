namespace Tic_Tac_Toe_Project
{
    public partial class Form1 : Form
    {
        String BnValue = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void Bn1_Click(object sender, EventArgs e)
        {
            if (Bn1.Text == "")
            {
                Bn1.Text = BnValue;
                if (BnValue == "X")
                {
                    BnValue = "O";
                }
                else
                {
                     BnValue = "X";
                }
                if  (Bn1.Text == Bn2.Text)
                {
                    if (Bn2.Text == Bn3.Text)
                    {
                        MessageBox.Show(Bn1.Text +" "+ "PLAYER WINS!");
                    }
                }
                if (Bn1.Text == Bn4.Text)
                {
                    if (Bn4.Text == Bn7.Text)
                    {
                        MessageBox.Show(Bn1.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn1.Text == Bn5.Text)
                {
                    if (Bn5.Text == Bn9.Text)
                    {
                        MessageBox.Show(Bn1.Text + " " + "PLAYER WINS!");
                    }
                }

            }
        }

            private void Bn2_Click(object sender, EventArgs e)
        {
            if (Bn2.Text == "")
            {
                Bn2.Text = BnValue;
                if (BnValue == "X")
                {
                    BnValue = "O";
                }
                else
                {
                    BnValue = "X";
                }
                if (Bn2.Text == Bn1.Text)
                {
                    if (Bn1.Text == Bn3.Text)
                    {
                        MessageBox.Show(Bn2.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn2.Text == Bn5.Text)
                {
                    if (Bn5.Text == Bn8.Text)
                    {
                        MessageBox.Show(Bn2.Text + " " + "PLAYER WINS!");
                    }
                }
            }
        }

        private void Bn3_Click(object sender, EventArgs e)
        {
            if (Bn3.Text == "")
            {
                Bn3.Text = BnValue;
                if (BnValue == "X")
                {
                    BnValue = "O";
                }
                else
                {
                    BnValue = "X";
                }
                if (Bn3.Text == Bn2.Text)
                {
                    if (Bn2.Text == Bn1.Text)
                    {
                        MessageBox.Show(Bn3.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn3.Text == Bn5.Text)
                {
                    if (Bn5.Text == Bn7.Text)
                    {
                        MessageBox.Show(Bn2.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn3.Text == Bn6.Text)
                {
                    if (Bn6.Text == Bn9.Text)
                    {
                        MessageBox.Show(Bn3.Text + " " + "PLAYER WINS!");
                    }
                }
            }
        }

        private void Bn4_Click(object sender, EventArgs e)
        {
            if (Bn4.Text == "")
            {
                Bn4.Text = BnValue;
                if (BnValue == "X")
                {
                    BnValue = "O";
                }
                else
                {
                    BnValue = "X";
                }
                if (Bn4.Text == Bn1.Text)
                {
                    if (Bn1.Text == Bn7.Text)
                    {
                        MessageBox.Show(Bn4.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn4.Text == Bn5.Text)
                {
                    if (Bn5.Text == Bn6.Text)
                    {
                        MessageBox.Show(Bn4.Text + " " + "PLAYER WINS!");
                    }
                }
            }
        }

        private void Bn5_Click(object sender, EventArgs e)
        {
            if (Bn5.Text == "")
            {
                Bn5.Text = BnValue;
                if (BnValue == "X")
                {
                    BnValue = "O";
                }
                else
                {
                    BnValue = "X";
                }
                if (Bn5.Text == Bn4.Text)
                {
                    if (Bn4.Text == Bn6.Text)
                    {
                        MessageBox.Show(Bn5.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn5.Text == Bn3.Text)
                {
                    if (Bn3.Text == Bn7.Text)
                    {
                        MessageBox.Show(Bn5.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn5.Text == Bn1.Text)
                {
                    if (Bn1.Text == Bn9.Text)
                    {
                        MessageBox.Show(Bn5.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn5.Text == Bn2.Text)
                {
                    if (Bn2.Text == Bn8.Text)
                    {
                        MessageBox.Show(Bn5.Text + " " + "PLAYER WINS!");
                    }
                }
            }
        }

        private void Bn6_Click(object sender, EventArgs e)
        {
            if (Bn6.Text == "")
            {
                Bn6.Text = BnValue;
                if (BnValue == "X")
                {
                    BnValue = "O";
                }
                else
                {
                    BnValue = "X";
                }
                if (Bn6.Text == Bn5.Text)
                {
                    if (Bn5.Text == Bn4.Text)
                    {
                        MessageBox.Show(Bn6.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn6.Text == Bn3.Text)
                {
                    if (Bn3.Text == Bn9.Text)
                    {
                        MessageBox.Show(Bn2.Text + " " + "PLAYER WINS!");
                    }
                }
            }
        }

        private void Bn7_Click(object sender, EventArgs e)
        {
            if (Bn7.Text == "")
            {
                Bn7.Text = BnValue;
                if (BnValue == "X")
                {
                    BnValue = "O";
                }
                else
                {
                    BnValue = "X";
                }
                if (Bn7.Text == Bn4.Text)
                {
                    if (Bn4.Text == Bn1.Text)
                    {
                        MessageBox.Show(Bn7.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn7.Text == Bn5.Text)
                {
                    if (Bn5.Text == Bn3.Text)
                    {
                        MessageBox.Show(Bn7.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn7.Text == Bn8.Text)
                {
                    if (Bn8.Text == Bn9.Text)
                    {
                        MessageBox.Show(Bn7.Text + " " + "PLAYER WINS!");
                    }
                }
            }
        }

        private void Bn8_Click(object sender, EventArgs e)
        {
            if (Bn8.Text == "")
            {
                Bn8.Text = BnValue;
                if (BnValue == "X")
                {
                    BnValue = "O";
                }
                else
                {
                    BnValue = "X";
                }
                if (Bn8.Text == Bn5.Text)
                {
                    if (Bn5.Text == Bn2.Text)
                    {
                        MessageBox.Show(Bn8.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn8.Text == Bn7.Text)
                {
                    if (Bn7.Text == Bn9.Text)
                    {
                        MessageBox.Show(Bn8.Text + " " + "PLAYER WINS!");
                    }
                }
            }
        }

        private void Bn9_Click(object sender, EventArgs e)
        {
            if (Bn9.Text == "")
            {
                Bn9.Text = BnValue;
                if (BnValue == "X")
                {
                    BnValue = "O";
                }
                else
                {
                    BnValue = "X";
                }
                if (Bn9.Text == Bn8.Text)
                {
                    if (Bn8.Text == Bn7.Text)
                    {
                        MessageBox.Show(Bn9.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn9.Text == Bn6.Text)
                {
                    if (Bn6.Text == Bn3.Text)
                    {
                        MessageBox.Show(Bn9.Text + " " + "PLAYER WINS!");
                    }
                }
                if (Bn9.Text == Bn5.Text)
                {
                    if (Bn5.Text == Bn1.Text)
                    {
                        MessageBox.Show(Bn9.Text + " " + "PLAYER WINS!");
                    }
                }
            }
        }
    }
}