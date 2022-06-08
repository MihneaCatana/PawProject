namespace WindowsFormsApp1
{
    partial class FormDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatabase));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label denumireLabel;
            System.Windows.Forms.Label stocLabel;
            System.Windows.Forms.Label pretLabel;
            this.materialeDataSet = new WindowsFormsApp1.MaterialeDataSet();
            this.materialeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialeTableAdapter = new WindowsFormsApp1.MaterialeDataSetTableAdapters.MaterialeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.MaterialeDataSetTableAdapters.TableAdapterManager();
            this.materialeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.materialeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.stocTextBox = new System.Windows.Forms.TextBox();
            this.pretTextBox = new System.Windows.Forms.TextBox();
            this.materialeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            denumireLabel = new System.Windows.Forms.Label();
            stocLabel = new System.Windows.Forms.Label();
            pretLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.materialeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialeBindingNavigator)).BeginInit();
            this.materialeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialeDataSet
            // 
            this.materialeDataSet.DataSetName = "MaterialeDataSet";
            this.materialeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialeBindingSource
            // 
            this.materialeBindingSource.DataMember = "Materiale";
            this.materialeBindingSource.DataSource = this.materialeDataSet;
            // 
            // materialeTableAdapter
            // 
            this.materialeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaterialeTableAdapter = this.materialeTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.MaterialeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // materialeBindingNavigator
            // 
            this.materialeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.materialeBindingNavigator.BindingSource = this.materialeBindingSource;
            this.materialeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.materialeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.materialeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.materialeBindingNavigatorSaveItem});
            this.materialeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.materialeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.materialeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.materialeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.materialeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.materialeBindingNavigator.Name = "materialeBindingNavigator";
            this.materialeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.materialeBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.materialeBindingNavigator.TabIndex = 1;
            this.materialeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // materialeBindingNavigatorSaveItem
            // 
            this.materialeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.materialeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("materialeBindingNavigatorSaveItem.Image")));
            this.materialeBindingNavigatorSaveItem.Name = "materialeBindingNavigatorSaveItem";
            this.materialeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.materialeBindingNavigatorSaveItem.Text = "Save Data";
            this.materialeBindingNavigatorSaveItem.Click += new System.EventHandler(this.materialeBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(43, 80);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialeBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(104, 77);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // denumireLabel
            // 
            denumireLabel.AutoSize = true;
            denumireLabel.Location = new System.Drawing.Point(43, 106);
            denumireLabel.Name = "denumireLabel";
            denumireLabel.Size = new System.Drawing.Size(55, 13);
            denumireLabel.TabIndex = 4;
            denumireLabel.Text = "Denumire:";
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialeBindingSource, "Denumire", true));
            this.denumireTextBox.Location = new System.Drawing.Point(104, 103);
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.Size = new System.Drawing.Size(100, 20);
            this.denumireTextBox.TabIndex = 5;
            // 
            // stocLabel
            // 
            stocLabel.AutoSize = true;
            stocLabel.Location = new System.Drawing.Point(43, 132);
            stocLabel.Name = "stocLabel";
            stocLabel.Size = new System.Drawing.Size(32, 13);
            stocLabel.TabIndex = 6;
            stocLabel.Text = "Stoc:";
            // 
            // stocTextBox
            // 
            this.stocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialeBindingSource, "Stoc", true));
            this.stocTextBox.Location = new System.Drawing.Point(104, 129);
            this.stocTextBox.Name = "stocTextBox";
            this.stocTextBox.Size = new System.Drawing.Size(100, 20);
            this.stocTextBox.TabIndex = 7;
            // 
            // pretLabel
            // 
            pretLabel.AutoSize = true;
            pretLabel.Location = new System.Drawing.Point(43, 158);
            pretLabel.Name = "pretLabel";
            pretLabel.Size = new System.Drawing.Size(29, 13);
            pretLabel.TabIndex = 8;
            pretLabel.Text = "Pret:";
            // 
            // pretTextBox
            // 
            this.pretTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialeBindingSource, "Pret", true));
            this.pretTextBox.Location = new System.Drawing.Point(104, 155);
            this.pretTextBox.Name = "pretTextBox";
            this.pretTextBox.Size = new System.Drawing.Size(100, 20);
            this.pretTextBox.TabIndex = 9;
            // 
            // materialeDataGridView
            // 
            this.materialeDataGridView.AutoGenerateColumns = false;
            this.materialeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.materialeDataGridView.DataSource = this.materialeBindingSource;
            this.materialeDataGridView.Location = new System.Drawing.Point(345, 48);
            this.materialeDataGridView.Name = "materialeDataGridView";
            this.materialeDataGridView.Size = new System.Drawing.Size(443, 360);
            this.materialeDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn2.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Stoc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Stoc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pret";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pret";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FormDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialeDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(denumireLabel);
            this.Controls.Add(this.denumireTextBox);
            this.Controls.Add(stocLabel);
            this.Controls.Add(this.stocTextBox);
            this.Controls.Add(pretLabel);
            this.Controls.Add(this.pretTextBox);
            this.Controls.Add(this.materialeBindingNavigator);
            this.Name = "FormDatabase";
            this.Text = "FormDatabase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDatabase_FormClosing);
            this.Load += new System.EventHandler(this.FormDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialeBindingNavigator)).EndInit();
            this.materialeBindingNavigator.ResumeLayout(false);
            this.materialeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialeDataSet materialeDataSet;
        private System.Windows.Forms.BindingSource materialeBindingSource;
        private MaterialeDataSetTableAdapters.MaterialeTableAdapter materialeTableAdapter;
        private MaterialeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator materialeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton materialeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox denumireTextBox;
        private System.Windows.Forms.TextBox stocTextBox;
        private System.Windows.Forms.TextBox pretTextBox;
        private System.Windows.Forms.DataGridView materialeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}