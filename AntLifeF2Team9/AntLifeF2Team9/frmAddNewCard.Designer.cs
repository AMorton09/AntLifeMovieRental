namespace AntLifeF2Team9
{
    partial class frmAddNewCard
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
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelExpiration = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.textBoxCSV = new System.Windows.Forms.TextBox();
            this.labelCSV = new System.Windows.Forms.Label();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.LabelCountry = new System.Windows.Forms.Label();
            this.labelCards = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.comboBoxCards = new System.Windows.Forms.ComboBox();
            this.textBoxCardName = new System.Windows.Forms.TextBox();
            this.labelNameOnCard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxZip
            // 
            this.textBoxZip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxZip.Location = new System.Drawing.Point(192, 326);
            this.textBoxZip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxZip.MaxLength = 7;
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(116, 27);
            this.textBoxZip.TabIndex = 10;
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(30, 330);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(75, 21);
            this.labelZip.TabIndex = 47;
            this.labelZip.Text = "Zip Code";
            // 
            // labelExpiration
            // 
            this.labelExpiration.AutoSize = true;
            this.labelExpiration.Location = new System.Drawing.Point(30, 219);
            this.labelExpiration.Name = "labelExpiration";
            this.labelExpiration.Size = new System.Drawing.Size(84, 21);
            this.labelExpiration.TabIndex = 46;
            this.labelExpiration.Text = "Expiration";
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYear.Location = new System.Drawing.Point(316, 219);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(78, 27);
            this.textBoxYear.TabIndex = 7;
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMonth.Location = new System.Drawing.Point(192, 219);
            this.textBoxMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(54, 27);
            this.textBoxMonth.TabIndex = 6;
            this.textBoxMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonth_KeyPress);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(275, 219);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(44, 21);
            this.labelYear.TabIndex = 43;
            this.labelYear.Text = "Year";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(89, 219);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(56, 21);
            this.labelMonth.TabIndex = 42;
            this.labelMonth.Text = "Month";
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCity.Location = new System.Drawing.Point(192, 178);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(116, 27);
            this.textBoxCity.TabIndex = 4;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(30, 182);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(38, 21);
            this.labelCity.TabIndex = 40;
            this.labelCity.Text = "City";
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCard.Location = new System.Drawing.Point(439, 352);
            this.buttonAddCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(87, 28);
            this.buttonAddCard.TabIndex = 11;
            this.buttonAddCard.Text = "Add Card";
            this.buttonAddCard.UseVisualStyleBackColor = true;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // textBoxCSV
            // 
            this.textBoxCSV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCSV.Location = new System.Drawing.Point(192, 289);
            this.textBoxCSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCSV.MaxLength = 3;
            this.textBoxCSV.Name = "textBoxCSV";
            this.textBoxCSV.Size = new System.Drawing.Size(116, 27);
            this.textBoxCSV.TabIndex = 9;
            // 
            // labelCSV
            // 
            this.labelCSV.AutoSize = true;
            this.labelCSV.Location = new System.Drawing.Point(30, 293);
            this.labelCSV.Name = "labelCSV";
            this.labelCSV.Size = new System.Drawing.Size(39, 21);
            this.labelCSV.TabIndex = 37;
            this.labelCSV.Text = "CSV";
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCardNumber.Location = new System.Drawing.Point(192, 252);
            this.textBoxCardNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCardNumber.MaxLength = 16;
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(207, 27);
            this.textBoxCardNumber.TabIndex = 8;
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(30, 256);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(107, 21);
            this.labelCardNumber.TabIndex = 35;
            this.labelCardNumber.Text = "Card Number";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.Location = new System.Drawing.Point(192, 108);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(178, 27);
            this.textBoxAddress.TabIndex = 2;
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Location = new System.Drawing.Point(30, 108);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(119, 21);
            this.LabelAddress.TabIndex = 33;
            this.LabelAddress.Text = "Billing Address";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(316, 182);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(118, 21);
            this.labelState.TabIndex = 32;
            this.labelState.Text = "State/Province";
            // 
            // LabelCountry
            // 
            this.LabelCountry.AutoSize = true;
            this.LabelCountry.Location = new System.Drawing.Point(30, 145);
            this.LabelCountry.Name = "LabelCountry";
            this.LabelCountry.Size = new System.Drawing.Size(67, 21);
            this.LabelCountry.TabIndex = 31;
            this.LabelCountry.Text = "Country";
            // 
            // labelCards
            // 
            this.labelCards.AutoSize = true;
            this.labelCards.Location = new System.Drawing.Point(30, 34);
            this.labelCards.Name = "labelCards";
            this.labelCards.Size = new System.Drawing.Size(85, 21);
            this.labelCards.TabIndex = 30;
            this.labelCards.Text = "Card Type";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(192, 142);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(86, 27);
            this.comboBoxCountry.TabIndex = 3;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // comboBoxState
            // 
            this.comboBoxState.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(408, 182);
            this.comboBoxState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(73, 27);
            this.comboBoxState.TabIndex = 5;
            // 
            // comboBoxCards
            // 
            this.comboBoxCards.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCards.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxCards.FormattingEnabled = true;
            this.comboBoxCards.Location = new System.Drawing.Point(192, 31);
            this.comboBoxCards.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCards.Name = "comboBoxCards";
            this.comboBoxCards.Size = new System.Drawing.Size(140, 27);
            this.comboBoxCards.TabIndex = 0;
            // 
            // textBoxCardName
            // 
            this.textBoxCardName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCardName.Location = new System.Drawing.Point(192, 68);
            this.textBoxCardName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCardName.Name = "textBoxCardName";
            this.textBoxCardName.Size = new System.Drawing.Size(178, 27);
            this.textBoxCardName.TabIndex = 1;
            this.textBoxCardName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCardName_KeyPress);
            // 
            // labelNameOnCard
            // 
            this.labelNameOnCard.AutoSize = true;
            this.labelNameOnCard.Location = new System.Drawing.Point(30, 71);
            this.labelNameOnCard.Name = "labelNameOnCard";
            this.labelNameOnCard.Size = new System.Drawing.Size(115, 21);
            this.labelNameOnCard.TabIndex = 25;
            this.labelNameOnCard.Text = "Name on Card";
            // 
            // frmAddNewCard
            // 
            this.AcceptButton = this.buttonAddCard;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(530, 384);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelExpiration);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.buttonAddCard);
            this.Controls.Add(this.textBoxCSV);
            this.Controls.Add(this.labelCSV);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.LabelCountry);
            this.Controls.Add(this.labelCards);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.comboBoxCards);
            this.Controls.Add(this.textBoxCardName);
            this.Controls.Add(this.labelNameOnCard);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAddNewCard";
            this.Text = "Add New Card";
            this.Load += new System.EventHandler(this.frmAddNewCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelExpiration;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Button buttonAddCard;
        private System.Windows.Forms.TextBox textBoxCSV;
        private System.Windows.Forms.Label labelCSV;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label LabelCountry;
        private System.Windows.Forms.Label labelCards;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.ComboBox comboBoxCards;
        private System.Windows.Forms.TextBox textBoxCardName;
        private System.Windows.Forms.Label labelNameOnCard;
    }
}