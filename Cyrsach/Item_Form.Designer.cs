namespace Cyrsach
{
    partial class Item_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.категориитоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyrsachDataSet4 = new Cyrsach.cyrsachDataSet4();
            this.категории_товаровTableAdapter = new Cyrsach.cyrsachDataSet4TableAdapters.Категории_товаровTableAdapter();
            this.Enterer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.категориитоваровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Категория:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxName.Location = new System.Drawing.Point(12, 225);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(239, 26);
            this.textBoxName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Название";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxCost.Location = new System.Drawing.Point(12, 175);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(239, 26);
            this.textBoxCost.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Цена";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxQuantity.Location = new System.Drawing.Point(12, 126);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(239, 26);
            this.textBoxQuantity.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Количество";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DataSource = this.категориитоваровBindingSource;
            this.comboBoxCategory.DisplayMember = "Название";
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(12, 74);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(239, 28);
            this.comboBoxCategory.TabIndex = 19;
            // 
            // категориитоваровBindingSource
            // 
            this.категориитоваровBindingSource.DataMember = "Категории_товаров";
            this.категориитоваровBindingSource.DataSource = this.cyrsachDataSet4;
            // 
            // cyrsachDataSet4
            // 
            this.cyrsachDataSet4.DataSetName = "cyrsachDataSet4";
            this.cyrsachDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // категории_товаровTableAdapter
            // 
            this.категории_товаровTableAdapter.ClearBeforeFill = true;
            // 
            // Enterer
            // 
            this.Enterer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Enterer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enterer.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enterer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enterer.Location = new System.Drawing.Point(12, 272);
            this.Enterer.Name = "Enterer";
            this.Enterer.Size = new System.Drawing.Size(239, 30);
            this.Enterer.TabIndex = 20;
            this.Enterer.Text = "Потвердить";
            this.Enterer.UseVisualStyleBackColor = false;
            this.Enterer.Click += new System.EventHandler(this.Enterer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(44, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(63, 21);
            this.labelID.TabIndex = 22;
            this.labelID.Text = "Новый";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(96, 50);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(89, 21);
            this.labelCategory.TabIndex = 23;
            this.labelCategory.Text = "Категория";
            // 
            // Item_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(266, 311);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Enterer);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Item_Form";
            this.Text = "Добавить товары";
            this.Load += new System.EventHandler(this.Item_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.категориитоваровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private cyrsachDataSet4 cyrsachDataSet4;
        private System.Windows.Forms.BindingSource категориитоваровBindingSource;
        private cyrsachDataSet4TableAdapters.Категории_товаровTableAdapter категории_товаровTableAdapter;
        private System.Windows.Forms.Button Enterer;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxCost;
        public System.Windows.Forms.TextBox textBoxQuantity;
        public System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labelID;
        public System.Windows.Forms.Label labelCategory;
    }
}