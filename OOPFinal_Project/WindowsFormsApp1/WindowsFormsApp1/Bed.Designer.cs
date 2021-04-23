namespace WindowsFormsApp1
{
    partial class Bed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bed));
            this.tbAvg_Replacement_Rate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateCreated = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbquantity = new System.Windows.Forms.TextBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.lbBed = new System.Windows.Forms.Label();
            this.dgvBedding = new System.Windows.Forms.DataGridView();
            this.bedIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgreplacementrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beddingInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bedRanchDataSet = new WindowsFormsApp1.BedRanchDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bedding_InventoryTableAdapter = new WindowsFormsApp1.BedRanchDataSetTableAdapters.Bedding_InventoryTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBedding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beddingInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedRanchDataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAvg_Replacement_Rate
            // 
            this.tbAvg_Replacement_Rate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAvg_Replacement_Rate.Location = new System.Drawing.Point(155, 211);
            this.tbAvg_Replacement_Rate.Name = "tbAvg_Replacement_Rate";
            this.tbAvg_Replacement_Rate.Size = new System.Drawing.Size(299, 20);
            this.tbAvg_Replacement_Rate.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Price";
            // 
            // DateCreated
            // 
            this.DateCreated.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateCreated.AutoSize = true;
            this.DateCreated.Location = new System.Drawing.Point(31, 227);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(118, 13);
            this.DateCreated.TabIndex = 10;
            this.DateCreated.Text = "Avg Replacement Rate";
            // 
            // LastName
            // 
            this.LastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(103, 71);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(46, 13);
            this.LastName.TabIndex = 6;
            this.LastName.Text = "Quantity";
            // 
            // UserPassword
            // 
            this.UserPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UserPassword.AutoSize = true;
            this.UserPassword.Location = new System.Drawing.Point(105, 19);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(44, 13);
            this.UserPassword.TabIndex = 2;
            this.UserPassword.Text = "Material";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tableLayoutPanel1.Controls.Add(this.tbquantity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbUnit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbPrice, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbAvg_Replacement_Rate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DateCreated, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbMaterial, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserPassword, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 260);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tbquantity
            // 
            this.tbquantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbquantity.Location = new System.Drawing.Point(155, 55);
            this.tbquantity.Name = "tbquantity";
            this.tbquantity.Size = new System.Drawing.Size(299, 20);
            this.tbquantity.TabIndex = 47;
            // 
            // cbUnit
            // 
            this.cbUnit.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.cbUnit.Location = new System.Drawing.Point(155, 107);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(299, 21);
            this.cbUnit.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Unit";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(155, 159);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(299, 20);
            this.tbPrice.TabIndex = 25;
            // 
            // cbMaterial
            // 
            this.cbMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Items.AddRange(new object[] {
            "Staw",
            "Shavings",
            "Cornstalks"});
            this.cbMaterial.Location = new System.Drawing.Point(155, 3);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(299, 21);
            this.cbMaterial.TabIndex = 26;
            // 
            // lbBed
            // 
            this.lbBed.AutoSize = true;
            this.lbBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBed.Location = new System.Drawing.Point(7, 21);
            this.lbBed.Name = "lbBed";
            this.lbBed.Size = new System.Drawing.Size(185, 25);
            this.lbBed.TabIndex = 24;
            this.lbBed.Text = "Bedding Inventory";
            // 
            // dgvBedding
            // 
            this.dgvBedding.AutoGenerateColumns = false;
            this.dgvBedding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBedding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bedIDDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.quanityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.avgreplacementrateDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvBedding.DataSource = this.beddingInventoryBindingSource;
            this.dgvBedding.Location = new System.Drawing.Point(12, 360);
            this.dgvBedding.Name = "dgvBedding";
            this.dgvBedding.Size = new System.Drawing.Size(718, 200);
            this.dgvBedding.TabIndex = 28;
            // 
            // bedIDDataGridViewTextBoxColumn
            // 
            this.bedIDDataGridViewTextBoxColumn.DataPropertyName = "bedID";
            this.bedIDDataGridViewTextBoxColumn.HeaderText = "bedID";
            this.bedIDDataGridViewTextBoxColumn.Name = "bedIDDataGridViewTextBoxColumn";
            this.bedIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            // 
            // quanityDataGridViewTextBoxColumn
            // 
            this.quanityDataGridViewTextBoxColumn.DataPropertyName = "Quanity";
            this.quanityDataGridViewTextBoxColumn.HeaderText = "Quanity";
            this.quanityDataGridViewTextBoxColumn.Name = "quanityDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // avgreplacementrateDataGridViewTextBoxColumn
            // 
            this.avgreplacementrateDataGridViewTextBoxColumn.DataPropertyName = "avg_replacement_rate";
            this.avgreplacementrateDataGridViewTextBoxColumn.HeaderText = "avg_replacement_rate";
            this.avgreplacementrateDataGridViewTextBoxColumn.Name = "avgreplacementrateDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // beddingInventoryBindingSource
            // 
            this.beddingInventoryBindingSource.DataMember = "Bedding_Inventory";
            this.beddingInventoryBindingSource.DataSource = this.bedRanchDataSet;
            // 
            // bedRanchDataSet
            // 
            this.bedRanchDataSet.DataSetName = "BedRanchDataSet";
            this.bedRanchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(555, 37);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(767, 367);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(85, 167);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 277);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // bedding_InventoryTableAdapter
            // 
            this.bedding_InventoryTableAdapter.ClearBeforeFill = true;
            // 
            // Bed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvBedding);
            this.Controls.Add(this.lbBed);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bed";
            this.Text = "Bed";
            this.Load += new System.EventHandler(this.Bed_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBedding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beddingInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedRanchDataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbAvg_Replacement_Rate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateCreated;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbBed;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.DataGridView dgvBedding;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbquantity;
        private BedRanchDataSet bedRanchDataSet;
        private System.Windows.Forms.BindingSource beddingInventoryBindingSource;
        private BedRanchDataSetTableAdapters.Bedding_InventoryTableAdapter bedding_InventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgreplacementrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}