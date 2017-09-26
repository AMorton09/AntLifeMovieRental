namespace AntLifeF2Team9
{
    partial class frmCart
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
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.buttonAddAnotherCard = new System.Windows.Forms.Button();
            this.comboBoxSavedCards = new System.Windows.Forms.ComboBox();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.buttonGetTotals = new System.Windows.Forms.Button();
            this.labelStateTax = new System.Windows.Forms.Label();
            this.labelFedTax = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.labelDiscountLevel = new System.Windows.Forms.Label();
            this.buttonRemoveFromCart = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.labelQtyAdded = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToDeleteRows = false;
            this.dataGridViewCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(14, 172);
            this.dataGridViewCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCart.Size = new System.Drawing.Size(902, 479);
            this.dataGridViewCart.TabIndex = 0;
            this.dataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellContentClick);
            this.dataGridViewCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellValueChanged);
            this.dataGridViewCart.SelectionChanged += new System.EventHandler(this.dataGridViewCart_SelectionChanged);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCheckout.Location = new System.Drawing.Point(735, 694);
            this.buttonCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(87, 28);
            this.buttonCheckout.TabIndex = 4;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // buttonAddAnotherCard
            // 
            this.buttonAddAnotherCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddAnotherCard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddAnotherCard.Location = new System.Drawing.Point(162, 658);
            this.buttonAddAnotherCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddAnotherCard.Name = "buttonAddAnotherCard";
            this.buttonAddAnotherCard.Size = new System.Drawing.Size(216, 28);
            this.buttonAddAnotherCard.TabIndex = 2;
            this.buttonAddAnotherCard.Text = "Add Different Card";
            this.buttonAddAnotherCard.UseVisualStyleBackColor = true;
            this.buttonAddAnotherCard.Click += new System.EventHandler(this.buttonAddAnotherCard_Click);
            // 
            // comboBoxSavedCards
            // 
            this.comboBoxSavedCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSavedCards.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxSavedCards.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSavedCards.FormattingEnabled = true;
            this.comboBoxSavedCards.Location = new System.Drawing.Point(14, 661);
            this.comboBoxSavedCards.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSavedCards.Name = "comboBoxSavedCards";
            this.comboBoxSavedCards.Size = new System.Drawing.Size(140, 27);
            this.comboBoxSavedCards.TabIndex = 1;
            this.comboBoxSavedCards.SelectedIndexChanged += new System.EventHandler(this.comboBoxSavedCards_SelectedIndexChanged);
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Location = new System.Drawing.Point(10, 31);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(0, 21);
            this.labelSubTotal.TabIndex = 4;
            // 
            // buttonGetTotals
            // 
            this.buttonGetTotals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetTotals.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGetTotals.Location = new System.Drawing.Point(640, 694);
            this.buttonGetTotals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGetTotals.Name = "buttonGetTotals";
            this.buttonGetTotals.Size = new System.Drawing.Size(87, 28);
            this.buttonGetTotals.TabIndex = 3;
            this.buttonGetTotals.Text = "Get Totals";
            this.buttonGetTotals.UseVisualStyleBackColor = true;
            this.buttonGetTotals.Click += new System.EventHandler(this.buttonGetTotals_Click);
            // 
            // labelStateTax
            // 
            this.labelStateTax.AutoSize = true;
            this.labelStateTax.Location = new System.Drawing.Point(10, 58);
            this.labelStateTax.Name = "labelStateTax";
            this.labelStateTax.Size = new System.Drawing.Size(0, 21);
            this.labelStateTax.TabIndex = 6;
            // 
            // labelFedTax
            // 
            this.labelFedTax.AutoSize = true;
            this.labelFedTax.Location = new System.Drawing.Point(10, 86);
            this.labelFedTax.Name = "labelFedTax";
            this.labelFedTax.Size = new System.Drawing.Size(0, 21);
            this.labelFedTax.TabIndex = 7;
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.Location = new System.Drawing.Point(10, 116);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(0, 21);
            this.labelGrandTotal.TabIndex = 8;
            // 
            // labelDiscountLevel
            // 
            this.labelDiscountLevel.AutoSize = true;
            this.labelDiscountLevel.Location = new System.Drawing.Point(14, 137);
            this.labelDiscountLevel.Name = "labelDiscountLevel";
            this.labelDiscountLevel.Size = new System.Drawing.Size(0, 21);
            this.labelDiscountLevel.TabIndex = 9;
            // 
            // buttonRemoveFromCart
            // 
            this.buttonRemoveFromCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveFromCart.Location = new System.Drawing.Point(510, 694);
            this.buttonRemoveFromCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemoveFromCart.Name = "buttonRemoveFromCart";
            this.buttonRemoveFromCart.Size = new System.Drawing.Size(124, 28);
            this.buttonRemoveFromCart.TabIndex = 10;
            this.buttonRemoveFromCart.Text = "Edit Cart Quantity";
            this.buttonRemoveFromCart.UseVisualStyleBackColor = true;
            this.buttonRemoveFromCart.Click += new System.EventHandler(this.buttonRemoveFromCart_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(828, 694);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 28);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxQty
            // 
            this.textBoxQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQty.Location = new System.Drawing.Point(869, 139);
            this.textBoxQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.ReadOnly = true;
            this.textBoxQty.Size = new System.Drawing.Size(27, 27);
            this.textBoxQty.TabIndex = 13;
            this.textBoxQty.Text = "1";
            this.textBoxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQty.TextChanged += new System.EventHandler(this.textBoxQty_TextChanged);
            // 
            // labelQtyAdded
            // 
            this.labelQtyAdded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQtyAdded.AutoSize = true;
            this.labelQtyAdded.Location = new System.Drawing.Point(846, 118);
            this.labelQtyAdded.Name = "labelQtyAdded";
            this.labelQtyAdded.Size = new System.Drawing.Size(95, 21);
            this.labelQtyAdded.TabIndex = 12;
            this.labelQtyAdded.Text = "Qty. to Edit";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(385, 694);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(118, 28);
            this.buttonRemove.TabIndex = 16;
            this.buttonRemove.Text = "Remove Item";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::AntLifeF2Team9.Properties.Resources.tm91;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(223, -35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 316);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinus.Image = global::AntLifeF2Team9.Properties.Resources.Remove_16x;
            this.buttonMinus.Location = new System.Drawing.Point(849, 139);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(28, 26);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlus.Image = global::AntLifeF2Team9.Properties.Resources.Add_grey_16x;
            this.buttonPlus.Location = new System.Drawing.Point(891, 139);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(28, 25);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 671);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "* Get totals must be selected if your selection changes before you are allowed to" +
    " check out.";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(114, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 25);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cash";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 25);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Credit Card";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(13, 692);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(223, 141);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(101, 25);
            this.checkBoxSelectAll.TabIndex = 22;
            this.checkBoxSelectAll.Text = "Select All";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(933, 735);
            this.Controls.Add(this.checkBoxSelectAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.labelQtyAdded);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRemoveFromCart);
            this.Controls.Add(this.labelDiscountLevel);
            this.Controls.Add(this.labelGrandTotal);
            this.Controls.Add(this.labelFedTax);
            this.Controls.Add(this.labelStateTax);
            this.Controls.Add(this.buttonGetTotals);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.buttonAddAnotherCard);
            this.Controls.Add(this.comboBoxSavedCards);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.frmCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Button buttonAddAnotherCard;
        private System.Windows.Forms.ComboBox comboBoxSavedCards;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Button buttonGetTotals;
        private System.Windows.Forms.Label labelStateTax;
        private System.Windows.Forms.Label labelFedTax;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelDiscountLevel;
        private System.Windows.Forms.Button buttonRemoveFromCart;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.Label labelQtyAdded;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
    }
}