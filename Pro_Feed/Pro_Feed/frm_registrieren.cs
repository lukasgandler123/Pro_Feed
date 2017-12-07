using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
                    if(!txt_Benutzername.Text.ToString().Equals(""))
                    {
                        Hash h = new Hash();
                        string passwort = h.HashPassword(txt_Passwort.Text.ToString(), 1000);
                        SqlConnection con = new SqlConnection("server = (localdb)\\MSSQLLocalDB; Integrated Security = sspi; Database = Master");
                        SqlCommand use = new SqlCommand("USE Pro_Feed", con);
                        SqlCommand insert = new SqlCommand("INSERT INTO t_Benutzer (Username, Passwort, Email) " +
                            "VALUES ('" + txt_Benutzername.Text.ToString() + "', '" + passwort + "', '" + txt_Email.Text.ToString() + "');", con);

                        try
                        {
                            con.Open();
                            use.ExecuteNonQuery();
                            insert.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                        MessageBox.Show("Benutzer " + txt_Benutzername.Text.ToString() + " wurde erfolgreich angelegt!");
                    }
                    else
                    {
                        MessageBox.Show("Geben Sie einen gültigen Benutzernamen ein!");
                    }
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
