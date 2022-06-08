namespace WindowsFormsApp1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.buttonAdaugaMateriale = new System.Windows.Forms.Button();
            this.listViewMateriale = new System.Windows.Forms.ListView();
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdaugaFurnizori = new System.Windows.Forms.Button();
            this.listViewFurnizori = new System.Windows.Forms.ListView();
            this.columnHeaderDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDurata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonContract = new System.Windows.Forms.Button();
            this.listViewContracte = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nrMateriale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Furnizor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaFisierFurnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideFisierFurnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaFisierContracteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideFisierContracteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideXMLFurnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaMaterialeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaFurnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.GraficMateriale = new System.Windows.Forms.Button();
            this.buttonDatabase = new System.Windows.Forms.Button();
            this.userControl11 = new WindowsFormsApp1.UserControl1();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdaugaMateriale
            // 
            this.buttonAdaugaMateriale.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdaugaMateriale.Location = new System.Drawing.Point(66, 275);
            this.buttonAdaugaMateriale.Name = "buttonAdaugaMateriale";
            this.buttonAdaugaMateriale.Size = new System.Drawing.Size(135, 34);
            this.buttonAdaugaMateriale.TabIndex = 0;
            this.buttonAdaugaMateriale.Text = "Adauga Materiale";
            this.buttonAdaugaMateriale.UseVisualStyleBackColor = true;
            this.buttonAdaugaMateriale.Click += new System.EventHandler(this.buttonAdaugaMateriale_Click);
            // 
            // listViewMateriale
            // 
            this.listViewMateriale.AllowDrop = true;
            this.listViewMateriale.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Denumire,
            this.Stoc,
            this.Pret});
            this.listViewMateriale.FullRowSelect = true;
            this.listViewMateriale.HideSelection = false;
            this.listViewMateriale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewMateriale.Location = new System.Drawing.Point(12, 70);
            this.listViewMateriale.Name = "listViewMateriale";
            this.listViewMateriale.Size = new System.Drawing.Size(305, 188);
            this.listViewMateriale.TabIndex = 1;
            this.listViewMateriale.UseCompatibleStateImageBehavior = false;
            this.listViewMateriale.View = System.Windows.Forms.View.Details;
            this.listViewMateriale.SelectedIndexChanged += new System.EventHandler(this.listViewMateriale_SelectedIndexChanged);
            this.listViewMateriale.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewMateriale_DragDrop);
            this.listViewMateriale.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewMateriale_DragEnter);
            // 
            // Denumire
            // 
            this.Denumire.Text = "Denumire";
            this.Denumire.Width = 87;
            // 
            // Stoc
            // 
            this.Stoc.Text = "Stoc";
            this.Stoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Stoc.Width = 96;
            // 
            // Pret
            // 
            this.Pret.Text = "Pret/Bucata";
            this.Pret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pret.Width = 119;
            // 
            // buttonAdaugaFurnizori
            // 
            this.buttonAdaugaFurnizori.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdaugaFurnizori.Location = new System.Drawing.Point(594, 275);
            this.buttonAdaugaFurnizori.Name = "buttonAdaugaFurnizori";
            this.buttonAdaugaFurnizori.Size = new System.Drawing.Size(132, 34);
            this.buttonAdaugaFurnizori.TabIndex = 2;
            this.buttonAdaugaFurnizori.Text = "Adauga Furnizori";
            this.buttonAdaugaFurnizori.UseVisualStyleBackColor = true;
            this.buttonAdaugaFurnizori.Click += new System.EventHandler(this.buttonAdaugaFurnizori_Click);
            // 
            // listViewFurnizori
            // 
            this.listViewFurnizori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDenumire,
            this.columnHeaderDurata,
            this.columnHeaderPret});
            this.listViewFurnizori.FullRowSelect = true;
            this.listViewFurnizori.HideSelection = false;
            this.listViewFurnizori.Location = new System.Drawing.Point(503, 70);
            this.listViewFurnizori.Name = "listViewFurnizori";
            this.listViewFurnizori.Size = new System.Drawing.Size(279, 175);
            this.listViewFurnizori.TabIndex = 3;
            this.listViewFurnizori.UseCompatibleStateImageBehavior = false;
            this.listViewFurnizori.View = System.Windows.Forms.View.Details;
            this.listViewFurnizori.SelectedIndexChanged += new System.EventHandler(this.listViewFurnizori_SelectedIndexChanged);
            this.listViewFurnizori.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewFurnizori_MouseDown);
            // 
            // columnHeaderDenumire
            // 
            this.columnHeaderDenumire.Text = "Denumire";
            this.columnHeaderDenumire.Width = 87;
            // 
            // columnHeaderDurata
            // 
            this.columnHeaderDurata.Text = "Durata";
            this.columnHeaderDurata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDurata.Width = 96;
            // 
            // columnHeaderPret
            // 
            this.columnHeaderPret.Text = "Pret Trans";
            this.columnHeaderPret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPret.Width = 91;
            // 
            // buttonContract
            // 
            this.buttonContract.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonContract.Location = new System.Drawing.Point(302, 483);
            this.buttonContract.Name = "buttonContract";
            this.buttonContract.Size = new System.Drawing.Size(142, 48);
            this.buttonContract.TabIndex = 4;
            this.buttonContract.Text = "Semneaza contract";
            this.buttonContract.UseVisualStyleBackColor = true;
            this.buttonContract.Click += new System.EventHandler(this.buttonContract_Click);
            // 
            // listViewContracte
            // 
            this.listViewContracte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.nrMateriale,
            this.Furnizor,
            this.Material});
            this.listViewContracte.HideSelection = false;
            this.listViewContracte.Location = new System.Drawing.Point(228, 307);
            this.listViewContracte.Name = "listViewContracte";
            this.listViewContracte.Size = new System.Drawing.Size(287, 158);
            this.listViewContracte.TabIndex = 5;
            this.listViewContracte.UseCompatibleStateImageBehavior = false;
            this.listViewContracte.View = System.Windows.Forms.View.Details;
            this.listViewContracte.SelectedIndexChanged += new System.EventHandler(this.listViewContracte_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // nrMateriale
            // 
            this.nrMateriale.Text = "nrMateriale";
            this.nrMateriale.Width = 83;
            // 
            // Furnizor
            // 
            this.Furnizor.DisplayIndex = 3;
            this.Furnizor.Text = "Furnizor";
            this.Furnizor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Furnizor.Width = 73;
            // 
            // Material
            // 
            this.Material.DisplayIndex = 2;
            this.Material.Text = "Material";
            this.Material.Width = 67;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem,
            this.deschideFisierToolStripMenuItem,
            this.salveazaFisierFurnizoriToolStripMenuItem,
            this.deschideFisierFurnizoriToolStripMenuItem,
            this.salveazaFisierContracteToolStripMenuItem,
            this.deschideFisierContracteToolStripMenuItem});
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.salveazaToolStripMenuItem.Text = "&Binar";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.sToolStripMenuItem.Text = "SalveazaFisierMateriale";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.salveazaBinarToolStripMenuItem_Click);
            // 
            // deschideFisierToolStripMenuItem
            // 
            this.deschideFisierToolStripMenuItem.Name = "deschideFisierToolStripMenuItem";
            this.deschideFisierToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.deschideFisierToolStripMenuItem.Text = "DeschideFisierMateriale";
            this.deschideFisierToolStripMenuItem.Click += new System.EventHandler(this.deschideFisierToolStripMenuItem_Click);
            // 
            // salveazaFisierFurnizoriToolStripMenuItem
            // 
            this.salveazaFisierFurnizoriToolStripMenuItem.Name = "salveazaFisierFurnizoriToolStripMenuItem";
            this.salveazaFisierFurnizoriToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.salveazaFisierFurnizoriToolStripMenuItem.Text = "SalveazaFisierFurnizori";
            this.salveazaFisierFurnizoriToolStripMenuItem.Click += new System.EventHandler(this.salveazaFisierFurnizoriToolStripMenuItem_Click);
            // 
            // deschideFisierFurnizoriToolStripMenuItem
            // 
            this.deschideFisierFurnizoriToolStripMenuItem.Name = "deschideFisierFurnizoriToolStripMenuItem";
            this.deschideFisierFurnizoriToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.deschideFisierFurnizoriToolStripMenuItem.Text = "DeschideFisierFurnizori";
            this.deschideFisierFurnizoriToolStripMenuItem.Click += new System.EventHandler(this.deschideFisierFurnizoriToolStripMenuItem_Click);
            // 
            // salveazaFisierContracteToolStripMenuItem
            // 
            this.salveazaFisierContracteToolStripMenuItem.Name = "salveazaFisierContracteToolStripMenuItem";
            this.salveazaFisierContracteToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.salveazaFisierContracteToolStripMenuItem.Text = "SalveazaFisierContracte";
            this.salveazaFisierContracteToolStripMenuItem.Click += new System.EventHandler(this.salveazaFisierContracteToolStripMenuItem_Click);
            // 
            // deschideFisierContracteToolStripMenuItem
            // 
            this.deschideFisierContracteToolStripMenuItem.Name = "deschideFisierContracteToolStripMenuItem";
            this.deschideFisierContracteToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.deschideFisierContracteToolStripMenuItem.Text = "DeschideFisierContracte";
            this.deschideFisierContracteToolStripMenuItem.Click += new System.EventHandler(this.deschideFisierContracteToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaXMLToolStripMenuItem,
            this.deschideXMLFurnizoriToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.xMLToolStripMenuItem.Text = "&XML";
            // 
            // salveazaXMLToolStripMenuItem
            // 
            this.salveazaXMLToolStripMenuItem.Name = "salveazaXMLToolStripMenuItem";
            this.salveazaXMLToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.salveazaXMLToolStripMenuItem.Text = "SalveazaXMLFurnizori";
            this.salveazaXMLToolStripMenuItem.Click += new System.EventHandler(this.salveazaXMLToolStripMenuItem_Click);
            // 
            // deschideXMLFurnizoriToolStripMenuItem
            // 
            this.deschideXMLFurnizoriToolStripMenuItem.Name = "deschideXMLFurnizoriToolStripMenuItem";
            this.deschideXMLFurnizoriToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.deschideXMLFurnizoriToolStripMenuItem.Text = "DeschideXMLFurnizori";
            this.deschideXMLFurnizoriToolStripMenuItem.Click += new System.EventHandler(this.deschideXMLFurnizoriToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaMaterialeToolStripMenuItem,
            this.adaugaFurnizoriToolStripMenuItem,
            this.adaugaContractToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // adaugaMaterialeToolStripMenuItem
            // 
            this.adaugaMaterialeToolStripMenuItem.Name = "adaugaMaterialeToolStripMenuItem";
            this.adaugaMaterialeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.adaugaMaterialeToolStripMenuItem.Text = "Adauga Materiale";
            this.adaugaMaterialeToolStripMenuItem.Click += new System.EventHandler(this.adaugaMaterialeToolStripMenuItem_Click);
            // 
            // adaugaFurnizoriToolStripMenuItem
            // 
            this.adaugaFurnizoriToolStripMenuItem.Name = "adaugaFurnizoriToolStripMenuItem";
            this.adaugaFurnizoriToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.adaugaFurnizoriToolStripMenuItem.Text = "Adauga Furnizori";
            this.adaugaFurnizoriToolStripMenuItem.Click += new System.EventHandler(this.adaugaFurnizoriToolStripMenuItem_Click);
            // 
            // adaugaContractToolStripMenuItem
            // 
            this.adaugaContractToolStripMenuItem.Name = "adaugaContractToolStripMenuItem";
            this.adaugaContractToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.adaugaContractToolStripMenuItem.Text = "Adauga Contract";
            this.adaugaContractToolStripMenuItem.Click += new System.EventHandler(this.adaugaContractToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // GraficMateriale
            // 
            this.GraficMateriale.Location = new System.Drawing.Point(639, 434);
            this.GraficMateriale.Name = "GraficMateriale";
            this.GraficMateriale.Size = new System.Drawing.Size(107, 51);
            this.GraficMateriale.TabIndex = 7;
            this.GraficMateriale.Text = "Grafic Materiale";
            this.GraficMateriale.UseVisualStyleBackColor = true;
            this.GraficMateriale.Click += new System.EventHandler(this.GraficMateriale_Click);
            // 
            // buttonDatabase
            // 
            this.buttonDatabase.Location = new System.Drawing.Point(639, 352);
            this.buttonDatabase.Name = "buttonDatabase";
            this.buttonDatabase.Size = new System.Drawing.Size(107, 49);
            this.buttonDatabase.TabIndex = 8;
            this.buttonDatabase.Text = "Database";
            this.buttonDatabase.UseVisualStyleBackColor = true;
            this.buttonDatabase.Click += new System.EventHandler(this.buttonDatabase_Click);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Beige;
            this.userControl11.Location = new System.Drawing.Point(344, 37);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(120, 36);
            this.userControl11.TabIndex = 9;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(794, 570);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.buttonDatabase);
            this.Controls.Add(this.GraficMateriale);
            this.Controls.Add(this.listViewContracte);
            this.Controls.Add(this.buttonContract);
            this.Controls.Add(this.listViewFurnizori);
            this.Controls.Add(this.buttonAdaugaFurnizori);
            this.Controls.Add(this.listViewMateriale);
            this.Controls.Add(this.buttonAdaugaMateriale);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "Aprovizion";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdaugaMateriale;
        private System.Windows.Forms.ListView listViewMateriale;
        private System.Windows.Forms.ColumnHeader Denumire;
        private System.Windows.Forms.ColumnHeader Stoc;
        private System.Windows.Forms.ColumnHeader Pret;
        private System.Windows.Forms.Button buttonAdaugaFurnizori;
        private System.Windows.Forms.ListView listViewFurnizori;
        private System.Windows.Forms.ColumnHeader columnHeaderDenumire;
        private System.Windows.Forms.ColumnHeader columnHeaderDurata;
        private System.Windows.Forms.ColumnHeader columnHeaderPret;
        private System.Windows.Forms.Button buttonContract;
        private System.Windows.Forms.ListView listViewContracte;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Furnizor;
        private System.Windows.Forms.ColumnHeader Material;
        private System.Windows.Forms.ColumnHeader nrMateriale;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideXMLFurnizoriToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaMaterialeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaFurnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem salveazaFisierFurnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideFisierFurnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaFisierContracteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideFisierContracteToolStripMenuItem;
        private System.Windows.Forms.Button GraficMateriale;
        private System.Windows.Forms.Button buttonDatabase;
        private UserControl1 userControl11;
    }
}

