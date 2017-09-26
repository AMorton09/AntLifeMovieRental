namespace AntLifeF2Team9
{
    partial class frmAddMembership
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
            this.labelNameOnCard = new System.Windows.Forms.Label();
            this.textBoxCardName = new System.Windows.Forms.TextBox();
            this.comboBoxCards = new System.Windows.Forms.ComboBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCards = new System.Windows.Forms.Label();
            this.LabelCountry = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.labelCSV = new System.Windows.Forms.Label();
            this.textBoxCSV = new System.Windows.Forms.TextBox();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelExpiration = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.groupBoxMembershipType = new System.Windows.Forms.GroupBox();
            this.radioButtonAnnual = new System.Windows.Forms.RadioButton();
            this.radioButtonTemp = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMembershipType.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNameOnCard
            // 
            this.labelNameOnCard.AutoSize = true;
            this.labelNameOnCard.Location = new System.Drawing.Point(14, 75);
            this.labelNameOnCard.Name = "labelNameOnCard";
            this.labelNameOnCard.Size = new System.Drawing.Size(90, 16);
            this.labelNameOnCard.TabIndex = 0;
            this.labelNameOnCard.Text = "Name on Card";
            this.labelNameOnCard.Click += new System.EventHandler(this.labelNameOnCard_Click);
            // 
            // textBoxCardName
            // 
            this.textBoxCardName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCardName.Location = new System.Drawing.Point(134, 71);
            this.textBoxCardName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCardName.Name = "textBoxCardName";
            this.textBoxCardName.Size = new System.Drawing.Size(173, 23);
            this.textBoxCardName.TabIndex = 1;
            this.textBoxCardName.TextChanged += new System.EventHandler(this.textBoxCardName_TextChanged);
            this.textBoxCardName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCardName_KeyPress);
            // 
            // comboBoxCards
            // 
            this.comboBoxCards.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCards.FormattingEnabled = true;
            this.comboBoxCards.Location = new System.Drawing.Point(134, 38);
            this.comboBoxCards.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCards.Name = "comboBoxCards";
            this.comboBoxCards.Size = new System.Drawing.Size(136, 24);
            this.comboBoxCards.TabIndex = 0;
            this.comboBoxCards.SelectedIndexChanged += new System.EventHandler(this.comboBoxCards_SelectedIndexChanged);
            // 
            // comboBoxState
            // 
            this.comboBoxState.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(355, 172);
            this.comboBoxState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(68, 24);
            this.comboBoxState.TabIndex = 5;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.comboBoxState_SelectedIndexChanged);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(134, 139);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(53, 24);
            this.comboBoxCountry.TabIndex = 3;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // labelCards
            // 
            this.labelCards.AutoSize = true;
            this.labelCards.Location = new System.Drawing.Point(14, 38);
            this.labelCards.Name = "labelCards";
            this.labelCards.Size = new System.Drawing.Size(67, 16);
            this.labelCards.TabIndex = 5;
            this.labelCards.Text = "Card Type";
            this.labelCards.Click += new System.EventHandler(this.labelCards_Click);
            // 
            // LabelCountry
            // 
            this.LabelCountry.AutoSize = true;
            this.LabelCountry.Location = new System.Drawing.Point(14, 139);
            this.LabelCountry.Name = "LabelCountry";
            this.LabelCountry.Size = new System.Drawing.Size(52, 16);
            this.LabelCountry.TabIndex = 6;
            this.LabelCountry.Text = "Country";
            this.LabelCountry.Click += new System.EventHandler(this.LabelCountry_Click);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(252, 176);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(91, 16);
            this.labelState.TabIndex = 7;
            this.labelState.Text = "State/Province";
            this.labelState.Click += new System.EventHandler(this.labelState_Click);
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Location = new System.Drawing.Point(14, 112);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(91, 16);
            this.LabelAddress.TabIndex = 8;
            this.LabelAddress.Text = "Billing Address";
            this.LabelAddress.Click += new System.EventHandler(this.LabelAddress_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.Location = new System.Drawing.Point(134, 105);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(173, 23);
            this.textBoxAddress.TabIndex = 2;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(14, 249);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(84, 16);
            this.labelCardNumber.TabIndex = 10;
            this.labelCardNumber.Text = "Card Number";
            this.labelCardNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCardNumber.Location = new System.Drawing.Point(134, 249);
            this.textBoxCardNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCardNumber.MaxLength = 16;
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(173, 23);
            this.textBoxCardNumber.TabIndex = 8;
            this.textBoxCardNumber.TextChanged += new System.EventHandler(this.textBoxCardNumber_TextChanged);
            this.textBoxCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCardNumber_KeyPress);
            // 
            // labelCSV
            // 
            this.labelCSV.AutoSize = true;
            this.labelCSV.Location = new System.Drawing.Point(14, 283);
            this.labelCSV.Name = "labelCSV";
            this.labelCSV.Size = new System.Drawing.Size(32, 16);
            this.labelCSV.TabIndex = 12;
            this.labelCSV.Text = "CSV";
            this.labelCSV.Click += new System.EventHandler(this.labelCSV_Click);
            // 
            // textBoxCSV
            // 
            this.textBoxCSV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCSV.Location = new System.Drawing.Point(134, 279);
            this.textBoxCSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCSV.MaxLength = 3;
            this.textBoxCSV.Name = "textBoxCSV";
            this.textBoxCSV.Size = new System.Drawing.Size(112, 23);
            this.textBoxCSV.TabIndex = 9;
            this.textBoxCSV.TextChanged += new System.EventHandler(this.textBoxCSV_TextChanged);
            this.textBoxCSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCSV_KeyPress);
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddCard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonAddCard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddCard.Location = new System.Drawing.Point(355, 398);
            this.buttonAddCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(87, 28);
            this.buttonAddCard.TabIndex = 11;
            this.buttonAddCard.Text = "Purchase";
            this.buttonAddCard.UseVisualStyleBackColor = false;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(14, 176);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(29, 16);
            this.labelCity.TabIndex = 15;
            this.labelCity.Text = "City";
            this.labelCity.Click += new System.EventHandler(this.labelCity_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCity.Location = new System.Drawing.Point(134, 172);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(112, 23);
            this.textBoxCity.TabIndex = 4;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            this.textBoxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCity_KeyPress);
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(69, 217);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(0, 16);
            this.labelMonth.TabIndex = 18;
            this.labelMonth.Click += new System.EventHandler(this.labelMonth_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(190, 217);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(34, 16);
            this.labelYear.TabIndex = 19;
            this.labelYear.Text = "Year";
            this.labelYear.Click += new System.EventHandler(this.labelYear_Click);
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMonth.Location = new System.Drawing.Point(134, 213);
            this.textBoxMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMonth.MaxLength = 2;
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(50, 23);
            this.textBoxMonth.TabIndex = 6;
            this.textBoxMonth.TextChanged += new System.EventHandler(this.textBoxMonth_TextChanged);
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYear.Location = new System.Drawing.Point(234, 213);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxYear.MaxLength = 4;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(73, 23);
            this.textBoxYear.TabIndex = 7;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // labelExpiration
            // 
            this.labelExpiration.AutoSize = true;
            this.labelExpiration.BackColor = System.Drawing.Color.Transparent;
            this.labelExpiration.Location = new System.Drawing.Point(14, 213);
            this.labelExpiration.Name = "labelExpiration";
            this.labelExpiration.Size = new System.Drawing.Size(103, 16);
            this.labelExpiration.TabIndex = 22;
            this.labelExpiration.Text = "Expiration Month";
            this.labelExpiration.Click += new System.EventHandler(this.labelExpiration_Click);
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(14, 321);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(58, 16);
            this.labelZip.TabIndex = 23;
            this.labelZip.Text = "Zip Code";
            this.labelZip.Click += new System.EventHandler(this.labelZip_Click);
            // 
            // textBoxZip
            // 
            this.textBoxZip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxZip.Location = new System.Drawing.Point(134, 318);
            this.textBoxZip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxZip.MaxLength = 7;
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(112, 23);
            this.textBoxZip.TabIndex = 10;
            this.textBoxZip.TextChanged += new System.EventHandler(this.textBoxZip_TextChanged);
            this.textBoxZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxZip_KeyPress);
            // 
            // groupBoxMembershipType
            // 
            this.groupBoxMembershipType.Controls.Add(this.radioButtonAnnual);
            this.groupBoxMembershipType.Controls.Add(this.radioButtonTemp);
            this.groupBoxMembershipType.Location = new System.Drawing.Point(14, 345);
            this.groupBoxMembershipType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMembershipType.Name = "groupBoxMembershipType";
            this.groupBoxMembershipType.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMembershipType.Size = new System.Drawing.Size(197, 78);
            this.groupBoxMembershipType.TabIndex = 25;
            this.groupBoxMembershipType.TabStop = false;
            this.groupBoxMembershipType.Text = "Membership Type";
            // 
            // radioButtonAnnual
            // 
            this.radioButtonAnnual.AutoSize = true;
            this.radioButtonAnnual.Location = new System.Drawing.Point(7, 52);
            this.radioButtonAnnual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonAnnual.Name = "radioButtonAnnual";
            this.radioButtonAnnual.Size = new System.Drawing.Size(106, 20);
            this.radioButtonAnnual.TabIndex = 1;
            this.radioButtonAnnual.TabStop = true;
            this.radioButtonAnnual.Text = "1 Year $50.00";
            this.radioButtonAnnual.UseVisualStyleBackColor = true;
            // 
            // radioButtonTemp
            // 
            this.radioButtonTemp.AutoSize = true;
            this.radioButtonTemp.Location = new System.Drawing.Point(7, 23);
            this.radioButtonTemp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonTemp.Name = "radioButtonTemp";
            this.radioButtonTemp.Size = new System.Drawing.Size(117, 20);
            this.radioButtonTemp.TabIndex = 0;
            this.radioButtonTemp.TabStop = true;
            this.radioButtonTemp.Text = "One Day $20.00";
            this.radioButtonTemp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(260, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Add Membership";
            // 
            // frmAddMembership
            // 
            this.AcceptButton = this.buttonAddCard;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(450, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxMembershipType);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAddMembership";
            this.Text = "Add Membership";
            this.Load += new System.EventHandler(this.frmAddMembership_Load);
            this.groupBoxMembershipType.ResumeLayout(false);
            this.groupBoxMembershipType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameOnCard;
        private System.Windows.Forms.TextBox textBoxCardName;
        private System.Windows.Forms.ComboBox comboBoxCards;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCards;
        private System.Windows.Forms.Label LabelCountry;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Label labelCSV;
        private System.Windows.Forms.TextBox textBoxCSV;
        private System.Windows.Forms.Button buttonAddCard;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelExpiration;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.GroupBox groupBoxMembershipType;
        private System.Windows.Forms.RadioButton radioButtonAnnual;
        private System.Windows.Forms.RadioButton radioButtonTemp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}