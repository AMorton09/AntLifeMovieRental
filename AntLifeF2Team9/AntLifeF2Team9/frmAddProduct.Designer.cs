namespace AntLifeF2Team9
{
    partial class frmAddProduct
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.checkBoxExpDate = new System.Windows.Forms.CheckBox();
            this.textBoxExpYear = new System.Windows.Forms.TextBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.checkBoxHazard = new System.Windows.Forms.CheckBox();
            this.textBoxNumStock = new System.Windows.Forms.TextBox();
            this.textBoxMaxStock = new System.Windows.Forms.TextBox();
            this.textBoxReorder = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelReorderAmount = new System.Windows.Forms.Label();
            this.textBoxReorderAmount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Location = new System.Drawing.Point(124, 95);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(233, 23);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDesc.Location = new System.Drawing.Point(124, 128);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(232, 99);
            this.textBoxDesc.TabIndex = 1;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCategory.Location = new System.Drawing.Point(124, 235);
            this.textBoxCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(232, 23);
            this.textBoxCategory.TabIndex = 2;
            this.textBoxCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCategory_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrice.Location = new System.Drawing.Point(124, 267);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(232, 23);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // checkBoxExpDate
            // 
            this.checkBoxExpDate.AutoSize = true;
            this.checkBoxExpDate.Location = new System.Drawing.Point(125, 300);
            this.checkBoxExpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxExpDate.Name = "checkBoxExpDate";
            this.checkBoxExpDate.Size = new System.Drawing.Size(113, 20);
            this.checkBoxExpDate.TabIndex = 4;
            this.checkBoxExpDate.Text = "Expiration Date";
            this.checkBoxExpDate.UseVisualStyleBackColor = true;
            // 
            // textBoxExpYear
            // 
            this.textBoxExpYear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxExpYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExpYear.Location = new System.Drawing.Point(412, 297);
            this.textBoxExpYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxExpYear.Name = "textBoxExpYear";
            this.textBoxExpYear.Size = new System.Drawing.Size(116, 23);
            this.textBoxExpYear.TabIndex = 5;
            this.textBoxExpYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExpYear_KeyPress);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(250, 295);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(60, 24);
            this.comboBoxMonth.TabIndex = 6;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Location = new System.Drawing.Point(329, 295);
            this.comboBoxDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(60, 24);
            this.comboBoxDay.TabIndex = 7;
            this.comboBoxDay.SelectedIndexChanged += new System.EventHandler(this.comboBoxDay_SelectedIndexChanged);
            // 
            // checkBoxHazard
            // 
            this.checkBoxHazard.AutoSize = true;
            this.checkBoxHazard.Location = new System.Drawing.Point(125, 329);
            this.checkBoxHazard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxHazard.Name = "checkBoxHazard";
            this.checkBoxHazard.Size = new System.Drawing.Size(101, 20);
            this.checkBoxHazard.TabIndex = 8;
            this.checkBoxHazard.Text = "Is Hazardous";
            this.checkBoxHazard.UseVisualStyleBackColor = true;
            // 
            // textBoxNumStock
            // 
            this.textBoxNumStock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNumStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumStock.Location = new System.Drawing.Point(125, 357);
            this.textBoxNumStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumStock.Name = "textBoxNumStock";
            this.textBoxNumStock.Size = new System.Drawing.Size(232, 23);
            this.textBoxNumStock.TabIndex = 9;
            this.textBoxNumStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumStock_KeyPress);
            // 
            // textBoxMaxStock
            // 
            this.textBoxMaxStock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxMaxStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaxStock.Location = new System.Drawing.Point(125, 389);
            this.textBoxMaxStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMaxStock.Name = "textBoxMaxStock";
            this.textBoxMaxStock.Size = new System.Drawing.Size(232, 23);
            this.textBoxMaxStock.TabIndex = 10;
            this.textBoxMaxStock.TextChanged += new System.EventHandler(this.textBoxMaxStock_TextChanged);
            this.textBoxMaxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaxStock_KeyPress);
            // 
            // textBoxReorder
            // 
            this.textBoxReorder.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxReorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReorder.Location = new System.Drawing.Point(125, 421);
            this.textBoxReorder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReorder.Name = "textBoxReorder";
            this.textBoxReorder.Size = new System.Drawing.Size(232, 23);
            this.textBoxReorder.TabIndex = 11;
            this.textBoxReorder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxReorder_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(484, 478);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 28);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add Product";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(390, 478);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 28);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(17, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(17, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(17, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Reorder Point";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(17, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Max Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(17, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Current Stock";
            // 
            // labelReorderAmount
            // 
            this.labelReorderAmount.AutoSize = true;
            this.labelReorderAmount.Location = new System.Drawing.Point(17, 462);
            this.labelReorderAmount.Name = "labelReorderAmount";
            this.labelReorderAmount.Size = new System.Drawing.Size(102, 16);
            this.labelReorderAmount.TabIndex = 39;
            this.labelReorderAmount.Text = "Reorder Amount";
            // 
            // textBoxReorderAmount
            // 
            this.textBoxReorderAmount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxReorderAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReorderAmount.Location = new System.Drawing.Point(124, 458);
            this.textBoxReorderAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReorderAmount.Name = "textBoxReorderAmount";
            this.textBoxReorderAmount.Size = new System.Drawing.Size(232, 23);
            this.textBoxReorderAmount.TabIndex = 40;
            this.textBoxReorderAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxReorderAmount_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AntLifeF2Team9.Properties.Resources.tm9;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(317, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 235);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddProduct
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(586, 521);
            this.Controls.Add(this.textBoxReorderAmount);
            this.Controls.Add(this.labelReorderAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
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
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.CheckBox checkBoxExpDate;
        private System.Windows.Forms.TextBox textBoxExpYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.CheckBox checkBoxHazard;
        private System.Windows.Forms.TextBox textBoxNumStock;
        private System.Windows.Forms.TextBox textBoxMaxStock;
        private System.Windows.Forms.TextBox textBoxReorder;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelReorderAmount;
        private System.Windows.Forms.TextBox textBoxReorderAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}