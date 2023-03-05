using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DateBazLibraru
{
    
       public partial class boks : Form
    {
private int index1;
        public boks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB detebl = new DB();
            detebl.open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `id` , `author`AS 'Автор книги',  `publication_year` AS 'Год публикации', `publisher` AS 'Издательство', `name_books` AS 'Название книги',  `book_number`AS 'Номер книги' FROM `books` ", detebl.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridViewBoks.DataSource = table;
            dataGridViewBoks.Columns[0].Width = 90;
            dataGridViewBoks.Columns[1].Width = 150;
            dataGridViewBoks.Columns[2].Width = 90;
            dataGridViewBoks.Columns[3].Width = 150;
            dataGridViewBoks.Columns[4].Width = 150;
            dataGridViewBoks.Columns[5].Width = 150;
            detebl.close();
        }

        private void поискПоКнигамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bazess registrs = new Bazess();
            registrs.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChecOK_Click(object sender, EventArgs e)
        {
          
            if (author.Text == "")
            {
                MessageBox.Show("Введите автора книги");
                return;
            }
            if (namesbok.Text == "")
            {
                MessageBox.Show("Введите год публикации");
                return;
            }
            if (yearpl.Text == "")
            {
                MessageBox.Show("Введите издательство");
                return;
            }
            if (yearpl.Text == "")
            {
                MessageBox.Show("Введите название книги");
                return;
            }
            if (Addbook.Text == "")
            {
                MessageBox.Show("Введите id книги");
                return;
            }

            DB db = new DB(); //имеем доступ к функциям с класса DBЫ
            MySqlDataAdapter adapte = new MySqlDataAdapter();
            db.open();
            DataTable table = new DataTable();
            MySqlCommand comm = new MySqlCommand("INSERT INTO `books` (`id`,  `author`, `publication_year`, `publisher` , `name_books`) VALUES (@name, @surname, @login, @password,@book )", db.getConnection());
            String surname = author.Text;
            String name = Addbook.Text;
            String password = izd.Text;
            String login = yearpl.Text;
            String boks = namesbok.Text;
            comm.Parameters.Add("@login", MySqlDbType.VarChar).Value = login; //внесли в заглушку значение переменной
            comm.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            comm.Parameters.Add("@name", MySqlDbType.VarChar).Value = name; //внесли в заглушку значение переменной
            comm.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
            comm.Parameters.Add("@book", MySqlDbType.VarChar).Value = boks;
            if (MessageBox.Show("Вы хотите добавить книгу?", "Добавление книги", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (comm.ExecuteNonQuery() == 1)
                    MessageBox.Show("Поздравляем Вы успешно добавили новую книгу");
                else
                    MessageBox.Show("Извините,но книга не может быть добавлена в библиотеку, проверьте данные или их актуальность");
            }
            
         
                       db.close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эти записи?", "Удаление записей", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridViewBoks.SelectedRows)
                {
                    dataGridViewBoks.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void dataGridViewBoks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DB db = new DB();
            db.open();
            int id_reader = System.Convert.ToInt32(dataGridViewBoks.Rows[e.RowIndex].Cells[0].Value);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tables = new DataTable();
            MySqlCommand comman = new MySqlCommand("SELECT `surname`, `name`, `id` FROM readeers WHERE id IN (SELECT id_reader FROM `issuee_cards` WHERE id_book = @id_reader)", db.getConnection());
            comman.Parameters.Add("@id_reader", MySqlDbType.VarChar).Value = id_reader;
            adapter.SelectCommand = comman;
            adapter.Fill(tables);
          ///  dataGridViewBoks.DataSource = tables;
            if (tables.Rows.Count > 0)
            {
                //     index1 = dataGridViewBoks.Rows[0].Index;
                nams.Text = tables.Rows[0]["surname"].ToString();
           //     srnm.Text = Convert.ToString(tables.Rows[0][5]);
            }
            if (tables.Rows.Count > 0)
            {
                
                srnm.Text = tables.Rows[0]["name"].ToString();
                
            }
            if (tables.Rows.Count > 0)
            {

                id.Text = tables.Rows[0]["id"].ToString();

            }

        }

        private void dataGridViewBoks_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           

            int row = dataGridViewBoks.CurrentRow.Index;
            dataGridViewBoks.Text = Convert.ToString(dataGridViewBoks.Rows[row].Cells[1].Value);
            auter.Text = Convert.ToString(dataGridViewBoks.Rows[row].Cells[1].Value);
            year.Text = Convert.ToString(dataGridViewBoks.Rows[row].Cells[2].Value);
            cozkc.Text = Convert.ToString(dataGridViewBoks.Rows[row].Cells[3].Value);
            name1.Text = Convert.ToString(dataGridViewBoks.Rows[row].Cells[4].Value);
            number1.Text = Convert.ToString(dataGridViewBoks.Rows[row].Cells[5].Value);
 

            
        }

        private void dataGridViewBoks_SelectionChanged(object sender, EventArgs e)
        {
           DB db = new DB();
            db.open();
            MySqlDataAdapter adapte = new MySqlDataAdapter();
            DataTable table = new DataTable();
           MySqlCommand command = new MySqlCommand("SELECT `id`, `author`,  `publication_year`, `publisher`, `name_books`,  `book_number`,  `picture` FROM `books` ", db.getConnection());
            adapte.SelectCommand = command;
            adapte.Fill(table);


            if (dataGridViewBoks.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                index1 = dataGridViewBoks.SelectedRows[0].Index;
                Byte[] data = new Byte[0];
                data = (Byte[])(table.Rows[index1][6]);
                
                  //  Byte[] data = new Byte[0];
                 //   data = (Byte[])(table.Rows[index1][6]);
                    MemoryStream mem = new MemoryStream(data);
                foto.Image = System.Drawing.Image.FromStream(mem);


            }
           
        }

        private void SearsJSN_Click(object sender, EventArgs e)
        {
            String Surname;
            Surname = Sears.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapte = new MySqlDataAdapter(); //создали память под адаптер
            DB db = new DB();
            MySqlCommand comm = new MySqlCommand($"SELECT * FROM books WHERE name_books = '{Surname}'", db.getConnection());
            adapte.SelectCommand = comm;
            adapte.Fill(table);
            dataGridViewBoks.DataSource = table;
            dataGridViewBoks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBoks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (table.Rows.Count > 0)
                MessageBox.Show("Сотрудник найден");
            else
                MessageBox.Show("Сотрудник не найден");
       
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewBoks.Sort(dataGridViewBoks.Columns[4], ListSortDirection.Ascending);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewBoks.Sort(dataGridViewBoks.Columns[1], ListSortDirection.Ascending);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewBoks.Sort(dataGridViewBoks.Columns[3], ListSortDirection.Ascending);
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
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void boks_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((DataTable)dataGridViewBoks.DataSource);
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

            if (dataGridViewBoks.Rows.Count > 0)

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

                            PdfPTable pTable = new PdfPTable(dataGridViewBoks.Columns.Count);

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

                            foreach (DataGridViewColumn col in dataGridViewBoks.Columns)

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
                                PdfPCell date = new PdfPCell(new Phrase("Дата: " + dateTimePicker2.Text, font));

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

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((DataTable)dataGridViewBoks.DataSource);

            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            if (dataGridViewBoks.Rows.Count > 0)
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
                            PdfPTable pTable = new PdfPTable(dataGridViewBoks.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            //Добавим в таблицу общий заголовок
                            PdfPCell cell = new PdfPCell(new Phrase("Полный отчет о всех книгах в библиотеке ", font));
                            cell.Colspan = ds.Tables[0].Columns.Count;
                            cell.HorizontalAlignment = 1;
                            //Убираем границу первой ячейки, чтобы были как заголовок
                            cell.Border = 0;
                            pTable.AddCell(cell);

                            foreach (DataGridViewColumn col in dataGridViewBoks.Columns)
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
                            PdfPCell date = new PdfPCell(new Phrase("Дата: " + dateTimePicker2.Text, font));
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
                            MessageBox.Show("Успешный экспорт данных", "Info");
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
