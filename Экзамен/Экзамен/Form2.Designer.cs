namespace Экзамен
{
    partial class Form2
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
            System.Windows.Forms.Label iD_ПользователяLabel;
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            System.Windows.Forms.Label статусLabel;
            this.автотранспортное_предприятиеDataSet = new Экзамен.Автотранспортное_предприятиеDataSet();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter = new Экзамен.Автотранспортное_предприятиеDataSetTableAdapters.ПользователиTableAdapter();
            this.tableAdapterManager = new Экзамен.Автотранспортное_предприятиеDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_ПользователяLabel1 = new System.Windows.Forms.Label();
            this.логинLabel1 = new System.Windows.Forms.Label();
            this.парольLabel1 = new System.Windows.Forms.Label();
            this.статусComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.пользователиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            iD_ПользователяLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.автотранспортное_предприятиеDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // автотранспортное_предприятиеDataSet
            // 
            this.автотранспортное_предприятиеDataSet.DataSetName = "Автотранспортное_предприятиеDataSet";
            this.автотранспортное_предприятиеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.автотранспортное_предприятиеDataSet;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Экзамен.Автотранспортное_предприятиеDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.ГрузыTableAdapter = null;
            this.tableAdapterManager.ЗаказчикиTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.НакладныеTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = this.пользователиTableAdapter;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(iD_ПользователяLabel);
            this.panel1.Controls.Add(this.iD_ПользователяLabel1);
            this.panel1.Controls.Add(логинLabel);
            this.panel1.Controls.Add(this.логинLabel1);
            this.panel1.Controls.Add(парольLabel);
            this.panel1.Controls.Add(this.парольLabel1);
            this.panel1.Controls.Add(статусLabel);
            this.panel1.Controls.Add(this.статусComboBox);
            this.panel1.Location = new System.Drawing.Point(36, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 231);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iD_ПользователяLabel
            // 
            iD_ПользователяLabel.AutoSize = true;
            iD_ПользователяLabel.Location = new System.Drawing.Point(155, 77);
            iD_ПользователяLabel.Name = "iD_ПользователяLabel";
            iD_ПользователяLabel.Size = new System.Drawing.Size(97, 13);
            iD_ПользователяLabel.TabIndex = 0;
            iD_ПользователяLabel.Text = "ID Пользователя:";
            // 
            // iD_ПользователяLabel1
            // 
            this.iD_ПользователяLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "ID_Пользователя", true));
            this.iD_ПользователяLabel1.Location = new System.Drawing.Point(258, 77);
            this.iD_ПользователяLabel1.Name = "iD_ПользователяLabel1";
            this.iD_ПользователяLabel1.Size = new System.Drawing.Size(121, 23);
            this.iD_ПользователяLabel1.TabIndex = 1;
            this.iD_ПользователяLabel1.Text = "label1";
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(155, 100);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(41, 13);
            логинLabel.TabIndex = 2;
            логинLabel.Text = "Логин:";
            // 
            // логинLabel1
            // 
            this.логинLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "Логин", true));
            this.логинLabel1.Location = new System.Drawing.Point(258, 100);
            this.логинLabel1.Name = "логинLabel1";
            this.логинLabel1.Size = new System.Drawing.Size(121, 23);
            this.логинLabel1.TabIndex = 3;
            this.логинLabel1.Text = "label1";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Location = new System.Drawing.Point(155, 123);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(48, 13);
            парольLabel.TabIndex = 4;
            парольLabel.Text = "Пароль:";
            // 
            // парольLabel1
            // 
            this.парольLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "Пароль", true));
            this.парольLabel1.Location = new System.Drawing.Point(258, 123);
            this.парольLabel1.Name = "парольLabel1";
            this.парольLabel1.Size = new System.Drawing.Size(121, 23);
            this.парольLabel1.TabIndex = 5;
            this.парольLabel1.Text = "label1";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(155, 152);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(44, 13);
            статусLabel.TabIndex = 6;
            статусLabel.Text = "Статус:";
            // 
            // статусComboBox
            // 
            this.статусComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "Статус", true));
            this.статусComboBox.FormattingEnabled = true;
            this.статусComboBox.Items.AddRange(new object[] {
            "Администратор",
            "Пользователь"});
            this.статусComboBox.Location = new System.Drawing.Point(258, 149);
            this.статусComboBox.Name = "статусComboBox";
            this.статусComboBox.Size = new System.Drawing.Size(121, 21);
            this.статусComboBox.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.пользователиDataGridView);
            this.panel2.Location = new System.Drawing.Point(33, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 231);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Перейти к заявкам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // пользователиDataGridView
            // 
            this.пользователиDataGridView.AutoGenerateColumns = false;
            this.пользователиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пользователиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.пользователиDataGridView.DataSource = this.пользователиBindingSource;
            this.пользователиDataGridView.Location = new System.Drawing.Point(50, 5);
            this.пользователиDataGridView.Name = "пользователиDataGridView";
            this.пользователиDataGridView.Size = new System.Drawing.Size(300, 220);
            this.пользователиDataGridView.TabIndex = 4;
            this.пользователиDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.пользователиDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Пользователя";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Пользователя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Логин";
            this.dataGridViewTextBoxColumn2.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Пароль";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Статус";
            this.dataGridViewTextBoxColumn4.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(492, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(492, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 308);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.автотранспортное_предприятиеDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.пользователиDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Автотранспортное_предприятиеDataSet автотранспортное_предприятиеDataSet;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private Автотранспортное_предприятиеDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private Автотранспортное_предприятиеDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label iD_ПользователяLabel1;
        private System.Windows.Forms.Label логинLabel1;
        private System.Windows.Forms.Label парольLabel1;
        private System.Windows.Forms.ComboBox статусComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView пользователиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button3;
    }
}