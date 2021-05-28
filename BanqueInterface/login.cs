using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using libBanq;
namespace BanqueInterface
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Data binding 

            string name = textBox1.Text;
            string password = textBox2.Text;

            //connexion 

            String connexionString;
            SqlConnection cnn;
            SqlCommand comd;
            String sql, nom = "" ,pass = "" ;
            SqlDataReader datareader;
            connexionString = @"Data Source=.;Initial Catalog=Banq;Integrated Security=True;Pooling=False";
            cnn = new SqlConnection(connexionString);

            Compte c;
            sql = "select name , password from Users ";
            cnn.Open();

            comd = new SqlCommand(sql, cnn);
            datareader = comd.ExecuteReader();

            while (datareader.Read())
            {
                if (datareader.GetValue(0).ToString() == name && datareader.GetValue(1).ToString() == password)
                {
                    MessageBox.Show("your connected");
                    nom += datareader.GetValue(0).ToString();
                    pass += datareader.GetValue(1).ToString();
                    home frm2 = new home();
                    frm2.Show();
                    frm2.showDetails(nom);
                        this.Hide();
                }


            }

            cnn.Close();
            //if (textBox1.Text == "achraf" && textBox2.Text == "01022001")
            //{
            //    home frm2 = new home();
            //    frm2.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("please enter correct information");
            //    textBox1.Clear();
            //    textBox2.Clear();
            //    textBox1.Focus();


            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            signup sign = new signup();
            sign.Show();
          //  this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void modifiertextbox1(string tex)
        {
            textBox1.Text = tex;
        }
        public void modifiertextbox(string pass , string email)
        {
            textBox1.Text = email ;
            textBox1.Text = pass  ;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
