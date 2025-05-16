using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class userbutton : Form
    {
        public userbutton()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuiWifiPercentageAPI1_Tick(object sender, EventArgs e)
        {

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "Habiba" && textPassword.Text=="Pass")
            {
                dashboard db = new dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid UserName OR Password.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnHideandShow.Text == "show")
            {
                btnHideandShow.Text = "hide";
                textPassword.PasswordChar = '\0';
            }
            else
            {
                btnHideandShow.Text = "show";
                textPassword.PasswordChar = '*';

            }


        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void xuiButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
