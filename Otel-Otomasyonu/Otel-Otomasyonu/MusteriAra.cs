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

namespace Otel_Otomasyonu
{
    public partial class MusteriAra : Form
    {
        public MusteriAra()
        {
            InitializeComponent();
        }
        
        public SqlConnection Conn;

        public void MusteriGetir()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                SqlCommand komut = new SqlCommand("SELECT * FROM musteriler WHERE tcKimlikNo="+textBox1.Text, Conn);
                SqlDataAdapter tablo = new SqlDataAdapter(komut);
                DataTable veriler = new DataTable();
                tablo.Fill(veriler);
                dataGridView1.DataSource = veriler;
                Conn.Close();
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        public void MusteriGoster()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                SqlCommand komut = new SqlCommand("SELECT * FROM musteriler", Conn);
                SqlDataAdapter tablo = new SqlDataAdapter(komut);
                DataTable veriler = new DataTable();
                tablo.Fill(veriler);
                dataGridView1.DataSource = veriler;
                Conn.Close();
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void MusteriAra_Load(object sender, EventArgs e)
        {
            Conn = new SqlConnection("Data Source=PC\\SA; Initial Catalog=otel; User Id=sa; Password=1234; Integrated Security=true");
            MusteriGoster();
        }
        
        
        
        bosOdalar bosOdalar;
        private void button1_Click(object sender, EventArgs e)
        {
            bosOdalar = new bosOdalar();
            bosOdalar.Show();
            this.Hide();
        }

        doluOdalar doluOdalar;
        private void button2_Click(object sender, EventArgs e)
        {
            doluOdalar = new doluOdalar();
            doluOdalar.Show();
            this.Hide();
        }

        Form1 anaform;
        private void button3_Click(object sender, EventArgs e)
        {
            anaform = new Form1();
            anaform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şaşarım aklı perişanına, heyhat");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        musteriKayit musteriKayit;
        private void button6_Click(object sender, EventArgs e)
        {
            musteriKayit = new musteriKayit();
            musteriKayit.Show();
            this.Hide();
        }

    }
}
