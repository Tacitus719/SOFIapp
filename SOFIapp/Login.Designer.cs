namespace SOFIapp
{
    partial class Login
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
            this.textBoxLoginPswd = new System.Windows.Forms.TextBox();
            this.textBoxLoginUserID = new System.Windows.Forms.TextBox();
            this.labelLoginUserID = new System.Windows.Forms.Label();
            this.labelLoginPswd = new System.Windows.Forms.Label();
            this.buttonLoginOK = new System.Windows.Forms.Button();
            this.buttonLoginCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLoginPswd
            // 
            this.textBoxLoginPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLoginPswd.Location = new System.Drawing.Point(95, 75);
            this.textBoxLoginPswd.MaxLength = 20;
            this.textBoxLoginPswd.Name = "textBoxLoginPswd";
            this.textBoxLoginPswd.PasswordChar = '•';
            this.textBoxLoginPswd.Size = new System.Drawing.Size(248, 27);
            this.textBoxLoginPswd.TabIndex = 2;
            this.textBoxLoginPswd.Text = "xloj";
            // 
            // textBoxLoginUserID
            // 
            this.textBoxLoginUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLoginUserID.Location = new System.Drawing.Point(95, 47);
            this.textBoxLoginUserID.MaxLength = 20;
            this.textBoxLoginUserID.Name = "textBoxLoginUserID";
            this.textBoxLoginUserID.Size = new System.Drawing.Size(248, 27);
            this.textBoxLoginUserID.TabIndex = 1;
            this.textBoxLoginUserID.Text = "xloj";
            this.textBoxLoginUserID.UseWaitCursor = true;
            // 
            // labelLoginUserID
            // 
            this.labelLoginUserID.AutoSize = true;
            this.labelLoginUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginUserID.Location = new System.Drawing.Point(27, 50);
            this.labelLoginUserID.Name = "labelLoginUserID";
            this.labelLoginUserID.Size = new System.Drawing.Size(67, 20);
            this.labelLoginUserID.TabIndex = 2;
            this.labelLoginUserID.Text = "UserID:";
            this.labelLoginUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLoginPswd
            // 
            this.labelLoginPswd.AutoSize = true;
            this.labelLoginPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginPswd.Location = new System.Drawing.Point(36, 78);
            this.labelLoginPswd.Name = "labelLoginPswd";
            this.labelLoginPswd.Size = new System.Drawing.Size(58, 20);
            this.labelLoginPswd.TabIndex = 3;
            this.labelLoginPswd.Text = "Heslo:";
            this.labelLoginPswd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonLoginOK
            // 
            this.buttonLoginOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonLoginOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoginOK.Location = new System.Drawing.Point(95, 108);
            this.buttonLoginOK.Name = "buttonLoginOK";
            this.buttonLoginOK.Size = new System.Drawing.Size(107, 46);
            this.buttonLoginOK.TabIndex = 4;
            this.buttonLoginOK.Text = "Prihlásiť";
            this.buttonLoginOK.UseVisualStyleBackColor = true;
            // 
            // buttonLoginCancel
            // 
            this.buttonLoginCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLoginCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoginCancel.Location = new System.Drawing.Point(208, 108);
            this.buttonLoginCancel.Name = "buttonLoginCancel";
            this.buttonLoginCancel.Size = new System.Drawing.Size(107, 46);
            this.buttonLoginCancel.TabIndex = 5;
            this.buttonLoginCancel.Text = "Zrušiť";
            this.buttonLoginCancel.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 209);
            this.Controls.Add(this.buttonLoginCancel);
            this.Controls.Add(this.buttonLoginOK);
            this.Controls.Add(this.labelLoginPswd);
            this.Controls.Add(this.labelLoginUserID);
            this.Controls.Add(this.textBoxLoginUserID);
            this.Controls.Add(this.textBoxLoginPswd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login » Prihlásenie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxLoginUserID;
        private System.Windows.Forms.Label labelLoginUserID;
        public System.Windows.Forms.Label labelLoginPswd;
        private System.Windows.Forms.Button buttonLoginOK;
        private System.Windows.Forms.Button buttonLoginCancel;
        public System.Windows.Forms.TextBox textBoxLoginPswd;
    }
}