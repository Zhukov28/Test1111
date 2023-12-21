using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экзамен
{
    public partial class auth : Form
    {
        string connectionString = "Data Source=DESKTOP-LCGSVS9;Initial Catalog=Автотранспортное предприятие; Integrated Security=True";
        public auth()
        {
            InitializeComponent();
        }

        private void auth_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автотранспортное_предприятиеDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.автотранспортное_предприятиеDataSet.Заказы);

            textBox3.PasswordChar= '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == null)
            {
                MessageBox.Show("Введите логин!", "Ошибка авторизации");
                return;
            }
            else if (textBox2.Text.Contains(" "))
            {
                MessageBox.Show("Логин не должен содержать пробелы!", "Ошибка авторизации");
                return;
            }

            if (textBox3.Text == "" || textBox3.Text == null)
            {
                MessageBox.Show("Введите пароль!", "Ошибка авторизации");
                return;
            }
            else if (textBox3.Text.Contains(" "))
            {
                MessageBox.Show("Пароль не должен содержать пробелы!", "Ошибка авторизации");
                return;
            }

            Value.Логин = textBox2.Text;
            Value.Пароль = textBox3.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select ID_Пользователя, Логин, Пароль from Пользователи where Логин = @login and Пароль = @password", connection))
                {
                    command.Parameters.Add(new SqlParameter("login", Value.Логин));
                    command.Parameters.Add(new SqlParameter("password", Value.Пароль));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Вы успешно авторизовались", "Авторизация в аккаунт");
                            reader.Close(); // Закрытие DataReader
                            using (SqlCommand statusCommand = new SqlCommand("Select Статус from Пользователи WHERE Логин=@login", connection))
                            {
                                statusCommand.Parameters.Add(new SqlParameter("login", Value.Логин));
                                string result = (string)statusCommand.ExecuteScalar();

                                if (result == "Администратор")
                                {
                                    this.Hide();
                                    Form admin = new Form1();
                                    admin.Show();
                                }
                                if (result == "Пользователь")
                                {
                                    this.Hide();
                                    Form admin = new Form2();
                                    admin.Show();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.автотранспортное_предприятиеDataSet);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           if(textBox2.Text == "" || textBox2.Text == null)
            {
                MessageBox.Show("ff");
                return;
            } else if (textBox2.Text.Contains(" "))
            {
                MessageBox.Show("ff");
                return;
            }

            Value.Логин = textBox2.Text;
            Value.Пароль = textBox3.Text;

            using(SqlConnection command = new SqlConnection(connectionString))
            {
                command.Open();

                using(SqlCommand comm = new SqlCommand("SELECT id, g,f FROM Пользователь WHERE пароль = @ff", command))
                {
                    comm.Parameters.Add(new SqlParameter("@id", Value.Логин));

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("");
                            reader.Close();
                            using(SqlCommand cd = new SqlCommand("SELECT Статус FROM Пользователи WHERE Логин = @id", command))
                            {
                                cd.Parameters.Add(new SqlParameter("id", Value.Логин));
                                string readef = (string)cd.ExecuteScalar();
                                if(readef == "ff")
                                {

                                }
                            }
                        }
                    }
                }
            }

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            
        }

        private void заказыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar= true;
            pictureBox3.Visible= false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = false; 
            pictureBox3.Visible= true;
            pictureBox2.Visible= false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = false;

            }
            else
            {
                textBox3.UseSystemPasswordChar = true;

            }
        }
    }
}
