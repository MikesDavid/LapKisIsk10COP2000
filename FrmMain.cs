using Microsoft.Data.SqlClient;
using LapKisIsk10COP2000.Properties;

namespace LapKisIsk10COP2000
{
    public partial class FrmMain : Form
    {
        private int _selectedID = -1;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void GetAllData()
        {
            _selectedID = -1;
            dgvOsszesito.Rows.Clear();

            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                cmdText: "SELECT nev, osszeg FROM NAPLO, BANK WHERE ki = sorszam;",
                connection: conn
                );
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgvOsszesito.Rows.Add(
                    reader[0],
                    reader[1]);
            }
            dgvOsszesito.ClearSelection();
            reader.Close();

            SqlCommand cmd2 = new SqlCommand(
                cmdText: "SELECT osszeg FROM BANK WHERE leiras = 'fenymasolas';",
                connection: conn
                );
            int ertek = 0;
            SqlDataReader read = cmd2.ExecuteReader();
            while (read.Read())
            {
                ertek += read.GetInt32(0);
            }
            tbFenymasolasraOsszesen.Text = ertek.ToString();
            read.Close();

            SqlCommand cmd3 = new SqlCommand(
                cmdText: "SELECT nev, sorszam FROM NAPLO ;",
                connection: conn
                );
            SqlDataReader read2 = cmd3.ExecuteReader();
            while (read2.Read())
            {
                cbDiakok.Items.Add(read2[0].ToString());
            }
        }
        private void FrmMain_Load(object sender, EventArgs e) => GetAllData();

        private void cbDiakok_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedID = cbDiakok.SelectedIndex;
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                cmdText: $"SELECT mikor, leiras, osszeg FROM NAPLO, BANK WHERE ki = {_selectedID};",
                connection: conn
                );
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rtbDiakTranzakcioi.Clear();
                rtbDiakTranzakcioi.AppendText(Environment.NewLine + reader[0].ToString());
                rtbDiakTranzakcioi.AppendText(Environment.NewLine + reader[1].ToString());
                rtbDiakTranzakcioi.AppendText(Environment.NewLine + reader[2].ToString());
            }

        }

        private void újTételToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = new UjTetel().ShowDialog();
        }

        private void számlaKimutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = new Szamla().ShowDialog();
        }
    }

}