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

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isValid()
        {
            if(txtUsername.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid user name!", "Error");
                return false;
            }
            else if (txtPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid password!", "Error");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isValid())
            {
                using(SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"))
                {
                    string query = "SELECT * FROM Login WHERE Username = '" + txtUsername.Text.Trim() + "' AND Password = '" + txtPassword.Text.Trim() +"'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable(); 
                    sda.Fill(dta);

                    if(dta.Rows.Count == 1)
                    {
                        FormPrincipal f1 = new FormPrincipal();
                        this.Hide();
                        f1.Show();
                    }
                }
            }
        }
    }
}
