using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class ClientListForm : Form
    {
        BindingList<Client> clientList;
        public ClientListForm()
        {
            InitializeComponent();
        }

        private async void ClientListForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<Client> clients = await ClientSql.GetClientList();
                clientList = new BindingList<Client>(clients);
                dataGridView1.DataSource = clientList;
            }
            catch
            {
                MessageBox.Show("Įvyko klaida užkraunant klientų duomenys");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}