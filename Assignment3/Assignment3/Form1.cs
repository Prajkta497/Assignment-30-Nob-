using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public int Netbalance { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void DepositM()
        {
            int no = Convert.ToInt32(label3.Text);
            int no2 =Convert.ToInt32( textBox2.Text);
            Netbalance = no + no2;
            listBox1.Items.Add(Netbalance);
            Thread.Sleep(500);
        }

        public void WithdrawM()
        {
            int no = Convert.ToInt32(label3.Text);
            int no2 = Convert.ToInt32(textBox2.Text);
            Netbalance = no - no2;
            listBox2.Items.Add(Netbalance);
            Thread.Sleep(500);
        }

        Thread t1, t2;
        private void button1_Click(object sender, EventArgs e)
        {
            //ListBox.CheckForIllegalCrossThreadCalls = false;
            //TextBox.CheckForIllegalCrossThreadCalls = false;
            //Button.CheckForIllegalCrossThreadCalls = false;
            t1 = new Thread(DepositM);
            t2 = new Thread(WithdrawM);

            t1.Start();
            t2.Start();
        }
    }
}
