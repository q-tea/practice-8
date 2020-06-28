using System;

namespace XMLGUI.Forms
{
    partial class InsertItems
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
            this.label4 = new System.Windows.Forms.Label();
            this.paramTxtBoxPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paramTxtBoxAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paramTxtBoxLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.paramTxtBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.paramTxtBoxFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.paramTxtBoxInstallationPayment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.paramTxtBoxStartDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paramTxtBoxID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.paramTxtBoxLastPayment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Телефон";
            // 
            // paramTxtBoxPhone
            // 
            this.paramTxtBoxPhone.Location = new System.Drawing.Point(49, 151);
            this.paramTxtBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.paramTxtBoxPhone.Name = "paramTxtBoxPhone";
            this.paramTxtBoxPhone.Size = new System.Drawing.Size(174, 20);
            this.paramTxtBoxPhone.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Адрес";
            // 
            // paramTxtBoxAddress
            // 
            this.paramTxtBoxAddress.Location = new System.Drawing.Point(49, 109);
            this.paramTxtBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.paramTxtBoxAddress.Name = "paramTxtBoxAddress";
            this.paramTxtBoxAddress.Size = new System.Drawing.Size(174, 20);
            this.paramTxtBoxAddress.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Район";
            // 
            // paramTxtBoxLocation
            // 
            this.paramTxtBoxLocation.Location = new System.Drawing.Point(49, 69);
            this.paramTxtBoxLocation.Margin = new System.Windows.Forms.Padding(2);
            this.paramTxtBoxLocation.Name = "paramTxtBoxLocation";
            this.paramTxtBoxLocation.Size = new System.Drawing.Size(174, 20);
            this.paramTxtBoxLocation.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Фамилия";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(150, 530);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(73, 20);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.OnBtnApplyClick);
            // 
            // paramTxtBoxName
            // 
            this.paramTxtBoxName.Location = new System.Drawing.Point(49, 30);
            this.paramTxtBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.paramTxtBoxName.Name = "paramTxtBoxName";
            this.paramTxtBoxName.Size = new System.Drawing.Size(174, 20);
            this.paramTxtBoxName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ежемесячный Платёж";
            // 
            // paramTxtBoxFee
            // 
            this.paramTxtBoxFee.Location = new System.Drawing.Point(49, 312);
            this.paramTxtBoxFee.Margin = new System.Windows.Forms.Padding(2);
            this.paramTxtBoxFee.Name = "paramTxtBoxFee";
            this.paramTxtBoxFee.Size = new System.Drawing.Size(174, 20);
            this.paramTxtBoxFee.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Оплата установки";
            // 
            // paramTxtBoxInstallationPayment
            // 
            this.paramTxtBoxInstallationPayment.Location = new System.Drawing.Point(49, 270);
            this.paramTxtBoxInstallationPayment.Margin = new System.Windows.Forms.Padding(2);
            this.paramTxtBoxInstallationPayment.Name = "paramTxtBoxInstallationPayment";
            this.paramTxtBoxInstallationPayment.Size = new System.Drawing.Size(174, 20);
            this.paramTxtBoxInstallationPayment.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Дата Заключения Договора";
            // 
            // paramTxtBoxStartDate
            // 
            this.paramTxtBoxStartDate.Location = new System.Drawing.Point(49, 230);
            this.paramTxtBoxStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.paramTxtBoxStartDate.Name = "paramTxtBoxStartDate";
            this.paramTxtBoxStartDate.Size = new System.Drawing.Size(174, 20);
            this.paramTxtBoxStartDate.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "ID";
            // 
            // paramTxtBoxID
            // 
            this.paramTxtBoxID.Location = new System.Drawing.Point(49, 191);
            this.paramTxtBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.paramTxtBoxID.Name = "paramTxtBoxID";
            this.paramTxtBoxID.Size = new System.Drawing.Size(174, 20);
            this.paramTxtBoxID.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Дата Последнего Платежа";
            // 
            // paramTxtBoxLastPayment
            // 
            this.paramTxtBoxLastPayment.Location = new System.Drawing.Point(49, 356);
            this.paramTxtBoxLastPayment.Margin = new System.Windows.Forms.Padding(2);
            this.paramTxtBoxLastPayment.Name = "paramTxtBoxLastPayment";
            this.paramTxtBoxLastPayment.Size = new System.Drawing.Size(174, 20);
            this.paramTxtBoxLastPayment.TabIndex = 31;
            // 
            // InsertItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 561);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.paramTxtBoxLastPayment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paramTxtBoxFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.paramTxtBoxInstallationPayment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.paramTxtBoxStartDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.paramTxtBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paramTxtBoxPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paramTxtBoxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paramTxtBoxLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.paramTxtBoxName);
            this.MaximumSize = new System.Drawing.Size(250, 600);
            this.MinimumSize = new System.Drawing.Size(250, 600);
            this.Name = "InsertItems";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InsertItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paramTxtBoxPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox paramTxtBoxAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paramTxtBoxLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox paramTxtBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox paramTxtBoxFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox paramTxtBoxInstallationPayment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox paramTxtBoxStartDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox paramTxtBoxID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox paramTxtBoxLastPayment;
    }
}