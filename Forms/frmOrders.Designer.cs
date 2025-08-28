namespace CIN7Core_MFT_EDI.Forms
{
    partial class frmOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.lblAddCity = new System.Windows.Forms.Label();
            this.lblAddPostCode = new System.Windows.Forms.Label();
            this.lblAddressLine = new System.Windows.Forms.Label();
            this.lblShippingAddress = new System.Windows.Forms.Label();
            this.lblTerms = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.groupBoxFulfilmentLines = new System.Windows.Forms.GroupBox();
            this.dataGridViewFulfilmentLines = new System.Windows.Forms.DataGridView();
            this.groupBoxFulfilments = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSync = new System.Windows.Forms.Button();
            this.dataGridViewSaleOrderFulfilments = new System.Windows.Forms.DataGridView();
            this.groupBoxSaleOrderList = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.bindingNavigatorOrderListPages = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewSaleOrdersList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFetchSaleOrderList = new System.Windows.Forms.Button();
            this.groupBoxSaleOrderUpdatedSince = new System.Windows.Forms.GroupBox();
            this.dateTimePickerOrderUpdated = new System.Windows.Forms.DateTimePicker();
            this.groupBoxSaleOrderCreateSince = new System.Windows.Forms.GroupBox();
            this.dateTimePickerOrderCreated = new System.Windows.Forms.DateTimePicker();
            this.groupBoxCombinedShippingStatus = new System.Windows.Forms.GroupBox();
            this.comboBoxCombinedShippingStatus = new System.Windows.Forms.ComboBox();
            this.groupBoxCombinedPackingStatus = new System.Windows.Forms.GroupBox();
            this.comboBoxCombinedPackingStatus = new System.Windows.Forms.ComboBox();
            this.groupBoxCombinedPickingStatus = new System.Windows.Forms.GroupBox();
            this.comboBoxCombinedPickingStatus = new System.Windows.Forms.ComboBox();
            this.groupBoxOverallStatus = new System.Windows.Forms.GroupBox();
            this.comboBoxOverallStatus = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.chkIncludePacked = new System.Windows.Forms.CheckBox();
            this.chkIncludeShipped = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxCustomerDetails.SuspendLayout();
            this.groupBoxFulfilmentLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFulfilmentLines)).BeginInit();
            this.groupBoxFulfilments.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleOrderFulfilments)).BeginInit();
            this.groupBoxSaleOrderList.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorOrderListPages)).BeginInit();
            this.bindingNavigatorOrderListPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleOrdersList)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxSaleOrderUpdatedSince.SuspendLayout();
            this.groupBoxSaleOrderCreateSince.SuspendLayout();
            this.groupBoxCombinedShippingStatus.SuspendLayout();
            this.groupBoxCombinedPackingStatus.SuspendLayout();
            this.groupBoxCombinedPickingStatus.SuspendLayout();
            this.groupBoxOverallStatus.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxSaleOrderList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1106, 680);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel3.Controls.Add(this.groupBoxCustomerDetails, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxFulfilmentLines, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxFulfilments, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 477);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1100, 203);
            this.tableLayoutPanel3.TabIndex = 33;
            // 
            // groupBoxCustomerDetails
            // 
            this.groupBoxCustomerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.groupBoxCustomerDetails.Controls.Add(this.lblPhone);
            this.groupBoxCustomerDetails.Controls.Add(this.lblAddCountry);
            this.groupBoxCustomerDetails.Controls.Add(this.lblAddCity);
            this.groupBoxCustomerDetails.Controls.Add(this.lblAddPostCode);
            this.groupBoxCustomerDetails.Controls.Add(this.lblAddressLine);
            this.groupBoxCustomerDetails.Controls.Add(this.lblShippingAddress);
            this.groupBoxCustomerDetails.Controls.Add(this.lblTerms);
            this.groupBoxCustomerDetails.Controls.Add(this.lblEmail);
            this.groupBoxCustomerDetails.Controls.Add(this.lblContact);
            this.groupBoxCustomerDetails.Controls.Add(this.lblCustomerName);
            this.groupBoxCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCustomerDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomerDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxCustomerDetails.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCustomerDetails.Name = "groupBoxCustomerDetails";
            this.groupBoxCustomerDetails.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBoxCustomerDetails.Size = new System.Drawing.Size(302, 197);
            this.groupBoxCustomerDetails.TabIndex = 33;
            this.groupBoxCustomerDetails.TabStop = false;
            this.groupBoxCustomerDetails.Text = "Customer Details";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(175, 113);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 19);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Visible = false;
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.Location = new System.Drawing.Point(167, 105);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(0, 19);
            this.lblAddCountry.TabIndex = 8;
            this.lblAddCountry.Visible = false;
            // 
            // lblAddCity
            // 
            this.lblAddCity.AutoSize = true;
            this.lblAddCity.Location = new System.Drawing.Point(159, 97);
            this.lblAddCity.Name = "lblAddCity";
            this.lblAddCity.Size = new System.Drawing.Size(0, 19);
            this.lblAddCity.TabIndex = 7;
            this.lblAddCity.Visible = false;
            // 
            // lblAddPostCode
            // 
            this.lblAddPostCode.AutoSize = true;
            this.lblAddPostCode.Location = new System.Drawing.Point(151, 89);
            this.lblAddPostCode.Name = "lblAddPostCode";
            this.lblAddPostCode.Size = new System.Drawing.Size(0, 19);
            this.lblAddPostCode.TabIndex = 6;
            this.lblAddPostCode.Visible = false;
            // 
            // lblAddressLine
            // 
            this.lblAddressLine.AutoSize = true;
            this.lblAddressLine.Location = new System.Drawing.Point(218, 108);
            this.lblAddressLine.Name = "lblAddressLine";
            this.lblAddressLine.Size = new System.Drawing.Size(0, 19);
            this.lblAddressLine.TabIndex = 5;
            this.lblAddressLine.Visible = false;
            // 
            // lblShippingAddress
            // 
            this.lblShippingAddress.AutoSize = true;
            this.lblShippingAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingAddress.Location = new System.Drawing.Point(3, 108);
            this.lblShippingAddress.Name = "lblShippingAddress";
            this.lblShippingAddress.Size = new System.Drawing.Size(0, 18);
            this.lblShippingAddress.TabIndex = 4;
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTerms.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerms.Location = new System.Drawing.Point(299, 26);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(0, 16);
            this.lblTerms.TabIndex = 3;
            this.lblTerms.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 18);
            this.lblEmail.TabIndex = 2;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(3, 64);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(0, 18);
            this.lblContact.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCustomerName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(3, 26);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 18);
            this.lblCustomerName.TabIndex = 0;
            // 
            // groupBoxFulfilmentLines
            // 
            this.groupBoxFulfilmentLines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.groupBoxFulfilmentLines.Controls.Add(this.dataGridViewFulfilmentLines);
            this.groupBoxFulfilmentLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFulfilmentLines.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFulfilmentLines.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxFulfilmentLines.Location = new System.Drawing.Point(641, 3);
            this.groupBoxFulfilmentLines.Name = "groupBoxFulfilmentLines";
            this.groupBoxFulfilmentLines.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBoxFulfilmentLines.Size = new System.Drawing.Size(456, 197);
            this.groupBoxFulfilmentLines.TabIndex = 31;
            this.groupBoxFulfilmentLines.TabStop = false;
            this.groupBoxFulfilmentLines.Text = "Fulfilment Lines";
            // 
            // dataGridViewFulfilmentLines
            // 
            this.dataGridViewFulfilmentLines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.dataGridViewFulfilmentLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFulfilmentLines.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFulfilmentLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFulfilmentLines.Location = new System.Drawing.Point(3, 26);
            this.dataGridViewFulfilmentLines.Name = "dataGridViewFulfilmentLines";
            this.dataGridViewFulfilmentLines.Size = new System.Drawing.Size(450, 165);
            this.dataGridViewFulfilmentLines.TabIndex = 1;
            // 
            // groupBoxFulfilments
            // 
            this.groupBoxFulfilments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.groupBoxFulfilments.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxFulfilments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFulfilments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFulfilments.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxFulfilments.Location = new System.Drawing.Point(311, 3);
            this.groupBoxFulfilments.Name = "groupBoxFulfilments";
            this.groupBoxFulfilments.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBoxFulfilments.Size = new System.Drawing.Size(324, 197);
            this.groupBoxFulfilments.TabIndex = 30;
            this.groupBoxFulfilments.TabStop = false;
            this.groupBoxFulfilments.Text = "Fulfillments";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnSync, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.dataGridViewSaleOrderFulfilments, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(318, 165);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnSync
            // 
            this.btnSync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnSync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSync.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSync.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSync.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(79)))), ((int)(((byte)(42)))));
            this.btnSync.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSync.Location = new System.Drawing.Point(3, 120);
            this.btnSync.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(312, 45);
            this.btnSync.TabIndex = 35;
            this.btnSync.Text = "🔄 SYNC";
            this.btnSync.UseVisualStyleBackColor = false;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // dataGridViewSaleOrderFulfilments
            // 
            this.dataGridViewSaleOrderFulfilments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.dataGridViewSaleOrderFulfilments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSaleOrderFulfilments.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSaleOrderFulfilments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSaleOrderFulfilments.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSaleOrderFulfilments.Name = "dataGridViewSaleOrderFulfilments";
            this.dataGridViewSaleOrderFulfilments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewSaleOrderFulfilments.Size = new System.Drawing.Size(312, 109);
            this.dataGridViewSaleOrderFulfilments.TabIndex = 0;
            this.dataGridViewSaleOrderFulfilments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSaleOrderFulfilments_CellClick);
            // 
            // groupBoxSaleOrderList
            // 
            this.groupBoxSaleOrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.groupBoxSaleOrderList.Controls.Add(this.tableLayoutPanel5);
            this.groupBoxSaleOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSaleOrderList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSaleOrderList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxSaleOrderList.Location = new System.Drawing.Point(3, 168);
            this.groupBoxSaleOrderList.Name = "groupBoxSaleOrderList";
            this.groupBoxSaleOrderList.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBoxSaleOrderList.Size = new System.Drawing.Size(1100, 303);
            this.groupBoxSaleOrderList.TabIndex = 32;
            this.groupBoxSaleOrderList.TabStop = false;
            this.groupBoxSaleOrderList.Text = "Sale Orders List";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.bindingNavigatorOrderListPages, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.dataGridViewSaleOrdersList, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1094, 271);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // bindingNavigatorOrderListPages
            // 
            this.bindingNavigatorOrderListPages.AddNewItem = null;
            this.bindingNavigatorOrderListPages.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorOrderListPages.DeleteItem = null;
            this.bindingNavigatorOrderListPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingNavigatorOrderListPages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigatorOrderListPages.Location = new System.Drawing.Point(3, 241);
            this.bindingNavigatorOrderListPages.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.bindingNavigatorOrderListPages.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorOrderListPages.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorOrderListPages.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorOrderListPages.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorOrderListPages.Name = "bindingNavigatorOrderListPages";
            this.bindingNavigatorOrderListPages.Padding = new System.Windows.Forms.Padding(0);
            this.bindingNavigatorOrderListPages.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorOrderListPages.Size = new System.Drawing.Size(1088, 27);
            this.bindingNavigatorOrderListPages.TabIndex = 0;
            this.bindingNavigatorOrderListPages.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 16);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // dataGridViewSaleOrdersList
            // 
            this.dataGridViewSaleOrdersList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.dataGridViewSaleOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSaleOrdersList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSaleOrdersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSaleOrdersList.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSaleOrdersList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dataGridViewSaleOrdersList.MultiSelect = false;
            this.dataGridViewSaleOrdersList.Name = "dataGridViewSaleOrdersList";
            this.dataGridViewSaleOrdersList.ReadOnly = true;
            this.dataGridViewSaleOrdersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewSaleOrdersList.Size = new System.Drawing.Size(1088, 238);
            this.dataGridViewSaleOrdersList.TabIndex = 1;
            this.dataGridViewSaleOrdersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSaleOrdersList_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnFetchSaleOrderList, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxSaleOrderUpdatedSince, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxSaleOrderCreateSince, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxCombinedShippingStatus, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxCombinedPackingStatus, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxCombinedPickingStatus, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxOverallStatus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1100, 159);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // btnFetchSaleOrderList
            // 
            this.btnFetchSaleOrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnFetchSaleOrderList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFetchSaleOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFetchSaleOrderList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFetchSaleOrderList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFetchSaleOrderList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchSaleOrderList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(79)))), ((int)(((byte)(42)))));
            this.btnFetchSaleOrderList.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFetchSaleOrderList.Location = new System.Drawing.Point(553, 92);
            this.btnFetchSaleOrderList.Margin = new System.Windows.Forms.Padding(3, 13, 3, 5);
            this.btnFetchSaleOrderList.Name = "btnFetchSaleOrderList";
            this.btnFetchSaleOrderList.Size = new System.Drawing.Size(269, 52);
            this.btnFetchSaleOrderList.TabIndex = 29;
            this.btnFetchSaleOrderList.Text = "▼ APPLY FILTERS";
            this.btnFetchSaleOrderList.UseVisualStyleBackColor = false;
            this.btnFetchSaleOrderList.Click += new System.EventHandler(this.btnFetchSaleOrderList_Click);
            // 
            // groupBoxSaleOrderUpdatedSince
            // 
            this.groupBoxSaleOrderUpdatedSince.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.groupBoxSaleOrderUpdatedSince.Controls.Add(this.dateTimePickerOrderUpdated);
            this.groupBoxSaleOrderUpdatedSince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSaleOrderUpdatedSince.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSaleOrderUpdatedSince.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxSaleOrderUpdatedSince.Location = new System.Drawing.Point(278, 82);
            this.groupBoxSaleOrderUpdatedSince.Name = "groupBoxSaleOrderUpdatedSince";
            this.groupBoxSaleOrderUpdatedSince.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBoxSaleOrderUpdatedSince.Size = new System.Drawing.Size(269, 64);
            this.groupBoxSaleOrderUpdatedSince.TabIndex = 28;
            this.groupBoxSaleOrderUpdatedSince.TabStop = false;
            this.groupBoxSaleOrderUpdatedSince.Text = "Updated Since";
            // 
            // dateTimePickerOrderUpdated
            // 
            this.dateTimePickerOrderUpdated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerOrderUpdated.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerOrderUpdated.Location = new System.Drawing.Point(3, 26);
            this.dateTimePickerOrderUpdated.Name = "dateTimePickerOrderUpdated";
            this.dateTimePickerOrderUpdated.Size = new System.Drawing.Size(263, 27);
            this.dateTimePickerOrderUpdated.TabIndex = 0;
            this.dateTimePickerOrderUpdated.ValueChanged += new System.EventHandler(this.dateTimePickerOrderUpdated_ValueChanged);
            // 
            // groupBoxSaleOrderCreateSince
            // 
            this.groupBoxSaleOrderCreateSince.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.groupBoxSaleOrderCreateSince.Controls.Add(this.dateTimePickerOrderCreated);
            this.groupBoxSaleOrderCreateSince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSaleOrderCreateSince.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSaleOrderCreateSince.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxSaleOrderCreateSince.Location = new System.Drawing.Point(3, 82);
            this.groupBoxSaleOrderCreateSince.Name = "groupBoxSaleOrderCreateSince";
            this.groupBoxSaleOrderCreateSince.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBoxSaleOrderCreateSince.Size = new System.Drawing.Size(269, 64);
            this.groupBoxSaleOrderCreateSince.TabIndex = 27;
            this.groupBoxSaleOrderCreateSince.TabStop = false;
            this.groupBoxSaleOrderCreateSince.Text = "Created Since";
            // 
            // dateTimePickerOrderCreated
            // 
            this.dateTimePickerOrderCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerOrderCreated.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerOrderCreated.Location = new System.Drawing.Point(3, 26);
            this.dateTimePickerOrderCreated.Name = "dateTimePickerOrderCreated";
            this.dateTimePickerOrderCreated.Size = new System.Drawing.Size(263, 27);
            this.dateTimePickerOrderCreated.TabIndex = 0;
            this.dateTimePickerOrderCreated.ValueChanged += new System.EventHandler(this.dateTimePickerOrderCreated_ValueChanged);
            // 
            // groupBoxCombinedShippingStatus
            // 
            this.groupBoxCombinedShippingStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.groupBoxCombinedShippingStatus.Controls.Add(this.comboBoxCombinedShippingStatus);
            this.groupBoxCombinedShippingStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCombinedShippingStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCombinedShippingStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxCombinedShippingStatus.Location = new System.Drawing.Point(828, 13);
            this.groupBoxCombinedShippingStatus.Name = "groupBoxCombinedShippingStatus";
            this.groupBoxCombinedShippingStatus.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBoxCombinedShippingStatus.Size = new System.Drawing.Size(269, 63);
            this.groupBoxCombinedShippingStatus.TabIndex = 26;
            this.groupBoxCombinedShippingStatus.TabStop = false;
            this.groupBoxCombinedShippingStatus.Text = "Combined Shipping Status";
            // 
            // comboBoxCombinedShippingStatus
            // 
            this.comboBoxCombinedShippingStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCombinedShippingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCombinedShippingStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCombinedShippingStatus.FormattingEnabled = true;
            this.comboBoxCombinedShippingStatus.Items.AddRange(new object[] {
            "------- ALL -------",
            "NOT AVAILABLE",
            "NOT SHIPPED",
            "PARTIALLY SHIPPED",
            "SHIPPED",
            "SHIPPING",
            "VOIDED"});
            this.comboBoxCombinedShippingStatus.Location = new System.Drawing.Point(3, 26);
            this.comboBoxCombinedShippingStatus.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.comboBoxCombinedShippingStatus.Name = "comboBoxCombinedShippingStatus";
            this.comboBoxCombinedShippingStatus.Size = new System.Drawing.Size(263, 27);
            this.comboBoxCombinedShippingStatus.TabIndex = 39;
            this.comboBoxCombinedShippingStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxCombinedShippingStatus_SelectedIndexChanged);
            // 
            // groupBoxCombinedPackingStatus
            // 
            this.groupBoxCombinedPackingStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.groupBoxCombinedPackingStatus.Controls.Add(this.comboBoxCombinedPackingStatus);
            this.groupBoxCombinedPackingStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCombinedPackingStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCombinedPackingStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxCombinedPackingStatus.Location = new System.Drawing.Point(553, 13);
            this.groupBoxCombinedPackingStatus.Name = "groupBoxCombinedPackingStatus";
            this.groupBoxCombinedPackingStatus.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBoxCombinedPackingStatus.Size = new System.Drawing.Size(269, 63);
            this.groupBoxCombinedPackingStatus.TabIndex = 25;
            this.groupBoxCombinedPackingStatus.TabStop = false;
            this.groupBoxCombinedPackingStatus.Text = "Combined Packing Status";
            // 
            // comboBoxCombinedPackingStatus
            // 
            this.comboBoxCombinedPackingStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCombinedPackingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCombinedPackingStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCombinedPackingStatus.FormattingEnabled = true;
            this.comboBoxCombinedPackingStatus.Items.AddRange(new object[] {
            "------- ALL -------",
            "NOT AVAILABLE",
            "NOT PACKED",
            "PACKED",
            "PACKING",
            "PARTIALLY PACKED",
            "VOIDED"});
            this.comboBoxCombinedPackingStatus.Location = new System.Drawing.Point(3, 26);
            this.comboBoxCombinedPackingStatus.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.comboBoxCombinedPackingStatus.Name = "comboBoxCombinedPackingStatus";
            this.comboBoxCombinedPackingStatus.Size = new System.Drawing.Size(263, 27);
            this.comboBoxCombinedPackingStatus.TabIndex = 39;
            this.comboBoxCombinedPackingStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxCombinedPackingStatus_SelectedIndexChanged);
            // 
            // groupBoxCombinedPickingStatus
            // 
            this.groupBoxCombinedPickingStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.groupBoxCombinedPickingStatus.Controls.Add(this.comboBoxCombinedPickingStatus);
            this.groupBoxCombinedPickingStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCombinedPickingStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCombinedPickingStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxCombinedPickingStatus.Location = new System.Drawing.Point(278, 13);
            this.groupBoxCombinedPickingStatus.Name = "groupBoxCombinedPickingStatus";
            this.groupBoxCombinedPickingStatus.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBoxCombinedPickingStatus.Size = new System.Drawing.Size(269, 63);
            this.groupBoxCombinedPickingStatus.TabIndex = 24;
            this.groupBoxCombinedPickingStatus.TabStop = false;
            this.groupBoxCombinedPickingStatus.Text = "Combined Picking Status ";
            // 
            // comboBoxCombinedPickingStatus
            // 
            this.comboBoxCombinedPickingStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCombinedPickingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCombinedPickingStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCombinedPickingStatus.FormattingEnabled = true;
            this.comboBoxCombinedPickingStatus.Items.AddRange(new object[] {
            "------- ALL -------",
            "NOT AVAILABLE",
            "NOT PICKED",
            "PARTIALLY PICKED",
            "PICKED",
            "PICKING",
            "VOIDED"});
            this.comboBoxCombinedPickingStatus.Location = new System.Drawing.Point(3, 26);
            this.comboBoxCombinedPickingStatus.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.comboBoxCombinedPickingStatus.Name = "comboBoxCombinedPickingStatus";
            this.comboBoxCombinedPickingStatus.Size = new System.Drawing.Size(263, 27);
            this.comboBoxCombinedPickingStatus.TabIndex = 39;
            this.comboBoxCombinedPickingStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxCombinedPickingStatus_SelectedIndexChanged);
            // 
            // groupBoxOverallStatus
            // 
            this.groupBoxOverallStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.groupBoxOverallStatus.Controls.Add(this.comboBoxOverallStatus);
            this.groupBoxOverallStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOverallStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOverallStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxOverallStatus.Location = new System.Drawing.Point(3, 13);
            this.groupBoxOverallStatus.Name = "groupBoxOverallStatus";
            this.groupBoxOverallStatus.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBoxOverallStatus.Size = new System.Drawing.Size(269, 63);
            this.groupBoxOverallStatus.TabIndex = 23;
            this.groupBoxOverallStatus.TabStop = false;
            this.groupBoxOverallStatus.Text = "Overall Status";
            // 
            // comboBoxOverallStatus
            // 
            this.comboBoxOverallStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxOverallStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOverallStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOverallStatus.FormattingEnabled = true;
            this.comboBoxOverallStatus.Items.AddRange(new object[] {
            "------- ALL -------",
            "BACKORDERED",
            "COMPLETED",
            "CREDITED",
            "DRAFT",
            "ESTIMATED",
            "ESTIMATING",
            "INVOICED",
            "INVOICING",
            "ORDERED",
            "ORDERING",
            "PACKED",
            "PACKING",
            "PICKED",
            "PICKING",
            "SHIPPING",
            "VOIDED"});
            this.comboBoxOverallStatus.Location = new System.Drawing.Point(3, 26);
            this.comboBoxOverallStatus.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.comboBoxOverallStatus.Name = "comboBoxOverallStatus";
            this.comboBoxOverallStatus.Size = new System.Drawing.Size(263, 27);
            this.comboBoxOverallStatus.TabIndex = 38;
            this.comboBoxOverallStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxOverallStatus_SelectedIndexChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.chkIncludePacked, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.chkIncludeShipped, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(828, 82);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(269, 64);
            this.tableLayoutPanel6.TabIndex = 30;
            // 
            // chkIncludePacked
            // 
            this.chkIncludePacked.AutoSize = true;
            this.chkIncludePacked.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.chkIncludePacked.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chkIncludePacked.Location = new System.Drawing.Point(3, 3);
            this.chkIncludePacked.Name = "chkIncludePacked";
            this.chkIncludePacked.Size = new System.Drawing.Size(151, 23);
            this.chkIncludePacked.TabIndex = 0;
            this.chkIncludePacked.Text = "Include Packed";
            this.chkIncludePacked.UseVisualStyleBackColor = true;
            // 
            // chkIncludeShipped
            // 
            this.chkIncludeShipped.AutoSize = true;
            this.chkIncludeShipped.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.chkIncludeShipped.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chkIncludeShipped.Location = new System.Drawing.Point(3, 35);
            this.chkIncludeShipped.Name = "chkIncludeShipped";
            this.chkIncludeShipped.Size = new System.Drawing.Size(156, 23);
            this.chkIncludeShipped.TabIndex = 1;
            this.chkIncludeShipped.Text = "Include Shipped";
            this.chkIncludeShipped.UseVisualStyleBackColor = true;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1106, 680);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrders_FormClosing);
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBoxCustomerDetails.ResumeLayout(false);
            this.groupBoxCustomerDetails.PerformLayout();
            this.groupBoxFulfilmentLines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFulfilmentLines)).EndInit();
            this.groupBoxFulfilments.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleOrderFulfilments)).EndInit();
            this.groupBoxSaleOrderList.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorOrderListPages)).EndInit();
            this.bindingNavigatorOrderListPages.ResumeLayout(false);
            this.bindingNavigatorOrderListPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleOrdersList)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBoxSaleOrderUpdatedSince.ResumeLayout(false);
            this.groupBoxSaleOrderCreateSince.ResumeLayout(false);
            this.groupBoxCombinedShippingStatus.ResumeLayout(false);
            this.groupBoxCombinedPackingStatus.ResumeLayout(false);
            this.groupBoxCombinedPickingStatus.ResumeLayout(false);
            this.groupBoxOverallStatus.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxOverallStatus;
        private System.Windows.Forms.GroupBox groupBoxSaleOrderUpdatedSince;
        private System.Windows.Forms.GroupBox groupBoxSaleOrderCreateSince;
        private System.Windows.Forms.GroupBox groupBoxCombinedShippingStatus;
        private System.Windows.Forms.GroupBox groupBoxCombinedPackingStatus;
        private System.Windows.Forms.GroupBox groupBoxCombinedPickingStatus;
        private System.Windows.Forms.Button btnFetchSaleOrderList;
        private System.Windows.Forms.ComboBox comboBoxOverallStatus;
        private System.Windows.Forms.ComboBox comboBoxCombinedShippingStatus;
        private System.Windows.Forms.ComboBox comboBoxCombinedPackingStatus;
        private System.Windows.Forms.ComboBox comboBoxCombinedPickingStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderCreated;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderUpdated;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBoxFulfilmentLines;
        private System.Windows.Forms.DataGridView dataGridViewFulfilmentLines;
        private System.Windows.Forms.GroupBox groupBoxFulfilments;
        private System.Windows.Forms.DataGridView dataGridViewSaleOrderFulfilments;
        private System.Windows.Forms.GroupBox groupBoxCustomerDetails;
        private System.Windows.Forms.GroupBox groupBoxSaleOrderList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dataGridViewSaleOrdersList;
        private System.Windows.Forms.BindingNavigator bindingNavigatorOrderListPages;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblTerms;
        private System.Windows.Forms.Label lblShippingAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Label lblAddCity;
        private System.Windows.Forms.Label lblAddPostCode;
        private System.Windows.Forms.Label lblAddressLine;
        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox chkIncludePacked;
        private System.Windows.Forms.CheckBox chkIncludeShipped;
    }
}