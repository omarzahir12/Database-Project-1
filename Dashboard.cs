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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-N8QVAOP; Database=Test_Database_1; Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Employee ([ID],[FirstName],[Lastname],[Email],[Gender],[Salary],[HireDate],[Address]) VALUES ('"+txtID.Text+ "', '" + txtFN.Text + "', '" + txtLN.Text + "', '" + txtEmail.Text + "', '" + txtGender.Text + "', '" + txtSalary.Text + "', '" + dtHireDate.Value + "', '" + txtAddress.Text + "')", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Saved Successfully!","Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
