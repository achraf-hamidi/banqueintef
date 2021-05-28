using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanqueInterface
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myAccount profile = new myAccount();
            profile.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            transactions trans  = new transactions();
            trans.Show();
            this.Hide();
            this.Hide(); 
        }
        public void showDetails(string name)
        {
            label1.Text = "Hello "+name+" to your account !"  ;
        }
    }
}
