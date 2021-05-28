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
    public partial class myAccount : Form
    {
        public myAccount()
        {
            InitializeComponent();
        }

        private void myAccount_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            log.modifiertextbox1(" test");
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            login log = new login();
            log.Show();
            log.modifiertextbox1(" test");
            // this.Hide();
        }
    }
}
