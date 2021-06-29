using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-N8QVAOP; Database=Test_Database_1; Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Accounts_Table Where Username='" + txtUsername.Text + "' and Password ='" + txtPassword.Text + "'", con);
            SqlDataReader sddr = cmd.ExecuteReader();

            if (sddr.Read())
            {
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
