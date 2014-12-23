using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyonu
{
    public partial class musteriKayit : Form
    {
        public musteriKayit()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label label1 = new Label();
        }


        // Veritabanına Kaydetme işlemleri
        private void button6_Click(object sender, EventArgs e)
        {

        }

        Form1 Form1;
        private void button7_Click(object sender, EventArgs e)
        {
            Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        public void TabPageRemov() {
            tabControl1.Controls.Remove(tabPage1);
            tabControl1.Controls.Remove(tabPage2);
            tabControl1.Controls.Remove(tabPage3);
            tabControl1.Controls.Remove(tabPage4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox5.Items[0].ToString() == "1")
            {
                TabPageRemov();
                tabControl1.Controls.Add(tabPage1);
            }
            else if (comboBox5.Items[1].ToString() == "2")
            {
                TabPageRemov();
                tabControl1.Controls.Add(tabPage1);
                tabControl1.Controls.Add(tabPage2);
            }
            else if (comboBox5.Items[2].ToString() == "3")
            {
                TabPageRemov();
                tabControl1.Controls.Add(tabPage1);
                tabControl1.Controls.Add(tabPage2);
                tabControl1.Controls.Add(tabPage3);
            }
            else if (comboBox5.Items[3].ToString() == "4")
            {
                TabPageRemov();
                tabControl1.Controls.Add(tabPage1);
                tabControl1.Controls.Add(tabPage2);
                tabControl1.Controls.Add(tabPage3);
                tabControl1.Controls.Add(tabPage4);
            }
        }

        private void musteriKayit_Load(object sender, EventArgs e)
        {
            //Form Load
            TabPageRemov();
        }

        
    }
}
