﻿
namespace Invoices.src.views
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.EditCompaniesOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ADD = new System.Windows.Forms.ToolStripMenuItem();
            this.EDIT = new System.Windows.Forms.ToolStripMenuItem();
            this.DELETE = new System.Windows.Forms.ToolStripMenuItem();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Invoices = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddScopeButton = new System.Windows.Forms.Button();
            this.Scope = new System.Windows.Forms.TextBox();
            this.ScopeDescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClearReceiptButton = new System.Windows.Forms.Button();
            this.ReceiptGrandTotal = new System.Windows.Forms.NumericUpDown();
            this.GenerateInvoiceButton = new System.Windows.Forms.Button();
            this.ReceiptTotal = new System.Windows.Forms.NumericUpDown();
            this.ReceiptVat = new System.Windows.Forms.NumericUpDown();
            this.Totals = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Vat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.NumericUpDown();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.CompanyList = new System.Windows.Forms.ComboBox();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.UnitPrice = new System.Windows.Forms.NumericUpDown();
            this.ValidUntilLabel = new System.Windows.Forms.Label();
            this.InvoiceExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.ItemsList = new System.Windows.Forms.ComboBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ScopeGrid = new System.Windows.Forms.DataGridView();
            this.SuccessPanel = new System.Windows.Forms.Panel();
            this.SuccessOkButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.InvoiceItemsGrid = new System.Windows.Forms.DataGridView();
            this.Companies = new System.Windows.Forms.TabPage();
            this.EditCompaniesPanel = new System.Windows.Forms.Panel();
            this.NewCompanyContactEmail = new System.Windows.Forms.TextBox();
            this.NewCompanyContactNumbers = new System.Windows.Forms.TextBox();
            this.NewCompanyContactTitle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NewCompanyContactPerson = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NewCompanyZipCode = new System.Windows.Forms.NumericUpDown();
            this.NewCompanyCity = new System.Windows.Forms.TextBox();
            this.NewCompanyAddress = new System.Windows.Forms.TextBox();
            this.NewCompanyName = new System.Windows.Forms.TextBox();
            this.NewCompanyCancelButton = new System.Windows.Forms.Button();
            this.NewCompanyDoneButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CompaniesGridView = new System.Windows.Forms.DataGridView();
            this.History = new System.Windows.Forms.TabPage();
            this.Setup = new System.Windows.Forms.TabPage();
            this.InvoiceItemsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCompaniesOptions.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.Invoices.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptGrandTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptVat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScopeGrid)).BeginInit();
            this.SuccessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemsGrid)).BeginInit();
            this.Companies.SuspendLayout();
            this.EditCompaniesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewCompanyZipCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesGridView)).BeginInit();
            this.InvoiceItemsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditCompaniesOptions
            // 
            this.EditCompaniesOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ADD,
            this.EDIT,
            this.DELETE});
            this.EditCompaniesOptions.Name = "contextMenuStrip2";
            this.EditCompaniesOptions.Size = new System.Drawing.Size(113, 70);
            this.EditCompaniesOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.EditCompaniesOptions_Click);
            // 
            // ADD
            // 
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(112, 22);
            this.ADD.Text = "ADD";
            // 
            // EDIT
            // 
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(112, 22);
            this.EDIT.Text = "EDIT";
            // 
            // DELETE
            // 
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(112, 22);
            this.DELETE.Text = "DELETE";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Invoices);
            this.Tabs.Controls.Add(this.Companies);
            this.Tabs.Controls.Add(this.History);
            this.Tabs.Controls.Add(this.Setup);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1421, 773);
            this.Tabs.TabIndex = 2;
            // 
            // Invoices
            // 
            this.Invoices.Controls.Add(this.panel3);
            this.Invoices.Controls.Add(this.panel2);
            this.Invoices.Controls.Add(this.panel1);
            this.Invoices.Controls.Add(this.ScopeGrid);
            this.Invoices.Controls.Add(this.SuccessPanel);
            this.Invoices.Controls.Add(this.InvoiceItemsGrid);
            this.Invoices.Location = new System.Drawing.Point(4, 28);
            this.Invoices.Name = "Invoices";
            this.Invoices.Padding = new System.Windows.Forms.Padding(3);
            this.Invoices.Size = new System.Drawing.Size(1413, 741);
            this.Invoices.TabIndex = 0;
            this.Invoices.Text = "Invoices";
            this.Invoices.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Ivory;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.AddScopeButton);
            this.panel3.Controls.Add(this.Scope);
            this.panel3.Controls.Add(this.ScopeDescription);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(4, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 155);
            this.panel3.TabIndex = 18;
            // 
            // AddScopeButton
            // 
            this.AddScopeButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddScopeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddScopeButton.Location = new System.Drawing.Point(146, 105);
            this.AddScopeButton.Name = "AddScopeButton";
            this.AddScopeButton.Size = new System.Drawing.Size(185, 31);
            this.AddScopeButton.TabIndex = 4;
            this.AddScopeButton.Text = "ADD ";
            this.AddScopeButton.UseVisualStyleBackColor = false;
            this.AddScopeButton.Click += new System.EventHandler(this.AddScopeButton_Click);
            // 
            // Scope
            // 
            this.Scope.Location = new System.Drawing.Point(146, 13);
            this.Scope.Name = "Scope";
            this.Scope.Size = new System.Drawing.Size(475, 26);
            this.Scope.TabIndex = 3;
            // 
            // ScopeDescription
            // 
            this.ScopeDescription.Location = new System.Drawing.Point(147, 50);
            this.ScopeDescription.Name = "ScopeDescription";
            this.ScopeDescription.Size = new System.Drawing.Size(476, 46);
            this.ScopeDescription.TabIndex = 2;
            this.ScopeDescription.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Scope";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ClearReceiptButton);
            this.panel2.Controls.Add(this.ReceiptGrandTotal);
            this.panel2.Controls.Add(this.GenerateInvoiceButton);
            this.panel2.Controls.Add(this.ReceiptTotal);
            this.panel2.Controls.Add(this.ReceiptVat);
            this.panel2.Controls.Add(this.Totals);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Vat);
            this.panel2.Location = new System.Drawing.Point(656, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 131);
            this.panel2.TabIndex = 17;
            // 
            // ClearReceiptButton
            // 
            this.ClearReceiptButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClearReceiptButton.FlatAppearance.BorderSize = 2;
            this.ClearReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearReceiptButton.Location = new System.Drawing.Point(11, 14);
            this.ClearReceiptButton.Name = "ClearReceiptButton";
            this.ClearReceiptButton.Size = new System.Drawing.Size(246, 42);
            this.ClearReceiptButton.TabIndex = 13;
            this.ClearReceiptButton.Text = "Clear Receipt";
            this.ClearReceiptButton.UseVisualStyleBackColor = false;
            this.ClearReceiptButton.Click += new System.EventHandler(this.ClearReceiptButton_Click);
            // 
            // ReceiptGrandTotal
            // 
            this.ReceiptGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceiptGrandTotal.DecimalPlaces = 2;
            this.ReceiptGrandTotal.InterceptArrowKeys = false;
            this.ReceiptGrandTotal.Location = new System.Drawing.Point(477, 88);
            this.ReceiptGrandTotal.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.ReceiptGrandTotal.Name = "ReceiptGrandTotal";
            this.ReceiptGrandTotal.ReadOnly = true;
            this.ReceiptGrandTotal.Size = new System.Drawing.Size(271, 26);
            this.ReceiptGrandTotal.TabIndex = 9;
            this.ReceiptGrandTotal.ThousandsSeparator = true;
            // 
            // GenerateInvoiceButton
            // 
            this.GenerateInvoiceButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GenerateInvoiceButton.FlatAppearance.BorderSize = 2;
            this.GenerateInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerateInvoiceButton.Location = new System.Drawing.Point(11, 72);
            this.GenerateInvoiceButton.Name = "GenerateInvoiceButton";
            this.GenerateInvoiceButton.Size = new System.Drawing.Size(246, 42);
            this.GenerateInvoiceButton.TabIndex = 4;
            this.GenerateInvoiceButton.Text = "Generate Invoice";
            this.GenerateInvoiceButton.UseVisualStyleBackColor = false;
            this.GenerateInvoiceButton.Click += new System.EventHandler(this.GenerateInvoiceButton_Click);
            // 
            // ReceiptTotal
            // 
            this.ReceiptTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceiptTotal.DecimalPlaces = 2;
            this.ReceiptTotal.InterceptArrowKeys = false;
            this.ReceiptTotal.Location = new System.Drawing.Point(477, 8);
            this.ReceiptTotal.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.ReceiptTotal.Name = "ReceiptTotal";
            this.ReceiptTotal.ReadOnly = true;
            this.ReceiptTotal.Size = new System.Drawing.Size(271, 26);
            this.ReceiptTotal.TabIndex = 5;
            this.ReceiptTotal.ThousandsSeparator = true;
            // 
            // ReceiptVat
            // 
            this.ReceiptVat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceiptVat.DecimalPlaces = 2;
            this.ReceiptVat.InterceptArrowKeys = false;
            this.ReceiptVat.Location = new System.Drawing.Point(477, 49);
            this.ReceiptVat.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.ReceiptVat.Name = "ReceiptVat";
            this.ReceiptVat.ReadOnly = true;
            this.ReceiptVat.Size = new System.Drawing.Size(271, 26);
            this.ReceiptVat.TabIndex = 7;
            this.ReceiptVat.ThousandsSeparator = true;
            // 
            // Totals
            // 
            this.Totals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Totals.AutoSize = true;
            this.Totals.Location = new System.Drawing.Point(296, 10);
            this.Totals.Name = "Totals";
            this.Totals.Size = new System.Drawing.Size(152, 19);
            this.Totals.TabIndex = 6;
            this.Totals.Text = "Total Excluding Vat";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grand Total";
            // 
            // Vat
            // 
            this.Vat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Vat.AutoSize = true;
            this.Vat.Location = new System.Drawing.Point(296, 51);
            this.Vat.Name = "Vat";
            this.Vat.Size = new System.Drawing.Size(37, 19);
            this.Vat.TabIndex = 8;
            this.Vat.Text = "VAT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AddItemButton);
            this.panel1.Controls.Add(this.TotalPriceLabel);
            this.panel1.Controls.Add(this.TotalPrice);
            this.panel1.Controls.Add(this.CompanyNameLabel);
            this.panel1.Controls.Add(this.CompanyList);
            this.panel1.Controls.Add(this.UnitPriceLabel);
            this.panel1.Controls.Add(this.UnitPrice);
            this.panel1.Controls.Add(this.ValidUntilLabel);
            this.panel1.Controls.Add(this.InvoiceExpiryDate);
            this.panel1.Controls.Add(this.ItemsList);
            this.panel1.Controls.Add(this.QuantityLabel);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.ItemNameLabel);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 300);
            this.panel1.TabIndex = 16;
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddItemButton.ForeColor = System.Drawing.Color.Black;
            this.AddItemButton.Location = new System.Drawing.Point(418, 240);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(205, 29);
            this.AddItemButton.TabIndex = 6;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(16, 245);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(89, 19);
            this.TotalPriceLabel.TabIndex = 12;
            this.TotalPriceLabel.Text = "Total Price";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPrice.DecimalPlaces = 2;
            this.TotalPrice.Location = new System.Drawing.Point(178, 243);
            this.TotalPrice.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Size = new System.Drawing.Size(205, 26);
            this.TotalPrice.TabIndex = 13;
            this.TotalPrice.ThousandsSeparator = true;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(15, 18);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(124, 19);
            this.CompanyNameLabel.TabIndex = 1;
            this.CompanyNameLabel.Text = "Select Company";
            // 
            // CompanyList
            // 
            this.CompanyList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CompanyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CompanyList.FormattingEnabled = true;
            this.CompanyList.Location = new System.Drawing.Point(178, 12);
            this.CompanyList.Name = "CompanyList";
            this.CompanyList.Size = new System.Drawing.Size(445, 27);
            this.CompanyList.TabIndex = 0;
            this.CompanyList.SelectedIndexChanged += new System.EventHandler(this.CompanyList_SelectedIndexChanged);
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(16, 200);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(83, 19);
            this.UnitPriceLabel.TabIndex = 10;
            this.UnitPriceLabel.Text = "Unit Price";
            // 
            // UnitPrice
            // 
            this.UnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitPrice.DecimalPlaces = 2;
            this.UnitPrice.Location = new System.Drawing.Point(178, 198);
            this.UnitPrice.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(205, 26);
            this.UnitPrice.TabIndex = 11;
            this.UnitPrice.ThousandsSeparator = true;
            this.UnitPrice.ValueChanged += new System.EventHandler(this.UnitPrice_ValueChanged);
            this.UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitPrice_KeyPress);
            // 
            // ValidUntilLabel
            // 
            this.ValidUntilLabel.AutoSize = true;
            this.ValidUntilLabel.Location = new System.Drawing.Point(16, 64);
            this.ValidUntilLabel.Name = "ValidUntilLabel";
            this.ValidUntilLabel.Size = new System.Drawing.Size(88, 19);
            this.ValidUntilLabel.TabIndex = 7;
            this.ValidUntilLabel.Text = "Valid Until";
            // 
            // InvoiceExpiryDate
            // 
            this.InvoiceExpiryDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceExpiryDate.Location = new System.Drawing.Point(178, 58);
            this.InvoiceExpiryDate.Name = "InvoiceExpiryDate";
            this.InvoiceExpiryDate.Size = new System.Drawing.Size(445, 26);
            this.InvoiceExpiryDate.TabIndex = 9;
            // 
            // ItemsList
            // 
            this.ItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.Location = new System.Drawing.Point(178, 105);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(445, 27);
            this.ItemsList.TabIndex = 2;
            this.ItemsList.SelectedIndexChanged += new System.EventHandler(this.ItemsList_SelectedIndexChanged);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(15, 154);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(74, 19);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "Quantity";
            // 
            // Quantity
            // 
            this.Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Quantity.Location = new System.Drawing.Point(178, 152);
            this.Quantity.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(205, 26);
            this.Quantity.TabIndex = 5;
            this.Quantity.ValueChanged += new System.EventHandler(this.Quantity_ValueChanged);
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(15, 108);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(142, 19);
            this.ItemNameLabel.TabIndex = 3;
            this.ItemNameLabel.Text = "Select/Insert Item";
            // 
            // ScopeGrid
            // 
            this.ScopeGrid.AllowUserToAddRows = false;
            this.ScopeGrid.AllowUserToDeleteRows = false;
            this.ScopeGrid.AllowUserToResizeRows = false;
            this.ScopeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScopeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScopeGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScopeGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ScopeGrid.Location = new System.Drawing.Point(656, 315);
            this.ScopeGrid.Margin = new System.Windows.Forms.Padding(1);
            this.ScopeGrid.Name = "ScopeGrid";
            this.ScopeGrid.Size = new System.Drawing.Size(753, 285);
            this.ScopeGrid.TabIndex = 15;
            // 
            // SuccessPanel
            // 
            this.SuccessPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SuccessPanel.BackColor = System.Drawing.Color.Lime;
            this.SuccessPanel.Controls.Add(this.SuccessOkButton);
            this.SuccessPanel.Controls.Add(this.label6);
            this.SuccessPanel.Location = new System.Drawing.Point(3, 637);
            this.SuccessPanel.Name = "SuccessPanel";
            this.SuccessPanel.Size = new System.Drawing.Size(417, 96);
            this.SuccessPanel.TabIndex = 14;
            this.SuccessPanel.Visible = false;
            // 
            // SuccessOkButton
            // 
            this.SuccessOkButton.Location = new System.Drawing.Point(129, 52);
            this.SuccessOkButton.Name = "SuccessOkButton";
            this.SuccessOkButton.Size = new System.Drawing.Size(142, 32);
            this.SuccessOkButton.TabIndex = 1;
            this.SuccessOkButton.Text = "OK";
            this.SuccessOkButton.UseVisualStyleBackColor = true;
            this.SuccessOkButton.Click += new System.EventHandler(this.SuccessOkButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(92, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Invoice has been generated";
            // 
            // InvoiceItemsGrid
            // 
            this.InvoiceItemsGrid.AllowUserToAddRows = false;
            this.InvoiceItemsGrid.AllowUserToDeleteRows = false;
            this.InvoiceItemsGrid.AllowUserToResizeRows = false;
            this.InvoiceItemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceItemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoiceItemsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InvoiceItemsGrid.ContextMenuStrip = this.InvoiceItemsOptions;
            this.InvoiceItemsGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InvoiceItemsGrid.Location = new System.Drawing.Point(656, 6);
            this.InvoiceItemsGrid.Margin = new System.Windows.Forms.Padding(1);
            this.InvoiceItemsGrid.Name = "InvoiceItemsGrid";
            this.InvoiceItemsGrid.Size = new System.Drawing.Size(753, 300);
            this.InvoiceItemsGrid.TabIndex = 3;
            this.InvoiceItemsGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.InvoiceItemsGrid_CellBeginEdit);
            this.InvoiceItemsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceItemsGrid_CellEndEdit);
            this.InvoiceItemsGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.InvoiceItemsGrid_DataError);
            // 
            // Companies
            // 
            this.Companies.Controls.Add(this.EditCompaniesPanel);
            this.Companies.Controls.Add(this.CompaniesGridView);
            this.Companies.Location = new System.Drawing.Point(4, 28);
            this.Companies.Name = "Companies";
            this.Companies.Size = new System.Drawing.Size(1413, 741);
            this.Companies.TabIndex = 4;
            this.Companies.Text = "Companies";
            this.Companies.UseVisualStyleBackColor = true;
            // 
            // EditCompaniesPanel
            // 
            this.EditCompaniesPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditCompaniesPanel.AutoSize = true;
            this.EditCompaniesPanel.BackColor = System.Drawing.Color.SlateGray;
            this.EditCompaniesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditCompaniesPanel.Controls.Add(this.NewCompanyContactEmail);
            this.EditCompaniesPanel.Controls.Add(this.NewCompanyContactNumbers);
            this.EditCompaniesPanel.Controls.Add(this.NewCompanyContactTitle);
            this.EditCompaniesPanel.Controls.Add(this.label12);
            this.EditCompaniesPanel.Controls.Add(this.label11);
            this.EditCompaniesPanel.Controls.Add(this.label10);
            this.EditCompaniesPanel.Controls.Add(this.NewCompanyContactPerson);
            this.EditCompaniesPanel.Controls.Add(this.label9);
            this.EditCompaniesPanel.Controls.Add(this.NewCompanyZipCode);
            this.EditCompaniesPanel.Controls.Add(this.NewCompanyCity);
            this.EditCompaniesPanel.Controls.Add(this.NewCompanyAddress);
            this.EditCompaniesPanel.Controls.Add(this.NewCompanyName);
            this.EditCompaniesPanel.Controls.Add(this.NewCompanyCancelButton);
            this.EditCompaniesPanel.Controls.Add(this.NewCompanyDoneButton);
            this.EditCompaniesPanel.Controls.Add(this.label4);
            this.EditCompaniesPanel.Controls.Add(this.label3);
            this.EditCompaniesPanel.Controls.Add(this.label2);
            this.EditCompaniesPanel.Controls.Add(this.label1);
            this.EditCompaniesPanel.Location = new System.Drawing.Point(259, 81);
            this.EditCompaniesPanel.Margin = new System.Windows.Forms.Padding(100);
            this.EditCompaniesPanel.Name = "EditCompaniesPanel";
            this.EditCompaniesPanel.Size = new System.Drawing.Size(759, 480);
            this.EditCompaniesPanel.TabIndex = 1;
            this.EditCompaniesPanel.Visible = false;
            // 
            // NewCompanyContactEmail
            // 
            this.NewCompanyContactEmail.Location = new System.Drawing.Point(219, 374);
            this.NewCompanyContactEmail.Name = "NewCompanyContactEmail";
            this.NewCompanyContactEmail.Size = new System.Drawing.Size(487, 26);
            this.NewCompanyContactEmail.TabIndex = 17;
            // 
            // NewCompanyContactNumbers
            // 
            this.NewCompanyContactNumbers.Location = new System.Drawing.Point(219, 323);
            this.NewCompanyContactNumbers.Name = "NewCompanyContactNumbers";
            this.NewCompanyContactNumbers.Size = new System.Drawing.Size(487, 26);
            this.NewCompanyContactNumbers.TabIndex = 16;
            // 
            // NewCompanyContactTitle
            // 
            this.NewCompanyContactTitle.Location = new System.Drawing.Point(219, 273);
            this.NewCompanyContactTitle.Name = "NewCompanyContactTitle";
            this.NewCompanyContactTitle.Size = new System.Drawing.Size(487, 26);
            this.NewCompanyContactTitle.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "Contact Numbers";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Title";
            // 
            // NewCompanyContactPerson
            // 
            this.NewCompanyContactPerson.Location = new System.Drawing.Point(219, 224);
            this.NewCompanyContactPerson.Name = "NewCompanyContactPerson";
            this.NewCompanyContactPerson.Size = new System.Drawing.Size(487, 26);
            this.NewCompanyContactPerson.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Contact Person";
            // 
            // NewCompanyZipCode
            // 
            this.NewCompanyZipCode.Location = new System.Drawing.Point(219, 175);
            this.NewCompanyZipCode.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NewCompanyZipCode.Name = "NewCompanyZipCode";
            this.NewCompanyZipCode.Size = new System.Drawing.Size(168, 26);
            this.NewCompanyZipCode.TabIndex = 9;
            this.NewCompanyZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewCompanyZipCode_KeyPress);
            // 
            // NewCompanyCity
            // 
            this.NewCompanyCity.Location = new System.Drawing.Point(219, 124);
            this.NewCompanyCity.Name = "NewCompanyCity";
            this.NewCompanyCity.Size = new System.Drawing.Size(487, 26);
            this.NewCompanyCity.TabIndex = 8;
            // 
            // NewCompanyAddress
            // 
            this.NewCompanyAddress.Location = new System.Drawing.Point(219, 74);
            this.NewCompanyAddress.Name = "NewCompanyAddress";
            this.NewCompanyAddress.Size = new System.Drawing.Size(487, 26);
            this.NewCompanyAddress.TabIndex = 7;
            // 
            // NewCompanyName
            // 
            this.NewCompanyName.Location = new System.Drawing.Point(219, 26);
            this.NewCompanyName.Name = "NewCompanyName";
            this.NewCompanyName.Size = new System.Drawing.Size(487, 26);
            this.NewCompanyName.TabIndex = 6;
            // 
            // NewCompanyCancelButton
            // 
            this.NewCompanyCancelButton.Location = new System.Drawing.Point(477, 426);
            this.NewCompanyCancelButton.Name = "NewCompanyCancelButton";
            this.NewCompanyCancelButton.Size = new System.Drawing.Size(229, 37);
            this.NewCompanyCancelButton.TabIndex = 5;
            this.NewCompanyCancelButton.Text = "Cancel";
            this.NewCompanyCancelButton.UseVisualStyleBackColor = true;
            this.NewCompanyCancelButton.Click += new System.EventHandler(this.NewCompanyCancelButton_Click);
            // 
            // NewCompanyDoneButton
            // 
            this.NewCompanyDoneButton.Location = new System.Drawing.Point(219, 426);
            this.NewCompanyDoneButton.Name = "NewCompanyDoneButton";
            this.NewCompanyDoneButton.Size = new System.Drawing.Size(228, 37);
            this.NewCompanyDoneButton.TabIndex = 4;
            this.NewCompanyDoneButton.Text = "Done";
            this.NewCompanyDoneButton.UseVisualStyleBackColor = true;
            this.NewCompanyDoneButton.Click += new System.EventHandler(this.NewCompanyDoneButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zip Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Town/City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name";
            // 
            // CompaniesGridView
            // 
            this.CompaniesGridView.AllowUserToResizeColumns = false;
            this.CompaniesGridView.AllowUserToResizeRows = false;
            this.CompaniesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompaniesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CompaniesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CompaniesGridView.ContextMenuStrip = this.EditCompaniesOptions;
            this.CompaniesGridView.Location = new System.Drawing.Point(2, 1);
            this.CompaniesGridView.Name = "CompaniesGridView";
            this.CompaniesGridView.ReadOnly = true;
            this.CompaniesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CompaniesGridView.Size = new System.Drawing.Size(1415, 740);
            this.CompaniesGridView.TabIndex = 0;
            this.CompaniesGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompaniesGridView_CellEndEdit);
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(4, 28);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(1413, 741);
            this.History.TabIndex = 2;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            // 
            // Setup
            // 
            this.Setup.Location = new System.Drawing.Point(4, 28);
            this.Setup.Name = "Setup";
            this.Setup.Size = new System.Drawing.Size(1413, 741);
            this.Setup.TabIndex = 3;
            this.Setup.Text = "Setup";
            this.Setup.UseVisualStyleBackColor = true;
            // 
            // InvoiceItemsOptions
            // 
            this.InvoiceItemsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteItem});
            this.InvoiceItemsOptions.Name = "InvoiceItemsOptions";
            this.InvoiceItemsOptions.Size = new System.Drawing.Size(113, 26);
            this.InvoiceItemsOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.InvoiceItemsOptions_ItemClicked);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(112, 22);
            this.DeleteItem.Text = "DELETE";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1421, 773);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookkeeper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.EditCompaniesOptions.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.Invoices.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptGrandTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptVat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScopeGrid)).EndInit();
            this.SuccessPanel.ResumeLayout(false);
            this.SuccessPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemsGrid)).EndInit();
            this.Companies.ResumeLayout(false);
            this.Companies.PerformLayout();
            this.EditCompaniesPanel.ResumeLayout(false);
            this.EditCompaniesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewCompanyZipCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesGridView)).EndInit();
            this.InvoiceItemsOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip EditCompaniesOptions;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Invoices;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.TabPage Setup;
        private System.Windows.Forms.ComboBox CompanyList;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.ComboBox ItemsList;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.DataGridView InvoiceItemsGrid;
        private System.Windows.Forms.DateTimePicker InvoiceExpiryDate;
        private System.Windows.Forms.Label ValidUntilLabel;
        private System.Windows.Forms.Button GenerateInvoiceButton;
        private System.Windows.Forms.NumericUpDown UnitPrice;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.NumericUpDown TotalPrice;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.TabPage Companies;
        private System.Windows.Forms.DataGridView CompaniesGridView;
        private System.Windows.Forms.ToolStripMenuItem ADD;
        private System.Windows.Forms.ToolStripMenuItem EDIT;
        private System.Windows.Forms.ToolStripMenuItem DELETE;
        private System.Windows.Forms.Panel EditCompaniesPanel;
        private System.Windows.Forms.NumericUpDown NewCompanyZipCode;
        private System.Windows.Forms.TextBox NewCompanyCity;
        private System.Windows.Forms.TextBox NewCompanyAddress;
        private System.Windows.Forms.TextBox NewCompanyName;
        private System.Windows.Forms.Button NewCompanyCancelButton;
        private System.Windows.Forms.Button NewCompanyDoneButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ReceiptTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Totals;
        private System.Windows.Forms.NumericUpDown ReceiptGrandTotal;
        private System.Windows.Forms.NumericUpDown ReceiptVat;
        private System.Windows.Forms.Label Vat;
        private System.Windows.Forms.Button ClearReceiptButton;
        private System.Windows.Forms.Panel SuccessPanel;
        private System.Windows.Forms.Button SuccessOkButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ScopeGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Scope;
        private System.Windows.Forms.RichTextBox ScopeDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddScopeButton;
        private System.Windows.Forms.TextBox NewCompanyContactEmail;
        private System.Windows.Forms.TextBox NewCompanyContactNumbers;
        private System.Windows.Forms.TextBox NewCompanyContactTitle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NewCompanyContactPerson;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip InvoiceItemsOptions;
        private System.Windows.Forms.ToolStripMenuItem DeleteItem;
    }
}