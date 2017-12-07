namespace Pro_Feed
{
    partial class frm_registrieren
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
            this.lbl_Benutzername = new System.Windows.Forms.Label();
            this.lbl_Passwort = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_PasswortBestaetigen = new System.Windows.Forms.Label();
            this.txt_Benutzername = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Passwort = new System.Windows.Forms.TextBox();
            this.txt_PasswortBestaetigen = new System.Windows.Forms.TextBox();
            this.btn_Anmelden = new System.Windows.Forms.Button();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Benutzername
            // 
            this.lbl_Benutzername.AutoSize = true;
            this.lbl_Benutzername.Location = new System.Drawing.Point(39, 15);
            this.lbl_Benutzername.Name = "lbl_Benutzername";
            this.lbl_Benutzername.Size = new System.Drawing.Size(75, 13);
            this.lbl_Benutzername.TabIndex = 0;
            this.lbl_Benutzername.Text = "Benutzername";
            // 
            // lbl_Passwort
            // 
            this.lbl_Passwort.AutoSize = true;
            this.lbl_Passwort.Location = new System.Drawing.Point(64, 67);
            this.lbl_Passwort.Name = "lbl_Passwort";
            this.lbl_Passwort.Size = new System.Drawing.Size(50, 13);
            this.lbl_Passwort.TabIndex = 1;
            this.lbl_Passwort.Text = "Passwort";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(78, 41);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(36, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-Mail";
            // 
            // lbl_PasswortBestaetigen
            // 
            this.lbl_PasswortBestaetigen.AutoSize = true;
            this.lbl_PasswortBestaetigen.Location = new System.Drawing.Point(12, 93);
            this.lbl_PasswortBestaetigen.Name = "lbl_PasswortBestaetigen";
            this.lbl_PasswortBestaetigen.Size = new System.Drawing.Size(102, 13);
            this.lbl_PasswortBestaetigen.TabIndex = 3;
            this.lbl_PasswortBestaetigen.Text = "Passwort bestätigen";
            // 
            // txt_Benutzername
            // 
            this.txt_Benutzername.Location = new System.Drawing.Point(136, 12);
            this.txt_Benutzername.Name = "txt_Benutzername";
            this.txt_Benutzername.Size = new System.Drawing.Size(176, 20);
            this.txt_Benutzername.TabIndex = 4;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(136, 38);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(176, 20);
            this.txt_Email.TabIndex = 5;
            // 
            // txt_Passwort
            // 
            this.txt_Passwort.Location = new System.Drawing.Point(136, 64);
            this.txt_Passwort.Name = "txt_Passwort";
            this.txt_Passwort.Size = new System.Drawing.Size(176, 20);
            this.txt_Passwort.TabIndex = 6;
            this.txt_Passwort.UseSystemPasswordChar = true;
            // 
            // txt_PasswortBestaetigen
            // 
            this.txt_PasswortBestaetigen.Location = new System.Drawing.Point(136, 90);
            this.txt_PasswortBestaetigen.Name = "txt_PasswortBestaetigen";
            this.txt_PasswortBestaetigen.Size = new System.Drawing.Size(176, 20);
            this.txt_PasswortBestaetigen.TabIndex = 7;
            this.txt_PasswortBestaetigen.UseSystemPasswordChar = true;
            // 
            // btn_Anmelden
            // 
            this.btn_Anmelden.Location = new System.Drawing.Point(167, 125);
            this.btn_Anmelden.Name = "btn_Anmelden";
            this.btn_Anmelden.Size = new System.Drawing.Size(145, 40);
            this.btn_Anmelden.TabIndex = 8;
            this.btn_Anmelden.Text = "Anmelden";
            this.btn_Anmelden.UseVisualStyleBackColor = true;
            this.btn_Anmelden.Click += new System.EventHandler(this.btn_Anmelden_Click);
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(12, 125);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(149, 40);
            this.btn_Abbrechen.TabIndex = 9;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            // 
            // frm_registrieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 176);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_Anmelden);
            this.Controls.Add(this.txt_PasswortBestaetigen);
            this.Controls.Add(this.txt_Passwort);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Benutzername);
            this.Controls.Add(this.lbl_PasswortBestaetigen);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_Passwort);
            this.Controls.Add(this.lbl_Benutzername);
            this.Name = "frm_registrieren";
            this.Text = "Registrieren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Benutzername;
        private System.Windows.Forms.Label lbl_Passwort;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_PasswortBestaetigen;
        private System.Windows.Forms.TextBox txt_Benutzername;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Passwort;
        private System.Windows.Forms.TextBox txt_PasswortBestaetigen;
        private System.Windows.Forms.Button btn_Anmelden;
        private System.Windows.Forms.Button btn_Abbrechen;
    }
}