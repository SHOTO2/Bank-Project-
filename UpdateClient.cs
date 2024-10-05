using Bank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project
{
    public partial class UpdateClient : Form
    {
        public Client cli;
        public UpdateClient(Client client)
        {
            cli = client;
            InitializeComponent();
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            txFirst1.Text = cli.FirstName;
            txLast1.Text = cli.LastName;
            txEmail1.Text = cli.Email;
            txPhone1.Text = cli.Phone;
            txPin1.Text = cli.PinCode.ToString();
            txSalary1.Text = cli.Salary.ToString();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            cli.FirstName = txFirst1.Text;
            cli.LastName = txLast1.Text;
            cli.Email = txEmail1.Text;
            cli.Phone = txPhone1.Text;
            cli.PinCode = Convert.ToInt32(txPin1.Text);
            cli.Salary = Convert.ToDouble(txSalary1.Text);
            Client.UpdateClient(cli);
            this.Close();
        }
    }
}
