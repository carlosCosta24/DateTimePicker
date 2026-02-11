using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        private int Counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Text + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dd-mmm-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd-mmm-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("mm-ddyyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dd/mm/yy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd,dd-mmm-yyyy") + Environment.NewLine;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.Start.ToShortDateString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.End.ToShortDateString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;
            label2.Text = Counter.ToString();
        }
    }
}
