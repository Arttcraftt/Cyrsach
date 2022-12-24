//форма добавления товаров
using System;
using System.Windows.Forms;

namespace Cyrsach
{
    public partial class Item_Form : Form
    {
        Query runner;
        Query reader;
        public Item_Form()
        {
            InitializeComponent();
            runner = new Query(ConnectionString.ConnStr);
            reader = new Query(ConnectionString.ConnStr);
        }

        private void Item_Form_Load(object sender, EventArgs e)
        {
            this.категории_товаровTableAdapter.Fill(this.cyrsachDataSet4.Категории_товаров);
        }

        private void Enterer_Click(object sender, EventArgs e)
        {
            
            if (labelID.Text != "Новый") {

            }
            else {
                runner.Add(reader.Name_To_ID_Categories(comboBoxCategory.Text, "Категории_товаров"),Int32.Parse(textBoxQuantity.Text), Int32.Parse(textBoxCost.Text),textBoxName.Text);
            }
            this.Close();
        }
    }
}
