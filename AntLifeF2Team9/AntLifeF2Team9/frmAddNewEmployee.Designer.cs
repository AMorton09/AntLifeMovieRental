namespace AntLifeF2Team9
{
    partial class frmAddNewEmployee
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
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.comboBoxStates = new System.Windows.Forms.ComboBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmEmail = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfirmEmail = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCurrentEmail = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.labelCreateAccount = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCountry.Location = new System.Drawing.Point(175, 215);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(86, 24);
            this.comboBoxCountry.TabIndex = 3;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(62, 225);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(52, 16);
            this.labelCountry.TabIndex = 47;
            this.labelCountry.Text = "Country";
            // 
            // comboBoxStates
            // 
            this.comboBoxStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStates.FormattingEnabled = true;
            this.comboBoxStates.Location = new System.Drawing.Point(421, 258);
            this.comboBoxStates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxStates.Name = "comboBoxStates";
            this.comboBoxStates.Size = new System.Drawing.Size(61, 24);
            this.comboBoxStates.TabIndex = 5;
            // 
            // textBoxZip
            // 
            this.textBoxZip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxZip.Location = new System.Drawing.Point(523, 258);
            this.textBoxZip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxZip.MaxLength = 7;
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(102, 23);
            this.textBoxZip.TabIndex = 6;
            this.textBoxZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxZip_KeyPress);
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCity.Location = new System.Drawing.Point(175, 260);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(173, 23);
            this.textBoxCity.TabIndex = 4;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            this.textBoxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCity_KeyPress);
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(175, 452);
            this.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(450, 23);
            this.textBoxConfirmPassword.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Location = new System.Drawing.Point(175, 405);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(450, 23);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxConfirmEmail
            // 
            this.textBoxConfirmEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxConfirmEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmEmail.Location = new System.Drawing.Point(175, 358);
            this.textBoxConfirmEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxConfirmEmail.Name = "textBoxConfirmEmail";
            this.textBoxConfirmEmail.Size = new System.Drawing.Size(450, 23);
            this.textBoxConfirmEmail.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Location = new System.Drawing.Point(175, 311);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(450, 23);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.Location = new System.Drawing.Point(175, 176);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(450, 23);
            this.textBoxAddress.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastName.Location = new System.Drawing.Point(175, 127);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(450, 23);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxFirstName.Location = new System.Drawing.Point(175, 78);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(450, 23);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(62, 455);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(112, 16);
            this.labelConfirmPassword.TabIndex = 36;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(62, 409);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 16);
            this.labelPassword.TabIndex = 35;
            this.labelPassword.Text = "Password";
            // 
            // labelConfirmEmail
            // 
            this.labelConfirmEmail.AutoSize = true;
            this.labelConfirmEmail.Location = new System.Drawing.Point(62, 362);
            this.labelConfirmEmail.Name = "labelConfirmEmail";
            this.labelConfirmEmail.Size = new System.Drawing.Size(88, 16);
            this.labelConfirmEmail.TabIndex = 34;
            this.labelConfirmEmail.Text = "Confirm Email";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(490, 263);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(25, 16);
            this.labelZipCode.TabIndex = 33;
            this.labelZipCode.Text = "Zip";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(360, 263);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(38, 16);
            this.labelState.TabIndex = 32;
            this.labelState.Text = "State";
            // 
            // labelCurrentEmail
            // 
            this.labelCurrentEmail.AutoSize = true;
            this.labelCurrentEmail.Location = new System.Drawing.Point(62, 315);
            this.labelCurrentEmail.Name = "labelCurrentEmail";
            this.labelCurrentEmail.Size = new System.Drawing.Size(86, 16);
            this.labelCurrentEmail.TabIndex = 31;
            this.labelCurrentEmail.Text = "Current Email";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(62, 263);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(29, 16);
            this.labelCity.TabIndex = 30;
            this.labelCity.Text = "City";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(62, 175);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(54, 16);
            this.labelAddress.TabIndex = 29;
            this.labelAddress.Text = "Address";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(62, 128);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(68, 16);
            this.labelLastName.TabIndex = 28;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(62, 81);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(70, 16);
            this.labelFirstName.TabIndex = 27;
            this.labelFirstName.Text = "First Name";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(503, 484);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 28);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateAccount.Location = new System.Drawing.Point(597, 484);
            this.buttonCreateAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(87, 28);
            this.buttonCreateAccount.TabIndex = 11;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // labelCreateAccount
            // 
            this.labelCreateAccount.AutoSize = true;
            this.labelCreateAccount.Location = new System.Drawing.Point(286, 11);
            this.labelCreateAccount.Name = "labelCreateAccount";
            this.labelCreateAccount.Size = new System.Drawing.Size(183, 16);
            this.labelCreateAccount.TabIndex = 52;
            this.labelCreateAccount.Text = "Create New Employee Account";
            this.labelCreateAccount.Click += new System.EventHandler(this.labelCreateAccount_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(356, 52);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(47, 16);
            this.labelTitle.TabIndex = 51;
            this.labelTitle.Text = "AntLife";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 53;
            // 
            // frmAddNewEmployee
            // 
            this.AcceptButton = this.buttonCreateAccount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(699, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCreateAccount);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.comboBoxStates);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxConfirmEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelConfirmEmail);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCurrentEmail);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAddNewEmployee";
            this.Text = "Create New Employee Account";
            this.Load += new System.EventHandler(this.frmAddNewEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.ComboBox comboBoxStates;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfirmEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmEmail;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCurrentEmail;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label labelCreateAccount;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
    }
}