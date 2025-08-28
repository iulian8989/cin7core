namespace CIN7Core_MFT_EDI.Forms
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbFTPdeets = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFTPPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFTPDirectory = new System.Windows.Forms.TextBox();
            this.txtFTPUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFTPHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCIN7api = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCin7ApiKey = new System.Windows.Forms.TextBox();
            this.txtCin7AccID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbFTPpath = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbFTPdeets.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbCIN7api.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbFTPpath.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbFTPdeets, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbCIN7api, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbFTPpath, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(888, 458);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbFTPdeets
            // 
            this.gbFTPdeets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.gbFTPdeets.Controls.Add(this.tableLayoutPanel2);
            this.gbFTPdeets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFTPdeets.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFTPdeets.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbFTPdeets.Location = new System.Drawing.Point(3, 6);
            this.gbFTPdeets.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gbFTPdeets.Name = "gbFTPdeets";
            this.gbFTPdeets.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gbFTPdeets.Size = new System.Drawing.Size(882, 118);
            this.gbFTPdeets.TabIndex = 18;
            this.gbFTPdeets.TabStop = false;
            this.gbFTPdeets.Text = "Mainfreight Credentials";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtFTPPassword, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtFTPDirectory, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtFTPUsername, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtFTPHost, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(876, 86);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFTPPassword
            // 
            this.txtFTPPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFTPPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFTPPassword.Enabled = false;
            this.txtFTPPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFTPPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtFTPPassword.Location = new System.Drawing.Point(541, 46);
            this.txtFTPPassword.Name = "txtFTPPassword";
            this.txtFTPPassword.Size = new System.Drawing.Size(332, 27);
            this.txtFTPPassword.TabIndex = 15;
            this.txtFTPPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Username:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFTPDirectory
            // 
            this.txtFTPDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFTPDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFTPDirectory.Enabled = false;
            this.txtFTPDirectory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFTPDirectory.ForeColor = System.Drawing.Color.DimGray;
            this.txtFTPDirectory.Location = new System.Drawing.Point(541, 13);
            this.txtFTPDirectory.Name = "txtFTPDirectory";
            this.txtFTPDirectory.Size = new System.Drawing.Size(332, 27);
            this.txtFTPDirectory.TabIndex = 13;
            // 
            // txtFTPUsername
            // 
            this.txtFTPUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFTPUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFTPUsername.Enabled = false;
            this.txtFTPUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFTPUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtFTPUsername.Location = new System.Drawing.Point(103, 46);
            this.txtFTPUsername.Name = "txtFTPUsername";
            this.txtFTPUsername.Size = new System.Drawing.Size(332, 27);
            this.txtFTPUsername.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(441, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFTPHost
            // 
            this.txtFTPHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFTPHost.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFTPHost.Enabled = false;
            this.txtFTPHost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFTPHost.ForeColor = System.Drawing.Color.DimGray;
            this.txtFTPHost.Location = new System.Drawing.Point(103, 13);
            this.txtFTPHost.Name = "txtFTPHost";
            this.txtFTPHost.Size = new System.Drawing.Size(332, 27);
            this.txtFTPHost.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(441, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Directory:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbCIN7api
            // 
            this.gbCIN7api.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.gbCIN7api.Controls.Add(this.tableLayoutPanel3);
            this.gbCIN7api.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCIN7api.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCIN7api.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbCIN7api.Location = new System.Drawing.Point(3, 136);
            this.gbCIN7api.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gbCIN7api.Name = "gbCIN7api";
            this.gbCIN7api.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gbCIN7api.Size = new System.Drawing.Size(882, 88);
            this.gbCIN7api.TabIndex = 21;
            this.gbCIN7api.TabStop = false;
            this.gbCIN7api.Text = "CIN7 Core Credentials";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtCin7ApiKey, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtCin7AccID, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(876, 56);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Account ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCin7ApiKey
            // 
            this.txtCin7ApiKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCin7ApiKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCin7ApiKey.Enabled = false;
            this.txtCin7ApiKey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCin7ApiKey.ForeColor = System.Drawing.Color.DimGray;
            this.txtCin7ApiKey.Location = new System.Drawing.Point(541, 13);
            this.txtCin7ApiKey.Name = "txtCin7ApiKey";
            this.txtCin7ApiKey.Size = new System.Drawing.Size(332, 27);
            this.txtCin7ApiKey.TabIndex = 13;
            this.txtCin7ApiKey.UseSystemPasswordChar = true;
            // 
            // txtCin7AccID
            // 
            this.txtCin7AccID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCin7AccID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCin7AccID.Enabled = false;
            this.txtCin7AccID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCin7AccID.ForeColor = System.Drawing.Color.DimGray;
            this.txtCin7AccID.Location = new System.Drawing.Point(103, 13);
            this.txtCin7AccID.Name = "txtCin7AccID";
            this.txtCin7AccID.Size = new System.Drawing.Size(332, 27);
            this.txtCin7AccID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(441, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Key";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbFTPpath
            // 
            this.gbFTPpath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.gbFTPpath.Controls.Add(this.tableLayoutPanel4);
            this.gbFTPpath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFTPpath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFTPpath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbFTPpath.Location = new System.Drawing.Point(3, 236);
            this.gbFTPpath.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gbFTPpath.Name = "gbFTPpath";
            this.gbFTPpath.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gbFTPpath.Size = new System.Drawing.Size(882, 88);
            this.gbFTPpath.TabIndex = 22;
            this.gbFTPpath.TabStop = false;
            this.gbFTPpath.Text = "Log File Path";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel4.Controls.Add(this.txtLogPath, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnBrowse, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(876, 56);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // txtLogPath
            // 
            this.txtLogPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLogPath.Enabled = false;
            this.txtLogPath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogPath.ForeColor = System.Drawing.Color.DimGray;
            this.txtLogPath.Location = new System.Drawing.Point(3, 13);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(750, 27);
            this.txtLogPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowse.Enabled = false;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(64)))), ((int)(((byte)(68)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(79)))), ((int)(((byte)(42)))));
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBrowse.Location = new System.Drawing.Point(759, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(114, 30);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "🌐 BROWSE";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel5.Controls.Add(this.btnsave, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnEdit, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 333);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(882, 45);
            this.tableLayoutPanel5.TabIndex = 23;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsave.Enabled = false;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(710, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(169, 39);
            this.btnsave.TabIndex = 24;
            this.btnsave.Text = " SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(535, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(169, 39);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 458);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbFTPdeets.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbCIN7api.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbFTPpath.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbFTPdeets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFTPPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFTPDirectory;
        private System.Windows.Forms.TextBox txtFTPUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFTPHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCIN7api;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCin7ApiKey;
        private System.Windows.Forms.TextBox txtCin7AccID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbFTPpath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}