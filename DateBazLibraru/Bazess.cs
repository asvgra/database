using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DateBazLibraru
{
    enum RumStat
    { 
        Exsisted,
        New,
        ModiFled,
        ModiFledNew,
        Deleted

    
    }
    public partial class Bazess : Form
    {
      
       // int select;

        public Bazess()
        {
            InitializeComponent();
        }
        private void CrewData()
        {
            
        }
        private void RegistrDB(DataGridView dgr,IDataRecord record)
        {        }


        private void Bazess_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   DataBase database = new DataBase();

             DB detebl = new DB();
             detebl.open();
            DataTable table = new DataTable();
             MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `id`, `login` AS 'Логин',  `password` AS 'Пароль' , `name` AS 'Имя пользователя' , `surname` AS 'Фамилия' ,  `patronymic`  AS 'Отчество', `passport`  AS 'Данные паспорта' ,`phone`  AS 'Номер телефона' FROM `readeers` ", detebl.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
             dataGridViewOSN.DataSource = table;
             dataGridViewOSN.Columns[0].Width = 50;
             dataGridViewOSN.Columns[3].Width = 80;
             dataGridViewOSN.Columns[4].Width = 100;
             detebl.close(); 
        }
      //  Form2 dlg = new LoginForm();
        private void button2_Click(object sender, EventArgs e)
        {        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {        }

        private void SearsJSN_Click(object sender, EventArgs e)
        {
            String Surname;
            Surname = Sears.Text;
            DataTable table = new DataTable();  
            MySqlDataAdapter adapte = new MySqlDataAdapter(); //создали память под адаптер
            DB db = new DB();
            MySqlCommand comm = new MySqlCommand($"SELECT * FROM readeers WHERE surname = '{Surname}'",  db.getConnection());
            adapte.SelectCommand = comm;
            adapte.Fill(table);
            dataGridViewOSN.DataSource = table; 
            dataGridViewOSN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOSN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (table.Rows.Count > 0)
                MessageBox.Show("Читатель найден");
            else
                MessageBox.Show("Читатель не найден");
        }
        
        
        private void Chenge()
        { 
        var selectedRowIndtxs = dataGridViewOSN.CurrentCell.RowIndex;       
            var id = selectedRowIndtxs.ToString();
        }
        private void Repac_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChecOK_Click(object sender, EventArgs e)
        {
            if (AddSurname.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (AddLogin.Text == "")
            {
                MessageBox.Show("Введите id читателя");
                return;
            }
            if (AddName.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (AddName.Text == "")
            {
                MessageBox.Show("Введите отчество");
                return;
            }
               
            DB db = new DB(); //имеем доступ к функциям с класса DBЫ
            MySqlDataAdapter adapte = new MySqlDataAdapter();
            db.open();
            DataTable table = new DataTable();
            MySqlCommand comm = new MySqlCommand("INSERT INTO `readeers` ( `id`,`name`,  `surname`,  `patronymic`) VALUES (@id,@name, @surname,  @password)", db.getConnection());
            String surname= AddSurname.Text;
            String  name = AddName.Text;
            String patronymic = AddPathonic.Text;
            String  login = AddLogin.Text;
           comm.Parameters.Add("@id", MySqlDbType.VarChar).Value = login; //внесли в заглушку значение переменной
            comm.Parameters.Add("@password", MySqlDbType.VarChar).Value = patronymic;
            comm.Parameters.Add("@name", MySqlDbType.VarChar).Value = name; //внесли в заглушку значение переменной
            comm.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
            if (comm.ExecuteNonQuery() == 1)
                MessageBox.Show("Поздравляем Вы успешно зарегистрировались");
            else
                MessageBox.Show("Извините,но аккаунт не может быть создан,проверьте данные или позвоните в библиотеку");
            db.close();
        }
        private void Update()
        {       }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {     }
        private void DeleteRow()
        {      }   
        private void Delete_Click(object sender, EventArgs e)
        {
            dataGridViewOSN.Sort(dataGridViewOSN.Columns[4], ListSortDirection.Ascending);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {        }
        private void Edit_table()
        {        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewOSN_SelectionChanged(object sender, EventArgs e)
        {        }

        private void FamilySers_CheckedChanged(object sender, EventArgs e)
        {

         
        }

        private void dataGridViewOSN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                DB db = new DB();
                db.open();
                MySqlDataAdapter adapte = new MySqlDataAdapter();
                int id_reader = System.Convert.ToInt32(dataGridViewOSN.Rows[e.RowIndex].Cells[0].Value);
                DataTable table = new DataTable();
                MySqlCommand comm = new MySqlCommand("SELECT `id_reader` AS 'id читателя',`id_book`  AS 'id книги', `creating_a_portfolio` AS 'Дата выдачи', `time_of_delivery` AS 'Время сдачи книги' FROM `issuee_cards` WHERE id_reader = @id_reader", db.getConnection());
                comm.Parameters.Add("@id_reader", MySqlDbType.VarChar).Value = id_reader; 
                adapte.SelectCommand = comm;
                adapte.Fill(table);
                Finall.DataSource = table;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable tables = new DataTable();
                MySqlCommand comman = new MySqlCommand("SELECT `id`, `author` AS 'Автор книги', `publication_year` AS 'Год публикации', `publisher` AS 'Издательство',`name_books`AS 'Название книги', `book_number`AS 'Код книги' FROM books WHERE id IN (SELECT id_book FROM `issuee_cards` WHERE id_reader = @id_reader)", db.getConnection());
                comman.Parameters.Add("@id_reader", MySqlDbType.VarChar).Value = id_reader;
                adapter.SelectCommand = comman;
                adapter.Fill(tables);
                 books.DataSource = tables;
                db.close();
            }
        }

        private void Fill_CellClick(object sender, DataGridViewCellEventArgs e)
        {        }

        private void Fill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewOSN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        }

       

        private void dataGridViewOSN_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewOSN.CurrentRow.Index;
            dataGridViewOSN.Text = Convert.ToString(dataGridViewOSN.Rows[row].Cells[1].Value);
            AddSurname.Text = Convert.ToString(dataGridViewOSN.Rows[row].Cells[4].Value);
            AddName.Text = Convert.ToString(dataGridViewOSN.Rows[row].Cells[3].Value);
            AddPathonic.Text = Convert.ToString(dataGridViewOSN.Rows[row].Cells[5].Value);
            AddLogin.Text = Convert.ToString(dataGridViewOSN.Rows[row].Cells[0].Value);
        }

        private void поискПоКнигамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            boks registrs = new boks();
            registrs.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            dataGridViewOSN.Sort(dataGridViewOSN.Columns[4], ListSortDirection.Ascending);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            dataGridViewOSN.Sort(dataGridViewOSN.Columns[1], ListSortDirection.Ascending);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
          
            dataGridViewOSN.Sort(dataGridViewOSN.Columns[3], ListSortDirection.Ascending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эти записи?", "Удаление записей", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridViewOSN.SelectedRows)
                {
                    dataGridViewOSN.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AddSurname.Text = "";
            AddSurname.Clear();
            AddName.Text = "";
            AddName.Clear();
            AddPathonic.Text = "";
            AddPathonic.Clear();
            AddLogin.Text = "";
            AddLogin.Clear();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            //DB db = new DB(); //имеем доступ к функциям с класса DBЫ
            //MySqlDataAdapter adapte = new MySqlDataAdapter();
            //db.open();
            //DataTable table = new DataTable();
            //MySqlCommand comm = new MySqlCommand("INSERT INTO `issuee_cards` (`id_book`,  `id_reader`) VALUES (@name, @surname)", db.getConnection());
            //String surname = AddLogin.Text;
            //String name = playgo.Text;
           

            
            //comm.Parameters.Add("@name", MySqlDbType.VarChar).Value = name; //внесли в заглушку значение переменной
            //comm.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
            //if (MessageBox.Show("Вы хотите добавить книгу?", "Добавление книги", MessageBoxButtons.YesNo,
            //                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //{
            //    if (comm.ExecuteNonQuery() == 1)
            //        MessageBox.Show("Поздравляем Вы успешно добавили новую книгу");
            //    else
            //        MessageBox.Show("Извините,но книга не может быть добавлена в библиотеку, проверьте данные или их актуальность");
            //}
            //   DB db = new DB();
            //   db.open();
            //   MySqlDataAdapter adapte = new MySqlDataAdapter();
            ////   int id_reader = System.Convert.ToInt32(dataGridViewOSN.CurrentCell.Value);
            //   DataTable table = new DataTable();
            //   MySqlCommand comm = new MySqlCommand("INSERT INTO `` (``) VALUES (@ul)", db.getConnection());
            //    //   "SELECT id_book FROM issuee_cards WHERE book = @uL ", db.getConnection());
            //   String book = playgo.Text;
            //  // "SELECT `id_reader` AS 'id читателя',`id_book`  AS 'id книги', `creating_a_portfolio` AS 'Cозданиe карточки', `time_of_delivery` AS 'Время сдачи книги' FROM `issuee_cards` WHERE id_reader = @id_reader", db.getConnection());
            //   comm.Parameters.Add("@ul", MySqlDbType.VarChar).Value = book;
            //   //adapte.SelectCommand = comm;
            //adapte.Fill(table);
            //Finall.DataSource = table;
            //DB db = new DB(); //имеем доступ к функциям с класса DBЫ
            // MySqlDataAdapter adapte = new MySqlDataAdapter();
            //db.open();
            // DataTable table = new DataTable();
            //  MySqlCommand comm = new MySqlCommand("INSERT INTO `issuee_cards` (`id_book`) VALUES (@book)", db.getConnection());

            //  comm.Parameters.Add("@book", MySqlDbType.VarChar).Value = book; //внесли в заглушку значение переменной

            // db.close(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                
            }
        }
        public DataSet CreateCmdsAndUpdate(string connectionString,
    string queryString, string tableName)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = new OleDbCommand(queryString, connection);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);

                connection.Open();

                DataSet customers = new DataSet();
                adapter.Fill(customers);

                //code to modify data in dataset here

                adapter.Update(customers, tableName);

                return customers;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Sears_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((DataTable)dataGridViewOSN.DataSource);
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

            if (dataGridViewOSN.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "Timetable.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Unable to wride data in disk" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(dataGridViewOSN.Columns.Count);

                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            //Добавим в таблицу общий заголовок
                            PdfPCell cell = new PdfPCell();

                           // PdfPCell date = new PdfPCell();
                            cell.Colspan = ds.Tables[0].Columns.Count;
                            cell.HorizontalAlignment = 1;
                            //Убираем границу первой ячейки, чтобы балы как заголовок
                            cell.Border = 0;
                            pTable.AddCell(cell);

                            foreach (DataGridViewColumn col in dataGridViewOSN.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }



                            //Добавляем все остальные ячейки
                            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                            {
                                for (int k = 0; k < ds.Tables[0].Columns.Count; k++)
                                {
                                    pTable.AddCell(new Phrase(ds.Tables[0].Rows[j][k].ToString(), font));
                                }


                                //Добавим в таблицу дату
                                PdfPCell date = new PdfPCell(new Phrase("Дата: " + dateTimePicker1.Text, font));

                                date.Colspan = ds.Tables[0].Columns.Count;
                                date.HorizontalAlignment = 0;
                                //Убираем границу первой ячейки, чтобы балы как заголовок
                                date.Border = 0;
                                pTable.AddCell(date);

                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                                {
                                    Document document = new Document(PageSize.A4.Rotate());
                                    PdfWriter.GetInstance(document, fileStream);

                                    document.Open();

                                    document.Add(pTable);

                                    document.Close();

                                    fileStream.Close();

                                }

                                MessageBox.Show("Data Export Successfully", "info");

                            }
                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Error while exporting Data" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No Record Found", "Info");

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
             DB db = new DB(); //имеем доступ к функциям с класса DBЫ
            MySqlDataAdapter adapte = new MySqlDataAdapter();
        db.open();
         DataTable table = new DataTable();
         MySqlCommand comm = new MySqlCommand("INSERT INTO `issuee_cards` (`id_book`,  `id_reader`) VALUES (@name, @surname)", db.getConnection());
       String surname = AddLogin.Text;
          String name = playgo.Text;



            comm.Parameters.Add("@name", MySqlDbType.VarChar).Value = name; //внесли в заглушку значение переменной
           comm.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
            if (MessageBox.Show("Вы хотите добавить книгу?", "Добавление книги", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
               if (comm.ExecuteNonQuery() == 1)
                   MessageBox.Show("Поздравляем Вы успешно добавили новую книгу");
              else
                  MessageBox.Show("Извините,но книга не может быть добавлена в библиотеку, проверьте данные или их актуальность");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
              ds.Tables.Add((DataTable)dataGridViewOSN.DataSource);
         
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            if (dataGridViewOSN.Rows.Count > 0)
            {

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "bibliots.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Не удается записать данные на диск! " + ex.Message, "Info");
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridViewOSN.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            //Добавим в таблицу общий заголовок
                            PdfPCell cell = new PdfPCell(new Phrase("Полный отчет о всех читателях ", font));
                            cell.Colspan = ds.Tables[0].Columns.Count;
                            cell.HorizontalAlignment = 1;
                            //Убираем границу первой ячейки, чтобы были как заголовок
                            cell.Border = 0;
                            pTable.AddCell(cell);

                            foreach (DataGridViewColumn col in dataGridViewOSN.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);

                            }

                            //Добавляем все остальные ячейки
                            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                            {
                                for (int k = 0; k < ds.Tables[0].Columns.Count; k++)
                                {
                                    pTable.AddCell(new Phrase(ds.Tables[0].Rows[j][k].ToString(), font));
                                }
                            }

                            //Добавим в таблицу дату
                            PdfPCell date = new PdfPCell(new Phrase("Дата: " + dateTimePicker1.Text, font));
                            date.Colspan = ds.Tables[0].Columns.Count;
                            date.HorizontalAlignment = 2;
                            //Убираем границу первой ячейки, чтобы было как заголовок
                            date.Border = 0;
                            pTable.AddCell(date);

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4.Rotate());
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            } 
                          MessageBox.Show("Успешный экспорт данных","Info");
                                              }
                        catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при экспорте данных" + ex.Message, "Info");
                    }
                }
            }
        }
            else
            {
                MessageBox.Show("Запись не найдена", "Info");
            }
}
    }
    }

