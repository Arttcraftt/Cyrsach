//класс с методами для SQL комманд
using System;
using System.Data.OleDb;
using System.Data;

namespace Cyrsach
{
    public class Query
    {
        public static OleDbConnection connection;
        private static OleDbCommand command;
        public static OleDbDataAdapter dataAdapter;
        public DataTable bufferTable;
        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        //сортировка таблицы 
        public DataTable upDateTable(string TableName, string attribute, string modifier)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM [{TableName}] ORDER BY \'{attribute}\' {modifier}", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        //методы добавления в таблицы
        public void Add(string familia, string FirstName, string LastName, string telephone)
        {
            connection.Open();
            command = new OleDbCommand("INSERT INTO [Клиенты] (Фамилия,Имя,Отчество,Телефон) VALUES(@Фамилия,@Имя,@Отчество,@Телефон)", connection);
            command.Parameters.AddWithValue("Фамилия", familia);
            command.Parameters.AddWithValue("Имя", FirstName);
            command.Parameters.AddWithValue("Отчество", LastName);
            command.Parameters.AddWithValue("Телефон", telephone);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Add(int post, string familia, string FirstName, string LastName, string telephone, string Login , string Password)
        {
            connection.Open();
            command = new OleDbCommand("INSERT INTO [Сотрудники] (Должность,Фамилия,Имя,Отчество,Телефон,Логин,Пароль) VALUES(@Должность,@Фамилия,@Имя,@Отчество,@Телефон,@Логин,@Пароль)", connection);
            command.Parameters.AddWithValue("Должность", post);
            command.Parameters.AddWithValue("Фамилия", familia);
            command.Parameters.AddWithValue("Имя", FirstName);
            command.Parameters.AddWithValue("Отчество", LastName);
            command.Parameters.AddWithValue("Телефон", telephone);
            command.Parameters.AddWithValue("Логин", Login);
            command.Parameters.AddWithValue("Пароль", Password);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Add(int category, int quantity, int cost, string Name)
        {
            connection.Open();
            command = new OleDbCommand("INSERT INTO [Товары] (Категория,Количество,Цена,Название) VALUES(@Категория,@Количество,@Цена,@Название)", connection);
            command.Parameters.AddWithValue("Категория", category);
            command.Parameters.AddWithValue("Количество", quantity);
            command.Parameters.AddWithValue("Цена", cost);
            command.Parameters.AddWithValue("Название", Name);
            command.ExecuteNonQuery();
            connection.Close();
        }

        //метод удаления
        public void Delete(int ID, string TableName)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM [{TableName}] WHERE ID = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        //метод покупки товаров
        public void Bying(int Worker, int Customer, int Item)
        {
            connection.Open();
            command = new OleDbCommand("INSERT INTO [Транзакции] (Сотрудник,Клиент,Товар,Дата) VALUES(@Сотрудник,@Клиент,@Товар,@Дата)", connection);
            command.Parameters.AddWithValue("Сотрудник", Worker);
            command.Parameters.AddWithValue("Клиент", Customer);
            command.Parameters.AddWithValue("Товар", Item);
            command.Parameters.AddWithValue("Дата", DateTime.Today);
            command.ExecuteNonQuery();
            command = new OleDbCommand($"UPDATE [Товары] SET Количество = Количество - 1 WHERE ID = {Item}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        //метод конвентирования названий Категорий товаров/Должностей в Код
        public int Name_To_ID_Categories(string Name, string TableName)
        {
            dataAdapter = new OleDbDataAdapter($"SELECT Код FROM [{TableName}] WHERE Название = \'{Name}\'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            return int.Parse(bufferTable.Rows[0][0].ToString());
        }

        //метод конвентирования Кода в Категории товаров/Должности
        public string ID_To_Name_Categories(int ID, string TableName)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT Название FROM [{TableName}]\n WHERE Код = {ID}", connection);
            connection.Close();
            bufferTable.Reset();
            dataAdapter.Fill(bufferTable);
            return bufferTable.Rows[0][0].ToString();
        }

        //метод конвентирования названий Товаров/Клиентов/Сотрудников в ID
        public int Name_To_ID_Datas(string Name, string TableName)
        {
            string tab_attribute = "Фамилия";
            if (TableName == "Товары") tab_attribute = "Название";
            dataAdapter = new OleDbDataAdapter($"SELECT ID FROM [{TableName}] WHERE {tab_attribute} = \'{Name}\'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            return int.Parse(bufferTable.Rows[0][0].ToString());
        }

        //метод конвентирования названий ID в Товаров/Клиентов/Сотрудников
        public string ID_To_Name_Datas(int ID, string TableName)
        {
            string tab_attribute = "Фамилия";
            if (TableName == "Товары") tab_attribute = "Название";
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT {tab_attribute} FROM [{TableName}]\n WHERE ID = {ID}", connection);
            connection.Close();
            bufferTable.Reset();
            dataAdapter.Fill(bufferTable);
            return bufferTable.Rows[0][0].ToString();
        }
        
        //метод, возвращающий строку таблицы со значениями по заданому ID и назанию таблицы
        public DataTable buffer_return(int ID, string TableName)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM [{TableName}] WHERE ID = {ID}", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public string Fam_Name { get; set; } // свойство Фамилия и Имя

        public string Familia { get; set; } // свойство Фамилия

        //метод авторизации
        public int Autoriza(string login, string password)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT Должности.Модификатор_доступа, Сотрудники.Фамилия, Сотрудники.Имя \nFROM Должности INNER JOIN Сотрудники ON Должности.Код = Сотрудники.Должность \nWHERE Логин = \'{login}\' AND Пароль = \'{password}\';", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            try {
                if (bufferTable.Rows[0][0] != null) {
                    Familia += bufferTable.Rows[0][1].ToString();
                    Fam_Name += bufferTable.Rows[0][1].ToString();
                    Fam_Name += " " + bufferTable.Rows[0][2].ToString();
                    return int.Parse(bufferTable.Rows[0][0].ToString());
                }
                else return 0;
            }
            catch {
                return 0;
            }
        }
    }
}
