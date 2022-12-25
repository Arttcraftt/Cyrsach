//форма добавления транзакций
using System;
using System.Windows.Forms;

namespace Cyrsach
{
    public partial class Tranzak_Form : Form
    {
        Query runner;
        Query reader;

        public Tranzak_Form()
        {
            InitializeComponent();
            runner = new Query(ConnectionString.ConnStr);
            reader = new Query(ConnectionString.ConnStr);
        }

        private void Tranzak_Form_Load(object sender, EventArgs e)
        {
            this.товарыTableAdapter.Fill(this.cyrsachDataSet7.Товары);
            this.клиентыTableAdapter.Fill(this.cyrsachDataSet6.Клиенты);
            this.сотрудникиTableAdapter.FillBy(this.cyrsachDataSet5.Сотрудники);
        }

        private void Enterer_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "Новый") {
                if (comboBoxWorker.Enabled == true) {
                    runner.Bying(runner.Name_To_ID_Datas(comboBoxWorker.Text, "Сотрудники"), runner.Name_To_ID_Datas(comboBoxCustomer.Text, "Клиенты"), runner.Name_To_ID_Datas(comboBoxItem.Text, "Товары"));
                }
                else {
                    runner.Bying(runner.Name_To_ID_Datas(labelWorker.Text, "Сотрудники"), runner.Name_To_ID_Datas(comboBoxCustomer.Text, "Клиенты"), runner.Name_To_ID_Datas(comboBoxItem.Text, "Товары"));
                }
            }
            else {
                runner.Update(int.Parse(labelID.Text), runner.Name_To_ID_Datas(labelWorker.Text, "Сотрудники"), runner.Name_To_ID_Datas(comboBoxCustomer.Text, "Клиенты"), runner.Name_To_ID_Datas(comboBoxItem.Text, "Товары"));
            }
            this.Close();
        }
    }
}