﻿namespace AntLifeF2Team9
{
    partial class frmEditProduct
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxReorder = new System.Windows.Forms.TextBox();
            this.textBoxMaxStock = new System.Windows.Forms.TextBox();
            this.textBoxNumStock = new System.Windows.Forms.TextBox();
            this.checkBoxHazard = new System.Windows.Forms.CheckBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.textBoxExpYear = new System.Windows.Forms.TextBox();
            this.checkBoxExpDate = new System.Windows.Forms.CheckBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxReorderAmount = new System.Windows.Forms.TextBox();
            this.labelReorderAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(232, 480);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 28);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(327, 480);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(87, 28);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Edit Product";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxReorder
            // 
            this.textBoxReorder.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxReorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReorder.Location = new System.Drawing.Point(119, 407);
            this.textBoxReorder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReorder.Name = "textBoxReorder";
            this.textBoxReorder.Size = new System.Drawing.Size(231, 23);
            this.textBoxReorder.TabIndex = 9;
            this.textBoxReorder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxReorder_KeyPress);
            // 
            // textBoxMaxStock
            // 
            this.textBoxMaxStock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxMaxStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaxStock.Location = new System.Drawing.Point(119, 375);
            this.textBoxMaxStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMaxStock.Name = "textBoxMaxStock";
            this.textBoxMaxStock.Size = new System.Drawing.Size(231, 23);
            this.textBoxMaxStock.TabIndex = 8;
            this.textBoxMaxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaxStock_KeyPress);
            // 
            // textBoxNumStock
            // 
            this.textBoxNumStock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNumStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNumStock.Location = new System.Drawing.Point(119, 343);
            this.textBoxNumStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumStock.Name = "textBoxNumStock";
            this.textBoxNumStock.Size = new System.Drawing.Size(231, 23);
            this.textBoxNumStock.TabIndex = 7;
            this.textBoxNumStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumStock_KeyPress);
            // 
            // checkBoxHazard
            // 
            this.checkBoxHazard.AutoSize = true;
            this.checkBoxHazard.Location = new System.Drawing.Point(10, 316);
            this.checkBoxHazard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxHazard.Name = "checkBoxHazard";
            this.checkBoxHazard.Size = new System.Drawing.Size(101, 20);
            this.checkBoxHazard.TabIndex = 22;
            this.checkBoxHazard.Text = "Is Hazardous";
            this.checkBoxHazard.UseVisualStyleBackColor = true;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Location = new System.Drawing.Point(196, 286);
            this.comboBoxDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(60, 24);
            this.comboBoxDay.TabIndex = 5;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(119, 284);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(60, 24);
            this.comboBoxMonth.TabIndex = 4;
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth_SelectedIndexChanged);
            // 
            // textBoxExpYear
            // 
            this.textBoxExpYear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxExpYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExpYear.Location = new System.Drawing.Point(264, 287);
            this.textBoxExpYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxExpYear.Name = "textBoxExpYear";
            this.textBoxExpYear.Size = new System.Drawing.Size(86, 23);
            this.textBoxExpYear.TabIndex = 6;
            this.textBoxExpYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExpYear_KeyPress);
            // 
            // checkBoxExpDate
            // 
            this.checkBoxExpDate.AutoSize = true;
            this.checkBoxExpDate.Location = new System.Drawing.Point(10, 288);
            this.checkBoxExpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxExpDate.Name = "checkBoxExpDate";
            this.checkBoxExpDate.Size = new System.Drawing.Size(113, 20);
            this.checkBoxExpDate.TabIndex = 18;
            this.checkBoxExpDate.Text = "Expiration Date";
            this.checkBoxExpDate.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrice.Location = new System.Drawing.Point(118, 254);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(232, 23);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCategory.Location = new System.Drawing.Point(118, 222);
            this.textBoxCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(232, 23);
            this.textBoxCategory.TabIndex = 2;
            this.textBoxCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCategory_KeyPress);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDesc.Location = new System.Drawing.Point(118, 114);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(232, 99);
            this.textBoxDesc.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Location = new System.Drawing.Point(118, 81);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(232, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Current Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Max Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Reorder Point";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Edit Product";
            // 
            // textBoxReorderAmount
            // 
            this.textBoxReorderAmount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxReorderAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReorderAmount.Location = new System.Drawing.Point(119, 441);
            this.textBoxReorderAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReorderAmount.Name = "textBoxReorderAmount";
            this.textBoxReorderAmount.Size = new System.Drawing.Size(231, 23);
            this.textBoxReorderAmount.TabIndex = 10;
            this.textBoxReorderAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxReorderAmount_KeyPress);
            // 
            // labelReorderAmount
            // 
            this.labelReorderAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelReorderAmount.AutoSize = true;
            this.labelReorderAmount.Location = new System.Drawing.Point(3, 443);
            this.labelReorderAmount.Name = "labelReorderAmount";
            this.labelReorderAmount.Size = new System.Drawing.Size(102, 16);
            this.labelReorderAmount.TabIndex = 41;
            this.labelReorderAmount.Text = "Reorder Amount";
            // 
            // frmEditProduct
            // 
            this.AcceptButton = this.buttonEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(428, 523);
            this.Controls.Add(this.textBoxReorderAmount);
            this.Controls.Add(this.labelReorderAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxReorder);
            this.Controls.Add(this.textBoxMaxStock);
            this.Controls.Add(this.textBoxNumStock);
            this.Controls.Add(this.checkBoxHazard);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.textBoxExpYear);
            this.Controls.Add(this.checkBoxExpDate);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmEditProduct";
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.frmEditProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxReorder;
        private System.Windows.Forms.TextBox textBoxMaxStock;
        private System.Windows.Forms.TextBox textBoxNumStock;
        private System.Windows.Forms.CheckBox checkBoxHazard;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.TextBox textBoxExpYear;
        private System.Windows.Forms.CheckBox checkBoxExpDate;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxReorderAmount;
        private System.Windows.Forms.Label labelReorderAmount;
    }
}