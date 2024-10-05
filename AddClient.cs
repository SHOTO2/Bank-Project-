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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank_Project
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void IsAccountNumberHereOrEmpty(object sender, CancelEventArgs e)
        {
            if (Client.IsAccountHere(txAcc.Text.Trim()))
            {
                e.Cancel = true;
                txAcc.Focus();
                errorProvider1.SetError(txAcc, "The Account Number Is Already Here");
            }
            else if (string.IsNullOrWhiteSpace(txAcc.Text))
            {
                e.Cancel = true;
                txAcc.Focus();
                errorProvider1.SetError(txAcc, "Requird");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txAcc, "");
            }
        }

        private void txFirst_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txFirst.Text))
            {
                e.Cancel = true;
                txFirst.Focus();
                errorProvider1.SetError(txFirst, "Requird");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txFirst, "");
            }
        }

        private void txPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txPhone.Text))
            {
                e.Cancel = true;
                txPhone.Focus();
                errorProvider1.SetError(txPhone, "Requird");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txPhone, "");
            }
        }

        private void txLast_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txLast.Text))
            {
                e.Cancel = true;
                txLast.Focus();
                errorProvider1.SetError(txLast, "Requird");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txLast, "");
            }
        }

        private void txEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txEmail.Text))
            {
                e.Cancel = true;
                txEmail.Focus();
                errorProvider1.SetError(txEmail, "Requird");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txEmail, "");
            }
        }

        private void txSalary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txSalary.Text))
            {
                e.Cancel = true;
                txSalary.Focus();
                errorProvider1.SetError(txSalary, "Requird");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txSalary, "");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string RecourdLine;
            string Seperetor = "#//#";
            RecourdLine = txFirst.Text.ToString() + Seperetor;
            RecourdLine+= txLast.Text.ToString() + Seperetor;
            RecourdLine+= txEmail.Text.ToString() + Seperetor;
            RecourdLine+= txPhone.Text.ToString() + Seperetor;
            RecourdLine+= txAcc.Text.ToString() + Seperetor;
            RecourdLine+= txPin.Text.ToString() + Seperetor;
            RecourdLine+= txSalary.Text.ToString() ;
            Client.AddClient(RecourdLine);
            this.Close();
        }
    }
}
