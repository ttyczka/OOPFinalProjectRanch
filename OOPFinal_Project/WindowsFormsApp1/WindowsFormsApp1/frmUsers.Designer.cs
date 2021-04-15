namespace WindowsFormsApp1
{
    partial class Ranch_Users
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtUserPasswd = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.DateCreated = new System.Windows.Forms.Label();
            this.dtbdatecreated = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranchUsersDataSet = new WindowsFormsApp1.RanchUsersDataSet();
            this.usersTableAdapter = new WindowsFormsApp1.RanchUsersDataSetTableAdapters.UsersTableAdapter();
            this.addUser = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranchUsersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtLastname, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUserPasswd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.FirstName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UserPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DateCreated, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtbdatecreated, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 262);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // txtLastname
            // 
            this.txtLastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastname.Location = new System.Drawing.Point(191, 159);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(187, 20);
            this.txtLastname.TabIndex = 14;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstname.Location = new System.Drawing.Point(191, 107);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(187, 20);
            this.txtFirstname.TabIndex = 13;
            // 
            // txtUserPasswd
            // 
            this.txtUserPasswd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserPasswd.Location = new System.Drawing.Point(191, 55);
            this.txtUserPasswd.Name = "txtUserPasswd";
            this.txtUserPasswd.Size = new System.Drawing.Size(187, 20);
            this.txtUserPasswd.TabIndex = 12;
            // 
            // FirstName
            // 
            this.FirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(128, 123);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "First Name";
            // 
            // UserPassword
            // 
            this.UserPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UserPassword.AutoSize = true;
            this.UserPassword.Location = new System.Drawing.Point(107, 71);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(78, 13);
            this.UserPassword.TabIndex = 2;
            this.UserPassword.Text = "User Password";
            // 
            // UserName
            // 
            this.UserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(128, 19);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(57, 13);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "UserName";
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Location = new System.Drawing.Point(191, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(187, 20);
            this.txtUsername.TabIndex = 11;
            // 
            // LastName
            // 
            this.LastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(127, 175);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 6;
            this.LastName.Text = "Last Name";
            // 
            // DateCreated
            // 
            this.DateCreated.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateCreated.AutoSize = true;
            this.DateCreated.Location = new System.Drawing.Point(115, 228);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(70, 13);
            this.DateCreated.TabIndex = 10;
            this.DateCreated.Text = "Date Created";
            // 
            // dtbdatecreated
            // 
            this.dtbdatecreated.Location = new System.Drawing.Point(191, 211);
            this.dtbdatecreated.Name = "dtbdatecreated";
            this.dtbdatecreated.Size = new System.Drawing.Size(187, 20);
            this.dtbdatecreated.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userPasswordDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(143, 353);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            this.userPasswordDataGridViewTextBoxColumn.DataPropertyName = "UserPassword";
            this.userPasswordDataGridViewTextBoxColumn.HeaderText = "UserPassword";
            this.userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.ranchUsersDataSet;
            // 
            // ranchUsersDataSet
            // 
            this.ranchUsersDataSet.DataSetName = "RanchUsersDataSet";
            this.ranchUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(153, 304);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(75, 23);
            this.addUser.TabIndex = 7;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // Ranch_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 569);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Ranch_Users";
            this.Text = "Ranch_Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranchUsersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtUserPasswd;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label DateCreated;
        private System.Windows.Forms.DateTimePicker dtbdatecreated;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RanchUsersDataSet ranchUsersDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private RanchUsersDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addUser;
    }
}