namespace AntLifeF2Team9
{
    partial class frmEditEmployee
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
            this.labelCreateAccount = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEditAccount = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.comboBoxStates = new System.Windows.Forms.ComboBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxConfirmEmail = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelConfirmEmail = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelNewEmail = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCreateAccount
            // 
            this.labelCreateAccount.AutoSize = true;
            this.labelCreateAccount.Location = new System.Drawing.Point(252, 11);
            this.labelCreateAccount.Name = "labelCreateAccount";
            this.labelCreateAccount.Size = new System.Drawing.Size(137, 16);
            this.labelCreateAccount.TabIndex = 79;
            this.labelCreateAccount.Text = "Edit Employee Account";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(295, 66);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(47, 16);
            this.labelTitle.TabIndex = 78;
            this.labelTitle.Text = "AntLife";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(383, 418);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 28);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEditAccount
            // 
            this.buttonEditAccount.Location = new System.Drawing.Point(477, 418);
            this.buttonEditAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditAccount.Name = "buttonEditAccount";
            this.buttonEditAccount.Size = new System.Drawing.Size(87, 28);
            this.buttonEditAccount.TabIndex = 9;
            this.buttonEditAccount.Text = "Save";
            this.buttonEditAccount.UseVisualStyleBackColor = true;
            this.buttonEditAccount.Click += new System.EventHandler(this.buttonEditAccount_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCountry.Location = new System.Drawing.Point(114, 230);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(86, 24);
            this.comboBoxCountry.TabIndex = 3;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(14, 240);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(52, 16);
            this.labelCountry.TabIndex = 77;
            this.labelCountry.Text = "Country";
            // 
            // comboBoxStates
            // 
            this.comboBoxStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStates.FormattingEnabled = true;
            this.comboBoxStates.Location = new System.Drawing.Point(360, 273);
            this.comboBoxStates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxStates.Name = "comboBoxStates";
            this.comboBoxStates.Size = new System.Drawing.Size(61, 24);
            this.comboBoxStates.TabIndex = 5;
            // 
            // textBoxZip
            // 
            this.textBoxZip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxZip.Location = new System.Drawing.Point(462, 273);
            this.textBoxZip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxZip.MaxLength = 7;
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(102, 23);
            this.textBoxZip.TabIndex = 6;
            this.textBoxZip.TextChanged += new System.EventHandler(this.textBoxZip_TextChanged);
            this.textBoxZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxZip_KeyPress);
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCity.Location = new System.Drawing.Point(114, 274);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(173, 23);
            this.textBoxCity.TabIndex = 4;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // textBoxConfirmEmail
            // 
            this.textBoxConfirmEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxConfirmEmail.Location = new System.Drawing.Point(114, 373);
            this.textBoxConfirmEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxConfirmEmail.Name = "textBoxConfirmEmail";
            this.textBoxConfirmEmail.Size = new System.Drawing.Size(450, 23);
            this.textBoxConfirmEmail.TabIndex = 8;
            this.textBoxConfirmEmail.TextChanged += new System.EventHandler(this.textBoxConfirmEmail_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxEmail.Location = new System.Drawing.Point(114, 326);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(450, 23);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAddress.Location = new System.Drawing.Point(114, 191);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(450, 23);
            this.textBoxAddress.TabIndex = 2;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxLastName.Location = new System.Drawing.Point(114, 142);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(450, 23);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxFirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxFirstName.Location = new System.Drawing.Point(114, 92);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(450, 23);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // labelConfirmEmail
            // 
            this.labelConfirmEmail.AutoSize = true;
            this.labelConfirmEmail.Location = new System.Drawing.Point(14, 377);
            this.labelConfirmEmail.Name = "labelConfirmEmail";
            this.labelConfirmEmail.Size = new System.Drawing.Size(88, 16);
            this.labelConfirmEmail.TabIndex = 74;
            this.labelConfirmEmail.Text = "Confirm Email";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(429, 278);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(25, 16);
            this.labelZipCode.TabIndex = 73;
            this.labelZipCode.Text = "Zip";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(300, 278);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(38, 16);
            this.labelState.TabIndex = 72;
            this.labelState.Text = "State";
            // 
            // labelNewEmail
            // 
            this.labelNewEmail.AutoSize = true;
            this.labelNewEmail.Location = new System.Drawing.Point(14, 330);
            this.labelNewEmail.Name = "labelNewEmail";
            this.labelNewEmail.Size = new System.Drawing.Size(68, 16);
            this.labelNewEmail.TabIndex = 71;
            this.labelNewEmail.Text = "New Email";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(14, 278);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(29, 16);
            this.labelCity.TabIndex = 70;
            this.labelCity.Text = "City";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(14, 190);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(54, 16);
            this.labelAddress.TabIndex = 69;
            this.labelAddress.Text = "Address";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(14, 143);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(68, 16);
            this.labelLastName.TabIndex = 68;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(14, 96);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(70, 16);
            this.labelFirstName.TabIndex = 67;
            this.labelFirstName.Text = "First Name";
            // 
            // frmEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(579, 462);
            this.Controls.Add(this.labelCreateAccount);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEditAccount);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.comboBoxStates);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxConfirmEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelConfirmEmail);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelNewEmail);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmEditEmployee";
            this.Text = "frmEditEmployee";
            this.Load += new System.EventHandler(this.frmEditEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateAccount;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEditAccount;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.ComboBox comboBoxStates;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxConfirmEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelConfirmEmail;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelNewEmail;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
    }
}