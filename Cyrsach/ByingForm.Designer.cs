namespace Cyrsach
{
    partial class ByingForm
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
            this.labelFLnames = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TranzakDataGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.транзакциифамилииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyrsachDataSet2 = new Cyrsach.cyrsachDataSet2();
            this.cyrsachDataSet3 = new Cyrsach.cyrsachDataSet3();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new Cyrsach.cyrsachDataSet3TableAdapters.КлиентыTableAdapter();
            this.транзакции_фамилииTableAdapter = new Cyrsach.cyrsachDataSet2TableAdapters.Транзакции_фамилииTableAdapter();
            this.ItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарикатегорииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyrsachDataSet1 = new Cyrsach.cyrsachDataSet1();
            this.товари_категорииTableAdapter = new Cyrsach.cyrsachDataSet1TableAdapters.Товари_категорииTableAdapter();
            this.Selling = new System.Windows.Forms.Button();
            this.UpDatebutton = new System.Windows.Forms.Button();
            this.CustomerDataGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TranzakDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.транзакциифамилииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарикатегорииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFLnames
            // 
            this.labelFLnames.AutoSize = true;
            this.labelFLnames.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFLnames.Location = new System.Drawing.Point(935, 9);
            this.labelFLnames.Name = "labelFLnames";
            this.labelFLnames.Size = new System.Drawing.Size(118, 21);
            this.labelFLnames.TabIndex = 15;
            this.labelFLnames.Text = "имя/фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(769, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Добро пожаловать:";
            // 
            // TranzakDataGrid
            // 
            this.TranzakDataGrid.AutoGenerateColumns = false;
            this.TranzakDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TranzakDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.сотрудникDataGridViewTextBoxColumn,
            this.клиентDataGridViewTextBoxColumn,
            this.товарDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn});
            this.TranzakDataGrid.DataSource = this.транзакциифамилииBindingSource;
            this.TranzakDataGrid.Location = new System.Drawing.Point(583, 33);
            this.TranzakDataGrid.Name = "TranzakDataGrid";
            this.TranzakDataGrid.Size = new System.Drawing.Size(563, 220);
            this.TranzakDataGrid.TabIndex = 13;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // сотрудникDataGridViewTextBoxColumn
            // 
            this.сотрудникDataGridViewTextBoxColumn.DataPropertyName = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.Name = "сотрудникDataGridViewTextBoxColumn";
            // 
            // клиентDataGridViewTextBoxColumn
            // 
            this.клиентDataGridViewTextBoxColumn.DataPropertyName = "Клиент";
            this.клиентDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.клиентDataGridViewTextBoxColumn.Name = "клиентDataGridViewTextBoxColumn";
            // 
            // товарDataGridViewTextBoxColumn
            // 
            this.товарDataGridViewTextBoxColumn.DataPropertyName = "Товар";
            this.товарDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.товарDataGridViewTextBoxColumn.Name = "товарDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // транзакциифамилииBindingSource
            // 
            this.транзакциифамилииBindingSource.DataMember = "Транзакции_фамилии";
            this.транзакциифамилииBindingSource.DataSource = this.cyrsachDataSet2;
            // 
            // cyrsachDataSet2
            // 
            this.cyrsachDataSet2.DataSetName = "cyrsachDataSet2";
            this.cyrsachDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cyrsachDataSet3
            // 
            this.cyrsachDataSet3.DataSetName = "cyrsachDataSet3";
            this.cyrsachDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.cyrsachDataSet3;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // транзакции_фамилииTableAdapter
            // 
            this.транзакции_фамилииTableAdapter.ClearBeforeFill = true;
            // 
            // ItemsDataGrid
            // 
            this.ItemsDataGrid.AutoGenerateColumns = false;
            this.ItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.категорияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn});
            this.ItemsDataGrid.DataSource = this.товарикатегорииBindingSource;
            this.ItemsDataGrid.Location = new System.Drawing.Point(12, 33);
            this.ItemsDataGrid.Name = "ItemsDataGrid";
            this.ItemsDataGrid.Size = new System.Drawing.Size(565, 220);
            this.ItemsDataGrid.TabIndex = 17;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // товарикатегорииBindingSource
            // 
            this.товарикатегорииBindingSource.DataMember = "Товари_категории";
            this.товарикатегорииBindingSource.DataSource = this.cyrsachDataSet1;
            // 
            // cyrsachDataSet1
            // 
            this.cyrsachDataSet1.DataSetName = "cyrsachDataSet1";
            this.cyrsachDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товари_категорииTableAdapter
            // 
            this.товари_категорииTableAdapter.ClearBeforeFill = true;
            // 
            // Selling
            // 
            this.Selling.BackColor = System.Drawing.Color.DarkRed;
            this.Selling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Selling.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Selling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Selling.Location = new System.Drawing.Point(12, 489);
            this.Selling.Name = "Selling";
            this.Selling.Size = new System.Drawing.Size(216, 30);
            this.Selling.TabIndex = 6;
            this.Selling.Text = "Продажа товара";
            this.Selling.UseVisualStyleBackColor = false;
            this.Selling.Click += new System.EventHandler(this.Selling_Click);
            // 
            // UpDatebutton
            // 
            this.UpDatebutton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UpDatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpDatebutton.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpDatebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpDatebutton.Location = new System.Drawing.Point(12, 523);
            this.UpDatebutton.Name = "UpDatebutton";
            this.UpDatebutton.Size = new System.Drawing.Size(216, 30);
            this.UpDatebutton.TabIndex = 20;
            this.UpDatebutton.Text = "Обновить таблицы";
            this.UpDatebutton.UseVisualStyleBackColor = false;
            this.UpDatebutton.Click += new System.EventHandler(this.UpDatebutton_Click);
            // 
            // CustomerDataGrid
            // 
            this.CustomerDataGrid.AutoGenerateColumns = false;
            this.CustomerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.фамилияDataGridViewTextBoxColumn1,
            this.имяDataGridViewTextBoxColumn1,
            this.отчествоDataGridViewTextBoxColumn1,
            this.телефонDataGridViewTextBoxColumn1});
            this.CustomerDataGrid.DataSource = this.клиентыBindingSource;
            this.CustomerDataGrid.Location = new System.Drawing.Point(583, 341);
            this.CustomerDataGrid.Name = "CustomerDataGrid";
            this.CustomerDataGrid.Size = new System.Drawing.Size(563, 212);
            this.CustomerDataGrid.TabIndex = 21;
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            // 
            // фамилияDataGridViewTextBoxColumn1
            // 
            this.фамилияDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.Name = "фамилияDataGridViewTextBoxColumn1";
            // 
            // имяDataGridViewTextBoxColumn1
            // 
            this.имяDataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn1.Name = "имяDataGridViewTextBoxColumn1";
            // 
            // отчествоDataGridViewTextBoxColumn1
            // 
            this.отчествоDataGridViewTextBoxColumn1.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.Name = "отчествоDataGridViewTextBoxColumn1";
            // 
            // телефонDataGridViewTextBoxColumn1
            // 
            this.телефонDataGridViewTextBoxColumn1.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.Name = "телефонDataGridViewTextBoxColumn1";
            // 
            // ByingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1158, 563);
            this.Controls.Add(this.CustomerDataGrid);
            this.Controls.Add(this.UpDatebutton);
            this.Controls.Add(this.Selling);
            this.Controls.Add(this.ItemsDataGrid);
            this.Controls.Add(this.labelFLnames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TranzakDataGrid);
            this.Name = "ByingForm";
            this.Text = "Продажа";
            this.Load += new System.EventHandler(this.ByingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TranzakDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.транзакциифамилииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарикатегорииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelFLnames;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView TranzakDataGrid;
        private cyrsachDataSet3 cyrsachDataSet3;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private cyrsachDataSet3TableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private cyrsachDataSet2 cyrsachDataSet2;
        private System.Windows.Forms.BindingSource транзакциифамилииBindingSource;
        private cyrsachDataSet2TableAdapters.Транзакции_фамилииTableAdapter транзакции_фамилииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn товарDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView ItemsDataGrid;
        private cyrsachDataSet1 cyrsachDataSet1;
        private System.Windows.Forms.BindingSource товарикатегорииBindingSource;
        private cyrsachDataSet1TableAdapters.Товари_категорииTableAdapter товари_категорииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Selling;
        private System.Windows.Forms.Button UpDatebutton;
        public System.Windows.Forms.DataGridView CustomerDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn1;
    }
}