namespace UI
{
    partial class frmError
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
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.picError = new System.Windows.Forms.PictureBox();
            this.lblTitleError = new System.Windows.Forms.Label();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelFooter.Location = new System.Drawing.Point(0, 229);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1052, 17);
            this.panelFooter.TabIndex = 46;
            // 
            // panelTop
            // 
            this.panelTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1052, 17);
            this.panelTop.TabIndex = 45;
            // 
            // panelBody
            // 
            this.panelBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panelBody.Controls.Add(this.lblError);
            this.panelBody.Controls.Add(this.picError);
            this.panelBody.Controls.Add(this.lblTitleError);
            this.panelBody.Location = new System.Drawing.Point(0, 17);
            this.panelBody.Margin = new System.Windows.Forms.Padding(4);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1052, 212);
            this.panelBody.TabIndex = 47;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblError.Location = new System.Drawing.Point(156, 98);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(739, 92);
            this.lblError.TabIndex = 46;
            this.lblError.Text = "Codigo XXX Descripción Error";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picError
            // 
            this.picError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picError.Image = global::UI.Properties.Resources.Error;
            this.picError.Location = new System.Drawing.Point(276, 22);
            this.picError.Margin = new System.Windows.Forms.Padding(4);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(48, 44);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError.TabIndex = 45;
            this.picError.TabStop = false;
            // 
            // lblTitleError
            // 
            this.lblTitleError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleError.AutoSize = true;
            this.lblTitleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleError.ForeColor = System.Drawing.Color.White;
            this.lblTitleError.Location = new System.Drawing.Point(337, 23);
            this.lblTitleError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleError.Name = "lblTitleError";
            this.lblTitleError.Size = new System.Drawing.Size(455, 46);
            this.lblTitleError.TabIndex = 44;
            this.lblTitleError.Tag = "";
            this.lblTitleError.Text = "ERROR INESPERADO";
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 246);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmError";
            this.Text = "frmError";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmError_KeyPress);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Label lblTitleError;
    }
}