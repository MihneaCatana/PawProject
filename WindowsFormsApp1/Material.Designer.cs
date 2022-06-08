namespace WindowsFormsApp1
{
    partial class FormMateriale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMateriale));
            this.labelDenumire = new System.Windows.Forms.Label();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.labelStoc = new System.Windows.Forms.Label();
            this.textBoxStoc = new System.Windows.Forms.TextBox();
            this.labelPret = new System.Windows.Forms.Label();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.buttonAdaugare = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.userControl11 = new WindowsFormsApp1.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumire.Location = new System.Drawing.Point(66, 112);
            this.labelDenumire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(103, 15);
            this.labelDenumire.TabIndex = 0;
            this.labelDenumire.Text = "Denumire Material";
            this.labelDenumire.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Location = new System.Drawing.Point(70, 147);
            this.textBoxDenumire.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(200, 23);
            this.textBoxDenumire.TabIndex = 1;
            this.textBoxDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDenumire_Validating);
            // 
            // labelTitlu
            // 
            this.labelTitlu.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.labelTitlu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.Location = new System.Drawing.Point(246, 58);
            this.labelTitlu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(220, 28);
            this.labelTitlu.TabIndex = 2;
            this.labelTitlu.Text = "ADAUGA MATERIAL";
            this.labelTitlu.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelStoc
            // 
            this.labelStoc.AutoSize = true;
            this.labelStoc.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStoc.Location = new System.Drawing.Point(66, 200);
            this.labelStoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStoc.Name = "labelStoc";
            this.labelStoc.Size = new System.Drawing.Size(31, 15);
            this.labelStoc.TabIndex = 3;
            this.labelStoc.Text = "Stoc";
            // 
            // textBoxStoc
            // 
            this.textBoxStoc.Location = new System.Drawing.Point(70, 240);
            this.textBoxStoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStoc.Name = "textBoxStoc";
            this.textBoxStoc.Size = new System.Drawing.Size(200, 23);
            this.textBoxStoc.TabIndex = 4;
            this.textBoxStoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStoc_KeyPress);
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPret.Location = new System.Drawing.Point(66, 299);
            this.labelPret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(69, 15);
            this.labelPret.TabIndex = 5;
            this.labelPret.Text = "Pret/Bucata";
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(70, 345);
            this.textBoxPret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(200, 23);
            this.textBoxPret.TabIndex = 6;
            this.textBoxPret.TextChanged += new System.EventHandler(this.textBoxPret_TextChanged);
            this.textBoxPret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPret_KeyPress);
            // 
            // buttonAdaugare
            // 
            this.buttonAdaugare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdaugare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdaugare.BackgroundImage")));
            this.buttonAdaugare.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdaugare.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugare.Location = new System.Drawing.Point(283, 416);
            this.buttonAdaugare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdaugare.Name = "buttonAdaugare";
            this.buttonAdaugare.Size = new System.Drawing.Size(135, 44);
            this.buttonAdaugare.TabIndex = 7;
            this.buttonAdaugare.Text = "Adauga Material";
            this.buttonAdaugare.UseVisualStyleBackColor = false;
            this.buttonAdaugare.Click += new System.EventHandler(this.buttonAdaugare_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Beige;
            this.userControl11.Location = new System.Drawing.Point(263, 11);
            this.userControl11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(140, 42);
            this.userControl11.TabIndex = 10;
            // 
            // FormMateriale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 513);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.buttonAdaugare);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.textBoxStoc);
            this.Controls.Add(this.labelStoc);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.textBoxDenumire);
            this.Controls.Add(this.labelDenumire);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMateriale";
            this.Text = "AdaugaMaterial";
            this.Load += new System.EventHandler(this.FormMateriale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelStoc;
        private System.Windows.Forms.TextBox textBoxStoc;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.Button buttonAdaugare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UserControl1 userControl11;
    }
}