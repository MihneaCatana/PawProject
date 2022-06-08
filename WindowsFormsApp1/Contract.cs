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
    public partial class FormContract : Form
    {
        public Contracte mFormContracte;
        
        public FormContract(Contracte c1,ListView l1, ListView l2)
        {
            InitializeComponent();

            foreach (ListViewItem l in l1.Items)
                comboBoxFurnizor.Items.Add(l.Text);

            foreach (ListViewItem l in l2.Items)
                comboBoxMaterial.Items.Add(l.Text);

            mFormContracte = c1;
            if(c1 != null)
            {
                textBoxIdComanda.Text = c1.IdComanda.ToString();
                textBoxNrMateriale.Text = c1.NrMateriale.ToString();    
                comboBoxFurnizor.Text = c1.furnizor.DenumireFirma;
                comboBoxMaterial.Text = c1.material.DenumireMaterial;
            }
        }

        private void buttonAdaugaContract_Click(object sender, EventArgs e)
        {
            if(mFormContracte is null)
                mFormContracte=new Contracte();
            mFormContracte.IdComanda = Convert.ToInt32(textBoxIdComanda.Text);
            mFormContracte.NrMateriale = Convert.ToInt32(textBoxNrMateriale.Text);
            mFormContracte.furnizor = new Furnizori(comboBoxFurnizor.Text, 0, 0);
            mFormContracte.material = new Materiale(comboBoxMaterial.Text, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIdComanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void textBoxNrMateriale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormContract_Load(object sender, EventArgs e)
        {

        }
    }
}
