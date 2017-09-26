namespace AntLifeF2Team9
{
    partial class frmShop
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.f2T9DataSet = new AntLifeF2Team9.F2T9DataSet();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.buttonViewCart = new System.Windows.Forms.Button();
            this.labelQtyAdded = new System.Windows.Forms.Label();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2T9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(14, 126);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(808, 438);
            this.dataGridViewProducts.TabIndex = 1;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // f2T9DataSet
            // 
            this.f2T9DataSet.DataSetName = "F2T9DataSet";
            this.f2T9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.f2T9DataSet;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategories.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(680, 92);
            this.comboBoxCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(140, 24);
            this.comboBoxCategories.TabIndex = 0;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddToCart.Location = new System.Drawing.Point(559, 608);
            this.buttonAddToCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(87, 28);
            this.buttonAddToCart.TabIndex = 2;
            this.buttonAddToCart.Text = "Add To Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonViewCart
            // 
            this.buttonViewCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewCart.Location = new System.Drawing.Point(654, 606);
            this.buttonViewCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonViewCart.Name = "buttonViewCart";
            this.buttonViewCart.Size = new System.Drawing.Size(87, 28);
            this.buttonViewCart.TabIndex = 3;
            this.buttonViewCart.Text = "View Cart";
            this.buttonViewCart.UseVisualStyleBackColor = true;
            this.buttonViewCart.Click += new System.EventHandler(this.buttonViewCart_Click);
            // 
            // labelQtyAdded
            // 
            this.labelQtyAdded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQtyAdded.AutoSize = true;
            this.labelQtyAdded.Location = new System.Drawing.Point(465, 588);
            this.labelQtyAdded.Name = "labelQtyAdded";
            this.labelQtyAdded.Size = new System.Drawing.Size(72, 16);
            this.labelQtyAdded.TabIndex = 4;
            this.labelQtyAdded.Text = "Qty. to Add";
            // 
            // textBoxQty
            // 
            this.textBoxQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQty.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQty.Location = new System.Drawing.Point(488, 608);
            this.textBoxQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.ReadOnly = true;
            this.textBoxQty.Size = new System.Drawing.Size(28, 23);
            this.textBoxQty.TabIndex = 5;
            this.textBoxQty.Text = "1";
            this.textBoxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQty.TextChanged += new System.EventHandler(this.textBoxQty_TextChanged);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMinus.Image = global::AntLifeF2Team9.Properties.Resources.Remove_16x;
            this.buttonMinus.Location = new System.Drawing.Point(463, 608);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(28, 26);
            this.buttonMinus.TabIndex = 7;
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPlus.Image = global::AntLifeF2Team9.Properties.Resources.Add_grey_16x;
            this.buttonPlus.Location = new System.Drawing.Point(512, 608);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(28, 25);
            this.buttonPlus.TabIndex = 6;
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(748, 605);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 28);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(836, 651);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.labelQtyAdded);
            this.Controls.Add(this.buttonViewCart);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.dataGridViewProducts);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmShop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.frmShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2T9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private F2T9DataSet f2T9DataSet;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Button buttonViewCart;
        private System.Windows.Forms.Label labelQtyAdded;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonClose;
    }
}