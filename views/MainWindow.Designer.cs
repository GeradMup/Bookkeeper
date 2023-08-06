
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
            this.EditCompaniesOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ADD = new System.Windows.Forms.ToolStripMenuItem();
            this.EDIT = new System.Windows.Forms.ToolStripMenuItem();
            this.DELETE = new System.Windows.Forms.ToolStripMenuItem();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Invoices = new System.Windows.Forms.TabPage();
            this.GenerateInvoiceButton = new System.Windows.Forms.Button();
            this.InvoiceItemsGrid = new System.Windows.Forms.DataGridView();
            this.ManagePricesButton = new System.Windows.Forms.Button();
            this.InvoicesBox = new System.Windows.Forms.GroupBox();
            this.TotalPrice = new System.Windows.Forms.NumericUpDown();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.UnitPrice = new System.Windows.Forms.NumericUpDown();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ValidUntilLabel = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemsList = new System.Windows.Forms.ComboBox();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.CompanyList = new System.Windows.Forms.ComboBox();
            this.ManageCompaniesButton = new System.Windows.Forms.Button();
            this.Quotes = new System.Windows.Forms.TabPage();
            this.History = new System.Windows.Forms.TabPage();
            this.Companies = new System.Windows.Forms.TabPage();
            this.EditCompaniesPanel = new System.Windows.Forms.Panel();
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
            this.Setup = new System.Windows.Forms.TabPage();
            this.EditCompaniesOptions.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.Invoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemsGrid)).BeginInit();
            this.InvoicesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.Companies.SuspendLayout();
            this.EditCompaniesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewCompanyZipCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesGridView)).BeginInit();
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
            this.Tabs.Controls.Add(this.Quotes);
            this.Tabs.Controls.Add(this.History);
            this.Tabs.Controls.Add(this.Companies);
            this.Tabs.Controls.Add(this.Setup);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1363, 626);
            this.Tabs.TabIndex = 2;
            // 
            // Invoices
            // 
            this.Invoices.Controls.Add(this.GenerateInvoiceButton);
            this.Invoices.Controls.Add(this.InvoiceItemsGrid);
            this.Invoices.Controls.Add(this.ManagePricesButton);
            this.Invoices.Controls.Add(this.InvoicesBox);
            this.Invoices.Controls.Add(this.ManageCompaniesButton);
            this.Invoices.Location = new System.Drawing.Point(4, 28);
            this.Invoices.Name = "Invoices";
            this.Invoices.Padding = new System.Windows.Forms.Padding(3);
            this.Invoices.Size = new System.Drawing.Size(1355, 594);
            this.Invoices.TabIndex = 0;
            this.Invoices.Text = "Invoices";
            this.Invoices.UseVisualStyleBackColor = true;
            // 
            // GenerateInvoiceButton
            // 
            this.GenerateInvoiceButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GenerateInvoiceButton.FlatAppearance.BorderSize = 2;
            this.GenerateInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerateInvoiceButton.Location = new System.Drawing.Point(333, 408);
            this.GenerateInvoiceButton.Name = "GenerateInvoiceButton";
            this.GenerateInvoiceButton.Size = new System.Drawing.Size(145, 42);
            this.GenerateInvoiceButton.TabIndex = 4;
            this.GenerateInvoiceButton.Text = "Generate Invoice";
            this.GenerateInvoiceButton.UseVisualStyleBackColor = false;
            // 
            // InvoiceItemsGrid
            // 
            this.InvoiceItemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceItemsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InvoiceItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceItemsGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InvoiceItemsGrid.Location = new System.Drawing.Point(499, 15);
            this.InvoiceItemsGrid.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.InvoiceItemsGrid.Name = "InvoiceItemsGrid";
            this.InvoiceItemsGrid.Size = new System.Drawing.Size(843, 375);
            this.InvoiceItemsGrid.TabIndex = 3;
            // 
            // ManagePricesButton
            // 
            this.ManagePricesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ManagePricesButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ManagePricesButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.ManagePricesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ManagePricesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ManagePricesButton.Location = new System.Drawing.Point(8, 541);
            this.ManagePricesButton.Name = "ManagePricesButton";
            this.ManagePricesButton.Size = new System.Drawing.Size(183, 45);
            this.ManagePricesButton.TabIndex = 2;
            this.ManagePricesButton.Text = "Manage Prices";
            this.ManagePricesButton.UseVisualStyleBackColor = false;
            // 
            // InvoicesBox
            // 
            this.InvoicesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InvoicesBox.AutoSize = true;
            this.InvoicesBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InvoicesBox.Controls.Add(this.TotalPrice);
            this.InvoicesBox.Controls.Add(this.TotalPriceLabel);
            this.InvoicesBox.Controls.Add(this.UnitPrice);
            this.InvoicesBox.Controls.Add(this.UnitPriceLabel);
            this.InvoicesBox.Controls.Add(this.dateTimePicker1);
            this.InvoicesBox.Controls.Add(this.ValidUntilLabel);
            this.InvoicesBox.Controls.Add(this.AddItemButton);
            this.InvoicesBox.Controls.Add(this.Quantity);
            this.InvoicesBox.Controls.Add(this.QuantityLabel);
            this.InvoicesBox.Controls.Add(this.ItemNameLabel);
            this.InvoicesBox.Controls.Add(this.ItemsList);
            this.InvoicesBox.Controls.Add(this.CompanyNameLabel);
            this.InvoicesBox.Controls.Add(this.CompanyList);
            this.InvoicesBox.Location = new System.Drawing.Point(6, 6);
            this.InvoicesBox.Name = "InvoicesBox";
            this.InvoicesBox.Size = new System.Drawing.Size(472, 384);
            this.InvoicesBox.TabIndex = 1;
            this.InvoicesBox.TabStop = false;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DecimalPlaces = 2;
            this.TotalPrice.Location = new System.Drawing.Point(181, 279);
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
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(18, 281);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(89, 19);
            this.TotalPriceLabel.TabIndex = 12;
            this.TotalPriceLabel.Text = "Total Price";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DecimalPlaces = 2;
            this.UnitPrice.Location = new System.Drawing.Point(181, 224);
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
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(18, 226);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(83, 19);
            this.UnitPriceLabel.TabIndex = 10;
            this.UnitPriceLabel.Text = "Unit Price";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // ValidUntilLabel
            // 
            this.ValidUntilLabel.AutoSize = true;
            this.ValidUntilLabel.Location = new System.Drawing.Point(18, 72);
            this.ValidUntilLabel.Name = "ValidUntilLabel";
            this.ValidUntilLabel.Size = new System.Drawing.Size(88, 19);
            this.ValidUntilLabel.TabIndex = 7;
            this.ValidUntilLabel.Text = "Valid Until";
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddItemButton.ForeColor = System.Drawing.Color.Black;
            this.AddItemButton.Location = new System.Drawing.Point(181, 330);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(140, 29);
            this.AddItemButton.TabIndex = 6;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = false;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(181, 171);
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
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(18, 173);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(74, 19);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "Quantity";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(18, 120);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(90, 19);
            this.ItemNameLabel.TabIndex = 3;
            this.ItemNameLabel.Text = "Select Item";
            // 
            // ItemsList
            // 
            this.ItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.Location = new System.Drawing.Point(181, 117);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(281, 27);
            this.ItemsList.TabIndex = 2;
            this.ItemsList.SelectedIndexChanged += new System.EventHandler(this.ItemsList_SelectedIndexChanged);
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(18, 19);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(124, 19);
            this.CompanyNameLabel.TabIndex = 1;
            this.CompanyNameLabel.Text = "Select Company";
            // 
            // CompanyList
            // 
            this.CompanyList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyList.FormattingEnabled = true;
            this.CompanyList.Location = new System.Drawing.Point(181, 16);
            this.CompanyList.Name = "CompanyList";
            this.CompanyList.Size = new System.Drawing.Size(281, 27);
            this.CompanyList.TabIndex = 0;
            this.CompanyList.SelectedIndexChanged += new System.EventHandler(this.CompanyList_SelectedIndexChanged);
            // 
            // ManageCompaniesButton
            // 
            this.ManageCompaniesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ManageCompaniesButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ManageCompaniesButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.ManageCompaniesButton.FlatAppearance.BorderSize = 2;
            this.ManageCompaniesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ManageCompaniesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ManageCompaniesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ManageCompaniesButton.Location = new System.Drawing.Point(206, 541);
            this.ManageCompaniesButton.Name = "ManageCompaniesButton";
            this.ManageCompaniesButton.Size = new System.Drawing.Size(186, 45);
            this.ManageCompaniesButton.TabIndex = 0;
            this.ManageCompaniesButton.Text = "Manage Companies";
            this.ManageCompaniesButton.UseVisualStyleBackColor = false;
            // 
            // Quotes
            // 
            this.Quotes.Location = new System.Drawing.Point(4, 28);
            this.Quotes.Name = "Quotes";
            this.Quotes.Padding = new System.Windows.Forms.Padding(3);
            this.Quotes.Size = new System.Drawing.Size(1355, 594);
            this.Quotes.TabIndex = 1;
            this.Quotes.Text = "Quotes";
            this.Quotes.UseVisualStyleBackColor = true;
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(4, 28);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(1355, 594);
            this.History.TabIndex = 2;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            // 
            // Companies
            // 
            this.Companies.Controls.Add(this.EditCompaniesPanel);
            this.Companies.Controls.Add(this.CompaniesGridView);
            this.Companies.Location = new System.Drawing.Point(4, 28);
            this.Companies.Name = "Companies";
            this.Companies.Size = new System.Drawing.Size(1355, 594);
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
            this.EditCompaniesPanel.Location = new System.Drawing.Point(259, 127);
            this.EditCompaniesPanel.Margin = new System.Windows.Forms.Padding(100);
            this.EditCompaniesPanel.Name = "EditCompaniesPanel";
            this.EditCompaniesPanel.Size = new System.Drawing.Size(759, 306);
            this.EditCompaniesPanel.TabIndex = 1;
            this.EditCompaniesPanel.Visible = false;
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
            this.NewCompanyCancelButton.Location = new System.Drawing.Point(477, 243);
            this.NewCompanyCancelButton.Name = "NewCompanyCancelButton";
            this.NewCompanyCancelButton.Size = new System.Drawing.Size(229, 37);
            this.NewCompanyCancelButton.TabIndex = 5;
            this.NewCompanyCancelButton.Text = "Cancel";
            this.NewCompanyCancelButton.UseVisualStyleBackColor = true;
            this.NewCompanyCancelButton.Click += new System.EventHandler(this.NewCompanyCancelButton_Click);
            // 
            // NewCompanyDoneButton
            // 
            this.NewCompanyDoneButton.Location = new System.Drawing.Point(219, 243);
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
            this.CompaniesGridView.Size = new System.Drawing.Size(1352, 590);
            this.CompaniesGridView.TabIndex = 0;
            this.CompaniesGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompaniesGridView_CellEndEdit);
            // 
            // Setup
            // 
            this.Setup.Location = new System.Drawing.Point(4, 28);
            this.Setup.Name = "Setup";
            this.Setup.Size = new System.Drawing.Size(1355, 594);
            this.Setup.TabIndex = 3;
            this.Setup.Text = "Setup";
            this.Setup.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1363, 626);
            this.Controls.Add(this.Tabs);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Keeper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.EditCompaniesOptions.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.Invoices.ResumeLayout(false);
            this.Invoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemsGrid)).EndInit();
            this.InvoicesBox.ResumeLayout(false);
            this.InvoicesBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            this.Companies.ResumeLayout(false);
            this.Companies.PerformLayout();
            this.EditCompaniesPanel.ResumeLayout(false);
            this.EditCompaniesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewCompanyZipCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip EditCompaniesOptions;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Invoices;
        private System.Windows.Forms.TabPage Quotes;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.TabPage Setup;
        private System.Windows.Forms.Button ManageCompaniesButton;
        private System.Windows.Forms.GroupBox InvoicesBox;
        private System.Windows.Forms.ComboBox CompanyList;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.ComboBox ItemsList;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button ManagePricesButton;
        private System.Windows.Forms.DataGridView InvoiceItemsGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
    }
}