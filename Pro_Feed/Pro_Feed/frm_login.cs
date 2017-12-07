using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Pro_Feed
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_Anmelden_Click(object sender, EventArgs e)
        {
            Pro_FeedEntities ent = new Pro_FeedEntities();
            Hash h = new Hash();
            
            // Select the Passwort
            string passwort = ent.t_Benutzer.Where(u => u.Username.Equals(txt_Benutzername.Text.ToString())).Select(u => u.Passwort).ToString();
            if(h.Verify(txt_Passwort.Text.ToString(), passwort))
            {
                MessageBox.Show("Anmeldung erfolgreich!");
            }
        }

        private void btn_Registrieren_Click(object sender, EventArgs e)
        {
            frm_registrieren reg = new frm_registrieren();
            Hide();
            reg.ShowDialog();
            ShowDialog();
        }
    }
}
