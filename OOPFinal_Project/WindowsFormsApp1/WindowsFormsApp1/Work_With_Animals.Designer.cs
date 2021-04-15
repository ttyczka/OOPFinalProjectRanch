namespace WindowsFormsApp1
{
    partial class Work_With_Animals
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.dgvWWA = new System.Windows.Forms.DataGridView();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbSpecies = new System.Windows.Forms.ComboBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.lbSpecies = new System.Windows.Forms.Label();
            this.lbAction = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbUnit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbBed = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wWADataSet = new WindowsFormsApp1.WWADataSet();
            this.workWithAnimalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.work_With_AnimalsTableAdapter = new WindowsFormsApp1.WWADataSetTableAdapters.Work_With_AnimalsTableAdapter();
            this.workIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWWA)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wWADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWithAnimalsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(572, 206);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(572, 240);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(653, 206);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // cbAction
            // 
            this.cbAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "Feed",
            "Bed",
            "Distribute Mineral Tub"});
            this.cbAction.Location = new System.Drawing.Point(182, 46);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(174, 21);
            this.cbAction.TabIndex = 9;
            // 
            // dgvWWA
            // 
            this.dgvWWA.AutoGenerateColumns = false;
            this.dgvWWA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWWA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workIDDataGridViewTextBoxColumn,
            this.speciesDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvWWA.DataSource = this.workWithAnimalsBindingSource;
            this.dgvWWA.Location = new System.Drawing.Point(28, 288);
            this.dgvWWA.Name = "dgvWWA";
            this.dgvWWA.Size = new System.Drawing.Size(740, 150);
            this.dgvWWA.TabIndex = 10;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(528, 28);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 11;
            // 
            // cbType
            // 
            this.cbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Hay",
            "Staw",
            "Corn Silage",
            "Shavings",
            "Cornstalks",
            "Grain",
            "Pellets"});
            this.cbType.Location = new System.Drawing.Point(182, 89);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(174, 21);
            this.cbType.TabIndex = 12;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // cbSpecies
            // 
            this.cbSpecies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpecies.FormattingEnabled = true;
            this.cbSpecies.Items.AddRange(new object[] {
            "Bulls ",
            "Calves",
            "Chickens",
            "Chicks",
            "Cows",
            "Pigs",
            "Horses",
            "Goats "});
            this.cbSpecies.Location = new System.Drawing.Point(182, 3);
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.Size = new System.Drawing.Size(174, 21);
            this.cbSpecies.TabIndex = 13;
            this.cbSpecies.SelectedIndexChanged += new System.EventHandler(this.cbSpecies_SelectedIndexChanged);
            // 
            // cbUnit
            // 
            this.cbUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "Handful ",
            "Small Pale",
            "5 Gallon Bucket ",
            "Skidloader Bucket ",
            "Hand Scoop",
            "Round Bale",
            "Wrapped Round Bale",
            "Square Bale"});
            this.cbUnit.Location = new System.Drawing.Point(182, 175);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(174, 21);
            this.cbUnit.TabIndex = 14;
            // 
            // lbSpecies
            // 
            this.lbSpecies.AutoSize = true;
            this.lbSpecies.Location = new System.Drawing.Point(3, 0);
            this.lbSpecies.Name = "lbSpecies";
            this.lbSpecies.Size = new System.Drawing.Size(45, 13);
            this.lbSpecies.TabIndex = 15;
            this.lbSpecies.Text = "Species";
            // 
            // lbAction
            // 
            this.lbAction.AutoSize = true;
            this.lbAction.Location = new System.Drawing.Point(3, 43);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(37, 13);
            this.lbAction.TabIndex = 16;
            this.lbAction.Text = "Action";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(3, 129);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(46, 13);
            this.lbQuantity.TabIndex = 17;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(3, 172);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(26, 13);
            this.lbUnit.TabIndex = 18;
            this.lbUnit.Text = "Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(3, 86);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(31, 13);
            this.lbType.TabIndex = 19;
            this.lbType.Text = "Type";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbUnit, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbUnit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbSpecies, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbAction, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbAction, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbQuantity, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbSpecies, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbType, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 219);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // lbBed
            // 
            this.lbBed.AutoSize = true;
            this.lbBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBed.Location = new System.Drawing.Point(12, 12);
            this.lbBed.Name = "lbBed";
            this.lbBed.Size = new System.Drawing.Size(222, 25);
            this.lbBed.TabIndex = 25;
            this.lbBed.Text = "Working With Animals";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(182, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 44;
            // 
            // wWADataSet
            // 
            this.wWADataSet.DataSetName = "WWADataSet";
            this.wWADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workWithAnimalsBindingSource
            // 
            this.workWithAnimalsBindingSource.DataMember = "Work_With_Animals";
            this.workWithAnimalsBindingSource.DataSource = this.wWADataSet;
            // 
            // work_With_AnimalsTableAdapter
            // 
            this.work_With_AnimalsTableAdapter.ClearBeforeFill = true;
            // 
            // workIDDataGridViewTextBoxColumn
            // 
            this.workIDDataGridViewTextBoxColumn.DataPropertyName = "workID";
            this.workIDDataGridViewTextBoxColumn.HeaderText = "workID";
            this.workIDDataGridViewTextBoxColumn.Name = "workIDDataGridViewTextBoxColumn";
            this.workIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // Work_With_Animals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbBed);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvWWA);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Work_With_Animals";
            this.Text = "Work_With_Animals";
            this.Load += new System.EventHandler(this.Work_With_Animals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWWA)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wWADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWithAnimalsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.DataGridView dgvWWA;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbSpecies;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label lbSpecies;
        private System.Windows.Forms.Label lbAction;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbBed;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private WWADataSet wWADataSet;
        private System.Windows.Forms.BindingSource workWithAnimalsBindingSource;
        private WWADataSetTableAdapters.Work_With_AnimalsTableAdapter work_With_AnimalsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}