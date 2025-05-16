using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Data.Design;


namespace WindowsFormsApp1
{
    public partial class AddNewUser : Form


    {
        bloodManager manager = new bloodManager();


        private List<Person> people = new List<Person>();
        public AddNewUser()
        {
            InitializeComponent();
            txtBG.DataSource = Enum.GetValues(typeof(BloodType));
            txtCase.DataSource = Enum.GetValues(typeof(Case));
            txtGender.DataSource = Enum.GetValues(typeof(Gender));

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e) { }


        private void button4_Click(object sender, EventArgs e)
        {

            int Process = int.Parse(txtBL.Text);
            BloodType bloodType = (BloodType)txtBG.SelectedItem;
            Case @Case = (Case)txtCase.SelectedItem;
            Gender g = (Gender)txtGender.SelectedItem;
            string id = txtID.Text;
            string address = txtAddress.Text;
            string name = txtName.Text;
            if (@Case == Case.Donor)
            {
                Donor d = new Donor(name, address, id, bloodType, g, @Case, Process);
                manager.AddPerson(d);

            }
            else if (Case == Case.Recipint)
            {
                Recipint r = new Recipint(name, address, id, bloodType, g, Case, Process);
                manager.AddPerson(r);
            }















            if (txtID.Text.Trim() == "" || txtName.Text.Trim() == "" || txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter All Data And Try Again!");
                return;
            }

            StreamReader Check = new StreamReader("Data.txt");
            string _Check = Check.ReadToEnd();
            Check.Close();
            if (_Check.Contains(txtName.Text + ";"))
            {
                MessageBox.Show("This Name is Exist,Try again");
                txtName.Focus();


            }
            else
            {
                StreamWriter sw = new StreamWriter("Data.txt", true);
                string donor = txtName.Text + ";"
                + txtAddress.Text + ";" + txtBG.Text + ";" + txtBL.Text + ";"
                + txtGender.Text + ";" + txtID.Text + ";" + txtCase.Text + ";";
                sw.WriteLine(donor);
                sw.Close();
                MessageBox.Show("Person is Added");
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                        c.Text = " ";

                }
                txtName.Focus();

            }
            Dictionary<BloodType, int> totals = manager.GettotalBlood();
            string message = "";
            foreach (var entry in totals)
            {
                message += $"{entry.Key}\t:{entry.Value}\n";
            }
            MessageBox.Show(message, "totalblood", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmShow = new Form();
            TextBox txtShow = new TextBox();
            frmShow.StartPosition = FormStartPosition.CenterScreen;
            frmShow.Font = this.Font; frmShow.Icon = this.Icon;
            frmShow.Icon = this.Icon;
            frmShow.Size = this.Size;
            frmShow.Text = "All Data";
            txtShow.Multiline = true;
            txtShow.Dock = DockStyle.Fill;




            frmShow.Controls.Add(txtShow);
            try
            {
                StreamReader sr = new StreamReader("Data.txt");
                string strAll = sr.ReadToEnd();
                sr.Close();
                txtShow.Text = strAll;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            frmShow.ShowDialog();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_Click(object sender, EventArgs e)
        {

        }

        private void txtBL_ValueChanged(object sender, EventArgs e)
        {










        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtBL.Value = 0;
        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        { }

        private void button1_Click_4(object sender, EventArgs e)
        {

        }

        private void button1_Click_5(object sender, EventArgs e) { }
    }
}
    
       













