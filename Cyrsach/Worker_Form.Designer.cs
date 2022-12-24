namespace Cyrsach
{
    partial class Worker_Form
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
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyrsachDataSet8 = new Cyrsach.cyrsachDataSet8();
            this.textBoxFamilia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOtchestvo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.должностиTableAdapter = new Cyrsach.cyrsachDataSet8TableAdapters.ДолжностиTableAdapter();
            this.Enterer = new System.Windows.Forms.Button();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(44, 8);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(63, 21);
            this.labelID.TabIndex = 32;
            this.labelID.Text = "Новый";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "ID:";
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxPost.DataSource = this.должностиBindingSource;
            this.comboBoxPost.DisplayMember = "Название";
            this.comboBoxPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Location = new System.Drawing.Point(12, 66);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(239, 28);
            this.comboBoxPost.TabIndex = 30;
            this.comboBoxPost.ValueMember = "Код_должности";
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.cyrsachDataSet8;
            // 
            // cyrsachDataSet8
            // 
            this.cyrsachDataSet8.DataSetName = "cyrsachDataSet8";
            this.cyrsachDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxFamilia
            // 
            this.textBoxFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxFamilia.Location = new System.Drawing.Point(12, 118);
            this.textBoxFamilia.Name = "textBoxFamilia";
            this.textBoxFamilia.Size = new System.Drawing.Size(239, 26);
            this.textBoxFamilia.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Фамилия";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxName.Location = new System.Drawing.Point(12, 167);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(239, 26);
            this.textBoxName.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Имя";
            // 
            // textBoxOtchestvo
            // 
            this.textBoxOtchestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxOtchestvo.Location = new System.Drawing.Point(12, 217);
            this.textBoxOtchestvo.Name = "textBoxOtchestvo";
            this.textBoxOtchestvo.Size = new System.Drawing.Size(239, 26);
            this.textBoxOtchestvo.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Отчество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Должность:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxPassword.Location = new System.Drawing.Point(12, 376);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(239, 26);
            this.textBoxPassword.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxLogin.Location = new System.Drawing.Point(12, 324);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(239, 26);
            this.textBoxLogin.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "Логин";
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // Enterer
            // 
            this.Enterer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Enterer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enterer.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enterer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enterer.Location = new System.Drawing.Point(12, 408);
            this.Enterer.Name = "Enterer";
            this.Enterer.Size = new System.Drawing.Size(239, 30);
            this.Enterer.TabIndex = 37;
            this.Enterer.Text = "Потвердить";
            this.Enterer.UseVisualStyleBackColor = false;
            this.Enterer.Click += new System.EventHandler(this.Enterer_Click);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxTelephone.Location = new System.Drawing.Point(12, 270);
            this.textBoxTelephone.MaxLength = 11;
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(239, 26);
            this.textBoxTelephone.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Телефон";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPost.Location = new System.Drawing.Point(92, 42);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(93, 21);
            this.labelPost.TabIndex = 40;
            this.labelPost.Text = "должность";
            this.labelPost.Visible = false;
            // 
            // Worker_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(263, 449);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Enterer);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPost);
            this.Controls.Add(this.textBoxFamilia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOtchestvo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Worker_Form";
            this.Text = "Добавить сотрудника";
            this.Load += new System.EventHandler(this.Worker_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyrsachDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBoxPost;
        public System.Windows.Forms.TextBox textBoxFamilia;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxOtchestvo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label7;
        private cyrsachDataSet8 cyrsachDataSet8;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private cyrsachDataSet8TableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private System.Windows.Forms.Button Enterer;
        public System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label labelPost;
    }
}