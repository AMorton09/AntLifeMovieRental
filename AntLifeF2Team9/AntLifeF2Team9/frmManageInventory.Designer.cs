namespace AntLifeF2Team9
{
    partial class frmManageInventory
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
            this.dataGridViewInv = new System.Windows.Forms.DataGridView();
            this.toolStripButtonRemove = new System.Windows.Forms.Button();
            this.toolStripButtonAddProduct = new System.Windows.Forms.Button();
            this.toolStripButtonEdit = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInv
            // 
            this.dataGridViewInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInv.Location = new System.Drawing.Point(14, 112);
            this.dataGridViewInv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewInv.Name = "dataGridViewInv";
            this.dataGridViewInv.Size = new System.Drawing.Size(797, 447);
            this.dataGridViewInv.TabIndex = 1;
            this.dataGridViewInv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripButtonRemove.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonRemove.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.toolStripButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toolStripButtonRemove.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripButtonRemove.Image = global::AntLifeF2Team9.Properties.Resources.Cancel_32x;
            this.toolStripButtonRemove.Location = new System.Drawing.Point(751, 58);
            this.toolStripButtonRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            this.toolStripButtonRemove.Size = new System.Drawing.Size(52, 47);
            this.toolStripButtonRemove.TabIndex = 7;
            this.toolStripButtonRemove.UseVisualStyleBackColor = false;
            this.toolStripButtonRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click);
            // 
            // toolStripButtonAddProduct
            // 
            this.toolStripButtonAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripButtonAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonAddProduct.BackgroundImage = global::AntLifeF2Team9.Properties.Resources.VSO_AddButton_mint_26x;
            this.toolStripButtonAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripButtonAddProduct.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.toolStripButtonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toolStripButtonAddProduct.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripButtonAddProduct.Location = new System.Drawing.Point(639, 58);
            this.toolStripButtonAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripButtonAddProduct.Name = "toolStripButtonAddProduct";
            this.toolStripButtonAddProduct.Size = new System.Drawing.Size(52, 47);
            this.toolStripButtonAddProduct.TabIndex = 6;
            this.toolStripButtonAddProduct.UseVisualStyleBackColor = false;
            this.toolStripButtonAddProduct.Click += new System.EventHandler(this.toolStripButtonAddEmployee_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonEdit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.toolStripButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toolStripButtonEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripButtonEdit.Image = global::AntLifeF2Team9.Properties.Resources.i_edit_itemBlue_F12;
            this.toolStripButtonEdit.Location = new System.Drawing.Point(695, 58);
            this.toolStripButtonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(52, 47);
            this.toolStripButtonEdit.TabIndex = 5;
            this.toolStripButtonEdit.UseVisualStyleBackColor = false;
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(723, 564);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 28);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // frmManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(818, 599);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.toolStripButtonRemove);
            this.Controls.Add(this.toolStripButtonAddProduct);
            this.Controls.Add(this.toolStripButtonEdit);
            this.Controls.Add(this.dataGridViewInv);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmManageInventory";
            this.Text = "Manage Inventory";
            this.Load += new System.EventHandler(this.frmManageInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewInv;
        private System.Windows.Forms.Button toolStripButtonRemove;
        private System.Windows.Forms.Button toolStripButtonAddProduct;
        private System.Windows.Forms.Button toolStripButtonEdit;
        private System.Windows.Forms.Button buttonClose;
    }
}