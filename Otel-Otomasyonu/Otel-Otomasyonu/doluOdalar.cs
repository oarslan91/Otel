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
    public partial class doluOdalar : Form
    {
        public doluOdalar()
        {
            InitializeComponent();
        }

        
        
        bosOdalar bosOdalar;
        private void button1_Click(object sender, EventArgs e)
        {
            bosOdalar = new bosOdalar();
            bosOdalar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şaşarım aklı perişanına, heyhat");
        }
        
        Form1 anaform;
        private void button3_Click(object sender, EventArgs e)
        {
            anaform = new Form1();
            anaform.Show();
            this.Hide();
        }

        MusteriAra musteriaraniyor;
        private void button4_Click(object sender, EventArgs e)
        {
            musteriaraniyor = new MusteriAra();
            musteriaraniyor.Show();
            this.Hide();
        }
    }
}
