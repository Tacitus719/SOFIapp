namespace SOFIapp
{
    partial class Odberatelia
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
            this.dataGridViewOdberatelia = new System.Windows.Forms.DataGridView();
            this.ODBERATEL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAZOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KRAJINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOdberateliaDetail = new System.Windows.Forms.Panel();
            this.groupBoxOdberatelia = new System.Windows.Forms.GroupBox();
            this.labelOdberateliaNazov = new System.Windows.Forms.Label();
            this.textBoxOdberateliaID = new System.Windows.Forms.TextBox();
            this.labelOdberateliaID = new System.Windows.Forms.Label();
            this.buttonOdberateliaPridat = new System.Windows.Forms.Button();
            this.buttonOdberateliaUpravit = new System.Windows.Forms.Button();
            this.buttonOdberateliaVymazat = new System.Windows.Forms.Button();
            this.textBoxOdberateliaNazov = new System.Windows.Forms.TextBox();
            this.textBoxOdberateliaAdresa = new System.Windows.Forms.TextBox();
            this.textBoxOdberateliaPSC = new System.Windows.Forms.TextBox();
            this.textBoxOdberateliaMesto = new System.Windows.Forms.TextBox();
            this.textBoxOdberateliaEmail = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelOdberateliaEmail = new System.Windows.Forms.Label();
            this.labelOdberateliaTelefon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdberatelia)).BeginInit();
            this.panelOdberateliaDetail.SuspendLayout();
            this.groupBoxOdberatelia.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOdberatelia
            // 
            this.dataGridViewOdberatelia.AllowUserToAddRows = false;
            this.dataGridViewOdberatelia.AllowUserToDeleteRows = false;
            this.dataGridViewOdberatelia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOdberatelia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdberatelia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ODBERATEL_ID,
            this.NAZOV,
            this.ADRESA,
            this.PSC,
            this.MESTO,
            this.KRAJINA,
            this.EMAIL,
            this.TELEFON});
            this.dataGridViewOdberatelia.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOdberatelia.Name = "dataGridViewOdberatelia";
            this.dataGridViewOdberatelia.ReadOnly = true;
            this.dataGridViewOdberatelia.RowHeadersVisible = false;
            this.dataGridViewOdberatelia.RowHeadersWidth = 51;
            this.dataGridViewOdberatelia.RowTemplate.Height = 24;
            this.dataGridViewOdberatelia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOdberatelia.Size = new System.Drawing.Size(888, 426);
            this.dataGridViewOdberatelia.TabIndex = 0;
            this.dataGridViewOdberatelia.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewOdberatelia_RowStateChanged);
            // 
            // ODBERATEL_ID
            // 
            this.ODBERATEL_ID.DataPropertyName = "ODBERATEL_ID";
            this.ODBERATEL_ID.HeaderText = "ID odberateľa";
            this.ODBERATEL_ID.MinimumWidth = 6;
            this.ODBERATEL_ID.Name = "ODBERATEL_ID";
            this.ODBERATEL_ID.ReadOnly = true;
            this.ODBERATEL_ID.Width = 125;
            // 
            // NAZOV
            // 
            this.NAZOV.DataPropertyName = "NAZOV";
            this.NAZOV.HeaderText = "názov odberateľa";
            this.NAZOV.MinimumWidth = 6;
            this.NAZOV.Name = "NAZOV";
            this.NAZOV.ReadOnly = true;
            this.NAZOV.Width = 125;
            // 
            // ADRESA
            // 
            this.ADRESA.DataPropertyName = "ADRESA";
            this.ADRESA.HeaderText = "adresa odberateľa";
            this.ADRESA.MinimumWidth = 6;
            this.ADRESA.Name = "ADRESA";
            this.ADRESA.ReadOnly = true;
            this.ADRESA.Width = 125;
            // 
            // PSC
            // 
            this.PSC.DataPropertyName = "PSC";
            this.PSC.HeaderText = "PSČ (ZIP code)";
            this.PSC.MinimumWidth = 6;
            this.PSC.Name = "PSC";
            this.PSC.ReadOnly = true;
            this.PSC.Width = 125;
            // 
            // MESTO
            // 
            this.MESTO.DataPropertyName = "MESTO";
            this.MESTO.HeaderText = "mesto (obec)";
            this.MESTO.MinimumWidth = 6;
            this.MESTO.Name = "MESTO";
            this.MESTO.ReadOnly = true;
            this.MESTO.Width = 125;
            // 
            // KRAJINA
            // 
            this.KRAJINA.DataPropertyName = "KRAJINA";
            this.KRAJINA.HeaderText = "Štát (Krajina)";
            this.KRAJINA.MinimumWidth = 6;
            this.KRAJINA.Name = "KRAJINA";
            this.KRAJINA.ReadOnly = true;
            this.KRAJINA.Width = 125;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "e-mailova adresa";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Width = 125;
            // 
            // TELEFON
            // 
            this.TELEFON.DataPropertyName = "TELEFON";
            this.TELEFON.HeaderText = "telefónne číslo";
            this.TELEFON.MinimumWidth = 6;
            this.TELEFON.Name = "TELEFON";
            this.TELEFON.ReadOnly = true;
            this.TELEFON.Width = 125;
            // 
            // panelOdberateliaDetail
            // 
            this.panelOdberateliaDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOdberateliaDetail.Controls.Add(this.groupBoxOdberatelia);
            this.panelOdberateliaDetail.Location = new System.Drawing.Point(916, 12);
            this.panelOdberateliaDetail.Name = "panelOdberateliaDetail";
            this.panelOdberateliaDetail.Size = new System.Drawing.Size(398, 426);
            this.panelOdberateliaDetail.TabIndex = 1;
            // 
            // groupBoxOdberatelia
            // 
            this.groupBoxOdberatelia.Controls.Add(this.buttonOdberateliaVymazat);
            this.groupBoxOdberatelia.Controls.Add(this.labelOdberateliaTelefon);
            this.groupBoxOdberatelia.Controls.Add(this.buttonOdberateliaUpravit);
            this.groupBoxOdberatelia.Controls.Add(this.labelOdberateliaEmail);
            this.groupBoxOdberatelia.Controls.Add(this.buttonOdberateliaPridat);
            this.groupBoxOdberatelia.Controls.Add(this.textBox1);
            this.groupBoxOdberatelia.Controls.Add(this.textBoxOdberateliaEmail);
            this.groupBoxOdberatelia.Controls.Add(this.textBoxOdberateliaMesto);
            this.groupBoxOdberatelia.Controls.Add(this.textBoxOdberateliaPSC);
            this.groupBoxOdberatelia.Controls.Add(this.textBoxOdberateliaAdresa);
            this.groupBoxOdberatelia.Controls.Add(this.textBoxOdberateliaNazov);
            this.groupBoxOdberatelia.Controls.Add(this.labelOdberateliaNazov);
            this.groupBoxOdberatelia.Controls.Add(this.textBoxOdberateliaID);
            this.groupBoxOdberatelia.Controls.Add(this.labelOdberateliaID);
            this.groupBoxOdberatelia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxOdberatelia.Location = new System.Drawing.Point(4, 1);
            this.groupBoxOdberatelia.Name = "groupBoxOdberatelia";
            this.groupBoxOdberatelia.Size = new System.Drawing.Size(378, 403);
            this.groupBoxOdberatelia.TabIndex = 0;
            this.groupBoxOdberatelia.TabStop = false;
            this.groupBoxOdberatelia.Text = "detail odberateľa";
            // 
            // labelOdberateliaNazov
            // 
            this.labelOdberateliaNazov.AutoSize = true;
            this.labelOdberateliaNazov.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdberateliaNazov.Location = new System.Drawing.Point(7, 67);
            this.labelOdberateliaNazov.Name = "labelOdberateliaNazov";
            this.labelOdberateliaNazov.Size = new System.Drawing.Size(116, 16);
            this.labelOdberateliaNazov.TabIndex = 2;
            this.labelOdberateliaNazov.Text = "názov odberateľa:";
            // 
            // textBoxOdberateliaID
            // 
            this.textBoxOdberateliaID.Location = new System.Drawing.Point(10, 42);
            this.textBoxOdberateliaID.Name = "textBoxOdberateliaID";
            this.textBoxOdberateliaID.ReadOnly = true;
            this.textBoxOdberateliaID.Size = new System.Drawing.Size(257, 22);
            this.textBoxOdberateliaID.TabIndex = 1;
            this.textBoxOdberateliaID.TabStop = false;
            // 
            // labelOdberateliaID
            // 
            this.labelOdberateliaID.AutoSize = true;
            this.labelOdberateliaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdberateliaID.Location = new System.Drawing.Point(7, 22);
            this.labelOdberateliaID.Name = "labelOdberateliaID";
            this.labelOdberateliaID.Size = new System.Drawing.Size(93, 16);
            this.labelOdberateliaID.TabIndex = 0;
            this.labelOdberateliaID.Text = "ID odberateľa:";
            // 
            // buttonOdberateliaPridat
            // 
            this.buttonOdberateliaPridat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOdberateliaPridat.Location = new System.Drawing.Point(6, 279);
            this.buttonOdberateliaPridat.Name = "buttonOdberateliaPridat";
            this.buttonOdberateliaPridat.Size = new System.Drawing.Size(131, 35);
            this.buttonOdberateliaPridat.TabIndex = 0;
            this.buttonOdberateliaPridat.Text = "Pridať";
            this.buttonOdberateliaPridat.UseVisualStyleBackColor = true;
            // 
            // buttonOdberateliaUpravit
            // 
            this.buttonOdberateliaUpravit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOdberateliaUpravit.Location = new System.Drawing.Point(6, 320);
            this.buttonOdberateliaUpravit.Name = "buttonOdberateliaUpravit";
            this.buttonOdberateliaUpravit.Size = new System.Drawing.Size(131, 35);
            this.buttonOdberateliaUpravit.TabIndex = 2;
            this.buttonOdberateliaUpravit.Text = "Upraviť";
            this.buttonOdberateliaUpravit.UseVisualStyleBackColor = true;
            // 
            // buttonOdberateliaVymazat
            // 
            this.buttonOdberateliaVymazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOdberateliaVymazat.Location = new System.Drawing.Point(6, 361);
            this.buttonOdberateliaVymazat.Name = "buttonOdberateliaVymazat";
            this.buttonOdberateliaVymazat.Size = new System.Drawing.Size(131, 35);
            this.buttonOdberateliaVymazat.TabIndex = 3;
            this.buttonOdberateliaVymazat.Text = "Vymazať";
            this.buttonOdberateliaVymazat.UseVisualStyleBackColor = true;
            this.buttonOdberateliaVymazat.Click += new System.EventHandler(this.buttonOdberateliaVymazat_Click);
            // 
            // textBoxOdberateliaNazov
            // 
            this.textBoxOdberateliaNazov.Location = new System.Drawing.Point(6, 86);
            this.textBoxOdberateliaNazov.MaxLength = 32;
            this.textBoxOdberateliaNazov.Name = "textBoxOdberateliaNazov";
            this.textBoxOdberateliaNazov.ReadOnly = true;
            this.textBoxOdberateliaNazov.Size = new System.Drawing.Size(338, 22);
            this.textBoxOdberateliaNazov.TabIndex = 3;
            this.textBoxOdberateliaNazov.TabStop = false;
            // 
            // textBoxOdberateliaAdresa
            // 
            this.textBoxOdberateliaAdresa.Location = new System.Drawing.Point(6, 114);
            this.textBoxOdberateliaAdresa.MaxLength = 32;
            this.textBoxOdberateliaAdresa.Name = "textBoxOdberateliaAdresa";
            this.textBoxOdberateliaAdresa.ReadOnly = true;
            this.textBoxOdberateliaAdresa.Size = new System.Drawing.Size(338, 22);
            this.textBoxOdberateliaAdresa.TabIndex = 4;
            this.textBoxOdberateliaAdresa.TabStop = false;
            // 
            // textBoxOdberateliaPSC
            // 
            this.textBoxOdberateliaPSC.Location = new System.Drawing.Point(6, 142);
            this.textBoxOdberateliaPSC.MaxLength = 10;
            this.textBoxOdberateliaPSC.Name = "textBoxOdberateliaPSC";
            this.textBoxOdberateliaPSC.ReadOnly = true;
            this.textBoxOdberateliaPSC.Size = new System.Drawing.Size(66, 22);
            this.textBoxOdberateliaPSC.TabIndex = 5;
            this.textBoxOdberateliaPSC.TabStop = false;
            // 
            // textBoxOdberateliaMesto
            // 
            this.textBoxOdberateliaMesto.Location = new System.Drawing.Point(78, 142);
            this.textBoxOdberateliaMesto.MaxLength = 32;
            this.textBoxOdberateliaMesto.Name = "textBoxOdberateliaMesto";
            this.textBoxOdberateliaMesto.ReadOnly = true;
            this.textBoxOdberateliaMesto.Size = new System.Drawing.Size(185, 22);
            this.textBoxOdberateliaMesto.TabIndex = 6;
            this.textBoxOdberateliaMesto.TabStop = false;
            // 
            // textBoxOdberateliaEmail
            // 
            this.textBoxOdberateliaEmail.Location = new System.Drawing.Point(10, 205);
            this.textBoxOdberateliaEmail.MaxLength = 32;
            this.textBoxOdberateliaEmail.Name = "textBoxOdberateliaEmail";
            this.textBoxOdberateliaEmail.ReadOnly = true;
            this.textBoxOdberateliaEmail.Size = new System.Drawing.Size(257, 22);
            this.textBoxOdberateliaEmail.TabIndex = 7;
            this.textBoxOdberateliaEmail.TabStop = false;
            this.textBoxOdberateliaEmail.TextChanged += new System.EventHandler(this.textBoxOdberateliaEmail_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 251);
            this.textBox1.MaxLength = 25;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(257, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TabStop = false;
            // 
            // labelOdberateliaEmail
            // 
            this.labelOdberateliaEmail.AutoSize = true;
            this.labelOdberateliaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdberateliaEmail.Location = new System.Drawing.Point(10, 186);
            this.labelOdberateliaEmail.Name = "labelOdberateliaEmail";
            this.labelOdberateliaEmail.Size = new System.Drawing.Size(113, 16);
            this.labelOdberateliaEmail.TabIndex = 9;
            this.labelOdberateliaEmail.Text = "email odberateľa:";
            // 
            // labelOdberateliaTelefon
            // 
            this.labelOdberateliaTelefon.AutoSize = true;
            this.labelOdberateliaTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdberateliaTelefon.Location = new System.Drawing.Point(10, 232);
            this.labelOdberateliaTelefon.Name = "labelOdberateliaTelefon";
            this.labelOdberateliaTelefon.Size = new System.Drawing.Size(120, 16);
            this.labelOdberateliaTelefon.TabIndex = 10;
            this.labelOdberateliaTelefon.Text = "telefón odberateľa:";
            // 
            // Odberatelia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 450);
            this.Controls.Add(this.panelOdberateliaDetail);
            this.Controls.Add(this.dataGridViewOdberatelia);
            this.Name = "Odberatelia";
            this.Text = "Odberatelia";
            this.Load += new System.EventHandler(this.Odberatelia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdberatelia)).EndInit();
            this.panelOdberateliaDetail.ResumeLayout(false);
            this.groupBoxOdberatelia.ResumeLayout(false);
            this.groupBoxOdberatelia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOdberatelia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ODBERATEL_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn KRAJINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFON;
        private System.Windows.Forms.Panel panelOdberateliaDetail;
        private System.Windows.Forms.Button buttonOdberateliaPridat;
        private System.Windows.Forms.Button buttonOdberateliaUpravit;
        private System.Windows.Forms.Button buttonOdberateliaVymazat;
        private System.Windows.Forms.GroupBox groupBoxOdberatelia;
        private System.Windows.Forms.Label labelOdberateliaNazov;
        public System.Windows.Forms.TextBox textBoxOdberateliaID;
        private System.Windows.Forms.Label labelOdberateliaID;
        public System.Windows.Forms.TextBox textBoxOdberateliaNazov;
        public System.Windows.Forms.TextBox textBoxOdberateliaPSC;
        public System.Windows.Forms.TextBox textBoxOdberateliaAdresa;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBoxOdberateliaEmail;
        public System.Windows.Forms.TextBox textBoxOdberateliaMesto;
        private System.Windows.Forms.Label labelOdberateliaTelefon;
        private System.Windows.Forms.Label labelOdberateliaEmail;
    }
}