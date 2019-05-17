using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UppgraderingAdressBok.DataControllers;
using UppgraderingAdressBok.UI;

namespace UppgraderingAdressBok.DataContext.DataControllers.Model.UI
{
    public partial class FirstApplicationForm : Form
    {
        public FirstApplicationForm()
        {
            InitializeComponent();
        }

        private void adressDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void registreraNyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistreraNy reg = new RegistreraNy();
            reg.Show();
        }

        private void FirstApplicationForm_Load(object sender, EventArgs e)
        { }

        private void sökningarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SökOlikaVärden sök = new SökOlikaVärden();
            sök.Show();
        }

        private void uppdateraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UppdateraAdress adress = new UppdateraAdress();
            adress.Show();
        }

        private void läggTillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LäggTillAdress nyadress = new LäggTillAdress();
            nyadress.Show();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void taBortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaBortAdress taBort = new TaBortAdress();
            taBort.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Struktur.SökAdress(gatunamnTextBox.Text);
          //  adressDataGridView.DataSource = 
        }
    }
}
