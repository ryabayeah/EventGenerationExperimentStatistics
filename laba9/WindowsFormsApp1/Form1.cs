using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double[] aboba = new double[5];

        public Form1()
        {
            InitializeComponent();
            StartB.Enabled = false;
        }

        private void Num5B_Click(object sender, EventArgs e)
        {
            aboba[0] = (double)Num1.Value;
            aboba[1] = (double)Num2.Value;
            aboba[2] = (double)Num3.Value;
            aboba[3] = (double)Num4.Value;
            aboba[4] = 1 - aboba[0] + aboba[1] + aboba[2] + aboba[3];
            if (aboba[4] <= 0)
            {
                return;
            }
            else
            {
                StartB.Enabled = true;
            };
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            Random rand = new Random();

            int[] stats = new int[5];
            var n = (int)Trials.Value;

            for (int i = 0; i<n; i++)
            {
                var q = (double)rand.NextDouble();
                for (int j=0; j<5; j++)
                {
                    q -= aboba[j];
                    if (q <= 0)
                    {
                        stats[j]++;
                        break;
                    }
                }
            }
            for (int i = 0; i<5; i++)
            {
                chart1.Series[0].Points.AddXY(i+1,(float)stats[i]/n);
            }
            
        }
    }
}
