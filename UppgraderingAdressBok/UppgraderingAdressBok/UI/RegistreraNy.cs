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
    public partial class RegistreraNy : Form
    {
        public RegistreraNy()
        {
            InitializeComponent();
            ComboItems();
        }

        private void ComboItems()
        {
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
        }

        private void RegistreraNy_Load(object sender, EventArgs e)
        {  }

        private void button1_Click(object sender, EventArgs e)
        {
            Struktur.NyPerson(Convert.ToInt32(comboBox1.Text), förnamnTextBox.Text, efternamnTextBox.Text, gatunamnTextBox.Text, postnummerTextBox.Text,
                postortTextBox.Text, Convert.ToInt32(riktnummerTextBox.Text), telefonnummerTextBox.Text, epostaddressTextBox.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }
    }
}
