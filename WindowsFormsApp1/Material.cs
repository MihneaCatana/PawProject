using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMateriale : Form
    {
        public Materiale mFormMateriale;
        public FormMateriale(Materiale m)
        {
            InitializeComponent();
            
            mFormMateriale = m;

            if(m!=null)
            {
                textBoxDenumire.Text = m.DenumireMaterial;
                textBoxStoc.Text = m.Stoc.ToString();
                textBoxPret.Text = m.PretBucata.ToString();
            }
        }

        private void buttonAdaugare_Click(object sender, EventArgs e)
        {
            if (mFormMateriale is null)
                mFormMateriale = new Materiale();
            mFormMateriale.DenumireMaterial = textBoxDenumire.Text;
            mFormMateriale.Stoc = Convert.ToInt32(textBoxStoc.Text);    
            mFormMateriale.PretBucata = (float)Convert.ToDouble(textBoxPret.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormMateriale_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDenumire_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxDenumire.Text.Length <3 )
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxDenumire, "Denumirea este mai scurta de 3 caractere");
            }
            else
            {
                errorProvider1.SetError(textBoxDenumire, "");
            }
        }

        private void textBoxStoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ((char)Keys.Back)) 
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void textBoxPret_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ',' || e.KeyChar == ((char)Keys.Back))
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }
    }
}
