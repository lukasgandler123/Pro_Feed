namespace Pro_Feed
{
    partial class frm_login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Anmelden = new System.Windows.Forms.Button();
            this.btn_Registrieren = new System.Windows.Forms.Button();
            this.lbl_Benutzername = new System.Windows.Forms.Label();
            this.lbl_passwort = new System.Windows.Forms.Label();
            this.txt_Benutzername = new System.Windows.Forms.TextBox();
            this.txt_Passwort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Anmelden
            // 
            this.btn_Anmelden.Location = new System.Drawing.Point(163, 81);
            this.btn_Anmelden.Name = "btn_Anmelden";
            this.btn_Anmelden.Size = new System.Drawing.Size(144, 35);
            this.btn_Anmelden.TabIndex = 0;
            this.btn_Anmelden.Text = "Anmelden";
            this.btn_Anmelden.UseVisualStyleBackColor = true;
            this.btn_Anmelden.Click += new System.EventHandler(this.btn_Anmelden_Click);
            // 
            // btn_Registrieren
            // 
            this.btn_Registrieren.Location = new System.Drawing.Point(12, 81);
            this.btn_Registrieren.Name = "btn_Registrieren";
            this.btn_Registrieren.Size = new System.Drawing.Size(145, 35);
            this.btn_Registrieren.TabIndex = 1;
            this.btn_Registrieren.Text = "Registrieren";
            this.btn_Registrieren.UseVisualStyleBackColor = true;
            this.btn_Registrieren.Click += new System.EventHandler(this.btn_Registrieren_Click);
            // 
            // lbl_Benutzername
            // 
            this.lbl_Benutzername.AutoSize = true;
            this.lbl_Benutzername.Location = new System.Drawing.Point(12, 15);
            this.lbl_Benutzername.Name = "lbl_Benutzername";
            this.lbl_Benutzername.Size = new System.Drawing.Size(75, 13);
            this.lbl_Benutzername.TabIndex = 2;
            this.lbl_Benutzername.Text = "Benutzername";
            // 
            // lbl_passwort
            // 
            this.lbl_passwort.AutoSize = true;
            this.lbl_passwort.Location = new System.Drawing.Point(37, 41);
            this.lbl_passwort.Name = "lbl_passwort";
            this.lbl_passwort.Size = new System.Drawing.Size(50, 13);
            this.lbl_passwort.TabIndex = 3;
            this.lbl_passwort.Text = "Passwort";
            // 
            // txt_Benutzername
            // 
            this.txt_Benutzername.Location = new System.Drawing.Point(134, 12);
            this.txt_Benutzername.Name = "txt_Benutzername";
            this.txt_Benutzername.Size = new System.Drawing.Size(173, 20);
            this.txt_Benutzername.TabIndex = 4;
            // 
            // txt_Passwort
            // 
            this.txt_Passwort.Location = new System.Drawing.Point(134, 38);
            this.txt_Passwort.Name = "txt_Passwort";
            this.txt_Passwort.Size = new System.Drawing.Size(173, 20);
            this.txt_Passwort.TabIndex = 5;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 128);
            this.Controls.Add(this.txt_Passwort);
            this.Controls.Add(this.txt_Benutzername);
            this.Controls.Add(this.lbl_passwort);
            this.Controls.Add(this.lbl_Benutzername);
            this.Controls.Add(this.btn_Registrieren);
            this.Controls.Add(this.btn_Anmelden);
            this.Name = "frm_login";
            this.Text = "Log-In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Anmelden;
        private System.Windows.Forms.Button btn_Registrieren;
        private System.Windows.Forms.Label lbl_Benutzername;
        private System.Windows.Forms.Label lbl_passwort;
        private System.Windows.Forms.TextBox txt_Benutzername;
        private System.Windows.Forms.TextBox txt_Passwort;
    }
}

