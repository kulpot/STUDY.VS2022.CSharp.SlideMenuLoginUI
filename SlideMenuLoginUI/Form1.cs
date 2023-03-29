using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideMenuLoginUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        Form2 frm2 = new Form2();

        private void Username_Click(object sender, EventArgs e)
        {
            Username.Clear();
            pictureUsername.BackgroundImage = Properties.Resources.Username2;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            Username.ForeColor = Color.FromArgb(78, 184, 206);

            picturePassword.BackgroundImage = Properties.Resources.password;
            panel2.BackColor = Color.WhiteSmoke;
            Password.ForeColor = Color.WhiteSmoke;

            pictureEmail.BackgroundImage = Properties.Resources.Email;
            panel3.BackColor = Color.WhiteSmoke;
            Email.ForeColor = Color.WhiteSmoke;
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Clear();
            Password.PasswordChar = '*';
            picturePassword.BackgroundImage = Properties.Resources.password2;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            Password.ForeColor = Color.FromArgb(78, 184, 206);

            pictureUsername.BackgroundImage = Properties.Resources.Username;
            panel1.BackColor = Color.WhiteSmoke;
            Username.ForeColor = Color.WhiteSmoke;

            pictureEmail.BackgroundImage = Properties.Resources.Email;
            panel3.BackColor = Color.WhiteSmoke;
            Email.ForeColor = Color.WhiteSmoke;
        }

        private void Email_Click(object sender, EventArgs e)
        {
            Email.Clear();
            pictureEmail.BackgroundImage = Properties.Resources.email2;
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            Email.ForeColor = Color.FromArgb(78, 184, 206);

            pictureUsername.BackgroundImage = Properties.Resources.Username;
            panel1.BackColor = Color.WhiteSmoke;
            Username.ForeColor = Color.WhiteSmoke;

            picturePassword.BackgroundImage = Properties.Resources.password;
            panel2.BackColor = Color.WhiteSmoke;
            Password.ForeColor = Color.WhiteSmoke;
        }

        private void picFB_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frm2.Left += 10;
            if(frm2.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm2.Left -= 10;
            if(frm2.Left <= 525)
            {
                timer2.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
