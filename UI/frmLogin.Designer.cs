namespace UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblPipe = new System.Windows.Forms.Label();
            this.picError = new System.Windows.Forms.PictureBox();
            this.lblErrorLogin = new System.Windows.Forms.Label();
            this.lblENG = new System.Windows.Forms.Label();
            this.lblESP = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelIdioma = new System.Windows.Forms.Panel();
            this.lblCHI = new System.Windows.Forms.Label();
            this.lblPipe1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            this.panelIdioma.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPipe
            // 
            this.lblPipe.AutoSize = true;
            this.lblPipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lblPipe.Location = new System.Drawing.Point(413, 8);
            this.lblPipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPipe.Name = "lblPipe";
            this.lblPipe.Size = new System.Drawing.Size(14, 20);
            this.lblPipe.TabIndex = 46;
            this.lblPipe.Tag = "";
            this.lblPipe.Text = "|";
            // 
            // picError
            // 
            this.picError.Image = global::UI.Properties.Resources.Error_20x20;
            this.picError.Location = new System.Drawing.Point(91, 291);
            this.picError.Margin = new System.Windows.Forms.Padding(4);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(21, 20);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picError.TabIndex = 45;
            this.picError.TabStop = false;
            this.picError.Visible = false;
            // 
            // lblErrorLogin
            // 
            this.lblErrorLogin.AutoSize = true;
            this.lblErrorLogin.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lblErrorLogin.Location = new System.Drawing.Point(120, 292);
            this.lblErrorLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorLogin.Name = "lblErrorLogin";
            this.lblErrorLogin.Size = new System.Drawing.Size(289, 19);
            this.lblErrorLogin.TabIndex = 44;
            this.lblErrorLogin.Text = "Usuario y/o clave incorrecto";
            this.lblErrorLogin.Visible = false;
            // 
            // lblENG
            // 
            this.lblENG.AutoSize = true;
            this.lblENG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblENG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblENG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lblENG.Location = new System.Drawing.Point(425, 11);
            this.lblENG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblENG.Name = "lblENG";
            this.lblENG.Size = new System.Drawing.Size(38, 17);
            this.lblENG.TabIndex = 39;
            this.lblENG.Tag = "EN-US";
            this.lblENG.Text = "ENG";
            this.lblENG.Click += new System.EventHandler(this.cambiarIdioma);
            // 
            // lblESP
            // 
            this.lblESP.AutoSize = true;
            this.lblESP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblESP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblESP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lblESP.Location = new System.Drawing.Point(374, 11);
            this.lblESP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblESP.Name = "lblESP";
            this.lblESP.Size = new System.Drawing.Size(38, 17);
            this.lblESP.TabIndex = 38;
            this.lblESP.Tag = "ES-AR";
            this.lblESP.Text = "ESP";
            this.lblESP.Click += new System.EventHandler(this.cambiarIdioma);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lblLogin.Location = new System.Drawing.Point(45, 81);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(291, 29);
            this.lblLogin.TabIndex = 35;
            this.lblLogin.Tag = "upper";
            this.lblLogin.Text = "ACCESO AL SISTEMA";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 411);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(527, 17);
            this.panelFooter.TabIndex = 37;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(527, 17);
            this.panelTop.TabIndex = 36;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(119, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 39);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUsuario.Location = new System.Drawing.Point(66, 122);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(151, 28);
            this.lblUsuario.TabIndex = 48;
            this.lblUsuario.Text = "Ingresar usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txtUsuario.Location = new System.Drawing.Point(71, 156);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(362, 34);
            this.txtUsuario.TabIndex = 49;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txtPassword.Location = new System.Drawing.Point(71, 241);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(362, 34);
            this.txtPassword.TabIndex = 51;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPassword.Location = new System.Drawing.Point(66, 206);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(131, 28);
            this.lblPassword.TabIndex = 50;
            this.lblPassword.Text = "Ingresar clave";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(304, 340);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(129, 39);
            this.btnAceptar.TabIndex = 52;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panelIdioma
            // 
            this.panelIdioma.Controls.Add(this.lblCHI);
            this.panelIdioma.Controls.Add(this.lblPipe1);
            this.panelIdioma.Controls.Add(this.lblESP);
            this.panelIdioma.Controls.Add(this.lblENG);
            this.panelIdioma.Controls.Add(this.lblPipe);
            this.panelIdioma.Location = new System.Drawing.Point(0, 17);
            this.panelIdioma.Name = "panelIdioma";
            this.panelIdioma.Size = new System.Drawing.Size(527, 38);
            this.panelIdioma.TabIndex = 53;
            // 
            // lblCHI
            // 
            this.lblCHI.AutoSize = true;
            this.lblCHI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCHI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lblCHI.Location = new System.Drawing.Point(478, 11);
            this.lblCHI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCHI.Name = "lblCHI";
            this.lblCHI.Size = new System.Drawing.Size(30, 17);
            this.lblCHI.TabIndex = 47;
            this.lblCHI.Tag = "ZH-CHS";
            this.lblCHI.Text = "CHI";
            this.lblCHI.Click += new System.EventHandler(this.cambiarIdioma);
            // 
            // lblPipe1
            // 
            this.lblPipe1.AutoSize = true;
            this.lblPipe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPipe1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lblPipe1.Location = new System.Drawing.Point(466, 8);
            this.lblPipe1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPipe1.Name = "lblPipe1";
            this.lblPipe1.Size = new System.Drawing.Size(14, 20);
            this.lblPipe1.TabIndex = 48;
            this.lblPipe1.Tag = "";
            this.lblPipe1.Text = "|";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(527, 428);
            this.Controls.Add(this.panelIdioma);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.picError);
            this.Controls.Add(this.lblErrorLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            this.panelIdioma.ResumeLayout(false);
            this.panelIdioma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPipe;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Label lblErrorLogin;
        private System.Windows.Forms.Label lblENG;
        private System.Windows.Forms.Label lblESP;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panelIdioma;
        private System.Windows.Forms.Label lblCHI;
        private System.Windows.Forms.Label lblPipe1;
    }
}

