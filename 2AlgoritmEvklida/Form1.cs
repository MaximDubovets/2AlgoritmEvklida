using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2AlgoritmEvklida
{
    public partial class Form1 : Form
    {
        int r, h, N, NOD, NOK, a, b, c, g;

        private void button1_Click(object sender, EventArgs e)
        {            
            N = (int)dataGridView1.RowCount-1;
            a = Math.Abs(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value));
            b = Math.Abs(Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value));
            h = a * b;
            if (a < b)
            {
                a = b;
                b = h / a;            
            }
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            NOD = a;
            NOK = h / a;
            for (int i = 2; i < N; i++) 
            {              
                a = NOD;               
                b = Math.Abs(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));               
                h = a * b;              
                if (a < b)
                {
                    a = b;
                    b = h / a;
                }               
                while (b != 0)
                {
                    r = a % b;
                    a = b;
                    b = r;
                }               
                NOD = a;               
            }
            for (int i = 2; i < N; i++) 
            {
                c = NOK;
                b = Math.Abs(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));
                g = c * b;
                if (c < b)
                {
                    c = b;
                    b = g / c;

                }
                while (b != 0)
                {
                    r = c % b;
                    c = b;
                    b = r;
                }
                NOK = g / c;
            }
            textBox3.Text = NOD.ToString();
            textBox4.Text = NOK.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
