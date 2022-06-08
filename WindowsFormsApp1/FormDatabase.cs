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

namespace WindowsFormsApp1
{
    public partial class FormDatabase : Form
    {
        //DataSet DsMedici = new DataSet();
        //string stringConexiune = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";
        //string SelectCommand = "select * from dbo.table";
        public FormDatabase()
        {
            InitializeComponent();

        }

        private void IncarcaDate()
        {
            //SqlConnection conexiune = new SqlConnection(stringConexiune);
            //conexiune.Open();
            //SqlDataAdapter adaptor = new SqlDataAdapter(SelectCommand, conexiune);
            //adaptor.Fill(DsMedici, "Table");

            //DsMedici.Tables["Table"].PrimaryKey = new DataColumn[1] { DsMedici.Tables["Table"].Columns["Denumire"] };

            //conexiune.Close();



        }
        private void FormDatabase_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void FormDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'materialeDataSet.Materiale' table. You can move, or remove it, as needed.
            this.materialeTableAdapter.Fill(this.materialeDataSet.Materiale);

        }

        private void materialeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.materialeDataSet);

        }
    }
}
