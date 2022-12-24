namespace Cyrsach
{
    partial class Tranzak_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Enterer = new System.Windows.Forms.Button();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyrsachDataSet5 = new Cyrsach.cyrsachDataSet5();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyrsachDataSet6 = new Cyrsach.cyrsachDataSet6();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyrsachDataSet7 = new Cyrsach.cyrsachDataSet7();
            this.сотрудникиTableAdapter = new Cyrsach.cyrsachDataSet5TableAdapters.СотрудникиTableAdapter();
            this.клиентыTableAdapter = new Cyrsach.cyrsachDataSet6TableAdapters.КлиентыTableAdapter();
            this.товарыTableAdapter = new Cyrsach.cyrsachDataSet7TableAdapters.ТоварыTableAdapter();
            this.cyrsachDataSet51 = new Cyrsach.cyrsachDataSet5();
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelWorker = new System.Windows.Forms.Label();
            this.labelCustom = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(48, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(63, 21);
            this.labelID.TabIndex = 33;
            this.labelID.Text = "Новый";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "ID:";
            // 
            // Enterer
            // 
            this.Enterer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Enterer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enterer.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enterer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enterer.Location = new System.Drawing.Point(16, 215);
            this.Enterer.Name = "Enterer";
            this.Enterer.Size = new System.Drawing.Size(239, 30);
            this.Enterer.TabIndex = 31;
            this.Enterer.Text = "Потвердить";
            this.Enterer.UseVisualStyleBackColor = false;
            this.Enterer.Click += new System.EventHandler(this.Enterer_Click);
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.DataSource = this.сотрудникиBindingSource;
            this.comboBoxWorker.DisplayMember = "Фамилия";
            this.comboBoxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(16, 74);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(239, 28);
            this.comboBoxWorker.TabIndex = 30;
            this.comboBoxWorker.ValueMember = "Фамилия";
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.cyrsachDataSet5;
            // 
            // cyrsachDataSet5
            // 
            this.cyrsachDataSet5.DataSetName = "cyrsachDataSet5";
            this.cyrsachDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Клиент:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Товар:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Сотрудник: ";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.DataSource = this.клиентыBindingSource;
            this.comboBoxCustomer.DisplayMember = "Фамилия";
            this.comboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(16, 126);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(239, 28);
            this.comboBoxCustomer.TabIndex = 34;
            this.comboBoxCustomer.ValueMember = "ID";
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.cyrsachDataSet6;
            // 
            // cyrsachDataSet6
            // 
            this.cyrsachDataSet6.DataSetName = "cyrsachDataSet6";
            this.cyrsachDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.DataSource = this.товарыBindingSource;
            this.comboBoxItem.DisplayMember = "Название";
            this.comboBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(16, 181);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(239, 28);
            this.comboBoxItem.TabIndex = 35;
            this.comboBoxItem.ValueMember = "ID";
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.cyrsachDataSet7;
            // 
            // cyrsachDataSet7
            // 
            this.cyrsachDataSet7.DataSetName = "cyrsachDataSet7";
            this.cyrsachDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // cyrsachDataSet51
            // 
            this.cyrsachDataSet51.DataSetName = "cyrsachDataSet5";
            this.cyrsachDataSet51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this.cyrsachDataSet5;
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorker.Location = new System.Drawing.Point(107, 50);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(89, 21);
            this.labelWorker.TabIndex = 36;
            this.labelWorker.Text = "сотрудник";
            this.labelWorker.Visible = false;
            // 
            // labelCustom
            // 
            this.labelCustom.AutoSize = true;
            this.labelCustom.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustom.Location = new System.Drawing.Point(76, 102);
            this.labelCustom.Name = "labelCustom";
            this.labelCustom.Size = new System.Drawing.Size(62, 21);
            this.labelCustom.TabIndex = 37;
            this.labelCustom.Text = "клиент";
            this.labelCustom.Visible = false;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItem.Location = new System.Drawing.Point(65, 157);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(54, 21);
            this.labelItem.TabIndex = 38;
            this.labelItem.Text = "товар";
            this.labelItem.Visible = false;
            // 
            // Tranzak_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(269, 256);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelCustom);
            this.Controls.Add(this.labelWorker);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Enterer);
            this.Controls.Add(this.comboBoxWorker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Tranzak_Form";
            this.Text = "Добавить транзакцию";
            this.Load += new System.EventHandler(this.Tranzak_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Enterer;
        public System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxCustomer;
        public System.Windows.Forms.ComboBox comboBoxItem;
        private cyrsachDataSet5 cyrsachDataSet5;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private cyrsachDataSet5TableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private cyrsachDataSet6 cyrsachDataSet6;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private cyrsachDataSet6TableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private cyrsachDataSet7 cyrsachDataSet7;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private cyrsachDataSet7TableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private cyrsachDataSet5 cyrsachDataSet51;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        public System.Windows.Forms.Label labelWorker;
        public System.Windows.Forms.Label labelCustom;
        public System.Windows.Forms.Label labelItem;
    }
}