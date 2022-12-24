using System;
using System.Windows.Forms;
using System.Data;

namespace Cyrsach
{
    public partial class AdminReadForm : Form
    {
        public static DataTable bufferTable;
        public AdminReadForm()
        {
            InitializeComponent();
        }


        private void AdminReadForm_Load(object sender, EventArgs e)
        {
            
            this.клиентыTableAdapter2.Fill(this.cyrsachDataSet6.Клиенты);
            
            this.клиентыTableAdapter1.Fill(this.cyrsachDataSet9.Клиенты);
            
            this.клиентыTableAdapter.Fill(this.cyrsachDataSet3.Клиенты);
            
            this.транзакции_фамилииTableAdapter.Fill(this.cyrsachDataSet2.Транзакции_фамилии);
            
            this.товари_категорииTableAdapter.Fill(this.cyrsachDataSet1.Товари_категории);
            
            this.сотрудники_должностиTableAdapter.Fill(this.cyrsachDataSet.Сотрудники_должности);

        }
        private void Change_Click(object sender, EventArgs e)
        {
            if (AdmincomboBox.Text != "")
            {
                switch (AdmincomboBox.SelectedIndex)
                {
                    case 0:
                        Worker_Form worker_Form = new Worker_Form();
                        worker_Form.Show();
                        break;
                    case 1:
                        Item_Form item_Form = new Item_Form();
                        item_Form.Show();
                        break;
                    case 2:
                        Tranzak_Form tranzak_Form = new Tranzak_Form();
                        tranzak_Form.Show();
                        break;
                    case 3:
                        Customer_Form customer_Form = new Customer_Form();
                        customer_Form.Show();
                        break;
                }
            }
            else MessageBox.Show("Выберите значение в списке в низу панели", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void UpDatebutton_Click(object sender, EventArgs e)
        {
            this.клиентыTableAdapter2.Fill(this.cyrsachDataSet6.Клиенты);

            this.клиентыTableAdapter1.Fill(this.cyrsachDataSet9.Клиенты);

            this.клиентыTableAdapter.Fill(this.cyrsachDataSet3.Клиенты);

            this.транзакции_фамилииTableAdapter.Fill(this.cyrsachDataSet2.Транзакции_фамилии);

            this.товари_категорииTableAdapter.Fill(this.cyrsachDataSet1.Товари_категории);

            this.сотрудники_должностиTableAdapter.Fill(this.cyrsachDataSet.Сотрудники_должности);
        }


        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTabelsFilter_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void Insert(object sender, EventArgs e)
        {
            if (AdmincomboBox.Text != "")
            {
                switch (AdmincomboBox.SelectedIndex)
                {
                    case 0:
                        Worker_Form worker_Form = new Worker_Form();
                        worker_Form.Show();
                        break;
                    case 1:
                        Item_Form item_Form = new Item_Form();
                        item_Form.Show();
                        break;
                    case 2:
                        Tranzak_Form tranzak_Form = new Tranzak_Form();
                        tranzak_Form.Show();
                        break;
                    case 3:
                        Customer_Form customer_Form = new Customer_Form();
                        customer_Form.Show();
                        break;
                }
            }
            else MessageBox.Show("Выберите значение в списке в низу панели", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
