using System;
using System.Windows.Forms;
using System.Data;

namespace Cyrsach
{
    public partial class AdminReadForm : Form
    {
        Query bufferer;
        public AdminReadForm()
        {
            InitializeComponent();
            bufferer = new Query(ConnectionString.ConnStr);
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
            DataTable bufferTab = new DataTable();
            if (AdmincomboBox.Text != "")
            {
                int ID;
                switch (AdmincomboBox.SelectedIndex)
                {
                    case 0: //изменение сотрудника
                        Worker_Form worker_Form = new Worker_Form();
                        worker_Form.Text = "Изменить сотрудника";
                         ID = int.Parse(WorkerDataGrid[0, WorkerDataGrid.CurrentRow.Index].Value.ToString());
                        worker_Form.labelID.Text = ID.ToString();
                        bufferTab = bufferer.buffer_return(ID, "Сотрудники");
                        worker_Form.textBoxFamilia.Text = bufferTab.Rows[0][2].ToString();
                        worker_Form.textBoxName.Text = bufferTab.Rows[0][3].ToString();
                        worker_Form.textBoxOtchestvo.Text = bufferTab.Rows[0][4].ToString();
                        worker_Form.textBoxTelephone.Text = bufferTab.Rows[0][5].ToString();
                        worker_Form.textBoxLogin.Text = bufferTab.Rows[0][6].ToString();
                        worker_Form.textBoxPassword.Text = bufferTab.Rows[0][7].ToString();
                        worker_Form.labelPost.Visible = true;
                        worker_Form.labelPost.Text = bufferer.ID_To_Name_Categories(int.Parse(bufferTab.Rows[0][1].ToString()), "Должности");
                        bufferTab.Reset();
                        worker_Form.Show();
                        break;
                    case 1: //изменение товара
                        Item_Form item_Form = new Item_Form();
                        ID = int.Parse(ItemsDataGrid[0, ItemsDataGrid.CurrentRow.Index].Value.ToString());
                        item_Form.labelID.Text = ID.ToString();
                        item_Form.Text = "Изменить товар";
                        bufferTab = bufferer.buffer_return(ID, "Товары");
                        item_Form.textBoxQuantity.Text = bufferTab.Rows[0][2].ToString();
                        item_Form.textBoxCost.Text = bufferTab.Rows[0][3].ToString();
                        item_Form.textBoxName.Text = bufferTab.Rows[0][4].ToString();
                        item_Form.labelCategory.Visible= true;
                        item_Form.labelCategory.Text = bufferer.ID_To_Name_Categories(int.Parse(bufferTab.Rows[0][1].ToString()), "Категории_товаров");
                        bufferTab.Reset();
                        item_Form.Show();
                        break;
                    case 2: //изменение транзакции
                        Tranzak_Form tranzak_Form = new Tranzak_Form();
                        tranzak_Form.Show();
                        break;
                    case 3: //изменение клиента
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
