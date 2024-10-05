using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank;

namespace Bank_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new ManageClients();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon");
        }
    }
}
