namespace AntLifeF2Team9
{
    partial class frmCustomer
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
            this.components = new System.ComponentModel.Container();
            this.labelCustName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxProgress = new System.Windows.Forms.GroupBox();
            this.lblXp = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblLvl = new System.Windows.Forms.Label();
            this.progressBarLvl = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonShop = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonViewCart = new System.Windows.Forms.Button();
            this.buttonAddMembership = new System.Windows.Forms.Button();
            this.groupBoxProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCustName
            // 
            this.labelCustName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustName.AutoSize = true;
            this.labelCustName.Location = new System.Drawing.Point(164, 11);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCustName.Size = new System.Drawing.Size(111, 16);
            this.labelCustName.TabIndex = 2;
            this.labelCustName.Text = "CUSTOMER NAME";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(282, 500);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxProgress
            // 
            this.groupBoxProgress.Controls.Add(this.lblXp);
            this.groupBoxProgress.Controls.Add(this.lblNext);
            this.groupBoxProgress.Controls.Add(this.lblLvl);
            this.groupBoxProgress.Controls.Add(this.progressBarLvl);
            this.groupBoxProgress.Location = new System.Drawing.Point(44, 358);
            this.groupBoxProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxProgress.Name = "groupBoxProgress";
            this.groupBoxProgress.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxProgress.Size = new System.Drawing.Size(350, 134);
            this.groupBoxProgress.TabIndex = 6;
            this.groupBoxProgress.TabStop = false;
            this.groupBoxProgress.Text = "Membership Level";
            // 
            // lblXp
            // 
            this.lblXp.AutoSize = true;
            this.lblXp.Location = new System.Drawing.Point(7, 50);
            this.lblXp.Name = "lblXp";
            this.lblXp.Size = new System.Drawing.Size(75, 16);
            this.lblXp.TabIndex = 3;
            this.lblXp.Text = "Current XP:";
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(7, 70);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(115, 16);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "XP Until NextLevel:";
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.Location = new System.Drawing.Point(7, 31);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(89, 16);
            this.lblLvl.TabIndex = 1;
            this.lblLvl.Text = "Current Level:";
            // 
            // progressBarLvl
            // 
            this.progressBarLvl.Location = new System.Drawing.Point(7, 102);
            this.progressBarLvl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarLvl.Name = "progressBarLvl";
            this.progressBarLvl.Size = new System.Drawing.Size(335, 28);
            this.progressBarLvl.TabIndex = 0;
            // 
            // buttonShop
            // 
            this.buttonShop.BackColor = System.Drawing.SystemColors.Control;
            this.buttonShop.BackgroundImage = global::AntLifeF2Team9.Properties.Resources.Shop_512;
            this.buttonShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonShop.Location = new System.Drawing.Point(30, 31);
            this.buttonShop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(184, 155);
            this.buttonShop.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonShop, "View Catalog");
            this.buttonShop.UseVisualStyleBackColor = false;
            this.buttonShop.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackgroundImage = global::AntLifeF2Team9.Properties.Resources.Easy_Returns_512;
            this.buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReturn.Location = new System.Drawing.Point(225, 196);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(184, 155);
            this.buttonReturn.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonReturn, "Retun an Item");
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonViewCart
            // 
            this.buttonViewCart.BackColor = System.Drawing.SystemColors.Control;
            this.buttonViewCart.BackgroundImage = global::AntLifeF2Team9.Properties.Resources.grocery_cart_icon_6;
            this.buttonViewCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonViewCart.Location = new System.Drawing.Point(225, 31);
            this.buttonViewCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonViewCart.Name = "buttonViewCart";
            this.buttonViewCart.Size = new System.Drawing.Size(184, 155);
            this.buttonViewCart.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonViewCart, "View Cart");
            this.buttonViewCart.UseVisualStyleBackColor = false;
            this.buttonViewCart.Click += new System.EventHandler(this.buttonViewCart_Click);
            // 
            // buttonAddMembership
            // 
            this.buttonAddMembership.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddMembership.BackgroundImage = global::AntLifeF2Team9.Properties.Resources.Become_member_button_300x203;
            this.buttonAddMembership.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddMembership.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddMembership.Location = new System.Drawing.Point(30, 196);
            this.buttonAddMembership.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddMembership.Name = "buttonAddMembership";
            this.buttonAddMembership.Size = new System.Drawing.Size(184, 155);
            this.buttonAddMembership.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonAddMembership, "Add / Renew Membership");
            this.buttonAddMembership.UseVisualStyleBackColor = false;
            this.buttonAddMembership.Click += new System.EventHandler(this.buttonAddMembership_Click);
            // 
            // frmCustomer
            // 
            this.AcceptButton = this.buttonShop;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(439, 532);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.groupBoxProgress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonViewCart);
            this.Controls.Add(this.labelCustName);
            this.Controls.Add(this.buttonShop);
            this.Controls.Add(this.buttonAddMembership);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.groupBoxProgress.ResumeLayout(false);
            this.groupBoxProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.Button buttonViewCart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxProgress;
        private System.Windows.Forms.Label lblXp;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.ProgressBar progressBarLvl;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonAddMembership;
    }
}