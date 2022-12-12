namespace WindowsReportFormsApp
{
    partial class Form1
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
            this.textLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textOrderId = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLocation
            // 
            this.textLocation.Location = new System.Drawing.Point(183, 81);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(240, 22);
            this.textLocation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(183, 139);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(240, 22);
            this.textFileName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order ID";
            // 
            // textOrderId
            // 
            this.textOrderId.Location = new System.Drawing.Point(183, 198);
            this.textOrderId.Name = "textOrderId";
            this.textOrderId.Size = new System.Drawing.Size(240, 22);
            this.textOrderId.TabIndex = 5;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(348, 272);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.textOrderId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLocation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textOrderId;
        private System.Windows.Forms.Button btnReport;
    }
}

