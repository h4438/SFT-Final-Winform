﻿namespace WinFormDrug
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabManu = new System.Windows.Forms.TabPage();
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowAllSplm = new System.Windows.Forms.Button();
            this.btnSaveSplm = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tableSupplement = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabManu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableSupplement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 661F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControlMain, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1592, 795);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(923, 787);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabManu);
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Location = new System.Drawing.Point(934, 4);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(654, 787);
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.Click += new System.EventHandler(this.changeTab_Click);
            // 
            // tabManu
            // 
            this.tabManu.Controls.Add(this.tableLayoutPanel2);
            this.tabManu.Controls.Add(this.btnShowAllManu);
            this.tabManu.Controls.Add(this.btnSaveManu);
            this.tabManu.Controls.Add(this.label1);
            this.tabManu.Location = new System.Drawing.Point(4, 29);
            this.tabManu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabManu.Name = "tabManu";
            this.tabManu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabManu.Size = new System.Drawing.Size(646, 754);
            this.tabManu.TabIndex = 0;
            this.tabManu.Text = "Manufacturer";
            this.tabManu.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(136, 85);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(460, 177);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Country";
            // 
            // textManuEmail
            // 
            this.textManuEmail.Location = new System.Drawing.Point(158, 144);
            this.textManuEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textManuEmail.Name = "textManuEmail";
            this.textManuEmail.Size = new System.Drawing.Size(281, 27);
            this.textManuEmail.TabIndex = 12;
            // 
            // textManuName
            // 
            this.textManuName.Location = new System.Drawing.Point(158, 4);
            this.textManuName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textManuName.Name = "textManuName";
            this.textManuName.Size = new System.Drawing.Size(281, 27);
            this.textManuName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // textManuAdrs
            // 
            this.textManuAdrs.Location = new System.Drawing.Point(158, 39);
            this.textManuAdrs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textManuAdrs.Name = "textManuAdrs";
            this.textManuAdrs.Size = new System.Drawing.Size(281, 27);
            this.textManuAdrs.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // textManuPhone
            // 
            this.textManuPhone.Location = new System.Drawing.Point(158, 109);
            this.textManuPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textManuPhone.Name = "textManuPhone";
            this.textManuPhone.Size = new System.Drawing.Size(281, 27);
            this.textManuPhone.TabIndex = 10;
            // 
            // textManuCountry
            // 
            this.textManuCountry.Location = new System.Drawing.Point(158, 74);
            this.textManuCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textManuCountry.Name = "textManuCountry";
            this.textManuCountry.Size = new System.Drawing.Size(281, 27);
            this.textManuCountry.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // btnShowAllManu
            // 
            this.btnShowAllManu.Location = new System.Drawing.Point(357, 327);
            this.btnShowAllManu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAllManu.Name = "btnShowAllManu";
            this.btnShowAllManu.Size = new System.Drawing.Size(94, 44);
            this.btnShowAllManu.TabIndex = 6;
            this.btnShowAllManu.Text = "Show All";
            this.btnShowAllManu.UseVisualStyleBackColor = true;
            this.btnShowAllManu.Click += new System.EventHandler(this.showAllManu_Click);
            // 
            // btnSaveManu
            // 
            this.btnSaveManu.Location = new System.Drawing.Point(194, 327);
            this.btnSaveManu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveManu.Name = "btnSaveManu";
            this.btnSaveManu.Size = new System.Drawing.Size(94, 44);
            this.btnSaveManu.TabIndex = 5;
            this.btnSaveManu.Text = "Save";
            this.btnSaveManu.UseVisualStyleBackColor = true;
            this.btnSaveManu.Click += new System.EventHandler(this.saveManufacturer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(256, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manufacturer";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnShowAllSplm);
            this.tabPage1.Controls.Add(this.btnSaveSplm);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.tableSupplement);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 754);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Supplement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 482);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 44);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clearAllText_Click);
            // 
            // btnShowAllSplm
            // 
            this.btnShowAllSplm.Location = new System.Drawing.Point(334, 643);
            this.btnShowAllSplm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAllSplm.Name = "btnShowAllSplm";
            this.btnShowAllSplm.Size = new System.Drawing.Size(94, 44);
            this.btnShowAllSplm.TabIndex = 7;
            this.btnShowAllSplm.Text = "Show All";
            this.btnShowAllSplm.UseVisualStyleBackColor = true;
            this.btnShowAllSplm.Click += new System.EventHandler(this.showAllSupplement_Click);
            // 
            // btnSaveSplm
            // 
            this.btnSaveSplm.Location = new System.Drawing.Point(138, 643);
            this.btnSaveSplm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveSplm.Name = "btnSaveSplm";
            this.btnSaveSplm.Size = new System.Drawing.Size(94, 44);
            this.btnSaveSplm.TabIndex = 6;
            this.btnSaveSplm.Text = "Save";
            this.btnSaveSplm.UseVisualStyleBackColor = true;
            this.btnSaveSplm.Click += new System.EventHandler(this.saveSupplement_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(249, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(179, 41);
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
            this.tableSupplement.Location = new System.Drawing.Point(6, 81);
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
            this.tableSupplement.Size = new System.Drawing.Size(634, 530);
            this.tableSupplement.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Manufacturer";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(3, 353);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 23);
            this.label18.TabIndex = 16;
            this.label18.Text = "Other";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(3, 300);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 23);
            this.label17.TabIndex = 14;
            this.label17.Text = "Inactive";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(3, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 23);
            this.label16.TabIndex = 12;
            this.label16.Text = "Direction";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(3, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 23);
            this.label15.TabIndex = 10;
            this.label15.Text = "Ingredient";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 23);
            this.label14.TabIndex = 8;
            this.label14.Text = "Uses";
            // 
            // richTextSplmName
            // 
            this.richTextSplmName.Location = new System.Drawing.Point(122, 3);
            this.richTextSplmName.Name = "richTextSplmName";
            this.richTextSplmName.Size = new System.Drawing.Size(509, 51);
            this.richTextSplmName.TabIndex = 0;
            this.richTextSplmName.Text = "";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(3, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 23);
            this.label13.TabIndex = 5;
            this.label13.Text = "Name";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(3, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "Category";
            // 
            // richTextSplmCate
            // 
            this.richTextSplmCate.Location = new System.Drawing.Point(122, 60);
            this.richTextSplmCate.Name = "richTextSplmCate";
            this.richTextSplmCate.Size = new System.Drawing.Size(509, 51);
            this.richTextSplmCate.TabIndex = 7;
            this.richTextSplmCate.Text = "";
            // 
            // richTextSplmUses
            // 
            this.richTextSplmUses.Location = new System.Drawing.Point(122, 117);
            this.richTextSplmUses.Name = "richTextSplmUses";
            this.richTextSplmUses.Size = new System.Drawing.Size(509, 51);
            this.richTextSplmUses.TabIndex = 9;
            this.richTextSplmUses.Text = "";
            // 
            // richTextSplmIngredient
            // 
            this.richTextSplmIngredient.Location = new System.Drawing.Point(122, 174);
            this.richTextSplmIngredient.Name = "richTextSplmIngredient";
            this.richTextSplmIngredient.Size = new System.Drawing.Size(509, 51);
            this.richTextSplmIngredient.TabIndex = 11;
            this.richTextSplmIngredient.Text = "";
            // 
            // richTextSplmDir
            // 
            this.richTextSplmDir.Location = new System.Drawing.Point(122, 231);
            this.richTextSplmDir.Name = "richTextSplmDir";
            this.richTextSplmDir.Size = new System.Drawing.Size(509, 51);
            this.richTextSplmDir.TabIndex = 13;
            this.richTextSplmDir.Text = "";
            // 
            // richTextSplmInactive
            // 
            this.richTextSplmInactive.Location = new System.Drawing.Point(122, 288);
            this.richTextSplmInactive.Name = "richTextSplmInactive";
            this.richTextSplmInactive.Size = new System.Drawing.Size(509, 47);
            this.richTextSplmInactive.TabIndex = 15;
            this.richTextSplmInactive.Text = "";
            // 
            // richTextSplmOther
            // 
            this.richTextSplmOther.Location = new System.Drawing.Point(122, 341);
            this.richTextSplmOther.Name = "richTextSplmOther";
            this.richTextSplmOther.Size = new System.Drawing.Size(509, 47);
            this.richTextSplmOther.TabIndex = 17;
            this.richTextSplmOther.Text = "";
            // 
            // comboBoxSplmManu
            // 
            this.comboBoxSplmManu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSplmManu.FormattingEnabled = true;
            this.comboBoxSplmManu.Location = new System.Drawing.Point(122, 447);
            this.comboBoxSplmManu.Name = "comboBoxSplmManu";
            this.comboBoxSplmManu.Size = new System.Drawing.Size(509, 28);
            this.comboBoxSplmManu.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(3, 406);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 23);
            this.label19.TabIndex = 19;
            this.label19.Text = "Warning";
            // 
            // richTextSplmWarn
            // 
            this.richTextSplmWarn.Location = new System.Drawing.Point(122, 394);
            this.richTextSplmWarn.Name = "richTextSplmWarn";
            this.richTextSplmWarn.Size = new System.Drawing.Size(509, 47);
            this.richTextSplmWarn.TabIndex = 21;
            this.richTextSplmWarn.Text = "";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 827);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form";
            this.Text = "WinForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabManu.ResumeLayout(false);
            this.tabManu.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableSupplement.ResumeLayout(false);
            this.tableSupplement.PerformLayout();
            this.ResumeLayout(false);

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
    }
}