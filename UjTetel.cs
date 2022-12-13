using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LapKisIsk10COP2000.Properties;
using Microsoft.Data.SqlClient;

namespace LapKisIsk10COP2000
{
    public partial class UjTetel : Form
    {
        int _selectedID=0;
        public UjTetel()
        {
            InitializeComponent();
        }

        private void UjTetel_Load(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();
            SqlCommand cmd3 = new SqlCommand(
               cmdText: "SELECT nev, sorszam FROM NAPLO ;",
               connection: conn
               );
            SqlDataReader read2 = cmd3.ExecuteReader();
            while (read2.Read())
            {
                cbNev.Items.Add(read2[0].ToString());
            }
            cbNev.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLeir.Text))
                MessageBox.Show(
                    icon: MessageBoxIcon.Error,
                    caption: "HIBA!!!!!!",
                    text: "Töltsd ki a Leírást!",
                    buttons: MessageBoxButtons.OK);
            else if (string.IsNullOrEmpty(tbOsszeg.Text))
                MessageBox.Show(
                    icon: MessageBoxIcon.Error,
                    caption: "HIBA!!!!!!",
                    text: "Töltsd ki az összeget!",
                    buttons: MessageBoxButtons.OK);
            else
            {
                _selectedID =cbNev.SelectedIndex;
                using SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();
                SqlCommand cmd = new(
                    cmdText: "UPDATE BANK SET " +
                    $"ki = '{cbNev.Text}', " +
                    $"leiras =  '{tbLeir.Text}'"+
                    $"mikor = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}' " +
                    $"osszeg = {p tbOsszeg.Text}" +
                    $"WHERE ki = '{_selectedID}';",
                    connection: conn);
                SqlDataAdapter adptr = new()
                {
                    UpdateCommand = cmd
                };
                adptr.UpdateCommand.ExecuteNonQuery();
                
            }
        }
    }
}
