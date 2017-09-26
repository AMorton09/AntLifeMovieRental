namespace AntLifeF2Team9
{
    partial class frmReports
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonNotSoldInYear = new System.Windows.Forms.Button();
            this.buttonTopSellers = new System.Windows.Forms.Button();
            this.buttonExpMem = new System.Windows.Forms.Button();
            this.buttonCurrentMem = new System.Windows.Forms.Button();
            this.buttonEod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(338, 482);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(86, 27);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonNotSoldInYear
            // 
            this.buttonNotSoldInYear.BackgroundImage = global::AntLifeF2Team9.Properties.Resources._54_512;
            this.buttonNotSoldInYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNotSoldInYear.Location = new System.Drawing.Point(135, 364);
            this.buttonNotSoldInYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNotSoldInYear.Name = "buttonNotSoldInYear";
            this.buttonNotSoldInYear.Size = new System.Drawing.Size(161, 137);
            this.buttonNotSoldInYear.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buttonNotSoldInYear, "Report of Not Sold In One Year");
            this.buttonNotSoldInYear.UseVisualStyleBackColor = true;
            this.buttonNotSoldInYear.Click += new System.EventHandler(this.buttonNotSoldInYear_Click);
            // 
            // buttonTopSellers
            // 
            this.buttonTopSellers.BackgroundImage = global::AntLifeF2Team9.Properties.Resources.dollar_signs_money_bags_icon_29937;
            this.buttonTopSellers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTopSellers.Location = new System.Drawing.Point(231, 220);
            this.buttonTopSellers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTopSellers.Name = "buttonTopSellers";
            this.buttonTopSellers.Size = new System.Drawing.Size(161, 137);
            this.buttonTopSellers.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonTopSellers, "Report for Most Sold");
            this.buttonTopSellers.UseVisualStyleBackColor = true;
            this.buttonTopSellers.Click += new System.EventHandler(this.buttonTopSellers_Click);
            // 
            // buttonExpMem
            // 
            this.buttonExpMem.BackgroundImage = global::AntLifeF2Team9.Properties.Resources.expired_slash2;
            this.buttonExpMem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExpMem.Location = new System.Drawing.Point(41, 220);
            this.buttonExpMem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExpMem.Name = "buttonExpMem";
            this.buttonExpMem.Size = new System.Drawing.Size(161, 137);
            this.buttonExpMem.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonExpMem, "Report for Expired Members");
            this.buttonExpMem.UseVisualStyleBackColor = true;
            this.buttonExpMem.Click += new System.EventHandler(this.buttonExpMem_Click);
            // 
            // buttonCurrentMem
            // 
            this.buttonCurrentMem.BackgroundImage = global::AntLifeF2Team9.Properties.Resources.download__1_;
            this.buttonCurrentMem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCurrentMem.Location = new System.Drawing.Point(231, 64);
            this.buttonCurrentMem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCurrentMem.Name = "buttonCurrentMem";
            this.buttonCurrentMem.Size = new System.Drawing.Size(161, 137);
            this.buttonCurrentMem.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonCurrentMem, "Report of Current Members");
            this.buttonCurrentMem.UseVisualStyleBackColor = true;
            this.buttonCurrentMem.Click += new System.EventHandler(this.buttonCurrentMem_Click);
            // 
            // buttonEod
            // 
            this.buttonEod.BackgroundImage = global::AntLifeF2Team9.Properties.Resources.closed;
            this.buttonEod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEod.Location = new System.Drawing.Point(41, 64);
            this.buttonEod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEod.Name = "buttonEod";
            this.buttonEod.Size = new System.Drawing.Size(161, 137);
            this.buttonEod.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonEod, "End Of Day Reports");
            this.buttonEod.UseVisualStyleBackColor = true;
            this.buttonEod.Click += new System.EventHandler(this.buttonEod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reports Will Be Saved To Documents.";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(433, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonNotSoldInYear);
            this.Controls.Add(this.buttonTopSellers);
            this.Controls.Add(this.buttonExpMem);
            this.Controls.Add(this.buttonCurrentMem);
            this.Controls.Add(this.buttonEod);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEod;
        private System.Windows.Forms.Button buttonCurrentMem;
        private System.Windows.Forms.Button buttonExpMem;
        private System.Windows.Forms.Button buttonTopSellers;
        private System.Windows.Forms.Button buttonNotSoldInYear;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}