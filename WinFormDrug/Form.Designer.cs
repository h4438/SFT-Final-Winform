namespace WinFormDrug
{
    partial class Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabManu = new System.Windows.Forms.TabPage();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textManuEmail = new System.Windows.Forms.TextBox();
            this.textManuName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textManuAdrs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textManuPhone = new System.Windows.Forms.TextBox();
            this.textManuCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowAllManu = new System.Windows.Forms.Button();
            this.btnSaveManu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnShowAllSplm = new System.Windows.Forms.Button();
            this.btnSaveSplm = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tableSupplement = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.richTextSplmName = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextSplmCate = new System.Windows.Forms.RichTextBox();
            this.richTextSplmUses = new System.Windows.Forms.RichTextBox();
            this.richTextSplmIngredient = new System.Windows.Forms.RichTextBox();
            this.richTextSplmDir = new System.Windows.Forms.RichTextBox();
            this.richTextSplmInactive = new System.Windows.Forms.RichTextBox();
            this.richTextSplmOther = new System.Windows.Forms.RichTextBox();
            this.comboBoxSplmManu = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.richTextSplmWarn = new System.Windows.Forms.RichTextBox();
            this.tabBatch = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxAddedBatch = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBoxBatchSplm = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBatchManu = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBatchExpDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOrderDeliverDate = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBatchQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBatchCost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerOrderSignedDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOrderManu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBatchPrice = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabManu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableSupplement.SuspendLayout();
            this.tabBatch.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 578F));
            this.tableLayoutPanel1.Controls.Add(this.tabControlMain, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1393, 760);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabManu);
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabBatch);
            this.tabControlMain.Location = new System.Drawing.Point(818, 3);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(572, 754);
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.Click += new System.EventHandler(this.changeTab_Click);
            // 
            // tabManu
            // 
            this.tabManu.Controls.Add(this.tableLayoutPanel2);
            this.tabManu.Controls.Add(this.btnShowAllManu);
            this.tabManu.Controls.Add(this.btnSaveManu);
            this.tabManu.Controls.Add(this.label1);
            this.tabManu.Location = new System.Drawing.Point(4, 24);
            this.tabManu.Name = "tabManu";
            this.tabManu.Padding = new System.Windows.Forms.Padding(3);
            this.tabManu.Size = new System.Drawing.Size(564, 726);
            this.tabManu.TabIndex = 0;
            this.tabManu.Text = "Manufacturer";
            this.tabManu.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSearch.Location = new System.Drawing.Point(81, 9);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(743, 23);
            this.textBoxSearch.TabIndex = 15;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(15, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(60, 21);
            this.label28.TabIndex = 14;
            this.label28.Text = "Search:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.69565F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.30434F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textManuEmail, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textManuName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textManuAdrs, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textManuPhone, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textManuCountry, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(113, 90);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(383, 145);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Country";
            // 
            // textManuEmail
            // 
            this.textManuEmail.Location = new System.Drawing.Point(132, 119);
            this.textManuEmail.Name = "textManuEmail";
            this.textManuEmail.Size = new System.Drawing.Size(246, 23);
            this.textManuEmail.TabIndex = 12;
            // 
            // textManuName
            // 
            this.textManuName.Location = new System.Drawing.Point(132, 3);
            this.textManuName.Name = "textManuName";
            this.textManuName.Size = new System.Drawing.Size(246, 23);
            this.textManuName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // textManuAdrs
            // 
            this.textManuAdrs.Location = new System.Drawing.Point(132, 32);
            this.textManuAdrs.Name = "textManuAdrs";
            this.textManuAdrs.Size = new System.Drawing.Size(246, 23);
            this.textManuAdrs.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // textManuPhone
            // 
            this.textManuPhone.Location = new System.Drawing.Point(132, 90);
            this.textManuPhone.Name = "textManuPhone";
            this.textManuPhone.Size = new System.Drawing.Size(246, 23);
            this.textManuPhone.TabIndex = 10;
            // 
            // textManuCountry
            // 
            this.textManuCountry.Location = new System.Drawing.Point(132, 61);
            this.textManuCountry.Name = "textManuCountry";
            this.textManuCountry.Size = new System.Drawing.Size(246, 23);
            this.textManuCountry.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // btnShowAllManu
            // 
            this.btnShowAllManu.Location = new System.Drawing.Point(312, 245);
            this.btnShowAllManu.Name = "btnShowAllManu";
            this.btnShowAllManu.Size = new System.Drawing.Size(82, 33);
            this.btnShowAllManu.TabIndex = 6;
            this.btnShowAllManu.Text = "Show All";
            this.btnShowAllManu.UseVisualStyleBackColor = true;
            this.btnShowAllManu.Click += new System.EventHandler(this.showAllManu_Click);
            // 
            // btnSaveManu
            // 
            this.btnSaveManu.Location = new System.Drawing.Point(170, 245);
            this.btnSaveManu.Name = "btnSaveManu";
            this.btnSaveManu.Size = new System.Drawing.Size(82, 33);
            this.btnSaveManu.TabIndex = 5;
            this.btnSaveManu.Text = "Save";
            this.btnSaveManu.UseVisualStyleBackColor = true;
            this.btnSaveManu.Click += new System.EventHandler(this.saveManufacturer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(224, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manufacturer";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnShowAllSplm);
            this.tabPage1.Controls.Add(this.btnSaveSplm);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.tableSupplement);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(564, 726);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Supplement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnShowAllSplm
            // 
            this.btnShowAllSplm.Location = new System.Drawing.Point(336, 522);
            this.btnShowAllSplm.Name = "btnShowAllSplm";
            this.btnShowAllSplm.Size = new System.Drawing.Size(82, 33);
            this.btnShowAllSplm.TabIndex = 7;
            this.btnShowAllSplm.Text = "Show All";
            this.btnShowAllSplm.UseVisualStyleBackColor = true;
            this.btnShowAllSplm.Click += new System.EventHandler(this.showAllSupplement_Click);
            // 
            // btnSaveSplm
            // 
            this.btnSaveSplm.Location = new System.Drawing.Point(124, 522);
            this.btnSaveSplm.Name = "btnSaveSplm";
            this.btnSaveSplm.Size = new System.Drawing.Size(82, 33);
            this.btnSaveSplm.TabIndex = 6;
            this.btnSaveSplm.Text = "Save";
            this.btnSaveSplm.UseVisualStyleBackColor = true;
            this.btnSaveSplm.Click += new System.EventHandler(this.saveSupplement_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(218, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 32);
            this.label20.TabIndex = 2;
            this.label20.Text = "Supplement";
            // 
            // tableSupplement
            // 
            this.tableSupplement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableSupplement.ColumnCount = 2;
            this.tableSupplement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableSupplement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSupplement.Controls.Add(this.btnClear, 0, 10);
            this.tableSupplement.Controls.Add(this.label7, 0, 9);
            this.tableSupplement.Controls.Add(this.label18, 0, 7);
            this.tableSupplement.Controls.Add(this.label17, 0, 6);
            this.tableSupplement.Controls.Add(this.label16, 0, 5);
            this.tableSupplement.Controls.Add(this.label15, 0, 4);
            this.tableSupplement.Controls.Add(this.label14, 0, 3);
            this.tableSupplement.Controls.Add(this.richTextSplmName, 1, 0);
            this.tableSupplement.Controls.Add(this.label13, 0, 0);
            this.tableSupplement.Controls.Add(this.label12, 0, 2);
            this.tableSupplement.Controls.Add(this.richTextSplmCate, 1, 2);
            this.tableSupplement.Controls.Add(this.richTextSplmUses, 1, 3);
            this.tableSupplement.Controls.Add(this.richTextSplmIngredient, 1, 4);
            this.tableSupplement.Controls.Add(this.richTextSplmDir, 1, 5);
            this.tableSupplement.Controls.Add(this.richTextSplmInactive, 1, 6);
            this.tableSupplement.Controls.Add(this.richTextSplmOther, 1, 7);
            this.tableSupplement.Controls.Add(this.comboBoxSplmManu, 1, 9);
            this.tableSupplement.Controls.Add(this.label19, 0, 8);
            this.tableSupplement.Controls.Add(this.richTextSplmWarn, 1, 8);
            this.tableSupplement.Location = new System.Drawing.Point(5, 61);
            this.tableSupplement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableSupplement.Name = "tableSupplement";
            this.tableSupplement.RowCount = 11;
            this.tableSupplement.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSupplement.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSupplement.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSupplement.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSupplement.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSupplement.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSupplement.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSupplement.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSupplement.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSupplement.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSupplement.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSupplement.Size = new System.Drawing.Size(555, 440);
            this.tableSupplement.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 396);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 33);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clearAllText_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Manufacturer";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(3, 281);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 19);
            this.label18.TabIndex = 16;
            this.label18.Text = "Other";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(3, 225);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 19);
            this.label17.TabIndex = 14;
            this.label17.Text = "Inactive";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(3, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 19);
            this.label16.TabIndex = 12;
            this.label16.Text = "Direction";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(3, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 19);
            this.label15.TabIndex = 10;
            this.label15.Text = "Ingredient";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 19);
            this.label14.TabIndex = 8;
            this.label14.Text = "Uses";
            // 
            // richTextSplmName
            // 
            this.richTextSplmName.Location = new System.Drawing.Point(101, 2);
            this.richTextSplmName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextSplmName.Name = "richTextSplmName";
            this.richTextSplmName.Size = new System.Drawing.Size(446, 39);
            this.richTextSplmName.TabIndex = 0;
            this.richTextSplmName.Text = "";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(3, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Name";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(3, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Category";
            // 
            // richTextSplmCate
            // 
            this.richTextSplmCate.Location = new System.Drawing.Point(101, 45);
            this.richTextSplmCate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextSplmCate.Name = "richTextSplmCate";
            this.richTextSplmCate.Size = new System.Drawing.Size(446, 39);
            this.richTextSplmCate.TabIndex = 7;
            this.richTextSplmCate.Text = "";
            // 
            // richTextSplmUses
            // 
            this.richTextSplmUses.Location = new System.Drawing.Point(101, 88);
            this.richTextSplmUses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextSplmUses.Name = "richTextSplmUses";
            this.richTextSplmUses.Size = new System.Drawing.Size(446, 39);
            this.richTextSplmUses.TabIndex = 9;
            this.richTextSplmUses.Text = "";
            // 
            // richTextSplmIngredient
            // 
            this.richTextSplmIngredient.Location = new System.Drawing.Point(101, 131);
            this.richTextSplmIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextSplmIngredient.Name = "richTextSplmIngredient";
            this.richTextSplmIngredient.Size = new System.Drawing.Size(446, 39);
            this.richTextSplmIngredient.TabIndex = 11;
            this.richTextSplmIngredient.Text = "";
            // 
            // richTextSplmDir
            // 
            this.richTextSplmDir.Location = new System.Drawing.Point(101, 174);
            this.richTextSplmDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextSplmDir.Name = "richTextSplmDir";
            this.richTextSplmDir.Size = new System.Drawing.Size(446, 39);
            this.richTextSplmDir.TabIndex = 13;
            this.richTextSplmDir.Text = "";
            // 
            // richTextSplmInactive
            // 
            this.richTextSplmInactive.Location = new System.Drawing.Point(101, 217);
            this.richTextSplmInactive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextSplmInactive.Name = "richTextSplmInactive";
            this.richTextSplmInactive.Size = new System.Drawing.Size(446, 36);
            this.richTextSplmInactive.TabIndex = 15;
            this.richTextSplmInactive.Text = "";
            // 
            // richTextSplmOther
            // 
            this.richTextSplmOther.Location = new System.Drawing.Point(101, 257);
            this.richTextSplmOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextSplmOther.Name = "richTextSplmOther";
            this.richTextSplmOther.Size = new System.Drawing.Size(446, 67);
            this.richTextSplmOther.TabIndex = 17;
            this.richTextSplmOther.Text = "";
            // 
            // comboBoxSplmManu
            // 
            this.comboBoxSplmManu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSplmManu.FormattingEnabled = true;
            this.comboBoxSplmManu.Location = new System.Drawing.Point(101, 368);
            this.comboBoxSplmManu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSplmManu.Name = "comboBoxSplmManu";
            this.comboBoxSplmManu.Size = new System.Drawing.Size(451, 23);
            this.comboBoxSplmManu.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(3, 336);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 19);
            this.label19.TabIndex = 19;
            this.label19.Text = "Warning";
            // 
            // richTextSplmWarn
            // 
            this.richTextSplmWarn.Location = new System.Drawing.Point(101, 328);
            this.richTextSplmWarn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextSplmWarn.Name = "richTextSplmWarn";
            this.richTextSplmWarn.Size = new System.Drawing.Size(446, 36);
            this.richTextSplmWarn.TabIndex = 21;
            this.richTextSplmWarn.Text = "";
            // 
            // tabBatch
            // 
            this.tabBatch.Controls.Add(this.button1);
            this.tabBatch.Controls.Add(this.comboBoxAddedBatch);
            this.tabBatch.Controls.Add(this.label25);
            this.tabBatch.Controls.Add(this.tableLayoutPanel3);
            this.tabBatch.Controls.Add(this.button3);
            this.tabBatch.Controls.Add(this.button2);
            this.tabBatch.Controls.Add(this.label26);
            this.tabBatch.Location = new System.Drawing.Point(4, 24);
            this.tabBatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBatch.Name = "tabBatch";
            this.tabBatch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBatch.Size = new System.Drawing.Size(564, 726);
            this.tabBatch.TabIndex = 3;
            this.tabBatch.Text = "Batch";
            this.tabBatch.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "New order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createInOrder_Click);
            // 
            // comboBoxAddedBatch
            // 
            this.comboBoxAddedBatch.FormattingEnabled = true;
            this.comboBoxAddedBatch.Location = new System.Drawing.Point(228, 86);
            this.comboBoxAddedBatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAddedBatch.Name = "comboBoxAddedBatch";
            this.comboBoxAddedBatch.Size = new System.Drawing.Size(196, 23);
            this.comboBoxAddedBatch.TabIndex = 16;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(98, 89);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 19);
            this.label25.TabIndex = 15;
            this.label25.Text = "AddedBatch";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.39695F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.60305F));
            this.tableLayoutPanel3.Controls.Add(this.label27, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxBatchSplm, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerBatchManu, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerBatchExpDate, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerOrderDeliverDate, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.label24, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label21, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.label23, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label22, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.textBatchQuantity, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBatchCost, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerOrderSignedDate, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxOrderManu, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.textBatchPrice, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(74, 215);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(455, 249);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(3, 4);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(145, 19);
            this.label27.TabIndex = 25;
            this.label27.Text = "Supplement";
            // 
            // comboBoxBatchSplm
            // 
            this.comboBoxBatchSplm.FormattingEnabled = true;
            this.comboBoxBatchSplm.Location = new System.Drawing.Point(154, 2);
            this.comboBoxBatchSplm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBatchSplm.Name = "comboBoxBatchSplm";
            this.comboBoxBatchSplm.Size = new System.Drawing.Size(295, 23);
            this.comboBoxBatchSplm.TabIndex = 24;
            // 
            // dateTimePickerBatchManu
            // 
            this.dateTimePickerBatchManu.Location = new System.Drawing.Point(154, 116);
            this.dateTimePickerBatchManu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBatchManu.Name = "dateTimePickerBatchManu";
            this.dateTimePickerBatchManu.Size = new System.Drawing.Size(295, 23);
            this.dateTimePickerBatchManu.TabIndex = 22;
            // 
            // dateTimePickerBatchExpDate
            // 
            this.dateTimePickerBatchExpDate.Location = new System.Drawing.Point(154, 143);
            this.dateTimePickerBatchExpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBatchExpDate.Name = "dateTimePickerBatchExpDate";
            this.dateTimePickerBatchExpDate.Size = new System.Drawing.Size(295, 23);
            this.dateTimePickerBatchExpDate.TabIndex = 15;
            // 
            // dateTimePickerOrderDeliverDate
            // 
            this.dateTimePickerOrderDeliverDate.Location = new System.Drawing.Point(154, 197);
            this.dateTimePickerOrderDeliverDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerOrderDeliverDate.Name = "dateTimePickerOrderDeliverDate";
            this.dateTimePickerOrderDeliverDate.Size = new System.Drawing.Size(295, 23);
            this.dateTimePickerOrderDeliverDate.TabIndex = 15;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(3, 90);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(145, 19);
            this.label24.TabIndex = 17;
            this.label24.Text = "Price per Batch";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(3, 226);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(145, 19);
            this.label21.TabIndex = 11;
            this.label21.Text = "Manufacturer";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(3, 199);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(145, 19);
            this.label23.TabIndex = 16;
            this.label23.Text = "Deliver Date";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(3, 172);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(145, 19);
            this.label22.TabIndex = 15;
            this.label22.Text = "Signed Date";
            // 
            // textBatchQuantity
            // 
            this.textBatchQuantity.Location = new System.Drawing.Point(154, 30);
            this.textBatchQuantity.Name = "textBatchQuantity";
            this.textBatchQuantity.Size = new System.Drawing.Size(295, 23);
            this.textBatchQuantity.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cost per Batch";
            // 
            // textBatchCost
            // 
            this.textBatchCost.Location = new System.Drawing.Point(154, 59);
            this.textBatchCost.Name = "textBatchCost";
            this.textBatchCost.Size = new System.Drawing.Size(295, 23);
            this.textBatchCost.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "Quantity";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Manufacture Date";
            // 
            // dateTimePickerOrderSignedDate
            // 
            this.dateTimePickerOrderSignedDate.Location = new System.Drawing.Point(154, 170);
            this.dateTimePickerOrderSignedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerOrderSignedDate.Name = "dateTimePickerOrderSignedDate";
            this.dateTimePickerOrderSignedDate.Size = new System.Drawing.Size(295, 23);
            this.dateTimePickerOrderSignedDate.TabIndex = 21;
            // 
            // comboBoxOrderManu
            // 
            this.comboBoxOrderManu.FormattingEnabled = true;
            this.comboBoxOrderManu.Location = new System.Drawing.Point(154, 224);
            this.comboBoxOrderManu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxOrderManu.Name = "comboBoxOrderManu";
            this.comboBoxOrderManu.Size = new System.Drawing.Size(295, 23);
            this.comboBoxOrderManu.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Expire Date";
            // 
            // textBatchPrice
            // 
            this.textBatchPrice.Location = new System.Drawing.Point(154, 88);
            this.textBatchPrice.Name = "textBatchPrice";
            this.textBatchPrice.Size = new System.Drawing.Size(295, 23);
            this.textBatchPrice.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 487);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addBatch_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(197, 14);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(210, 32);
            this.label26.TabIndex = 3;
            this.label26.Text = "Supplement Batch";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(809, 750);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 812);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label28);
            this.Name = "Form";
            this.Text = "WinForm";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabManu.ResumeLayout(false);
            this.tabManu.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableSupplement.ResumeLayout(false);
            this.tableSupplement.PerformLayout();
            this.tabBatch.ResumeLayout(false);
            this.tabBatch.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TabControl tabControlMain;
        private TabPage tabManu;
        private Label label1;
        private Button btnShowAllManu;
        private Button btnSaveManu;
        private TabPage tabPage1;
        private TableLayoutPanel tableSupplement;
        private RichTextBox richTextSplmName;
        private Label label13;
        private Label label12;
        private RichTextBox richTextSplmCate;
        private Label label16;
        private Label label15;
        private Label label14;
        private RichTextBox richTextSplmUses;
        private RichTextBox richTextSplmIngredient;
        private RichTextBox richTextSplmDir;
        private Label label19;
        private Label label18;
        private Label label17;
        private RichTextBox richTextSplmInactive;
        private RichTextBox richTextSplmOther;
        private ComboBox comboBoxSplmManu;
        private Label label20;
        private TextBox textManuEmail;
        private Button btnShowAllSplm;
        private Button btnSaveSplm;
        private Label label7;
        private RichTextBox richTextSplmWarn;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TextBox textManuName;
        private Label label3;
        private TextBox textManuAdrs;
        private Label label4;
        private TextBox textManuPhone;
        private TextBox textManuCountry;
        private Label label5;
        private Label label6;
        private Button btnClear;
        private TabPage tabBatch;
        private Label label26;
        private Button button3;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label8;
        private TextBox textBatchQuantity;
        private Label label9;
        private TextBox textBatchCost;
        private Label label10;
        private Label label11;
        private Label label21;
        private Label label24;
        private Label label23;
        private Label label22;
        private DateTimePicker dateTimePickerOrderDeliverDate;
        private TextBox textBatchPrice;
        private DateTimePicker dateTimePickerBatchExpDate;
        private DateTimePicker dateTimePickerOrderSignedDate;
        private DateTimePicker dateTimePickerBatchManu;
        private ComboBox comboBoxOrderManu;
        private ComboBox comboBoxAddedBatch;
        private Label label25;
        private Label label27;
        private ComboBox comboBoxBatchSplm;
        private Button button1;
        private TextBox textBoxSearch;
        private Label label28;
    }
}