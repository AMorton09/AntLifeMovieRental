namespace AntLifeF2Team9
{
    partial class frmReturn
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
            this.dataGridViewPurchases = new System.Windows.Forms.DataGridView();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.checkBoxDefect = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPurchases
            // 
            this.dataGridViewPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchases.Location = new System.Drawing.Point(14, 146);
            this.dataGridViewPurchases.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPurchases.Name = "dataGridViewPurchases";
            this.dataGridViewPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPurchases.Size = new System.Drawing.Size(732, 358);
            this.dataGridViewPurchases.TabIndex = 0;
            this.dataGridViewPurchases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPurchases_CellContentClick);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReturn.Location = new System.Drawing.Point(493, 528);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(159, 28);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "Return Selected Item";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // checkBoxDefect
            // 
            this.checkBoxDefect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDefect.AutoSize = true;
            this.checkBoxDefect.Location = new System.Drawing.Point(586, 118);
            this.checkBoxDefect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxDefect.Name = "checkBoxDefect";
            this.checkBoxDefect.Size = new System.Drawing.Size(159, 25);
            this.checkBoxDefect.TabIndex = 2;
            this.checkBoxDefect.Text = "Item is Defective";
            this.checkBoxDefect.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(658, 528);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 28);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(760, 571);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.checkBoxDefect);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dataGridViewPurchases);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReturn";
            this.Text = "Returns";
            this.Load += new System.EventHandler(this.frmReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPurchases;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.CheckBox checkBoxDefect;
        private System.Windows.Forms.Button buttonClose;
    }
}