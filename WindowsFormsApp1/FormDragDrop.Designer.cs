namespace WindowsFormsApp1
{
    partial class FormDragDrop
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFurnizor = new System.Windows.Forms.TextBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.textBoxNrMateriale = new System.Windows.Forms.TextBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.userControl11 = new WindowsFormsApp1.UserControl1();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(87, 72);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(87, 53);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(18, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Furnizor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numar Materiale";
            // 
            // textBoxFurnizor
            // 
            this.textBoxFurnizor.Location = new System.Drawing.Point(87, 149);
            this.textBoxFurnizor.Name = "textBoxFurnizor";
            this.textBoxFurnizor.ReadOnly = true;
            this.textBoxFurnizor.Size = new System.Drawing.Size(100, 20);
            this.textBoxFurnizor.TabIndex = 5;
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(87, 227);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.ReadOnly = true;
            this.textBoxMaterial.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaterial.TabIndex = 6;
            // 
            // textBoxNrMateriale
            // 
            this.textBoxNrMateriale.Location = new System.Drawing.Point(87, 297);
            this.textBoxNrMateriale.Name = "textBoxNrMateriale";
            this.textBoxNrMateriale.Size = new System.Drawing.Size(100, 20);
            this.textBoxNrMateriale.TabIndex = 7;
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdauga.Location = new System.Drawing.Point(361, 373);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(75, 23);
            this.buttonAdauga.TabIndex = 8;
            this.buttonAdauga.TabStop = false;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Beige;
            this.userControl11.Location = new System.Drawing.Point(332, 13);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(120, 36);
            this.userControl11.TabIndex = 10;
            // 
            // FormDragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.textBoxNrMateriale);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.textBoxFurnizor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.textBoxID);
            this.Name = "FormDragDrop";
            this.Text = "FormDragDrop";
            this.Load += new System.EventHandler(this.FormDragDrop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFurnizor;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.TextBox textBoxNrMateriale;
        private System.Windows.Forms.Button buttonAdauga;
        private UserControl1 userControl11;
    }
}