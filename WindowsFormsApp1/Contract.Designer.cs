namespace WindowsFormsApp1
{
    partial class FormContract
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdComanda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdaugaContract = new System.Windows.Forms.Button();
            this.comboBoxFurnizor = new System.Windows.Forms.ComboBox();
            this.textBoxNrMateriale = new System.Windows.Forms.TextBox();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.userControl11 = new WindowsFormsApp1.UserControl1();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADAUGA CONTRACT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxIdComanda
            // 
            this.textBoxIdComanda.Location = new System.Drawing.Point(65, 134);
            this.textBoxIdComanda.Name = "textBoxIdComanda";
            this.textBoxIdComanda.Size = new System.Drawing.Size(142, 23);
            this.textBoxIdComanda.TabIndex = 1;
            this.textBoxIdComanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdComanda_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Comanda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numar de materiale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nume Furnizor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nume Material";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonAdaugaContract
            // 
            this.buttonAdaugaContract.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdaugaContract.Location = new System.Drawing.Point(315, 355);
            this.buttonAdaugaContract.Name = "buttonAdaugaContract";
            this.buttonAdaugaContract.Size = new System.Drawing.Size(106, 35);
            this.buttonAdaugaContract.TabIndex = 9;
            this.buttonAdaugaContract.Text = "Adauga Contract";
            this.buttonAdaugaContract.UseVisualStyleBackColor = true;
            this.buttonAdaugaContract.Click += new System.EventHandler(this.buttonAdaugaContract_Click);
            // 
            // comboBoxFurnizor
            // 
            this.comboBoxFurnizor.FormattingEnabled = true;
            this.comboBoxFurnizor.Location = new System.Drawing.Point(520, 134);
            this.comboBoxFurnizor.Name = "comboBoxFurnizor";
            this.comboBoxFurnizor.Size = new System.Drawing.Size(142, 23);
            this.comboBoxFurnizor.TabIndex = 10;
            // 
            // textBoxNrMateriale
            // 
            this.textBoxNrMateriale.Location = new System.Drawing.Point(65, 219);
            this.textBoxNrMateriale.Name = "textBoxNrMateriale";
            this.textBoxNrMateriale.Size = new System.Drawing.Size(142, 23);
            this.textBoxNrMateriale.TabIndex = 4;
            this.textBoxNrMateriale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNrMateriale_KeyPress);
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(520, 219);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(142, 23);
            this.comboBoxMaterial.TabIndex = 11;
            this.comboBoxMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterial_SelectedIndexChanged);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Beige;
            this.userControl11.Location = new System.Drawing.Point(297, 14);
            this.userControl11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(140, 42);
            this.userControl11.TabIndex = 12;
            // 
            // FormContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 465);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.comboBoxFurnizor);
            this.Controls.Add(this.buttonAdaugaContract);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNrMateriale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdComanda);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormContract";
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.FormContract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdComanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAdaugaContract;
        private System.Windows.Forms.ComboBox comboBoxFurnizor;
        private System.Windows.Forms.TextBox textBoxNrMateriale;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private UserControl1 userControl11;
    }
}