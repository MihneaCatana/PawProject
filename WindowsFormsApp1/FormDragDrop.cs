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
    public partial class FormDragDrop : Form
    {
        Materiale m1;
        Furnizori f1;
        public Contracte contract;
        public FormDragDrop(Materiale m, Furnizori f)
        {
            InitializeComponent();
            textBoxFurnizor.Text = f.DenumireFirma;
            textBoxMaterial.Text = m.DenumireMaterial;
            m1 = m;
            f1 = f;
        }

        private void FormDragDrop_Load(object sender, EventArgs e)
        {
            contract = new Contracte();
            contract.furnizor = f1;
            contract.material = m1;
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            if(contract is null)
                contract = new Contracte();
            contract.IdComanda = Convert.ToInt32(textBoxID.Text);
            contract.NrMateriale = Convert.ToInt32(textBoxNrMateriale.Text);

        }
    }
}
