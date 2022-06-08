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
    public partial class FormFurnizor : Form
    {
        public Furnizori mFormFurnizori;
        public FormFurnizor(Furnizori f1)
        {
            InitializeComponent();

            mFormFurnizori = f1;

            if(f1 != null)
            {
                textBoxDenumire.Text = f1.DenumireFirma;
                textBoxDurata.Text = f1.DurataTransport.ToString();
                textBoxPret.Text = f1.PretTransport.ToString(); 
            }
        }

        private void buttonAdaugaFurnizor_Click(object sender, EventArgs e)
        {
            if (mFormFurnizori is null)
                mFormFurnizori = new Furnizori();
            mFormFurnizori.DenumireFirma = textBoxDenumire.Text;
            mFormFurnizori.DurataTransport = Convert.ToInt32(textBoxDurata.Text);
            mFormFurnizori.PretTransport = (float)Convert.ToDouble(textBoxPret.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Furnizor_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDenumire_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxDenumire.Text.Length < 2)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxDenumire, "Denumirea este mai scurta de 2 caractere");
            }
            else
            {
                errorProvider1.SetError(textBoxDenumire, "");
            }
        }

        private void textBoxDurata_KeyPress(object sender, KeyPressEventArgs e)
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
