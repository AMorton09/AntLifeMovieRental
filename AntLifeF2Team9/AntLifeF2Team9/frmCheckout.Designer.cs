namespace AntLifeF2Team9
{
    partial class Checkout
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
            this.labelOrderSubTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOrderSubTotal
            // 
            this.labelOrderSubTotal.AutoSize = true;
            this.labelOrderSubTotal.Location = new System.Drawing.Point(12, 120);
            this.labelOrderSubTotal.Name = "labelOrderSubTotal";
            this.labelOrderSubTotal.Size = new System.Drawing.Size(66, 13);
            this.labelOrderSubTotal.TabIndex = 0;
            this.labelOrderSubTotal.Text = "Order Total:";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(453, 423);
            this.Controls.Add(this.labelOrderSubTotal);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Checkout";
            this.Text = "frmCheckout";
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrderSubTotal;
    }
}