namespace XMLGUI.Forms
{
    partial class FilterProperties
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
            this.paramTxtBoxName = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paramTxtBoxLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paramTxtBoxStartDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paramTxtBoxLastPayment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // paramTxtBoxName
            // 
            this.paramTxtBoxName.Location = new System.Drawing.Point(49, 34);
            this.paramTxtBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paramTxtBoxName.Name = "paramTxtBoxName";
            this.paramTxtBoxName.Size = new System.Drawing.Size(174, 20);
            this.paramTxtBoxName.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(150, 200);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(73, 20);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.OnBtnApplyClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Район";
            // 
            // paramTxtBoxLocation
            // 
            this.paramTxtBoxLocation.Location = new System.Drawing.Point(49, 73);
            this.paramTxtBoxLocation.Margin = new System.Windows.Forms.Padding(2);
            this.paramTxtBoxLocation.Name = "paramTxtBoxLocation";
            this.paramTxtBoxLocation.Size = new System.Drawing.Size(174, 20);
            this.paramTxtBoxLocation.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата Заключения Договора";
            // 
            // paramTxtBoxStartDate
            // 
            this.paramTxtBoxStartDate.Location = new System.Drawing.Point(49, 113);
            this.paramTxtBoxStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.paramTxtBoxStartDate.Name = "paramTxtBoxStartDate";
            this.paramTxtBoxStartDate.Size = new System.Drawing.Size(174, 20);
            this.paramTxtBoxStartDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата Последнего Платежа";
            // 
            // paramTxtBoxLastPayment
            // 
            this.paramTxtBoxLastPayment.Location = new System.Drawing.Point(49, 155);
            this.paramTxtBoxLastPayment.Margin = new System.Windows.Forms.Padding(2);
            this.paramTxtBoxLastPayment.Name = "paramTxtBoxLastPayment";
            this.paramTxtBoxLastPayment.Size = new System.Drawing.Size(174, 20);
            this.paramTxtBoxLastPayment.TabIndex = 12;
            // 
            // FilterProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 231);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paramTxtBoxLastPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paramTxtBoxStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paramTxtBoxLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.paramTxtBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 270);
            this.Name = "FilterProperties";
            this.Text = "Filter properties";
            this.Load += new System.EventHandler(this.FilterProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paramTxtBoxName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paramTxtBoxLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox paramTxtBoxStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paramTxtBoxLastPayment;
    }
}