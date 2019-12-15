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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void klientuSarasasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form clientListForm = new ClientListForm();
            clientListForm.ShowDialog();
        }

        private void importuotiKlientusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Client> importedClients = Json<Client>.JsonToList();

                ClientSql.InsertClients(importedClients);

                ClientSql.SaveChanges();
                MessageBox.Show("Klientų duomenis importuoti sėkmingai");
            }
            catch
            {
                MessageBox.Show("Įvyko klaida importuojant klientų duomenys");
            }
        }

        private async void atnaujintiPastoIndeksusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                List<Client> clients = await ClientSql.GetClientList();
                for (int i = 0; i < clients.Count; i++)
                {
                    string temp_post_code = await PostItAPI.GetPostCode(clients[i].address);
                    int post_code = Int32.Parse(temp_post_code);
                    clients[i].post_code = post_code;
                    ClientSql.UpdateClientsPostCodes(clients[i]);
                }
                ClientSql.SaveChanges();
                MessageBox.Show("Pašto kodai atnaujinti sėkmingai");
            }
            catch
            {
                MessageBox.Show("Įvyko klaida atnaujinant pašto kodus");
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}