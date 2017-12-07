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
    public partial class frm_registrieren : Form
    {
        public frm_registrieren()
        {
            InitializeComponent();
        }

        private void btn_Anmelden_Click(object sender, EventArgs e)
        {
            Pro_FeedEntities ent = new Pro_FeedEntities();

            // Check passwords
            if(txt_Passwort.Text.ToString().Equals(txt_PasswortBestaetigen.Text.ToString()) && !txt_Passwort.Text.ToString().Equals(""))
            {
                // Check email
                if(txt_Email.Text.ToString().Contains("@"))
                {
                    // Check username
                }
                else
                {
                    MessageBox.Show("Geben Sie eine gültige E-Mailadresse ein!");
                }
            }
            else
            {
                MessageBox.Show("Passwörter stimmen nicht überein!");
            }
        }
    }
}
