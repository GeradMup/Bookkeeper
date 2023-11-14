
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
            this.RefInvoice = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddScopeButton = new System.Windows.Forms.Button();
            this.Scope = new System.Windows.Forms.TextBox();
            this.ScopeDescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InvoiceQuoteToggleLabel = new System.Windows.Forms.Label();
            this.InvoicePoNumberLabel = new System.Windows.Forms.Label();
            this.InvoicePoNumber = new System.Windows.Forms.TextBox();
            this.InvoiceCheckbox = new System.Windows.Forms.CheckBox();
            this.ClearReceiptButton = new System.Windows.Forms.Button();
            this.ReceiptGrandTotal = new System.Windows.Forms.NumericUpDown();
            this.GenerateInvoiceButton = new System.Windows.Forms.Button();
            this.ReceiptTotal = new System.Windows.Forms.NumericUpDown();
            this.ReceiptVat = new System.Windows.Forms.NumericUpDown();
            this.Totals = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Vat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuotingCompany = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
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
            this.ScopeItemsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteScope = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoiceItemsGrid = new System.Windows.Forms.DataGridView();
            this.InvoiceItemsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompanyDetailspPanel = new System.Windows.Forms.Panel();
            this.RecipientVat = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.RecipientEmail = new System.Windows.Forms.Label();
            this.RecipientTown = new System.Windows.Forms.Label();
            this.RecipientZipCode = new System.Windows.Forms.Label();
            this.RecipientRepresentative = new System.Windows.Forms.Label();
            this.RecipientTitle = new System.Windows.Forms.Label();
            this.RecipientNumbers = new System.Windows.Forms.Label();
            this.RecipientAddress = new System.Windows.Forms.Label();
            this.RecipientName = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.HistoryMonths = new System.Windows.Forms.ComboBox();
            this.HistoryAddAttachments = new System.Windows.Forms.Button();
            this.HistoryAttachmentsGrid = new System.Windows.Forms.DataGridView();
            this.HistoryAttachmentsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DELETE_ATTACHMENT = new System.Windows.Forms.ToolStripMenuItem();
            this.VIEW_ATTACHMENT = new System.Windows.Forms.ToolStripMenuItem();
            this.UseAsReferenceButton = new System.Windows.Forms.Button();
            this.Label222 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.HistoryNumberFilter = new System.Windows.Forms.TextBox();
            this.HistoryCompanyFilter = new System.Windows.Forms.TextBox();
            this.HistoryDateFilter = new System.Windows.Forms.TextBox();
            this.HistoryAllInvoicesGrid = new System.Windows.Forms.DataGridView();
            this.HistoryInvoiceTotal = new System.Windows.Forms.NumericUpDown();
            this.HistoryScopeItemsGrid = new System.Windows.Forms.DataGridView();
            this.HistoryInvoicesGrid = new System.Windows.Forms.DataGridView();
            this.Quotes = new System.Windows.Forms.TabPage();
            this.QuotesMonthFilter = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.QuotesAddButton = new System.Windows.Forms.Button();
            this.QuotesGrid = new System.Windows.Forms.DataGridView();
            this.QuotesGridOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.VIEW_QUOTE = new System.Windows.Forms.ToolStripMenuItem();
            this.Clients = new System.Windows.Forms.TabPage();
            this.EditCompaniesPanel = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.NewClientVat = new System.Windows.Forms.TextBox();
            this.NewClientContactEmail = new System.Windows.Forms.TextBox();
            this.NewClientContactNumbers = new System.Windows.Forms.TextBox();
            this.NewClientContactTitle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NewClientContactPerson = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NewClientZipCode = new System.Windows.Forms.NumericUpDown();
            this.NewClientCity = new System.Windows.Forms.TextBox();
            this.NewClientAddress = new System.Windows.Forms.TextBox();
            this.NewClientName = new System.Windows.Forms.TextBox();
            this.NewClientCancelButton = new System.Windows.Forms.Button();
            this.NewClientDoneButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientsGridView = new System.Windows.Forms.DataGridView();
            this.Companies = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OurCompanyNumber = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.OurCompanyCancelButton = new System.Windows.Forms.Button();
            this.OurCompanySubmitButton = new System.Windows.Forms.Button();
            this.OurCompanyFooter = new System.Windows.Forms.TextBox();
            this.OurCompanyLogo = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.OurCompanyEditButton = new System.Windows.Forms.Button();
            this.OurCompanyNewButton = new System.Windows.Forms.Button();
            this.OurCompanyVendorNumber = new System.Windows.Forms.TextBox();
            this.OurCompanyVatNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.OurCompanies = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.BankDetailsEditButton = new System.Windows.Forms.Button();
            this.BankDetailsSaveButton = new System.Windows.Forms.Button();
            this.BankDetailsNewButton = new System.Windows.Forms.Button();
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
            this.ScopeItemsOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemsGrid)).BeginInit();
            this.InvoiceItemsOptions.SuspendLayout();
            this.CompanyDetailspPanel.SuspendLayout();
            this.History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryAttachmentsGrid)).BeginInit();
            this.HistoryAttachmentsOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryAllInvoicesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryInvoiceTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryScopeItemsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryInvoicesGrid)).BeginInit();
            this.Quotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuotesGrid)).BeginInit();
            this.QuotesGridOptions.SuspendLayout();
            this.Clients.SuspendLayout();
            this.EditCompaniesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewClientZipCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).BeginInit();
            this.Companies.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.Tabs.Controls.Add(this.History);
            this.Tabs.Controls.Add(this.Quotes);
            this.Tabs.Controls.Add(this.Clients);
            this.Tabs.Controls.Add(this.Companies);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1530, 837);
            this.Tabs.TabIndex = 2;
            this.Tabs.Deselected += new System.Windows.Forms.TabControlEventHandler(this.Tabs_Deselected);
            this.Tabs.TabIndexChanged += new System.EventHandler(this.Tabs_TabIndexChanged);
            // 
            // Invoices
            // 
            this.Invoices.Controls.Add(this.RefInvoice);
            this.Invoices.Controls.Add(this.panel3);
            this.Invoices.Controls.Add(this.panel2);
            this.Invoices.Controls.Add(this.panel1);
            this.Invoices.Controls.Add(this.ScopeGrid);
            this.Invoices.Controls.Add(this.InvoiceItemsGrid);
            this.Invoices.Controls.Add(this.CompanyDetailspPanel);
            this.Invoices.Location = new System.Drawing.Point(4, 28);
            this.Invoices.Name = "Invoices";
            this.Invoices.Padding = new System.Windows.Forms.Padding(3);
            this.Invoices.Size = new System.Drawing.Size(1522, 805);
            this.Invoices.TabIndex = 0;
            this.Invoices.Text = "Invoices";
            this.Invoices.UseVisualStyleBackColor = true;
            // 
            // RefInvoice
            // 
            this.RefInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefInvoice.AutoSize = true;
            this.RefInvoice.Location = new System.Drawing.Point(739, 781);
            this.RefInvoice.Name = "RefInvoice";
            this.RefInvoice.Size = new System.Drawing.Size(147, 19);
            this.RefInvoice.TabIndex = 20;
            this.RefInvoice.Text = "Reference Invoice :";
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
            this.panel3.Size = new System.Drawing.Size(676, 146);
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
            this.label8.Location = new System.Drawing.Point(15, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 16);
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
            this.panel2.Controls.Add(this.InvoiceQuoteToggleLabel);
            this.panel2.Controls.Add(this.InvoicePoNumberLabel);
            this.panel2.Controls.Add(this.InvoicePoNumber);
            this.panel2.Controls.Add(this.InvoiceCheckbox);
            this.panel2.Controls.Add(this.ClearReceiptButton);
            this.panel2.Controls.Add(this.ReceiptGrandTotal);
            this.panel2.Controls.Add(this.GenerateInvoiceButton);
            this.panel2.Controls.Add(this.ReceiptTotal);
            this.panel2.Controls.Add(this.ReceiptVat);
            this.panel2.Controls.Add(this.Totals);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Vat);
            this.panel2.Location = new System.Drawing.Point(743, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 174);
            this.panel2.TabIndex = 17;
            // 
            // InvoiceQuoteToggleLabel
            // 
            this.InvoiceQuoteToggleLabel.AutoSize = true;
            this.InvoiceQuoteToggleLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceQuoteToggleLabel.Location = new System.Drawing.Point(6, 13);
            this.InvoiceQuoteToggleLabel.Name = "InvoiceQuoteToggleLabel";
            this.InvoiceQuoteToggleLabel.Size = new System.Drawing.Size(90, 28);
            this.InvoiceQuoteToggleLabel.TabIndex = 20;
            this.InvoiceQuoteToggleLabel.Text = "QUOTE";
            // 
            // InvoicePoNumberLabel
            // 
            this.InvoicePoNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoicePoNumberLabel.AutoSize = true;
            this.InvoicePoNumberLabel.Location = new System.Drawing.Point(318, 23);
            this.InvoicePoNumberLabel.Name = "InvoicePoNumberLabel";
            this.InvoicePoNumberLabel.Size = new System.Drawing.Size(100, 19);
            this.InvoicePoNumberLabel.TabIndex = 19;
            this.InvoicePoNumberLabel.Text = "PO NUMBER";
            this.InvoicePoNumberLabel.Visible = false;
            // 
            // InvoicePoNumber
            // 
            this.InvoicePoNumber.Location = new System.Drawing.Point(499, 18);
            this.InvoicePoNumber.Name = "InvoicePoNumber";
            this.InvoicePoNumber.Size = new System.Drawing.Size(271, 26);
            this.InvoicePoNumber.TabIndex = 18;
            this.InvoicePoNumber.Visible = false;
            // 
            // InvoiceCheckbox
            // 
            this.InvoiceCheckbox.AutoSize = true;
            this.InvoiceCheckbox.Location = new System.Drawing.Point(11, 54);
            this.InvoiceCheckbox.Name = "InvoiceCheckbox";
            this.InvoiceCheckbox.Size = new System.Drawing.Size(141, 23);
            this.InvoiceCheckbox.TabIndex = 17;
            this.InvoiceCheckbox.Text = "Invoice / Quote";
            this.InvoiceCheckbox.UseVisualStyleBackColor = true;
            this.InvoiceCheckbox.CheckedChanged += new System.EventHandler(this.InvoiceCheckbox_CheckedChanged);
            // 
            // ClearReceiptButton
            // 
            this.ClearReceiptButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClearReceiptButton.FlatAppearance.BorderSize = 2;
            this.ClearReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearReceiptButton.Location = new System.Drawing.Point(11, 94);
            this.ClearReceiptButton.Name = "ClearReceiptButton";
            this.ClearReceiptButton.Size = new System.Drawing.Size(246, 31);
            this.ClearReceiptButton.TabIndex = 13;
            this.ClearReceiptButton.Text = "Clear Invoice";
            this.ClearReceiptButton.UseVisualStyleBackColor = false;
            this.ClearReceiptButton.Click += new System.EventHandler(this.ClearReceiptButton_Click);
            // 
            // ReceiptGrandTotal
            // 
            this.ReceiptGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceiptGrandTotal.DecimalPlaces = 2;
            this.ReceiptGrandTotal.InterceptArrowKeys = false;
            this.ReceiptGrandTotal.Location = new System.Drawing.Point(499, 138);
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
            this.GenerateInvoiceButton.Location = new System.Drawing.Point(11, 134);
            this.GenerateInvoiceButton.Name = "GenerateInvoiceButton";
            this.GenerateInvoiceButton.Size = new System.Drawing.Size(246, 31);
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
            this.ReceiptTotal.Location = new System.Drawing.Point(499, 60);
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
            this.ReceiptVat.Location = new System.Drawing.Point(499, 99);
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
            this.Totals.Location = new System.Drawing.Point(318, 62);
            this.Totals.Name = "Totals";
            this.Totals.Size = new System.Drawing.Size(152, 19);
            this.Totals.TabIndex = 6;
            this.Totals.Text = "Total Excluding Vat";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grand Total";
            // 
            // Vat
            // 
            this.Vat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Vat.AutoSize = true;
            this.Vat.Location = new System.Drawing.Point(318, 100);
            this.Vat.Name = "Vat";
            this.Vat.Size = new System.Drawing.Size(37, 19);
            this.Vat.TabIndex = 8;
            this.Vat.Text = "VAT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.QuotingCompany);
            this.panel1.Controls.Add(this.label24);
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
            this.panel1.Size = new System.Drawing.Size(677, 300);
            this.panel1.TabIndex = 16;
            // 
            // QuotingCompany
            // 
            this.QuotingCompany.AutoSize = true;
            this.QuotingCompany.Location = new System.Drawing.Point(174, 12);
            this.QuotingCompany.Name = "QuotingCompany";
            this.QuotingCompany.Size = new System.Drawing.Size(13, 19);
            this.QuotingCompany.TabIndex = 15;
            this.QuotingCompany.Text = ".";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 19);
            this.label24.TabIndex = 14;
            this.label24.Text = "Quoting As";
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddItemButton.ForeColor = System.Drawing.Color.Black;
            this.AddItemButton.Location = new System.Drawing.Point(454, 261);
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
            this.TotalPriceLabel.Location = new System.Drawing.Point(16, 266);
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
            this.TotalPrice.Location = new System.Drawing.Point(178, 264);
            this.TotalPrice.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Size = new System.Drawing.Size(241, 26);
            this.TotalPrice.TabIndex = 13;
            this.TotalPrice.ThousandsSeparator = true;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(16, 55);
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
            this.CompanyList.Location = new System.Drawing.Point(178, 52);
            this.CompanyList.Name = "CompanyList";
            this.CompanyList.Size = new System.Drawing.Size(481, 27);
            this.CompanyList.TabIndex = 0;
            this.CompanyList.SelectedIndexChanged += new System.EventHandler(this.CompanyList_SelectedIndexChanged);
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(15, 227);
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
            this.UnitPrice.Location = new System.Drawing.Point(178, 225);
            this.UnitPrice.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(241, 26);
            this.UnitPrice.TabIndex = 11;
            this.UnitPrice.ThousandsSeparator = true;
            this.UnitPrice.ValueChanged += new System.EventHandler(this.UnitPrice_ValueChanged);
            this.UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitPrice_KeyPress);
            // 
            // ValidUntilLabel
            // 
            this.ValidUntilLabel.AutoSize = true;
            this.ValidUntilLabel.Location = new System.Drawing.Point(15, 102);
            this.ValidUntilLabel.Name = "ValidUntilLabel";
            this.ValidUntilLabel.Size = new System.Drawing.Size(88, 19);
            this.ValidUntilLabel.TabIndex = 7;
            this.ValidUntilLabel.Text = "Valid Until";
            // 
            // InvoiceExpiryDate
            // 
            this.InvoiceExpiryDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceExpiryDate.Location = new System.Drawing.Point(178, 96);
            this.InvoiceExpiryDate.Name = "InvoiceExpiryDate";
            this.InvoiceExpiryDate.Size = new System.Drawing.Size(481, 26);
            this.InvoiceExpiryDate.TabIndex = 9;
            // 
            // ItemsList
            // 
            this.ItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.Location = new System.Drawing.Point(178, 139);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(481, 27);
            this.ItemsList.TabIndex = 2;
            this.ItemsList.SelectedIndexChanged += new System.EventHandler(this.ItemsList_SelectedIndexChanged);
            this.ItemsList.Enter += new System.EventHandler(this.ItemsList_Enter);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(16, 184);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(74, 19);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "Quantity";
            // 
            // Quantity
            // 
            this.Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Quantity.Location = new System.Drawing.Point(178, 182);
            this.Quantity.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(241, 26);
            this.Quantity.TabIndex = 5;
            this.Quantity.ValueChanged += new System.EventHandler(this.Quantity_ValueChanged);
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(15, 142);
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
            this.ScopeGrid.ContextMenuStrip = this.ScopeItemsOptions;
            this.ScopeGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ScopeGrid.Location = new System.Drawing.Point(686, 315);
            this.ScopeGrid.Margin = new System.Windows.Forms.Padding(1);
            this.ScopeGrid.Name = "ScopeGrid";
            this.ScopeGrid.Size = new System.Drawing.Size(832, 285);
            this.ScopeGrid.TabIndex = 15;
            this.ScopeGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ScopeGrid_CellBeginEdit);
            this.ScopeGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScopeGrid_CellEndEdit);
            this.ScopeGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ScopeGrid_DataError);
            // 
            // ScopeItemsOptions
            // 
            this.ScopeItemsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteScope});
            this.ScopeItemsOptions.Name = "ScopeItemsOptions";
            this.ScopeItemsOptions.Size = new System.Drawing.Size(113, 26);
            this.ScopeItemsOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ScopeItemsOptions_ItemClicked);
            // 
            // DeleteScope
            // 
            this.DeleteScope.Name = "DeleteScope";
            this.DeleteScope.Size = new System.Drawing.Size(112, 22);
            this.DeleteScope.Text = "DELETE";
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
            this.InvoiceItemsGrid.Location = new System.Drawing.Point(686, 6);
            this.InvoiceItemsGrid.Margin = new System.Windows.Forms.Padding(1);
            this.InvoiceItemsGrid.Name = "InvoiceItemsGrid";
            this.InvoiceItemsGrid.Size = new System.Drawing.Size(832, 300);
            this.InvoiceItemsGrid.TabIndex = 3;
            this.InvoiceItemsGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.InvoiceItemsGrid_CellBeginEdit);
            this.InvoiceItemsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceItemsGrid_CellEndEdit);
            this.InvoiceItemsGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.InvoiceItemsGrid_DataError);
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
            // CompanyDetailspPanel
            // 
            this.CompanyDetailspPanel.BackColor = System.Drawing.Color.Ivory;
            this.CompanyDetailspPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyDetailspPanel.Controls.Add(this.RecipientVat);
            this.CompanyDetailspPanel.Controls.Add(this.label26);
            this.CompanyDetailspPanel.Controls.Add(this.label23);
            this.CompanyDetailspPanel.Controls.Add(this.label22);
            this.CompanyDetailspPanel.Controls.Add(this.label21);
            this.CompanyDetailspPanel.Controls.Add(this.label20);
            this.CompanyDetailspPanel.Controls.Add(this.label19);
            this.CompanyDetailspPanel.Controls.Add(this.label18);
            this.CompanyDetailspPanel.Controls.Add(this.label17);
            this.CompanyDetailspPanel.Controls.Add(this.label16);
            this.CompanyDetailspPanel.Controls.Add(this.RecipientEmail);
            this.CompanyDetailspPanel.Controls.Add(this.RecipientTown);
            this.CompanyDetailspPanel.Controls.Add(this.RecipientZipCode);
            this.CompanyDetailspPanel.Controls.Add(this.RecipientRepresentative);
            this.CompanyDetailspPanel.Controls.Add(this.RecipientTitle);
            this.CompanyDetailspPanel.Controls.Add(this.RecipientNumbers);
            this.CompanyDetailspPanel.Controls.Add(this.RecipientAddress);
            this.CompanyDetailspPanel.Controls.Add(this.RecipientName);
            this.CompanyDetailspPanel.Location = new System.Drawing.Point(4, 467);
            this.CompanyDetailspPanel.Name = "CompanyDetailspPanel";
            this.CompanyDetailspPanel.Size = new System.Drawing.Size(676, 279);
            this.CompanyDetailspPanel.TabIndex = 19;
            // 
            // RecipientVat
            // 
            this.RecipientVat.AutoSize = true;
            this.RecipientVat.Location = new System.Drawing.Point(187, 66);
            this.RecipientVat.Name = "RecipientVat";
            this.RecipientVat.Size = new System.Drawing.Size(68, 19);
            this.RecipientVat.TabIndex = 19;
            this.RecipientVat.Text = "Address";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(25, 68);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(96, 19);
            this.label26.TabIndex = 18;
            this.label26.Text = "Vat Number";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(25, 252);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 19);
            this.label23.TabIndex = 17;
            this.label23.Text = "Email";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(25, 223);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 19);
            this.label22.TabIndex = 16;
            this.label22.Text = "Contact Numbers";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(25, 194);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 19);
            this.label21.TabIndex = 15;
            this.label21.Text = "Title";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 163);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(121, 19);
            this.label20.TabIndex = 14;
            this.label20.Text = "Contact Person";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 19);
            this.label19.TabIndex = 13;
            this.label19.Text = "Zip Code";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 19);
            this.label18.TabIndex = 12;
            this.label18.Text = "Town/City";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 19);
            this.label17.TabIndex = 11;
            this.label17.Text = "Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 19);
            this.label16.TabIndex = 10;
            this.label16.Text = "Company";
            // 
            // RecipientEmail
            // 
            this.RecipientEmail.AutoSize = true;
            this.RecipientEmail.Location = new System.Drawing.Point(187, 252);
            this.RecipientEmail.Name = "RecipientEmail";
            this.RecipientEmail.Size = new System.Drawing.Size(63, 19);
            this.RecipientEmail.TabIndex = 9;
            this.RecipientEmail.Text = "label18";
            // 
            // RecipientTown
            // 
            this.RecipientTown.AutoSize = true;
            this.RecipientTown.Location = new System.Drawing.Point(187, 101);
            this.RecipientTown.Name = "RecipientTown";
            this.RecipientTown.Size = new System.Drawing.Size(86, 19);
            this.RecipientTown.TabIndex = 8;
            this.RecipientTown.Text = "Town/City";
            // 
            // RecipientZipCode
            // 
            this.RecipientZipCode.AutoSize = true;
            this.RecipientZipCode.Location = new System.Drawing.Point(187, 132);
            this.RecipientZipCode.Name = "RecipientZipCode";
            this.RecipientZipCode.Size = new System.Drawing.Size(63, 19);
            this.RecipientZipCode.TabIndex = 7;
            this.RecipientZipCode.Text = "label23";
            // 
            // RecipientRepresentative
            // 
            this.RecipientRepresentative.AutoSize = true;
            this.RecipientRepresentative.Location = new System.Drawing.Point(187, 163);
            this.RecipientRepresentative.Name = "RecipientRepresentative";
            this.RecipientRepresentative.Size = new System.Drawing.Size(63, 19);
            this.RecipientRepresentative.TabIndex = 6;
            this.RecipientRepresentative.Text = "label22";
            // 
            // RecipientTitle
            // 
            this.RecipientTitle.AutoSize = true;
            this.RecipientTitle.Location = new System.Drawing.Point(187, 194);
            this.RecipientTitle.Name = "RecipientTitle";
            this.RecipientTitle.Size = new System.Drawing.Size(63, 19);
            this.RecipientTitle.TabIndex = 5;
            this.RecipientTitle.Text = "label21";
            // 
            // RecipientNumbers
            // 
            this.RecipientNumbers.AutoSize = true;
            this.RecipientNumbers.Location = new System.Drawing.Point(187, 223);
            this.RecipientNumbers.Name = "RecipientNumbers";
            this.RecipientNumbers.Size = new System.Drawing.Size(63, 19);
            this.RecipientNumbers.TabIndex = 4;
            this.RecipientNumbers.Text = "label20";
            // 
            // RecipientAddress
            // 
            this.RecipientAddress.AutoSize = true;
            this.RecipientAddress.Location = new System.Drawing.Point(187, 36);
            this.RecipientAddress.Name = "RecipientAddress";
            this.RecipientAddress.Size = new System.Drawing.Size(68, 19);
            this.RecipientAddress.TabIndex = 1;
            this.RecipientAddress.Text = "Address";
            // 
            // RecipientName
            // 
            this.RecipientName.AutoSize = true;
            this.RecipientName.Location = new System.Drawing.Point(187, 7);
            this.RecipientName.Name = "RecipientName";
            this.RecipientName.Size = new System.Drawing.Size(123, 19);
            this.RecipientName.TabIndex = 0;
            this.RecipientName.Text = "Company Name";
            // 
            // History
            // 
            this.History.Controls.Add(this.label33);
            this.History.Controls.Add(this.HistoryMonths);
            this.History.Controls.Add(this.HistoryAddAttachments);
            this.History.Controls.Add(this.HistoryAttachmentsGrid);
            this.History.Controls.Add(this.UseAsReferenceButton);
            this.History.Controls.Add(this.Label222);
            this.History.Controls.Add(this.label31);
            this.History.Controls.Add(this.label30);
            this.History.Controls.Add(this.HistoryNumberFilter);
            this.History.Controls.Add(this.HistoryCompanyFilter);
            this.History.Controls.Add(this.HistoryDateFilter);
            this.History.Controls.Add(this.HistoryAllInvoicesGrid);
            this.History.Controls.Add(this.HistoryInvoiceTotal);
            this.History.Controls.Add(this.HistoryScopeItemsGrid);
            this.History.Controls.Add(this.HistoryInvoicesGrid);
            this.History.Location = new System.Drawing.Point(4, 28);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(1522, 805);
            this.History.TabIndex = 2;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(681, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(105, 19);
            this.label33.TabIndex = 17;
            this.label33.Text = "Select Month";
            // 
            // HistoryMonths
            // 
            this.HistoryMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HistoryMonths.FormattingEnabled = true;
            this.HistoryMonths.Location = new System.Drawing.Point(685, 38);
            this.HistoryMonths.Name = "HistoryMonths";
            this.HistoryMonths.Size = new System.Drawing.Size(327, 27);
            this.HistoryMonths.TabIndex = 16;
            this.HistoryMonths.SelectedIndexChanged += new System.EventHandler(this.HistoryMonths_SelectedIndexChanged);
            // 
            // HistoryAddAttachments
            // 
            this.HistoryAddAttachments.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.HistoryAddAttachments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HistoryAddAttachments.Location = new System.Drawing.Point(339, 570);
            this.HistoryAddAttachments.Name = "HistoryAddAttachments";
            this.HistoryAddAttachments.Size = new System.Drawing.Size(340, 29);
            this.HistoryAddAttachments.TabIndex = 15;
            this.HistoryAddAttachments.Text = "Add Attachement";
            this.HistoryAddAttachments.UseVisualStyleBackColor = false;
            this.HistoryAddAttachments.Click += new System.EventHandler(this.HistoryAddAttachments_Click);
            // 
            // HistoryAttachmentsGrid
            // 
            this.HistoryAttachmentsGrid.AllowUserToResizeColumns = false;
            this.HistoryAttachmentsGrid.AllowUserToResizeRows = false;
            this.HistoryAttachmentsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryAttachmentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryAttachmentsGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.HistoryAttachmentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryAttachmentsGrid.ContextMenuStrip = this.HistoryAttachmentsOptions;
            this.HistoryAttachmentsGrid.Location = new System.Drawing.Point(682, 570);
            this.HistoryAttachmentsGrid.Name = "HistoryAttachmentsGrid";
            this.HistoryAttachmentsGrid.ReadOnly = true;
            this.HistoryAttachmentsGrid.Size = new System.Drawing.Size(832, 213);
            this.HistoryAttachmentsGrid.TabIndex = 14;
            // 
            // HistoryAttachmentsOptions
            // 
            this.HistoryAttachmentsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DELETE_ATTACHMENT,
            this.VIEW_ATTACHMENT});
            this.HistoryAttachmentsOptions.Name = "HistoryAttachmentsOptions";
            this.HistoryAttachmentsOptions.Size = new System.Drawing.Size(113, 48);
            this.HistoryAttachmentsOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.HistoryAttachmentsOptions_ItemClicked);
            // 
            // DELETE_ATTACHMENT
            // 
            this.DELETE_ATTACHMENT.Name = "DELETE_ATTACHMENT";
            this.DELETE_ATTACHMENT.Size = new System.Drawing.Size(112, 22);
            this.DELETE_ATTACHMENT.Text = "DELETE";
            // 
            // VIEW_ATTACHMENT
            // 
            this.VIEW_ATTACHMENT.Name = "VIEW_ATTACHMENT";
            this.VIEW_ATTACHMENT.Size = new System.Drawing.Size(112, 22);
            this.VIEW_ATTACHMENT.Text = "VIEW";
            // 
            // UseAsReferenceButton
            // 
            this.UseAsReferenceButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.UseAsReferenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UseAsReferenceButton.Location = new System.Drawing.Point(8, 570);
            this.UseAsReferenceButton.Name = "UseAsReferenceButton";
            this.UseAsReferenceButton.Size = new System.Drawing.Size(325, 29);
            this.UseAsReferenceButton.TabIndex = 13;
            this.UseAsReferenceButton.Text = "Use As Reference";
            this.UseAsReferenceButton.UseVisualStyleBackColor = false;
            this.UseAsReferenceButton.Click += new System.EventHandler(this.UseAsReferenceButton_Click);
            // 
            // Label222
            // 
            this.Label222.AutoSize = true;
            this.Label222.Location = new System.Drawing.Point(463, 16);
            this.Label222.Name = "Label222";
            this.Label222.Size = new System.Drawing.Size(112, 19);
            this.Label222.TabIndex = 12;
            this.Label222.Text = "Number Filter";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(221, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(121, 19);
            this.label31.TabIndex = 11;
            this.label31.Text = "Company Filter";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(4, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(87, 19);
            this.label30.TabIndex = 10;
            this.label30.Text = "Date Filter";
            // 
            // HistoryNumberFilter
            // 
            this.HistoryNumberFilter.Location = new System.Drawing.Point(467, 38);
            this.HistoryNumberFilter.Name = "HistoryNumberFilter";
            this.HistoryNumberFilter.Size = new System.Drawing.Size(212, 26);
            this.HistoryNumberFilter.TabIndex = 9;
            this.HistoryNumberFilter.TextChanged += new System.EventHandler(this.HistoryNumberFilter_TextChanged);
            // 
            // HistoryCompanyFilter
            // 
            this.HistoryCompanyFilter.Location = new System.Drawing.Point(225, 38);
            this.HistoryCompanyFilter.Name = "HistoryCompanyFilter";
            this.HistoryCompanyFilter.Size = new System.Drawing.Size(236, 26);
            this.HistoryCompanyFilter.TabIndex = 8;
            this.HistoryCompanyFilter.TextChanged += new System.EventHandler(this.HistoryCompanyFilter_TextChanged);
            // 
            // HistoryDateFilter
            // 
            this.HistoryDateFilter.Location = new System.Drawing.Point(8, 38);
            this.HistoryDateFilter.Name = "HistoryDateFilter";
            this.HistoryDateFilter.Size = new System.Drawing.Size(211, 26);
            this.HistoryDateFilter.TabIndex = 7;
            this.HistoryDateFilter.TextChanged += new System.EventHandler(this.HistoryDateFilter_TextChanged);
            // 
            // HistoryAllInvoicesGrid
            // 
            this.HistoryAllInvoicesGrid.AllowUserToAddRows = false;
            this.HistoryAllInvoicesGrid.AllowUserToDeleteRows = false;
            this.HistoryAllInvoicesGrid.AllowUserToResizeColumns = false;
            this.HistoryAllInvoicesGrid.AllowUserToResizeRows = false;
            this.HistoryAllInvoicesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryAllInvoicesGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.HistoryAllInvoicesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryAllInvoicesGrid.Location = new System.Drawing.Point(8, 70);
            this.HistoryAllInvoicesGrid.Name = "HistoryAllInvoicesGrid";
            this.HistoryAllInvoicesGrid.ReadOnly = true;
            this.HistoryAllInvoicesGrid.Size = new System.Drawing.Size(671, 494);
            this.HistoryAllInvoicesGrid.TabIndex = 6;
            this.HistoryAllInvoicesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HistoryAllInvoicesGrid_CellClick);
            this.HistoryAllInvoicesGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HistoryAllInvoicesGrid_CellDoubleClick);
            // 
            // HistoryInvoiceTotal
            // 
            this.HistoryInvoiceTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryInvoiceTotal.DecimalPlaces = 2;
            this.HistoryInvoiceTotal.InterceptArrowKeys = false;
            this.HistoryInvoiceTotal.Location = new System.Drawing.Point(1270, 39);
            this.HistoryInvoiceTotal.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.HistoryInvoiceTotal.Name = "HistoryInvoiceTotal";
            this.HistoryInvoiceTotal.ReadOnly = true;
            this.HistoryInvoiceTotal.Size = new System.Drawing.Size(244, 26);
            this.HistoryInvoiceTotal.TabIndex = 5;
            this.HistoryInvoiceTotal.ThousandsSeparator = true;
            // 
            // HistoryScopeItemsGrid
            // 
            this.HistoryScopeItemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryScopeItemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryScopeItemsGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.HistoryScopeItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryScopeItemsGrid.Location = new System.Drawing.Point(682, 324);
            this.HistoryScopeItemsGrid.Name = "HistoryScopeItemsGrid";
            this.HistoryScopeItemsGrid.ReadOnly = true;
            this.HistoryScopeItemsGrid.Size = new System.Drawing.Size(832, 240);
            this.HistoryScopeItemsGrid.TabIndex = 2;
            // 
            // HistoryInvoicesGrid
            // 
            this.HistoryInvoicesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryInvoicesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryInvoicesGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.HistoryInvoicesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryInvoicesGrid.Location = new System.Drawing.Point(682, 71);
            this.HistoryInvoicesGrid.Name = "HistoryInvoicesGrid";
            this.HistoryInvoicesGrid.ReadOnly = true;
            this.HistoryInvoicesGrid.Size = new System.Drawing.Size(832, 248);
            this.HistoryInvoicesGrid.TabIndex = 1;
            // 
            // Quotes
            // 
            this.Quotes.Controls.Add(this.QuotesMonthFilter);
            this.Quotes.Controls.Add(this.label32);
            this.Quotes.Controls.Add(this.QuotesAddButton);
            this.Quotes.Controls.Add(this.QuotesGrid);
            this.Quotes.Location = new System.Drawing.Point(4, 28);
            this.Quotes.Name = "Quotes";
            this.Quotes.Size = new System.Drawing.Size(1522, 805);
            this.Quotes.TabIndex = 5;
            this.Quotes.Text = "Quotes";
            this.Quotes.UseVisualStyleBackColor = true;
            // 
            // QuotesMonthFilter
            // 
            this.QuotesMonthFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuotesMonthFilter.FormattingEnabled = true;
            this.QuotesMonthFilter.Location = new System.Drawing.Point(136, 65);
            this.QuotesMonthFilter.Name = "QuotesMonthFilter";
            this.QuotesMonthFilter.Size = new System.Drawing.Size(291, 27);
            this.QuotesMonthFilter.TabIndex = 3;
            this.QuotesMonthFilter.SelectedIndexChanged += new System.EventHandler(this.QuotesMonthFilter_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(8, 68);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(105, 19);
            this.label32.TabIndex = 2;
            this.label32.Text = "Select Month";
            // 
            // QuotesAddButton
            // 
            this.QuotesAddButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.QuotesAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuotesAddButton.Location = new System.Drawing.Point(8, 15);
            this.QuotesAddButton.Name = "QuotesAddButton";
            this.QuotesAddButton.Size = new System.Drawing.Size(262, 30);
            this.QuotesAddButton.TabIndex = 1;
            this.QuotesAddButton.Text = "Add Quote";
            this.QuotesAddButton.UseVisualStyleBackColor = false;
            this.QuotesAddButton.Click += new System.EventHandler(this.QuotesAddButton_Click);
            // 
            // QuotesGrid
            // 
            this.QuotesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuotesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QuotesGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuotesGrid.ContextMenuStrip = this.QuotesGridOptions;
            this.QuotesGrid.Location = new System.Drawing.Point(12, 98);
            this.QuotesGrid.Name = "QuotesGrid";
            this.QuotesGrid.Size = new System.Drawing.Size(1502, 699);
            this.QuotesGrid.TabIndex = 0;
            // 
            // QuotesGridOptions
            // 
            this.QuotesGridOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VIEW_QUOTE});
            this.QuotesGridOptions.Name = "QuotesGridOptions";
            this.QuotesGridOptions.Size = new System.Drawing.Size(142, 26);
            this.QuotesGridOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.QuotesGridOptions_ItemClicked);
            // 
            // VIEW_QUOTE
            // 
            this.VIEW_QUOTE.Name = "VIEW_QUOTE";
            this.VIEW_QUOTE.Size = new System.Drawing.Size(141, 22);
            this.VIEW_QUOTE.Text = "VIEW QUOTE";
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.EditCompaniesPanel);
            this.Clients.Controls.Add(this.ClientsGridView);
            this.Clients.Location = new System.Drawing.Point(4, 28);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(1522, 805);
            this.Clients.TabIndex = 4;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // EditCompaniesPanel
            // 
            this.EditCompaniesPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditCompaniesPanel.AutoSize = true;
            this.EditCompaniesPanel.BackColor = System.Drawing.Color.SlateGray;
            this.EditCompaniesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditCompaniesPanel.Controls.Add(this.label25);
            this.EditCompaniesPanel.Controls.Add(this.NewClientVat);
            this.EditCompaniesPanel.Controls.Add(this.NewClientContactEmail);
            this.EditCompaniesPanel.Controls.Add(this.NewClientContactNumbers);
            this.EditCompaniesPanel.Controls.Add(this.NewClientContactTitle);
            this.EditCompaniesPanel.Controls.Add(this.label12);
            this.EditCompaniesPanel.Controls.Add(this.label11);
            this.EditCompaniesPanel.Controls.Add(this.label10);
            this.EditCompaniesPanel.Controls.Add(this.NewClientContactPerson);
            this.EditCompaniesPanel.Controls.Add(this.label9);
            this.EditCompaniesPanel.Controls.Add(this.NewClientZipCode);
            this.EditCompaniesPanel.Controls.Add(this.NewClientCity);
            this.EditCompaniesPanel.Controls.Add(this.NewClientAddress);
            this.EditCompaniesPanel.Controls.Add(this.NewClientName);
            this.EditCompaniesPanel.Controls.Add(this.NewClientCancelButton);
            this.EditCompaniesPanel.Controls.Add(this.NewClientDoneButton);
            this.EditCompaniesPanel.Controls.Add(this.label4);
            this.EditCompaniesPanel.Controls.Add(this.label3);
            this.EditCompaniesPanel.Controls.Add(this.label2);
            this.EditCompaniesPanel.Controls.Add(this.label1);
            this.EditCompaniesPanel.Location = new System.Drawing.Point(382, 56);
            this.EditCompaniesPanel.Margin = new System.Windows.Forms.Padding(100);
            this.EditCompaniesPanel.Name = "EditCompaniesPanel";
            this.EditCompaniesPanel.Size = new System.Drawing.Size(759, 530);
            this.EditCompaniesPanel.TabIndex = 1;
            this.EditCompaniesPanel.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(39, 124);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(96, 19);
            this.label25.TabIndex = 19;
            this.label25.Text = "Vat Number";
            // 
            // NewClientVat
            // 
            this.NewClientVat.Location = new System.Drawing.Point(219, 121);
            this.NewClientVat.Name = "NewClientVat";
            this.NewClientVat.Size = new System.Drawing.Size(487, 26);
            this.NewClientVat.TabIndex = 18;
            // 
            // NewClientContactEmail
            // 
            this.NewClientContactEmail.Location = new System.Drawing.Point(219, 419);
            this.NewClientContactEmail.Name = "NewClientContactEmail";
            this.NewClientContactEmail.Size = new System.Drawing.Size(487, 26);
            this.NewClientContactEmail.TabIndex = 17;
            // 
            // NewClientContactNumbers
            // 
            this.NewClientContactNumbers.Location = new System.Drawing.Point(219, 368);
            this.NewClientContactNumbers.Name = "NewClientContactNumbers";
            this.NewClientContactNumbers.Size = new System.Drawing.Size(487, 26);
            this.NewClientContactNumbers.TabIndex = 16;
            // 
            // NewClientContactTitle
            // 
            this.NewClientContactTitle.Location = new System.Drawing.Point(219, 318);
            this.NewClientContactTitle.Name = "NewClientContactTitle";
            this.NewClientContactTitle.Size = new System.Drawing.Size(487, 26);
            this.NewClientContactTitle.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "Contact Numbers";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Title";
            // 
            // NewClientContactPerson
            // 
            this.NewClientContactPerson.Location = new System.Drawing.Point(219, 269);
            this.NewClientContactPerson.Name = "NewClientContactPerson";
            this.NewClientContactPerson.Size = new System.Drawing.Size(487, 26);
            this.NewClientContactPerson.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Contact Person";
            // 
            // NewClientZipCode
            // 
            this.NewClientZipCode.Location = new System.Drawing.Point(219, 220);
            this.NewClientZipCode.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NewClientZipCode.Name = "NewClientZipCode";
            this.NewClientZipCode.Size = new System.Drawing.Size(168, 26);
            this.NewClientZipCode.TabIndex = 9;
            this.NewClientZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewCompanyZipCode_KeyPress);
            // 
            // NewClientCity
            // 
            this.NewClientCity.Location = new System.Drawing.Point(219, 169);
            this.NewClientCity.Name = "NewClientCity";
            this.NewClientCity.Size = new System.Drawing.Size(487, 26);
            this.NewClientCity.TabIndex = 8;
            // 
            // NewClientAddress
            // 
            this.NewClientAddress.Location = new System.Drawing.Point(219, 74);
            this.NewClientAddress.Name = "NewClientAddress";
            this.NewClientAddress.Size = new System.Drawing.Size(487, 26);
            this.NewClientAddress.TabIndex = 7;
            // 
            // NewClientName
            // 
            this.NewClientName.Location = new System.Drawing.Point(219, 26);
            this.NewClientName.Name = "NewClientName";
            this.NewClientName.Size = new System.Drawing.Size(487, 26);
            this.NewClientName.TabIndex = 6;
            // 
            // NewClientCancelButton
            // 
            this.NewClientCancelButton.Location = new System.Drawing.Point(477, 471);
            this.NewClientCancelButton.Name = "NewClientCancelButton";
            this.NewClientCancelButton.Size = new System.Drawing.Size(229, 37);
            this.NewClientCancelButton.TabIndex = 5;
            this.NewClientCancelButton.Text = "Cancel";
            this.NewClientCancelButton.UseVisualStyleBackColor = true;
            this.NewClientCancelButton.Click += new System.EventHandler(this.NewCompanyCancelButton_Click);
            // 
            // NewClientDoneButton
            // 
            this.NewClientDoneButton.Location = new System.Drawing.Point(219, 471);
            this.NewClientDoneButton.Name = "NewClientDoneButton";
            this.NewClientDoneButton.Size = new System.Drawing.Size(228, 37);
            this.NewClientDoneButton.TabIndex = 4;
            this.NewClientDoneButton.Text = "Done";
            this.NewClientDoneButton.UseVisualStyleBackColor = true;
            this.NewClientDoneButton.Click += new System.EventHandler(this.NewCompanyDoneButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zip Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 172);
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
            // ClientsGridView
            // 
            this.ClientsGridView.AllowUserToAddRows = false;
            this.ClientsGridView.AllowUserToDeleteRows = false;
            this.ClientsGridView.AllowUserToResizeColumns = false;
            this.ClientsGridView.AllowUserToResizeRows = false;
            this.ClientsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClientsGridView.ContextMenuStrip = this.EditCompaniesOptions;
            this.ClientsGridView.Location = new System.Drawing.Point(3, 4);
            this.ClientsGridView.Name = "ClientsGridView";
            this.ClientsGridView.ReadOnly = true;
            this.ClientsGridView.RowHeadersVisible = false;
            this.ClientsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ClientsGridView.Size = new System.Drawing.Size(1511, 793);
            this.ClientsGridView.TabIndex = 0;
            // 
            // Companies
            // 
            this.Companies.Controls.Add(this.panel5);
            this.Companies.Controls.Add(this.panel4);
            this.Companies.Location = new System.Drawing.Point(4, 28);
            this.Companies.Name = "Companies";
            this.Companies.Size = new System.Drawing.Size(1522, 805);
            this.Companies.TabIndex = 3;
            this.Companies.Text = "Companies";
            this.Companies.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Ivory;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.BankDetailsNewButton);
            this.panel5.Controls.Add(this.BankDetailsSaveButton);
            this.panel5.Controls.Add(this.BankDetailsEditButton);
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label38);
            this.panel5.Controls.Add(this.label37);
            this.panel5.Controls.Add(this.label36);
            this.panel5.Controls.Add(this.label35);
            this.panel5.Controls.Add(this.label34);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(557, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(567, 346);
            this.panel5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Banking Details";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Ivory;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.OurCompanyNumber);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.OurCompanyCancelButton);
            this.panel4.Controls.Add(this.OurCompanySubmitButton);
            this.panel4.Controls.Add(this.OurCompanyFooter);
            this.panel4.Controls.Add(this.OurCompanyLogo);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.OurCompanyEditButton);
            this.panel4.Controls.Add(this.OurCompanyNewButton);
            this.panel4.Controls.Add(this.OurCompanyVendorNumber);
            this.panel4.Controls.Add(this.OurCompanyVatNumber);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.OurCompanies);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 347);
            this.panel4.TabIndex = 2;
            // 
            // OurCompanyNumber
            // 
            this.OurCompanyNumber.Location = new System.Drawing.Point(195, 246);
            this.OurCompanyNumber.Name = "OurCompanyNumber";
            this.OurCompanyNumber.ReadOnly = true;
            this.OurCompanyNumber.Size = new System.Drawing.Size(294, 26);
            this.OurCompanyNumber.TabIndex = 16;
            this.OurCompanyNumber.Visible = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(27, 246);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 19);
            this.label29.TabIndex = 15;
            this.label29.Text = "Footer";
            this.label29.Visible = false;
            // 
            // OurCompanyCancelButton
            // 
            this.OurCompanyCancelButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.OurCompanyCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OurCompanyCancelButton.Location = new System.Drawing.Point(271, 286);
            this.OurCompanyCancelButton.Name = "OurCompanyCancelButton";
            this.OurCompanyCancelButton.Size = new System.Drawing.Size(95, 43);
            this.OurCompanyCancelButton.TabIndex = 14;
            this.OurCompanyCancelButton.Text = "CANCEL";
            this.OurCompanyCancelButton.UseVisualStyleBackColor = false;
            this.OurCompanyCancelButton.Click += new System.EventHandler(this.OurCompanyCancelButton_Click);
            // 
            // OurCompanySubmitButton
            // 
            this.OurCompanySubmitButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.OurCompanySubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OurCompanySubmitButton.Location = new System.Drawing.Point(388, 286);
            this.OurCompanySubmitButton.Name = "OurCompanySubmitButton";
            this.OurCompanySubmitButton.Size = new System.Drawing.Size(101, 43);
            this.OurCompanySubmitButton.TabIndex = 13;
            this.OurCompanySubmitButton.Text = "SUBMIT";
            this.OurCompanySubmitButton.UseVisualStyleBackColor = false;
            this.OurCompanySubmitButton.Click += new System.EventHandler(this.OurCompanySubmitButton_Click);
            // 
            // OurCompanyFooter
            // 
            this.OurCompanyFooter.Location = new System.Drawing.Point(195, 205);
            this.OurCompanyFooter.Name = "OurCompanyFooter";
            this.OurCompanyFooter.ReadOnly = true;
            this.OurCompanyFooter.Size = new System.Drawing.Size(294, 26);
            this.OurCompanyFooter.TabIndex = 12;
            this.OurCompanyFooter.Enter += new System.EventHandler(this.OurCompanyFooter_Enter);
            // 
            // OurCompanyLogo
            // 
            this.OurCompanyLogo.Location = new System.Drawing.Point(195, 160);
            this.OurCompanyLogo.Name = "OurCompanyLogo";
            this.OurCompanyLogo.ReadOnly = true;
            this.OurCompanyLogo.Size = new System.Drawing.Size(294, 26);
            this.OurCompanyLogo.TabIndex = 11;
            this.OurCompanyLogo.Enter += new System.EventHandler(this.OurCompanyLogo_Enter);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(27, 205);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(56, 19);
            this.label28.TabIndex = 10;
            this.label28.Text = "Footer";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(27, 160);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 19);
            this.label27.TabIndex = 9;
            this.label27.Text = "Logo";
            // 
            // OurCompanyEditButton
            // 
            this.OurCompanyEditButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.OurCompanyEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OurCompanyEditButton.Location = new System.Drawing.Point(31, 286);
            this.OurCompanyEditButton.Name = "OurCompanyEditButton";
            this.OurCompanyEditButton.Size = new System.Drawing.Size(96, 43);
            this.OurCompanyEditButton.TabIndex = 8;
            this.OurCompanyEditButton.Text = "EDIT";
            this.OurCompanyEditButton.UseVisualStyleBackColor = false;
            this.OurCompanyEditButton.Click += new System.EventHandler(this.OurCompanyEditButton_Click);
            // 
            // OurCompanyNewButton
            // 
            this.OurCompanyNewButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.OurCompanyNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OurCompanyNewButton.Location = new System.Drawing.Point(144, 286);
            this.OurCompanyNewButton.Name = "OurCompanyNewButton";
            this.OurCompanyNewButton.Size = new System.Drawing.Size(105, 43);
            this.OurCompanyNewButton.TabIndex = 6;
            this.OurCompanyNewButton.Text = "NEW";
            this.OurCompanyNewButton.UseVisualStyleBackColor = false;
            this.OurCompanyNewButton.Click += new System.EventHandler(this.OurCompanyNewButton_Click);
            // 
            // OurCompanyVendorNumber
            // 
            this.OurCompanyVendorNumber.Location = new System.Drawing.Point(195, 112);
            this.OurCompanyVendorNumber.Name = "OurCompanyVendorNumber";
            this.OurCompanyVendorNumber.ReadOnly = true;
            this.OurCompanyVendorNumber.Size = new System.Drawing.Size(294, 26);
            this.OurCompanyVendorNumber.TabIndex = 5;
            // 
            // OurCompanyVatNumber
            // 
            this.OurCompanyVatNumber.Location = new System.Drawing.Point(195, 66);
            this.OurCompanyVatNumber.Name = "OurCompanyVatNumber";
            this.OurCompanyVatNumber.ReadOnly = true;
            this.OurCompanyVatNumber.Size = new System.Drawing.Size(294, 26);
            this.OurCompanyVatNumber.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "Vendor Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "VAT Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "Company";
            // 
            // OurCompanies
            // 
            this.OurCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OurCompanies.FormattingEnabled = true;
            this.OurCompanies.Location = new System.Drawing.Point(195, 15);
            this.OurCompanies.Name = "OurCompanies";
            this.OurCompanies.Size = new System.Drawing.Size(294, 27);
            this.OurCompanies.TabIndex = 0;
            this.OurCompanies.SelectedIndexChanged += new System.EventHandler(this.OurCompanies_SelectedIndexChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Cambria", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(15, 68);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(130, 20);
            this.label34.TabIndex = 1;
            this.label34.Text = "Account Holder";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Cambria", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(15, 111);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(98, 20);
            this.label35.TabIndex = 2;
            this.label35.Text = "Bank Name";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Cambria", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(15, 154);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(114, 20);
            this.label36.TabIndex = 3;
            this.label36.Text = "Branch Name";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Cambria", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(15, 200);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(108, 20);
            this.label37.TabIndex = 4;
            this.label37.Text = "Branch Code";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Cambria", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(15, 248);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(98, 20);
            this.label38.TabIndex = 5;
            this.label38.Text = "Bank Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(334, 26);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(334, 26);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(203, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(334, 26);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(203, 198);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(334, 26);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(203, 246);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(334, 26);
            this.textBox5.TabIndex = 10;
            // 
            // BankDetailsEditButton
            // 
            this.BankDetailsEditButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BankDetailsEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BankDetailsEditButton.Location = new System.Drawing.Point(203, 289);
            this.BankDetailsEditButton.Name = "BankDetailsEditButton";
            this.BankDetailsEditButton.Size = new System.Drawing.Size(162, 40);
            this.BankDetailsEditButton.TabIndex = 11;
            this.BankDetailsEditButton.Text = "EDIT";
            this.BankDetailsEditButton.UseVisualStyleBackColor = false;
            // 
            // BankDetailsSaveButton
            // 
            this.BankDetailsSaveButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BankDetailsSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BankDetailsSaveButton.Location = new System.Drawing.Point(383, 289);
            this.BankDetailsSaveButton.Name = "BankDetailsSaveButton";
            this.BankDetailsSaveButton.Size = new System.Drawing.Size(154, 40);
            this.BankDetailsSaveButton.TabIndex = 12;
            this.BankDetailsSaveButton.Text = "SAVE";
            this.BankDetailsSaveButton.UseVisualStyleBackColor = false;
            // 
            // BankDetailsNewButton
            // 
            this.BankDetailsNewButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BankDetailsNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BankDetailsNewButton.Location = new System.Drawing.Point(19, 289);
            this.BankDetailsNewButton.Name = "BankDetailsNewButton";
            this.BankDetailsNewButton.Size = new System.Drawing.Size(162, 40);
            this.BankDetailsNewButton.TabIndex = 13;
            this.BankDetailsNewButton.Text = "NEW";
            this.BankDetailsNewButton.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1530, 837);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookkeeper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.EditCompaniesOptions.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.Invoices.ResumeLayout(false);
            this.Invoices.PerformLayout();
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
            this.ScopeItemsOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemsGrid)).EndInit();
            this.InvoiceItemsOptions.ResumeLayout(false);
            this.CompanyDetailspPanel.ResumeLayout(false);
            this.CompanyDetailspPanel.PerformLayout();
            this.History.ResumeLayout(false);
            this.History.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryAttachmentsGrid)).EndInit();
            this.HistoryAttachmentsOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryAllInvoicesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryInvoiceTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryScopeItemsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryInvoicesGrid)).EndInit();
            this.Quotes.ResumeLayout(false);
            this.Quotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuotesGrid)).EndInit();
            this.QuotesGridOptions.ResumeLayout(false);
            this.Clients.ResumeLayout(false);
            this.Clients.PerformLayout();
            this.EditCompaniesPanel.ResumeLayout(false);
            this.EditCompaniesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewClientZipCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).EndInit();
            this.Companies.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip EditCompaniesOptions;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Invoices;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.TabPage Companies;
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
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.DataGridView ClientsGridView;
        private System.Windows.Forms.ToolStripMenuItem ADD;
        private System.Windows.Forms.ToolStripMenuItem EDIT;
        private System.Windows.Forms.ToolStripMenuItem DELETE;
        private System.Windows.Forms.Panel EditCompaniesPanel;
        private System.Windows.Forms.NumericUpDown NewClientZipCode;
        private System.Windows.Forms.TextBox NewClientCity;
        private System.Windows.Forms.TextBox NewClientAddress;
        private System.Windows.Forms.TextBox NewClientName;
        private System.Windows.Forms.Button NewClientCancelButton;
        private System.Windows.Forms.Button NewClientDoneButton;
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
        private System.Windows.Forms.DataGridView ScopeGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Scope;
        private System.Windows.Forms.RichTextBox ScopeDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddScopeButton;
        private System.Windows.Forms.TextBox NewClientContactEmail;
        private System.Windows.Forms.TextBox NewClientContactNumbers;
        private System.Windows.Forms.TextBox NewClientContactTitle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NewClientContactPerson;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip InvoiceItemsOptions;
        private System.Windows.Forms.ToolStripMenuItem DeleteItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button OurCompanyNewButton;
        private System.Windows.Forms.TextBox OurCompanyVendorNumber;
        private System.Windows.Forms.TextBox OurCompanyVatNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox OurCompanies;
        private System.Windows.Forms.Button OurCompanyEditButton;
        private System.Windows.Forms.Panel CompanyDetailspPanel;
        private System.Windows.Forms.Label RecipientEmail;
        private System.Windows.Forms.Label RecipientTown;
        private System.Windows.Forms.Label RecipientZipCode;
        private System.Windows.Forms.Label RecipientRepresentative;
        private System.Windows.Forms.Label RecipientTitle;
        private System.Windows.Forms.Label RecipientNumbers;
        private System.Windows.Forms.Label RecipientAddress;
        private System.Windows.Forms.Label RecipientName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label QuotingCompany;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox NewClientVat;
        private System.Windows.Forms.Label RecipientVat;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox OurCompanyFooter;
        private System.Windows.Forms.TextBox OurCompanyLogo;
        private System.Windows.Forms.Button OurCompanySubmitButton;
        private System.Windows.Forms.Button OurCompanyCancelButton;
        private System.Windows.Forms.TextBox OurCompanyNumber;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox InvoiceCheckbox;
        private System.Windows.Forms.ContextMenuStrip ScopeItemsOptions;
        private System.Windows.Forms.DataGridView HistoryScopeItemsGrid;
        private System.Windows.Forms.DataGridView HistoryInvoicesGrid;
        private System.Windows.Forms.NumericUpDown HistoryInvoiceTotal;
        private System.Windows.Forms.DataGridView HistoryAllInvoicesGrid;
        private System.Windows.Forms.Label Label222;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox HistoryNumberFilter;
        private System.Windows.Forms.TextBox HistoryCompanyFilter;
        private System.Windows.Forms.TextBox HistoryDateFilter;
        private System.Windows.Forms.ToolStripMenuItem DeleteScope;
        private System.Windows.Forms.Label RefInvoice;
        private System.Windows.Forms.Button UseAsReferenceButton;
        private System.Windows.Forms.DataGridView HistoryAttachmentsGrid;
        private System.Windows.Forms.Button HistoryAddAttachments;
        private System.Windows.Forms.ContextMenuStrip HistoryAttachmentsOptions;
        private System.Windows.Forms.ToolStripMenuItem DELETE_ATTACHMENT;
        private System.Windows.Forms.ToolStripMenuItem VIEW_ATTACHMENT;
        private System.Windows.Forms.TabPage Quotes;
        private System.Windows.Forms.DataGridView QuotesGrid;
        private System.Windows.Forms.Button QuotesAddButton;
        private System.Windows.Forms.ComboBox QuotesMonthFilter;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ContextMenuStrip QuotesGridOptions;
        private System.Windows.Forms.ToolStripMenuItem VIEW_QUOTE;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox HistoryMonths;
        private System.Windows.Forms.Label InvoicePoNumberLabel;
        private System.Windows.Forms.TextBox InvoicePoNumber;
        private System.Windows.Forms.Label InvoiceQuoteToggleLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BankDetailsNewButton;
        private System.Windows.Forms.Button BankDetailsSaveButton;
        private System.Windows.Forms.Button BankDetailsEditButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
    }
}