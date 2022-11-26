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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Manufacturer = new System.Windows.Forms.TabControl();
            this.tabManu = new System.Windows.Forms.TabPage();
            this.btnShowAllManu = new System.Windows.Forms.Button();
            this.btnSaveManu = new System.Windows.Forms.Button();
            this.textManuAdrs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textManuName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSupplement = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Manufacturer.SuspendLayout();
            this.tabManu.SuspendLayout();
            this.tabSupplement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 578F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Manufacturer, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1393, 596);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(808, 590);
            this.dataGridView1.TabIndex = 0;
            // 
            // Manufacturer
            // 
            this.Manufacturer.Controls.Add(this.tabManu);
            this.Manufacturer.Controls.Add(this.tabSupplement);
            this.Manufacturer.Location = new System.Drawing.Point(818, 3);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.SelectedIndex = 0;
            this.Manufacturer.Size = new System.Drawing.Size(572, 590);
            this.Manufacturer.TabIndex = 1;
            // 
            // tabManu
            // 
            this.tabManu.Controls.Add(this.btnShowAllManu);
            this.tabManu.Controls.Add(this.btnSaveManu);
            this.tabManu.Controls.Add(this.textManuAdrs);
            this.tabManu.Controls.Add(this.label3);
            this.tabManu.Controls.Add(this.textManuName);
            this.tabManu.Controls.Add(this.label2);
            this.tabManu.Controls.Add(this.label1);
            this.tabManu.Location = new System.Drawing.Point(4, 24);
            this.tabManu.Name = "tabManu";
            this.tabManu.Padding = new System.Windows.Forms.Padding(3);
            this.tabManu.Size = new System.Drawing.Size(564, 562);
            this.tabManu.TabIndex = 0;
            this.tabManu.Text = "Manufacturer";
            this.tabManu.UseVisualStyleBackColor = true;
            // 
            // btnShowAllManu
            // 
            this.btnShowAllManu.Location = new System.Drawing.Point(300, 247);
            this.btnShowAllManu.Name = "btnShowAllManu";
            this.btnShowAllManu.Size = new System.Drawing.Size(82, 33);
            this.btnShowAllManu.TabIndex = 6;
            this.btnShowAllManu.Text = "Show All";
            this.btnShowAllManu.UseVisualStyleBackColor = true;
            this.btnShowAllManu.Click += new System.EventHandler(this.showAllManu_Click);
            // 
            // btnSaveManu
            // 
            this.btnSaveManu.Location = new System.Drawing.Point(170, 247);
            this.btnSaveManu.Name = "btnSaveManu";
            this.btnSaveManu.Size = new System.Drawing.Size(82, 33);
            this.btnSaveManu.TabIndex = 5;
            this.btnSaveManu.Text = "Save";
            this.btnSaveManu.UseVisualStyleBackColor = true;
            this.btnSaveManu.Click += new System.EventHandler(this.saveManufacturer_Click);
            // 
            // textManuAdrs
            // 
            this.textManuAdrs.Location = new System.Drawing.Point(257, 145);
            this.textManuAdrs.Name = "textManuAdrs";
            this.textManuAdrs.Size = new System.Drawing.Size(184, 23);
            this.textManuAdrs.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(170, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // textManuName
            // 
            this.textManuName.Location = new System.Drawing.Point(257, 80);
            this.textManuName.Name = "textManuName";
            this.textManuName.Size = new System.Drawing.Size(184, 23);
            this.textManuName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(170, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
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
            // tabSupplement
            // 
            this.tabSupplement.Controls.Add(this.label4);
            this.tabSupplement.Location = new System.Drawing.Point(4, 24);
            this.tabSupplement.Name = "tabSupplement";
            this.tabSupplement.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupplement.Size = new System.Drawing.Size(564, 562);
            this.tabSupplement.TabIndex = 1;
            this.tabSupplement.Text = "Supplement";
            this.tabSupplement.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(224, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Supplement";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form";
            this.Text = "WinForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Manufacturer.ResumeLayout(false);
            this.tabManu.ResumeLayout(false);
            this.tabManu.PerformLayout();
            this.tabSupplement.ResumeLayout(false);
            this.tabSupplement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TabControl Manufacturer;
        private TabPage tabManu;
        private TabPage tabSupplement;
        private Label label1;
        private TextBox textManuName;
        private Label label2;
        private TextBox textManuAdrs;
        private Label label3;
        private Button btnShowAllManu;
        private Button btnSaveManu;
        private Label label4;
    }
}