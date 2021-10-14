using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visualisation v = new Visualisation();
            v.ChtenieInfo(dataGridView1);
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Stolb st = new Stolb();
                st.StolbInform(chart1, dataGridView1);
            }
            if (radioButton1.Checked)
            {
                KRUG kr = new KRUG();
                kr.KrugInfo(chart1, dataGridView1);
            }
            if (radioButton3.Checked)
            {
                GraFik gr = new GraFik();
                gr.GrfInform(chart1, dataGridView1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visualisation v = new Visualisation();
            v.ZapisInfo(dataGridView1);
        }
    }
}
