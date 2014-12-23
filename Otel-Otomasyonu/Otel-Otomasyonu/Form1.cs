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
    public partial class Form1 : Form
    {
        public Form1()
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

        doluOdalar doluOdalar;
        private void button2_Click(object sender, EventArgs e)
        {
            doluOdalar = new doluOdalar();
            doluOdalar.Show();
            this.Hide();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şaşarım aklı perişanına, heyhat");
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
