using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            pct.Left = pct.Left + 20;
            if (pct.Left + pct.Width + 20 > this.ClientSize.Width)
            {
                tmr.Enabled = false;
            }
            else
            {
                pct.Left += 20;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Старт")
            {
                btnStart.Text = "Стоп";
                tmr.Enabled = true;
                tmr.Interval = 50;
            }
            else
            {
                btnStart.Text = "Cтарт";
                tmr.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
