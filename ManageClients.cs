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
    public partial class ManageClients : Form
    {
        public Client clinetUpdate;
        public ManageClients()
        {
            InitializeComponent();
        }

        private void ManageClients_Load(object sender, EventArgs e)
        {
            List<Client> ListClients = Client.ListClient();
            foreach(Client Client in ListClients)
            {
                ListViewItem op = new ListViewItem(Client.FirstName.ToString());
                op.SubItems.Add(Client.LastName);
                op.SubItems.Add(Client.Email);
                op.SubItems.Add(Client.Phone);
                op.SubItems.Add(Client.AccountNumber);
                op.SubItems.Add(Client.PinCode.ToString());
                op.SubItems.Add(Client.Salary.ToString());
                listView1.Items.Add(op);
            }
        }


        private  void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new AddClient();
            frm.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clinetUpdate.FirstName = listView1.SelectedItems[0].SubItems[0].Text;
            //clinetUpdate.LastName = listView1.SelectedItems[0].SubItems[1].Text;
            //clinetUpdate.Email = listView1.SelectedItems[0].SubItems[2].Text;
            //clinetUpdate.Phone = listView1.SelectedItems[0].SubItems[3].Text;
            //clinetUpdate.AccountNumber = listView1.SelectedItems[0].SubItems[4].Text;
            //clinetUpdate.PinCode = Convert.ToInt32(listView1.SelectedItems[0].SubItems[5].Text);
            //clinetUpdate.Salary = Convert.ToDouble(listView1.SelectedItems[0].SubItems[6].Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();
                Client.Delete(clinetUpdate.AccountNumber);
                this.Close();
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                Client client = Client.FindClient(listView1.SelectedItems[0].SubItems[4].Text);
                clinetUpdate = client;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Client client = Client.FindClient(listView1.SelectedItems[0].SubItems[4].Text);
                clinetUpdate = client;
                this.Close();
                Form frm = new UpdateClient(clinetUpdate);
                frm.ShowDialog();
            }
        }
    }
}
