using System;
using System.Windows.Forms;

namespace Cyrsach
{
    public partial class ByingForm : Form
    {
        public ByingForm()
        {
            InitializeComponent();
        }
        public string Familia { get; set; }
        private void ByingForm_Load(object sender, EventArgs e)
        {
           
            this.товари_категорииTableAdapter.Fill(this.cyrsachDataSet1.Товари_категории);
            
            this.транзакции_фамилииTableAdapter.Fill(this.cyrsachDataSet2.Транзакции_фамилии);
            
            this.клиентыTableAdapter.Fill(this.cyrsachDataSet3.Клиенты);

        }

        private void Selling_Click(object sender, EventArgs e)
        {
            Tranzak_Form tranzak_Form = new Tranzak_Form();
            tranzak_Form.comboBoxWorker.DataBindings.Clear();
            tranzak_Form.labelFamilia.Text = Familia;
            tranzak_Form.labelFamilia.Visible = true;
            tranzak_Form.comboBoxWorker.Visible = false;
            tranzak_Form.comboBoxWorker.Enabled = false;
            tranzak_Form.Show();
        }

        private void UpDatebutton_Click(object sender, EventArgs e)
        {
            this.товари_категорииTableAdapter.Fill(this.cyrsachDataSet1.Товари_категории);

            this.транзакции_фамилииTableAdapter.Fill(this.cyrsachDataSet2.Транзакции_фамилии);

            this.клиентыTableAdapter.Fill(this.cyrsachDataSet3.Клиенты);
        }

        private void comboBoxTabelsFilter_SelectionChangeCommitted  (object sender, EventArgs e)
        {

        }
    }
}
