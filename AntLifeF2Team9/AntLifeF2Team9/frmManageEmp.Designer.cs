namespace AntLifeF2Team9
{
    partial class frmManageEmp
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
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.toolStripButtonRemove = new System.Windows.Forms.Button();
            this.toolStripButtonAddEmployee = new System.Windows.Forms.Button();
            this.toolStripButtonEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(578, 470);
            this.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(13, 84);
            this.dataGridViewEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(863, 511);
            this.dataGridViewEmployees.TabIndex = 1;
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellContentClick);
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripButtonRemove.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonRemove.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.toolStripButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toolStripButtonRemove.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripButtonRemove.Image = global::AntLifeF2Team9.Properties.Resources.Cancel_32x;
            this.toolStripButtonRemove.Location = new System.Drawing.Point(824, 30);
            this.toolStripButtonRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            this.toolStripButtonRemove.Size = new System.Drawing.Size(52, 47);
            this.toolStripButtonRemove.TabIndex = 4;
            this.toolTip1.SetToolTip(this.toolStripButtonRemove, "Remove an employee");
            this.toolStripButtonRemove.UseVisualStyleBackColor = false;
            this.toolStripButtonRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click_1);
            // 
            // toolStripButtonAddEmployee
            // 
            this.toolStripButtonAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripButtonAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonAddEmployee.BackgroundImage = global::AntLifeF2Team9.Properties.Resources.VSO_AddButton_mint_26x;
            this.toolStripButtonAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripButtonAddEmployee.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.toolStripButtonAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toolStripButtonAddEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripButtonAddEmployee.Location = new System.Drawing.Point(712, 30);
            this.toolStripButtonAddEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripButtonAddEmployee.Name = "toolStripButtonAddEmployee";
            this.toolStripButtonAddEmployee.Size = new System.Drawing.Size(52, 47);
            this.toolStripButtonAddEmployee.TabIndex = 3;
            this.toolTip1.SetToolTip(this.toolStripButtonAddEmployee, "Add a new employee");
            this.toolStripButtonAddEmployee.UseVisualStyleBackColor = false;
            this.toolStripButtonAddEmployee.Click += new System.EventHandler(this.toolStripButtonAddEmployee_Click_1);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonEdit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.toolStripButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toolStripButtonEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripButtonEdit.Image = global::AntLifeF2Team9.Properties.Resources.i_edit_itemBlue_F12;
            this.toolStripButtonEdit.Location = new System.Drawing.Point(768, 30);
            this.toolStripButtonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(52, 47);
            this.toolStripButtonEdit.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolStripButtonEdit, "Edit an employee");
            this.toolStripButtonEdit.UseVisualStyleBackColor = false;
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(792, 602);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmManageEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(891, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStripButtonRemove);
            this.Controls.Add(this.toolStripButtonAddEmployee);
            this.Controls.Add(this.toolStripButtonEdit);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmManageEmp";
            this.Text = "Manage Employees";
            this.Load += new System.EventHandler(this.frmManageEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button toolStripButtonEdit;
        private System.Windows.Forms.Button toolStripButtonAddEmployee;
        private System.Windows.Forms.Button toolStripButtonRemove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}