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
    public partial class bosOdalar : Form
    {
        public bosOdalar()
        {
            InitializeComponent();
        }



        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şaşarım aklı perişanına, heyhat");
        }

        doluOdalar doluOdalarForm;
        private void button2_Click(object sender, EventArgs e)
        {
            doluOdalarForm = new doluOdalar();
            doluOdalarForm.Show();
            this.Hide();
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
