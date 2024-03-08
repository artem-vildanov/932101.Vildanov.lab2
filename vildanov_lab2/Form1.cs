using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vildanov_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Dollar;
        double Euro;
        double kDollar = 0.05;
        double kEuro = 0.07;
        bool StartStop = true;
        Random rnd = new Random();
        int i = 0;

        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            Dollar = (double)EdDollar.Value;
            Euro = (double)EdEuro.Value;

            if (StartStop)
            {
                timer1.Start();
                StartStop = false;
            }
            else
            {
                timer1.Stop();
                StartStop = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dollar = Dollar * (1 + kDollar * (rnd.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(i, Dollar);
            Euro = Euro * (1 + kEuro * (rnd.NextDouble() - 0.5));
            chart1.Series[1].Points.AddXY(i, Euro);
            i++;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }
    }
}
