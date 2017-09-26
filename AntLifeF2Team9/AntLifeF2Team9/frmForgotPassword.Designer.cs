namespace AntLifeF2Team9
{
    partial class frmForgotPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.textBoxNum3 = new System.Windows.Forms.TextBox();
            this.textBoxNum4 = new System.Windows.Forms.TextBox();
            this.textBoxNum5 = new System.Windows.Forms.TextBox();
            this.textBoxNum6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Location = new System.Drawing.Point(108, 45);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(440, 23);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(142, 79);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(373, 57);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send Code";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Code:";
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(506, 227);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(87, 28);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum1.Location = new System.Drawing.Point(107, 143);
            this.textBoxNum1.MaxLength = 1;
            this.textBoxNum1.Multiline = true;
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(46, 66);
            this.textBoxNum1.TabIndex = 2;
            this.textBoxNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum1.TextChanged += new System.EventHandler(this.textBoxNum1_TextChanged);
            this.textBoxNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum1_KeyPress);
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum2.Location = new System.Drawing.Point(186, 143);
            this.textBoxNum2.MaxLength = 1;
            this.textBoxNum2.Multiline = true;
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(46, 66);
            this.textBoxNum2.TabIndex = 3;
            this.textBoxNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum2_KeyPress);
            // 
            // textBoxNum3
            // 
            this.textBoxNum3.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum3.Location = new System.Drawing.Point(265, 143);
            this.textBoxNum3.MaxLength = 1;
            this.textBoxNum3.Multiline = true;
            this.textBoxNum3.Name = "textBoxNum3";
            this.textBoxNum3.Size = new System.Drawing.Size(46, 66);
            this.textBoxNum3.TabIndex = 4;
            this.textBoxNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum3.TextChanged += new System.EventHandler(this.textBoxNum3_TextChanged);
            this.textBoxNum3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum3_KeyPress);
            // 
            // textBoxNum4
            // 
            this.textBoxNum4.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum4.Location = new System.Drawing.Point(344, 143);
            this.textBoxNum4.MaxLength = 1;
            this.textBoxNum4.Multiline = true;
            this.textBoxNum4.Name = "textBoxNum4";
            this.textBoxNum4.Size = new System.Drawing.Size(46, 66);
            this.textBoxNum4.TabIndex = 5;
            this.textBoxNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum4_KeyPress);
            // 
            // textBoxNum5
            // 
            this.textBoxNum5.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum5.Location = new System.Drawing.Point(423, 143);
            this.textBoxNum5.MaxLength = 1;
            this.textBoxNum5.Multiline = true;
            this.textBoxNum5.Name = "textBoxNum5";
            this.textBoxNum5.Size = new System.Drawing.Size(46, 66);
            this.textBoxNum5.TabIndex = 6;
            this.textBoxNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum5.TextChanged += new System.EventHandler(this.textBoxNum5_TextChanged);
            this.textBoxNum5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum5_KeyPress);
            // 
            // textBoxNum6
            // 
            this.textBoxNum6.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum6.Location = new System.Drawing.Point(502, 143);
            this.textBoxNum6.MaxLength = 1;
            this.textBoxNum6.Multiline = true;
            this.textBoxNum6.Name = "textBoxNum6";
            this.textBoxNum6.Size = new System.Drawing.Size(46, 66);
            this.textBoxNum6.TabIndex = 7;
            this.textBoxNum6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum6_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(474, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "-";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(412, 227);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(85, 28);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // frmForgotPassword
            // 
            this.AcceptButton = this.buttonReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 268);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNum6);
            this.Controls.Add(this.textBoxNum5);
            this.Controls.Add(this.textBoxNum4);
            this.Controls.Add(this.textBoxNum3);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmForgotPassword";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.frmForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.TextBox textBoxNum3;
        private System.Windows.Forms.TextBox textBoxNum4;
        private System.Windows.Forms.TextBox textBoxNum5;
        private System.Windows.Forms.TextBox textBoxNum6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonClose;
    }
}