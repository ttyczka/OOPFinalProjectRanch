namespace WindowsFormsApp1
{
    partial class Feed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feed));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cbFood_Type = new System.Windows.Forms.ComboBox();
            this.tbRecommended_Feed_Rate = new System.Windows.Forms.TextBox();
            this.txQuantity = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.Label();
            this.DateCreated = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.ranch_AnimalTableAdapter1 = new WindowsFormsApp1.Ranch_Animal_DataSetTableAdapters.Ranch_AnimalTableAdapter();
            this.lbBed = new System.Windows.Forms.Label();
            this.dgvWWA = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.ranch_Animal_DataSet1 = new WindowsFormsApp1.Ranch_Animal_DataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.feedRanchDataSet = new WindowsFormsApp1.FeedRanchDataSet();
            this.feedInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feed_InventoryTableAdapter = new WindowsFormsApp1.FeedRanchDataSetTableAdapters.Feed_InventoryTableAdapter();
            this.feedIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recommendedfeedrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWWA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranch_Animal_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedRanchDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedInventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbPrice, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbFood_Type, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbRecommended_Feed_Rate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txQuantity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UserPassword, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DateCreated, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbUnit, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 281);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tbPrice
            // 
            this.tbPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPrice.Location = new System.Drawing.Point(193, 171);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(185, 20);
            this.tbPrice.TabIndex = 33;
            // 
            // cbFood_Type
            // 
            this.cbFood_Type.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbFood_Type.FormattingEnabled = true;
            this.cbFood_Type.Items.AddRange(new object[] {
            "Hay",
            "Corn Silage",
            "Grain",
            "Pellets"});
            this.cbFood_Type.Location = new System.Drawing.Point(193, 3);
            this.cbFood_Type.Name = "cbFood_Type";
            this.cbFood_Type.Size = new System.Drawing.Size(185, 21);
            this.cbFood_Type.TabIndex = 33;
            // 
            // tbRecommended_Feed_Rate
            // 
            this.tbRecommended_Feed_Rate.Location = new System.Drawing.Point(193, 227);
            this.tbRecommended_Feed_Rate.Multiline = true;
            this.tbRecommended_Feed_Rate.Name = "tbRecommended_Feed_Rate";
            this.tbRecommended_Feed_Rate.Size = new System.Drawing.Size(185, 20);
            this.tbRecommended_Feed_Rate.TabIndex = 32;
            // 
            // txQuantity
            // 
            this.txQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txQuantity.Location = new System.Drawing.Point(193, 59);
            this.txQuantity.Name = "txQuantity";
            this.txQuantity.Size = new System.Drawing.Size(185, 20);
            this.txQuantity.TabIndex = 14;
            // 
            // UserPassword
            // 
            this.UserPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UserPassword.AutoSize = true;
            this.UserPassword.Location = new System.Drawing.Point(129, 21);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(58, 13);
            this.UserPassword.TabIndex = 2;
            this.UserPassword.Text = "Food Type";
            // 
            // DateCreated
            // 
            this.DateCreated.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateCreated.AutoSize = true;
            this.DateCreated.Location = new System.Drawing.Point(55, 246);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(132, 13);
            this.DateCreated.TabIndex = 10;
            this.DateCreated.Text = "Recommended Feed Rate";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Price";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Unit";
            // 
            // LastName
            // 
            this.LastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(141, 77);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(46, 13);
            this.LastName.TabIndex = 6;
            this.LastName.Text = "Quantity";
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
            this.cbUnit.Location = new System.Drawing.Point(193, 115);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(185, 21);
            this.cbUnit.TabIndex = 46;
            // 
            // ranch_AnimalTableAdapter1
            // 
            this.ranch_AnimalTableAdapter1.ClearBeforeFill = true;
            // 
            // lbBed
            // 
            this.lbBed.AutoSize = true;
            this.lbBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBed.Location = new System.Drawing.Point(12, 18);
            this.lbBed.Name = "lbBed";
            this.lbBed.Size = new System.Drawing.Size(155, 25);
            this.lbBed.TabIndex = 25;
            this.lbBed.Text = "Feed Inventory";
            this.lbBed.Click += new System.EventHandler(this.lbBed_Click);
            // 
            // dgvWWA
            // 
            this.dgvWWA.AutoGenerateColumns = false;
            this.dgvWWA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWWA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feedIDDataGridViewTextBoxColumn,
            this.feedTypeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.recommendedfeedrateDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvWWA.DataSource = this.feedInventoryBindingSource;
            this.dgvWWA.Location = new System.Drawing.Point(21, 369);
            this.dgvWWA.Name = "dgvWWA";
            this.dgvWWA.Size = new System.Drawing.Size(732, 191);
            this.dgvWWA.TabIndex = 29;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 126);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(537, 31);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ranch_Animal_DataSet1
            // 
            this.ranch_Animal_DataSet1.DataSetName = "Ranch_Animal_DataSet";
            this.ranch_Animal_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(458, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 288);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(772, 386);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(85, 167);
            this.tableLayoutPanel2.TabIndex = 46;
            // 
            // feedRanchDataSet
            // 
            this.feedRanchDataSet.DataSetName = "FeedRanchDataSet";
            this.feedRanchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedInventoryBindingSource
            // 
            this.feedInventoryBindingSource.DataMember = "Feed_Inventory";
            this.feedInventoryBindingSource.DataSource = this.feedRanchDataSet;
            // 
            // feed_InventoryTableAdapter
            // 
            this.feed_InventoryTableAdapter.ClearBeforeFill = true;
            // 
            // feedIDDataGridViewTextBoxColumn
            // 
            this.feedIDDataGridViewTextBoxColumn.DataPropertyName = "feedID";
            this.feedIDDataGridViewTextBoxColumn.HeaderText = "feedID";
            this.feedIDDataGridViewTextBoxColumn.Name = "feedIDDataGridViewTextBoxColumn";
            this.feedIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feedTypeDataGridViewTextBoxColumn
            // 
            this.feedTypeDataGridViewTextBoxColumn.DataPropertyName = "Feed_Type";
            this.feedTypeDataGridViewTextBoxColumn.HeaderText = "Feed_Type";
            this.feedTypeDataGridViewTextBoxColumn.Name = "feedTypeDataGridViewTextBoxColumn";
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
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // recommendedfeedrateDataGridViewTextBoxColumn
            // 
            this.recommendedfeedrateDataGridViewTextBoxColumn.DataPropertyName = "recommended_feed_rate";
            this.recommendedfeedrateDataGridViewTextBoxColumn.HeaderText = "recommended_feed_rate";
            this.recommendedfeedrateDataGridViewTextBoxColumn.Name = "recommendedfeedrateDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // Feed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 572);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvWWA);
            this.Controls.Add(this.lbBed);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Feed";
            this.Text = "Feed";
            this.Load += new System.EventHandler(this.Feed_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWWA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranch_Animal_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feedRanchDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedInventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txQuantity;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label DateCreated;
        private System.Windows.Forms.Label label1;
        private Ranch_Animal_DataSetTableAdapters.Ranch_AnimalTableAdapter ranch_AnimalTableAdapter1;
        private System.Windows.Forms.Label lbBed;
        private System.Windows.Forms.DataGridView dgvWWA;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbRecommended_Feed_Rate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Ranch_Animal_DataSet ranch_Animal_DataSet1;
        private System.Windows.Forms.ComboBox cbFood_Type;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FeedRanchDataSet feedRanchDataSet;
        private System.Windows.Forms.BindingSource feedInventoryBindingSource;
        private FeedRanchDataSetTableAdapters.Feed_InventoryTableAdapter feed_InventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendedfeedrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}