//форма добавления клиентов
using System;
using System.Windows.Forms;

namespace Cyrsach
{
    public partial class Customer_Form : Form
    {
        Query runner;
        public Customer_Form()
        {
            InitializeComponent();
            runner = new Query(ConnectionString.ConnStr);
        }

        private void Enterer_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "Новый") {

            }
            else {
                runner.Add(textBoxFamilia.Text, textBoxName.Text, textBoxOtchestvo.Text, textBoxTelephone.Text);
            }
            this.Close();
        }
    }
}
