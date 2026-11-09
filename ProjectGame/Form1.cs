using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGame
{
    public partial class Form1 : Form
    {
        Player player1 = new Player();
        Player player2 = new Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void lblrounds_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbavatar1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void picAvatar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            
        }

        private void picdefaultPlayer1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPlayer1Name_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayer1Name.Text != string.Empty)
            {
                btnSetupPlayer1.Enabled =true;
            }
            else
            {
                btnSetupPlayer1.Enabled=false;
            }
           


        }

        private void txtPlayer2Name_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayer2Name.Text!=string.Empty) 
            { 
                btnSetupPlayer2.Enabled =true;
            }
            else 
            {
                btnSetupPlayer2.Enabled=false;
            }
        }

        private void btnSetupPlayer1_Click(object sender, EventArgs e)
        {
            player1.Name = txtPlayer1Name.Text;
            if (rbAvatar1.Checked)
            {
                player1.avatars = 1;
                picdefaultPlayer1.Image = Properties.Resources.avatar1;
            }
            else if (rbAvatar2.Checked)
            {
                player1.avatars = 2;
                picdefaultPlayer1.Image = Properties.Resources.avatar2;
            }
            else if (rbAvatar3.Checked)
            {
                player1.avatars = 3;
                picdefaultPlayer1.Image= Properties.Resources.avatar3;
            }
            else
            {
                player1.avatars = 4;
                picdefaultPlayer1.Image = Properties.Resources.avatar4;
            }

            if (player1.avatars == player2.avatars) 
            {
                MessageBox.Show("this avatar is already choosed Please choose another one ");
                player1.avatars = 0;
                picdefaultPlayer1.Image=Properties.Resources.avatar_default;
                return;
            }


        }

        private void btnSetupPlayer2_Click(object sender, EventArgs e)
        {
            player2.Name = txtPlayer2Name.Text;
            if (rbAvatar1.Checked) 
            { 
                player2.avatars = 1;
                picdefaultPlayer2.Image = Properties.Resources.avatar1;
            }
            else if (rbAvatar2.Checked)
            {
                player2.avatars = 2;
                picdefaultPlayer2.Image= Properties.Resources.avatar2;
            }
            else if (rbAvatar3.Checked) 
            { 
                player2.avatars=3;
                picdefaultPlayer2.Image=Properties.Resources.avatar3;
            }
            else 
            {
                player2.avatars = 4;
                picdefaultPlayer2.Image = Properties.Resources.avatar4;
            }
            if (player1.avatars == player2.avatars) 
            {
                MessageBox.Show("this avatar is already choosed please take another one");
                player2.avatars = 0;
                picdefaultPlayer2.Image= Properties.Resources.avatar_default;
            }
        }

       
    }
}
