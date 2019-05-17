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

namespace UppgraderingAdressBok.UI
{
    public partial class LäggTillAdress : Form
    {
        public LäggTillAdress()
        {
            InitializeComponent();
        }

        private void LäggTillAdress_Load(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            Struktur.LäggTillAdress(Convert.ToInt32(personIDTextBox.Text), gatunamnTextBox.Text, postnummerTextBox.Text, postortTextBox.Text);
        }
    }
}
