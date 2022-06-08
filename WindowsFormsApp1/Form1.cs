using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
            Materiale m1 = new Materiale("Ciment", 200, 40);
            Materiale m2 = new Materiale("Caramida", 80, 30);
            Materiale m3 = new Materiale("Aluminiu", 500, 10);
            Materiale m4 = new Materiale("Cupru", 100, 70);

            ListViewItem lv1 = new ListViewItem(m1.DenumireMaterial);
            lv1.SubItems.Add(m1.Stoc.ToString());
            lv1.SubItems.Add(m1.PretBucata.ToString());
            lv1.Tag = m1;
            listViewMateriale.Items.Add(lv1);

            ListViewItem lv2 = new ListViewItem(m2.DenumireMaterial);
            lv2.SubItems.Add(m2.Stoc.ToString());
            lv2.SubItems.Add(m2.PretBucata.ToString());
            lv2.Tag = m2;
            listViewMateriale.Items.Add(lv2);

            ListViewItem lv3 = new ListViewItem(m3.DenumireMaterial);
            lv3.SubItems.Add(m3.Stoc.ToString());
            lv3.SubItems.Add(m3.PretBucata.ToString());
            lv3.Tag = m3;
            listViewMateriale.Items.Add(lv3);

            ListViewItem lv4 = new ListViewItem(m4.DenumireMaterial);
            lv4.SubItems.Add(m4.Stoc.ToString());
            lv4.SubItems.Add(m4.PretBucata.ToString());
            lv4.Tag = m4;
            listViewMateriale.Items.Add(lv4);

            Furnizori f1 = new Furnizori("Dedeman", 4, 50);
            Furnizori f2 = new Furnizori("Practiker", 7, 30);


            ListViewItem fv1 = new ListViewItem(f1.DenumireFirma);
            fv1.SubItems.Add(f1.DurataTransport.ToString());
            fv1.SubItems.Add(f1.PretTransport.ToString());

            fv1.Tag = f1;
            listViewFurnizori.Items.Add(fv1);

            ListViewItem fv2 = new ListViewItem(f2.DenumireFirma);
            fv2.SubItems.Add(f2.DurataTransport.ToString());
            fv2.SubItems.Add(f2.PretTransport.ToString());

            fv2.Tag = f2;
            listViewFurnizori.Items.Add(fv2);

            Contracte c1 = new Contracte(1, 20, f1, m1);

            ListViewItem ct1 = new ListViewItem(new string[] {c1.IdComanda.ToString(),c1.NrMateriale.ToString(),c1.furnizor.DenumireFirma, c1.material.DenumireMaterial});
            ct1.Tag = c1;
            listViewContracte.Items.Add(ct1);   


        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdaugaMateriale_Click(object sender, EventArgs e)
        {
            Materiale mat = null;
            FormMateriale f1 = new FormMateriale(mat);
            f1.ShowDialog();

            if(f1.DialogResult == DialogResult.OK)
            {
                mat = f1.mFormMateriale;
                ListViewItem lv1 = new ListViewItem();
                lv1 = new ListViewItem(new string[] { mat.DenumireMaterial, mat.Stoc.ToString(), mat.PretBucata.ToString() });
                lv1.Tag = mat;
                listViewMateriale.Items.Add(lv1);
            }
        }

        private void listViewMateriale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdaugaFurnizori_Click(object sender, EventArgs e)
        {
            Furnizori furn = null;
            FormFurnizor f2 = new FormFurnizor(furn);
            f2.ShowDialog();

            if(f2.DialogResult == DialogResult.OK)
            {
                furn = f2.mFormFurnizori;
                ListViewItem lv2 = new ListViewItem(new string[] { furn.DenumireFirma, furn.DurataTransport.ToString(), furn.PretTransport.ToString() } );
                lv2.Tag = furn;
                listViewFurnizori.Items.Add(lv2);
            }
        }

        private void buttonContract_Click(object sender, EventArgs e)
        {
            Contracte c1 = null;
            FormContract formContract = new FormContract(c1, listViewFurnizori, listViewMateriale);
            formContract.ShowDialog();
            
            if(formContract.DialogResult == DialogResult.OK)
            {
                c1 = formContract.mFormContracte;
                ListViewItem lv1 = new ListViewItem(new string[] {c1.IdComanda.ToString(), c1.NrMateriale.ToString(), c1.furnizor.DenumireFirma, c1.material.DenumireMaterial});
                lv1.Tag = c1;
                listViewContracte.Items.Add(lv1);
            }
        }

        private void salveazaBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere materiale (*.mtr)|*.mtr";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
               List<Materiale> lista = new List<Materiale>();
                foreach (ListViewItem lv in listViewMateriale.Items)
                    lista.Add((Materiale)lv.Tag);

                BinaryFormatter serializator = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);

                serializator.Serialize(fisier, lista);
                fisier.Close();
            }
        }

        private void deschideFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere materiale (*.mtr)|*.mtr";
            fd.CheckFileExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Materiale> lista = new List<Materiale>();
                BinaryFormatter serializator = new BinaryFormatter();
                Stream fisier = File.OpenRead(fd.FileName);

                lista.AddRange((List<Materiale>)serializator.Deserialize(fisier));
                fisier.Close ();

                foreach (Materiale mat in lista)
                {
                    ListViewItem lv = new ListViewItem(new string[] { mat.DenumireMaterial, mat.Stoc.ToString(), mat.PretBucata.ToString() });
                    lv.Tag = mat;
                    listViewMateriale.Items.Add(lv);
                }
            }
        }

        private void salveazaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere furnizori (*.xml)|*.xml";
            fd.CheckPathExists = true;

            if(fd.ShowDialog()==DialogResult.OK)
            {
                List<Furnizori> lista = new List<Furnizori>();
                foreach (ListViewItem lv in listViewFurnizori.Items)
                    lista.Add((Furnizori)lv.Tag);

                XmlSerializer serializator = new XmlSerializer(typeof(List<Furnizori>));
                TextWriter writer = new StreamWriter(fd.FileName);
                serializator.Serialize(writer, lista);

                writer.Close();
            }
        }

        private void deschideXMLFurnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere persoane (*.xml)|*.xml";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Furnizori> lista = new List<Furnizori>();

                Stream reader = new FileStream(fd.FileName, FileMode.Open);
                XmlSerializer serializator = new
                        XmlSerializer(typeof(List<Furnizori>));

                lista.AddRange((List<Furnizori>)serializator.Deserialize(reader));

                reader.Close();

                foreach (Furnizori f in lista)
                {
                    ListViewItem lv = new ListViewItem( new string[] {f.DenumireFirma,f.DurataTransport.ToString(),f.PretTransport.ToString()} );
                    lv.Tag = f;
                    listViewFurnizori.Items.Add(lv);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void adaugaMaterialeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAdaugaMateriale_Click(sender, e);
        }

        private void adaugaFurnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAdaugaFurnizori_Click(sender, e);
        }

        private void adaugaContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonContract_Click(sender,e);
        }

        private void listViewFurnizori_MouseDown(object sender, MouseEventArgs e)
        {
            if(listViewFurnizori.SelectedItems.Count > 0)
            {
                listViewFurnizori.DoDragDrop(listViewFurnizori.SelectedItems[0].Tag, DragDropEffects.Link);
            }
        }

        private void listViewMateriale_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(new Furnizori().GetType().ToString()))
            {
                e.Effect = DragDropEffects.Link;
            }
            else 
                e.Effect= DragDropEffects.None;

        }

        private void listViewMateriale_DragDrop(object sender, DragEventArgs e)
        {
            Point punctDinListViewMateriale = listViewMateriale.PointToClient(new Point(e.X,e.Y));
            ListViewItem lv = listViewMateriale.GetItemAt(punctDinListViewMateriale.X, punctDinListViewMateriale.Y);

            if(lv != null)
            {
               Materiale m = (Materiale)lv.Tag;
               Furnizori f = (Furnizori)e.Data.GetData(new Furnizori().GetType().ToString());
                FormDragDrop fdd = new FormDragDrop(m, f);
                fdd.ShowDialog();

                if(fdd.DialogResult == DialogResult.OK)
                {
                    Contracte c1 = fdd.contract;
                    ListViewItem lv1 = new ListViewItem(new string[]  { c1.IdComanda.ToString(), c1.NrMateriale.ToString(), c1.furnizor.DenumireFirma, c1.material.DenumireMaterial  });
                   
                    
                    
                    listViewContracte.Items.Add(lv1);    
                }
            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            e.Graphics.DrawString("Lista Materiale ", new Font("Times New Roman", 30, FontStyle.Bold), Brushes.Black, new Point(230, 100));

            e.Graphics.DrawString(" Denumire ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(140, 200));
            e.Graphics.DrawString(" Stoc ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(250, 200));
            e.Graphics.DrawString(" Pret/Bucata ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(300, 200));


            List<Materiale> lista = new List<Materiale>();

            foreach ( ListViewItem lv in listViewMateriale.Items )
            {
                lista.Add((Materiale)lv.Tag);
            }

            int dist = 1;

            foreach ( Materiale material in lista )
            {
                e.Graphics.DrawString(material.ToString(), new Font("Times New Roman", 12, FontStyle.Italic), Brushes.Black, new Point(150, (2 * dist) + 225));
                dist = dist + 20;
            }
        }

        private void listViewContracte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salveazaFisierFurnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere materiale (*.fzr)| *.fzr";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Furnizori> lista = new List<Furnizori>(); 
                foreach(ListViewItem lv in listViewFurnizori.Items)
                    lista.Add((Furnizori)lv.Tag);

                BinaryFormatter serializator = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);

                serializator.Serialize(fisier, lista);  
                fisier.Close();
            }
        }

        private void deschideFisierFurnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere furnizori (*.fzr)|*.fzr";
            fd.CheckFileExists = true;

            if(fd.ShowDialog(this) == DialogResult.OK)
            {
                List<Furnizori> lista = new List<Furnizori>();
                BinaryFormatter serializator = new BinaryFormatter();
                Stream fisier = File.OpenRead(fd.FileName);

                lista.AddRange((List<Furnizori>)serializator.Deserialize(fisier));
                fisier.Close();

                foreach( Furnizori f in lista )
                {
                    ListViewItem lv = new ListViewItem(new string[] {f.DenumireFirma,f.DurataTransport.ToString(),f.PretTransport.ToString() });
                    lv.Tag = f; 
                   
                    listViewFurnizori.Items.Add(lv);    
                }
            }
        }

        private void salveazaFisierContracteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere contracte (*.ctr) |*.ctr";
            fd.CheckPathExists=true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Contracte> lista = new List<Contracte>();
                foreach(ListViewItem lv in listViewContracte.Items)
                    lista.Add((Contracte)lv.Tag);

                BinaryFormatter serializator = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);

                serializator.Serialize(fisier,lista);
                fisier.Close();
            }
        }

        private void deschideFisierContracteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere contracte (*.ctr) |*.ctr";
            fd.CheckFileExists = true;

            if (fd.ShowDialog(this) == DialogResult.OK)
            {
                List<Contracte> lista = new List<Contracte>();
                BinaryFormatter serializator = new BinaryFormatter();
                Stream fisier = File.OpenRead(fd.FileName);

                lista.AddRange((List<Contracte>)serializator.Deserialize(fisier));
                fisier.Close();

                foreach (Contracte c1 in lista)
                {
                    ListViewItem lv = new ListViewItem(new string[] { c1.IdComanda.ToString(), c1.NrMateriale.ToString(),c1.furnizor.DenumireFirma, c1.material.DenumireMaterial });
                    lv.Tag = c1;

                    listViewContracte.Items.Add(lv);
                }
            }
        }

        private void listViewFurnizori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GraficMateriale_Click(object sender, EventArgs e)
        {
            FormGrafic fg = new FormGrafic(listViewMateriale);
            fg.ShowDialog();
        }

        private void buttonDatabase_Click(object sender, EventArgs e)
        {
            FormDatabase fd = new FormDatabase();
            fd.ShowDialog();
        }
    }
}
