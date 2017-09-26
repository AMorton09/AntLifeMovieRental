namespace AntLifeF2Team9
{
    partial class frmLogin
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
            this.labelSignIn = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelNotAMember = new System.Windows.Forms.Label();
            this.linkLabelNewAccount = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelForgotPass = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSignIn
            // 
            this.labelSignIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.Location = new System.Drawing.Point(282, 315);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(116, 37);
            this.labelSignIn.TabIndex = 1;
            this.labelSignIn.Text = "Sign In";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(146, 368);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 16);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(146, 444);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 16);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxEmail.Location = new System.Drawing.Point(227, 364);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(245, 23);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.Text = "test@customer.com";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPassword.Location = new System.Drawing.Point(227, 436);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(245, 23);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "test1234";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(570, 529);
            this.buttonSignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(87, 28);
            this.buttonSignIn.TabIndex = 2;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(476, 529);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 28);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelNotAMember
            // 
            this.labelNotAMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNotAMember.AutoSize = true;
            this.labelNotAMember.Location = new System.Drawing.Point(162, 512);
            this.labelNotAMember.Name = "labelNotAMember";
            this.labelNotAMember.Size = new System.Drawing.Size(200, 16);
            this.labelNotAMember.TabIndex = 8;
            this.labelNotAMember.Text = "Not An AntLife Rewards Member?";
            // 
            // linkLabelNewAccount
            // 
            this.linkLabelNewAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabelNewAccount.AutoSize = true;
            this.linkLabelNewAccount.Location = new System.Drawing.Point(365, 512);
            this.linkLabelNewAccount.Name = "linkLabelNewAccount";
            this.linkLabelNewAccount.Size = new System.Drawing.Size(114, 16);
            this.linkLabelNewAccount.TabIndex = 4;
            this.linkLabelNewAccount.TabStop = true;
            this.linkLabelNewAccount.Text = "Create An Account";
            this.linkLabelNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNewAccount_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AntLifeF2Team9.Properties.Resources.tm9;
            this.pictureBox1.Location = new System.Drawing.Point(92, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 331);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelForgotPass
            // 
            this.linkLabelForgotPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabelForgotPass.AutoSize = true;
            this.linkLabelForgotPass.Location = new System.Drawing.Point(287, 464);
            this.linkLabelForgotPass.Name = "linkLabelForgotPass";
            this.linkLabelForgotPass.Size = new System.Drawing.Size(110, 16);
            this.linkLabelForgotPass.TabIndex = 10;
            this.linkLabelForgotPass.TabStop = true;
            this.linkLabelForgotPass.Text = "Forgot Password?";
            this.linkLabelForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.buttonSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(672, 572);
            this.Controls.Add(this.linkLabelForgotPass);
            this.Controls.Add(this.linkLabelNewAccount);
            this.Controls.Add(this.labelNotAMember);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelSignIn);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSignIn;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelNotAMember;
        private System.Windows.Forms.LinkLabel linkLabelNewAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelForgotPass;
    }
}

