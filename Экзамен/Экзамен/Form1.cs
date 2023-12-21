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
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=DESKTOP-LCGSVS9;Initial Catalog=Автотранспортное предприятие; Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
 
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автотранспортное_предприятиеDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.автотранспортное_предприятиеDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автотранспортное_предприятиеDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.автотранспортное_предприятиеDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автотранспортное_предприятиеDataSet.Заказчики". При необходимости она может быть перемещена или удалена.
            this.заказчикиTableAdapter.Fill(this.автотранспортное_предприятиеDataSet.Заказчики);

            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данные?", "Подтверждение удадения данных", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string name = название_компанииTextBox.Text;
                string tel = номер_телефонаTextBox.Text;
                string address = адресTextBox.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Удаление заказчика из базы данных 
                    string query = "DELETE FROM Заказчики WHERE Название_компании = @CompanyName AND Номер_телефона = @PhoneNumber AND Адрес = @Address";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CompanyName", name);
                        command.Parameters.AddWithValue("@PhoneNumber", tel);
                        command.Parameters.AddWithValue("@Address", address);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Заказчик успешно удален");

                            // Обновление данных в dataGridView
                            string selectQuery = "SELECT * FROM Заказчики";
                            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            заказчикиDataGridView.DataSource = table;
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при удалении заказчика");
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void dob_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(название_компанииTextBox.Text) ||
                string.IsNullOrEmpty(номер_телефонаTextBox.Text) ||
                string.IsNullOrEmpty(адресTextBox.Text))
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка при заполнении таблицы Клиенты_ЮЛ!");
                }
                else
                {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите обновить данные?", "Подтверждение обновления данных", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        this.Validate();
                        this.заказчикиBindingSource.EndEdit();
                        this.заказчикиTableAdapter.Update(this.автотранспортное_предприятиеDataSet);
                        MessageBox.Show("Новый клиент был добавлен успешно!", "Успешно!");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Не удалось добавить нового клиента. Попробуйте ввести корректные данные!", "Ошибка при заполнении таблицы Клиенты_ЮЛ!" + ex);
                    }
                }
                else
                {
                    return;
                }
                  }         
        }

        private void id_заказчикиLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
     
        }

        private void id_заказчикиTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void название_компанииTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void номер_телефонаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void адресTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            заказчикиBindingSource.Filter = $"[Название_компании] LIKE '%{textBox1.Text}%'";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "Заказчики";
            panel2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "Test";
            panel2.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void заказчикиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void заказыBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            заказчикиBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Подтверждение выхода", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form exit = new auth();
                 exit.Show();
                  this.Hide();
            }
            else
            {
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string name = название_компанииTextBox.Text;
            string tel = номер_телефонаTextBox.Text;
            string adress = адресTextBox.Text;

            if (string.IsNullOrEmpty(название_компанииTextBox.Text) ||
                string.IsNullOrEmpty(номер_телефонаTextBox.Text) ||
                string.IsNullOrEmpty(адресTextBox.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка при заполнении таблицы заказчики!");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Добавление нового пользователя в базу данных
                    string query = "INSERT INTO Заказчики (Название_компании, Номер_телефона, Адрес) VALUES (@Username, @Password, @Position)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", name);
                        command.Parameters.AddWithValue("@Password", tel);
                        command.Parameters.AddWithValue("@Position", adress);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Заказчик успешно добавлен");
                            string selectQuery = "SELECT * FROM Заказчики";
                            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            заказчикиDataGridView.DataSource = table;
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при добавлении пользователя"); 
                        }
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
           
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryCheckExisting = "SELECT COUNT(*) FROM Заказчики WHERE Название_компании = @Name AND Номер_телефона = @Tel AND Адрес = @Add";
                SqlCommand commandCheckExisting = new SqlCommand(queryCheckExisting, connection);

                commandCheckExisting.Parameters.AddWithValue("@Name", Convert.ToString(название_компанииTextBox.Text));
                commandCheckExisting.Parameters.AddWithValue("@Tel", Convert.ToString(номер_телефонаTextBox.Text));
                commandCheckExisting.Parameters.AddWithValue("@Add", Convert.ToString(адресTextBox.Text));

                connection.Open();

                int existingCount = (int)commandCheckExisting.ExecuteScalar();

                if (string.IsNullOrEmpty(название_компанииTextBox.Text) || string.IsNullOrEmpty(номер_телефонаTextBox.Text) || string.IsNullOrEmpty(адресTextBox.Text))
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка при заполнении таблицы заказчики");
                }
                else
                {
                    if (existingCount > 0)
                    {
                        MessageBox.Show("Заказчик с таким названием уже существуетbb!", "Ошибка при добавлении");
                    }
                    else
                    {
                        try
                        {
                            this.Validate();
                            this.заказчикиBindingSource.EndEdit();
                            this.заказчикиTableAdapter.Update(this.автотранспортное_предприятиеDataSet);
                            MessageBox.Show("Новый клиент был обновоён успешно!", "Успешно!");
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("Ошибка при удалении данных: " + ex.Message, "Ошибка при удалении данных!");
                        }
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
         
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данные?", "Подтверждение удаления данных", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    this.заказчикиBindingSource.RemoveCurrent();
                    this.заказчикиTableAdapter.Update(this.автотранспортное_предприятиеDataSet);
                    MessageBox.Show("Данные успешно удалены!", "Успешно!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Не удалось удалить данные. Пожалуйста, проверьте введенные данные и повторите попытку.", "Ошибка при удалении данных!" + ex);
                }
            }
            else
            {
                return;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int nextRowIndex = заказчикиDataGridView.CurrentRow.Index + 1;
            if (nextRowIndex < заказчикиDataGridView.Rows.Count)
            {
                заказчикиDataGridView.CurrentCell = заказчикиDataGridView.Rows[nextRowIndex].Cells[0];
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int previousRowIndex = заказчикиDataGridView.CurrentRow.Index - 1;
            if (previousRowIndex >= 0)
            {
                заказчикиDataGridView.CurrentCell = заказчикиDataGridView.Rows[previousRowIndex].Cells[0];
            }
        }
    }
}
