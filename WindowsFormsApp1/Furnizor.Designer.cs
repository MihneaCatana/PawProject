namespace WindowsFormsApp1
{
    partial class FormFurnizor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDurata = new System.Windows.Forms.TextBox();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdaugaFurnizor = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.userControl11 = new WindowsFormsApp1.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADAUGA FURNIZOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Denumire Firma";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Location = new System.Drawing.Point(71, 146);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(172, 23);
            this.textBoxDenumire.TabIndex = 2;
            this.textBoxDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDenumire_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Durata Transport";
            // 
            // textBoxDurata
            // 
            this.textBoxDurata.Location = new System.Drawing.Point(71, 233);
            this.textBoxDurata.Name = "textBoxDurata";
            this.textBoxDurata.Size = new System.Drawing.Size(172, 23);
            this.textBoxDurata.TabIndex = 4;
            this.textBoxDurata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDurata_KeyPress);
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(71, 314);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(172, 23);
            this.textBoxPret.TabIndex = 5;
            this.textBoxPret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPret_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pret Transport";
            // 
            // buttonAdaugaFurnizor
            // 
            this.buttonAdaugaFurnizor.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAdaugaFurnizor.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdaugaFurnizor.Location = new System.Drawing.Point(282, 411);
            this.buttonAdaugaFurnizor.Name = "buttonAdaugaFurnizor";
            this.buttonAdaugaFurnizor.Size = new System.Drawing.Size(113, 41);
            this.buttonAdaugaFurnizor.TabIndex = 7;
            this.buttonAdaugaFurnizor.Text = "Adauga Furnizor";
            this.buttonAdaugaFurnizor.UseVisualStyleBackColor = false;
            this.buttonAdaugaFurnizor.Click += new System.EventHandler(this.buttonAdaugaFurnizor_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Beige;
            this.userControl11.Location = new System.Drawing.Point(267, 14);
            this.userControl11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(140, 42);
            this.userControl11.TabIndex = 10;
            // 
            // FormFurnizor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 504);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.buttonAdaugaFurnizor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.textBoxDurata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDenumire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormFurnizor";
            this.Text = "Furnizor";
            this.Load += new System.EventHandler(this.Furnizor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDurata;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdaugaFurnizor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UserControl1 userControl11;
    }
}