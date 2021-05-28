using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DeviseLibrary;
namespace BanqueInterface
{
    public partial class transactions : Form
    {
        public transactions()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
            login log = new login();
            log.Show();
           
            this.Hide();
            
        }
        //public void test()
        //{
            
        //    if (comboBox1.Text == "MAD")
        //    {
        //        MAD = new MAD();

        //    }
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
