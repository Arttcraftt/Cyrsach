//форма добавления работников
using System;
using System.Windows.Forms;

namespace Cyrsach
{
    public partial class Worker_Form : Form
    {
        Query runner;
        Query reader;
        public Worker_Form()
        {
            InitializeComponent();
            runner = new Query(ConnectionString.ConnStr);
            reader = new Query(ConnectionString.ConnStr);
        }

        private void Worker_Form_Load(object sender, EventArgs e)
        {
            this.должностиTableAdapter.Fill(this.cyrsachDataSet8.Должности);
        }

        private void Enterer_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "Новый") {

            }
            else {
                runner.Add(reader.Name_To_ID_Categories(comboBoxPost.Text, "Должности"), textBoxFamilia.Text, textBoxName.Text, textBoxOtchestvo.Text, textBoxTelephone.Text, textBoxLogin.Text, textBoxPassword.Text);
            }
            this.Close();
        }
    }
}
