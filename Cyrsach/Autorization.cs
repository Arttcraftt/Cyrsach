//форма авторизации
using System;
using System.Windows.Forms;

namespace Cyrsach
{
    public partial class Autorization : Form
    {
        Query runner;

        public Autorization()
        {
            InitializeComponent();
            runner = new Query(ConnectionString.ConnStr);
        }

        private void Enterer_Click(object sender, EventArgs e)
        {
            AdminReadForm adminReadForm = new AdminReadForm();
            ByingForm byingForm = new ByingForm();
            switch (runner.Autoriza(textBoxLogin.Text, textBoxPassword.Text))
                {
                    case 1:
                        adminReadForm.AdminPanel.Visible = false;
                        adminReadForm.TranzakDataGrid.ReadOnly = true;
                        adminReadForm.CustomerDataGrid.ReadOnly = true;
                        adminReadForm.WorkerDataGrid.ReadOnly = true;
                        adminReadForm.ItemsDataGrid.ReadOnly = true;
                        adminReadForm.labelFLnames.Text = runner.Fam_Name;
                        adminReadForm.Show();
                        this.Hide();
                        break;
                    case 0:
                        MessageBox.Show("Не верно введён логин или пароль", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 2:
                        adminReadForm.labelFLnames.Text = runner.Fam_Name;
                        adminReadForm.Show();
                        this.Hide();
                        break; 
                    case 3:
                        byingForm.Familia = runner.Familia;
                        byingForm.labelFLnames.Text = runner.Fam_Name;
                        byingForm.Show();
                        this.Hide();
                        break;
            }
        } 
    }
}