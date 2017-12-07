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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_Anmelden_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = (localdb)\\MSSQLLocalDB; Integrated Security = sspi; Database = Master");
            SqlCommand use = new SqlCommand("USE Pro_Feed;", con);
            SqlCommand select = new SqlCommand("SELECT Passwort FROM t_Benutzer WHERE Username = '" + txt_Benutzername.Text.ToString() + "';", con);

            Hash h = new Hash();

            try
            {
                con.Open();
                use.ExecuteNonQuery();
                SqlDataReader reader = select.ExecuteReader();
                while(reader.Read())
                {
                    if(h.Verify(txt_Passwort.Text.ToString(), reader[0].ToString()))
                    {
                        MessageBox.Show("Anmeldung erfolgreich!");
                    }
                    else
                    {
                        MessageBox.Show("Benutzer konnte nicht angemeldet werden. Prüfen Sie Ihren Benutzernamen oder Ihr Passwort.");
                    }
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
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
